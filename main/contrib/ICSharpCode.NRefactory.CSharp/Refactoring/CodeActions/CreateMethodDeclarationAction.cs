// 
// CreateMethodDeclarationAction.cs
//  
// Author:
//       Mike Krüger <mkrueger@xamarin.com>
// 
// Copyright (c) 2012 Xamarin <http://xamarin.com>
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Collections.Generic;
using System.Linq;
using ICSharpCode.NRefactory.Semantics;
using ICSharpCode.NRefactory.TypeSystem;
using System.Text;

namespace ICSharpCode.NRefactory.CSharp.Refactoring
{
	[ContextAction("Create method", Description = "Creates a method declaration out of an invocation.")]
	public class CreateMethodDeclarationAction : ICodeActionProvider
	{
		public IEnumerable<CodeAction> GetActions(RefactoringContext context)
		{
			var invocation = context.GetNode<InvocationExpression>();
			if (invocation != null) {
				return GetActionsFromInvocation(context, invocation);
			}
			var identifier = context.GetNode<IdentifierExpression>();
			if (identifier != null) {
				return GetActionsFromIdentifier(context, identifier);
			}
			return Enumerable.Empty<CodeAction>();
		}

		public IEnumerable<CodeAction>  GetActionsFromIdentifier(RefactoringContext context, IdentifierExpression identifier)
		{
			if (!(context.Resolve(identifier).IsError)) {
				yield break;
			}
			var methodName = identifier.Identifier;
			var guessedType = CreateFieldAction.GuessType(context, identifier);
			if (guessedType.Kind != TypeKind.Delegate) {
				yield break;
			}
			var invocationMethod = guessedType.GetDelegateInvokeMethod();
			var state = context.GetResolverStateBefore(identifier);
			bool isStatic = state.CurrentMember.IsStatic;

			var service = (NamingConventionService)context.GetService(typeof(NamingConventionService));
			if (service != null && !service.IsValidName(methodName, AffectedEntity.Method, Modifiers.Private, isStatic)) { 
				yield break;
			}

			yield return new CodeAction(context.TranslateString("Create delegate handler"), script => {
				var decl = new MethodDeclaration() {
					ReturnType = context.CreateShortType(invocationMethod.ReturnType),
					Name = methodName,
					Body = new BlockStatement() {
						new ThrowStatement(new ObjectCreateExpression(context.CreateShortType("System", "NotImplementedException")))
					}
				};
				if (isStatic) {
					decl.Modifiers |= Modifiers.Static;
				}

				foreach (var parameter in invocationMethod.Parameters) {
					decl.Parameters.Add(new ParameterDeclaration(context.CreateShortType (parameter.Type), parameter.Name) {
						ParameterModifier = GetModifiers(parameter)
					});
				}
				script.InsertWithCursor(context.TranslateString("Create delegate handler"), decl, Script.InsertPosition.Before);
			});

		}

		static ParameterModifier GetModifiers(IParameter parameter)
		{
			if (parameter.IsOut) {
				return ParameterModifier.Out;
			}
			if (parameter.IsRef) {
				return ParameterModifier.Ref;
			}
			if (parameter.IsParams) {
				return ParameterModifier.Params;
			}
			return ParameterModifier.None;
		}
		
		public IEnumerable<CodeAction> GetActionsFromInvocation(RefactoringContext context, InvocationExpression invocation)
		{
			if (!(context.Resolve(invocation.Target).IsError)) {
				yield break;
			}

			var methodName = GetMethodName(invocation);
			if (methodName == null) {
				yield break;
			}
			var state = context.GetResolverStateBefore(invocation);
			var guessedType = invocation.Parent is ExpressionStatement ? new PrimitiveType("void") : CreateFieldAction.GuessAstType(context, invocation);

			var service = (NamingConventionService)context.GetService(typeof(NamingConventionService));
			bool isStatic = invocation.Target is IdentifierExpression && state.CurrentMember.IsStatic;
			if (service != null && !service.IsValidName(methodName, AffectedEntity.Method, Modifiers.Private, isStatic)) { 
				yield break;
			}


			yield return new CodeAction(context.TranslateString("Create method"), script => {
				var decl = new MethodDeclaration() {
					ReturnType = guessedType,
					Name = methodName,
					Body = new BlockStatement() {
						new ThrowStatement(new ObjectCreateExpression(context.CreateShortType("System", "NotImplementedException")))
					}
				};
				if (isStatic) {
					decl.Modifiers |= Modifiers.Static;
				}

				foreach (var parameter in GenerateParameters (context, invocation)) {
					decl.Parameters.Add(parameter);
				}
				script.InsertWithCursor(context.TranslateString("Create method"), decl, Script.InsertPosition.Before);
			});
		}

		public IEnumerable<ParameterDeclaration> GenerateParameters(RefactoringContext context, InvocationExpression invocation)
		{
			Dictionary<string, int> nameCounter = new Dictionary<string, int>();
			foreach (var argument in invocation.Arguments) {
				ParameterModifier direction = ParameterModifier.None;
				AstNode node;
				if (argument is DirectionExpression) {
					var de = (DirectionExpression)argument;
					direction = de.FieldDirection == FieldDirection.Out ? ParameterModifier.Out : ParameterModifier.Ref;
					node = de.Expression;
				} else {
					node = argument;
				}

				var resolveResult = context.Resolve(node);
				string name = CreateBaseName(argument, resolveResult.Type);
				if (!nameCounter.ContainsKey(name)) {
					nameCounter [name] = 1;
				} else {
					nameCounter [name]++;
					name += nameCounter [name].ToString();
				}
				var type = resolveResult.Type.Kind == TypeKind.Unknown ? new PrimitiveType("object") : context.CreateShortType(resolveResult.Type);

				yield return new ParameterDeclaration(type, name) { ParameterModifier = direction};
			}
		}

		static string CreateBaseNameFromString(string str)
		{
			if (string.IsNullOrEmpty(str)) {
				return "empty";
			}
			var sb = new StringBuilder();
			bool firstLetter = true, wordStart = false;
			foreach (char ch in str) {
				if (char.IsWhiteSpace(ch)) {
					wordStart = true;
					continue;
				}
				if (!char.IsLetter(ch)) {
					continue;
				}
				if (firstLetter) {
					sb.Append(char.ToLower(ch));
					firstLetter = false;
					continue;
				}
				if (wordStart) {
					sb.Append(char.ToUpper(ch));
					wordStart = false;
					continue;
				}
				sb.Append(ch);
			}
			return sb.Length == 0 ? "str" : sb.ToString();
		}

		static string CreateBaseName(AstNode node, IType type)
		{
			string name = null;
			if (node is DirectionExpression) {
				node = ((DirectionExpression)node).Expression;
			}

			if (node is IdentifierExpression) {
				name = ((IdentifierExpression)node).Identifier;
			} else if (node is MemberReferenceExpression) {
				name = ((MemberReferenceExpression)node).MemberName;
			} else if (node is PrimitiveExpression) {
				var pe = (PrimitiveExpression)node;
				if (pe.Value is string) {
					name = CreateBaseNameFromString(pe.Value.ToString());
				}
				name = char.ToLower(type.Name [0]).ToString();
			} else {
				name = type.Kind == TypeKind.Unknown ? "par" : type.Name;
			}

			name = char.ToLower(name [0]) + name.Substring(1);
			return name;
		}

		public string GetMethodName(InvocationExpression invocation)
		{
			if (invocation.Target is IdentifierExpression) {
				return ((IdentifierExpression)invocation.Target).Identifier;
			}
			if (invocation.Target is MemberReferenceExpression) {
				return ((MemberReferenceExpression)invocation.Target).MemberName;
			}

			return null;
		}
	}
}