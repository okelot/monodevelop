
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.MacDev.PlistEditor
{
	public partial class IPhoneDeploymentInfo
	{
		private global::Gtk.Table table1;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Label label7;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.Label GtkLabel3;
		private global::Gtk.Label GtkLabel4;
		private global::Gtk.Label GtkLabel5;
		private global::Gtk.HBox hbox2;
		private global::Gtk.VBox vbox1;
		private global::Gtk.ToggleButton togglePortrait;
		private global::Gtk.Image imageIPhone1;
		private global::Gtk.Label label8;
		private global::Gtk.VBox vbox4;
		private global::Gtk.ToggleButton toggleUpsideDown;
		private global::Gtk.Image imageIPhone2;
		private global::Gtk.Label label9;
		private global::Gtk.VBox vbox3;
		private global::Gtk.ToggleButton toggleLandscapeLeft;
		private global::Gtk.Image imageIPhone3;
		private global::Gtk.Label label10;
		private global::Gtk.VBox vbox2;
		private global::Gtk.ToggleButton toggleLandscapeRight;
		private global::Gtk.Image imageIPhone4;
		private global::Gtk.Label label11;
		private global::Gtk.HBox hbox5;
		private global::MonoDevelop.Ide.Gui.Components.ProjectFileEntry interfacePicker;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.HSeparator hseparator3;
		private global::Gtk.Label label12;
		private global::Gtk.Label label13;
		private global::Gtk.Table table3;
		private global::Gtk.Label label14;
		private global::Gtk.VBox vbox11;
		private global::Gtk.Alignment alignment10;
		private global::MonoDevelop.MacDev.PlistEditor.ImageChooser imageIPhoneAppIconRetina;
		private global::Gtk.VBox vbox13;
		private global::Gtk.Alignment alignment12;
		private global::MonoDevelop.MacDev.PlistEditor.ImageChooser imageIPhoneAppIcon;
		private global::Gtk.Table table4;
		private global::Gtk.Label label6;
		private global::Gtk.VBox vbox14;
		private global::Gtk.Alignment alignment13;
		private global::MonoDevelop.MacDev.PlistEditor.ImageChooser imageIPhoneLaunch;
		private global::Gtk.VBox vbox15;
		private global::Gtk.Alignment alignment14;
		private global::MonoDevelop.MacDev.PlistEditor.ImageChooser imageIPhoneLaunchRetina;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.MacDev.PlistEditor.IPhoneDeploymentInfo
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.MacDev.PlistEditor.IPhoneDeploymentInfo";
			// Container child MonoDevelop.MacDev.PlistEditor.IPhoneDeploymentInfo.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(12)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(8));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.LeftPadding = ((uint)(24));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Main Interface:");
			this.alignment2.Add (this.label7);
			this.table1.Add (this.alignment2);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment2]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.table1.Add (this.alignment4);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment4]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.Xalign = 0F;
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Supported Device Orientations</b>");
			this.GtkLabel3.UseMarkup = true;
			this.table1.Add (this.GtkLabel3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkLabel3]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.Xalign = 0F;
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>App Icons</b>");
			this.GtkLabel4.UseMarkup = true;
			this.table1.Add (this.GtkLabel4);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkLabel4]));
			w5.TopAttach = ((uint)(6));
			w5.BottomAttach = ((uint)(7));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.Xalign = 0F;
			this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Launch images</b>");
			this.GtkLabel5.UseMarkup = true;
			this.table1.Add (this.GtkLabel5);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkLabel5]));
			w6.TopAttach = ((uint)(9));
			w6.BottomAttach = ((uint)(10));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 12;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.togglePortrait = new global::Gtk.ToggleButton ();
			this.togglePortrait.CanFocus = true;
			this.togglePortrait.Name = "togglePortrait";
			// Container child togglePortrait.Gtk.Container+ContainerChild
			this.imageIPhone1 = new global::Gtk.Image ();
			this.imageIPhone1.Name = "imageIPhone1";
			this.imageIPhone1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("iPhone1.png");
			this.togglePortrait.Add (this.imageIPhone1);
			this.togglePortrait.Label = null;
			this.vbox1.Add (this.togglePortrait);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.togglePortrait]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Portrait");
			this.vbox1.Add (this.label8);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label8]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.hbox2.Add (this.vbox1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox1]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.toggleUpsideDown = new global::Gtk.ToggleButton ();
			this.toggleUpsideDown.CanFocus = true;
			this.toggleUpsideDown.Name = "toggleUpsideDown";
			// Container child toggleUpsideDown.Gtk.Container+ContainerChild
			this.imageIPhone2 = new global::Gtk.Image ();
			this.imageIPhone2.Name = "imageIPhone2";
			this.imageIPhone2.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("iPhone3.png");
			this.toggleUpsideDown.Add (this.imageIPhone2);
			this.toggleUpsideDown.Label = null;
			this.vbox4.Add (this.toggleUpsideDown);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.toggleUpsideDown]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Upside\nDown");
			this.label9.UseMarkup = true;
			this.label9.Justify = ((global::Gtk.Justification)(2));
			this.vbox4.Add (this.label9);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label9]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.hbox2.Add (this.vbox4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox4]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.toggleLandscapeLeft = new global::Gtk.ToggleButton ();
			this.toggleLandscapeLeft.CanFocus = true;
			this.toggleLandscapeLeft.Name = "toggleLandscapeLeft";
			// Container child toggleLandscapeLeft.Gtk.Container+ContainerChild
			this.imageIPhone3 = new global::Gtk.Image ();
			this.imageIPhone3.Name = "imageIPhone3";
			this.imageIPhone3.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("iPhone2.png");
			this.toggleLandscapeLeft.Add (this.imageIPhone3);
			this.toggleLandscapeLeft.Label = null;
			this.vbox3.Add (this.toggleLandscapeLeft);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.toggleLandscapeLeft]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Landscape\nLeft");
			this.label10.Justify = ((global::Gtk.Justification)(2));
			this.vbox3.Add (this.label10);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label10]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox2.Add (this.vbox3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox3]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.toggleLandscapeRight = new global::Gtk.ToggleButton ();
			this.toggleLandscapeRight.CanFocus = true;
			this.toggleLandscapeRight.Name = "toggleLandscapeRight";
			// Container child toggleLandscapeRight.Gtk.Container+ContainerChild
			this.imageIPhone4 = new global::Gtk.Image ();
			this.imageIPhone4.Name = "imageIPhone4";
			this.imageIPhone4.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("iPhone4.png");
			this.toggleLandscapeRight.Add (this.imageIPhone4);
			this.toggleLandscapeRight.Label = null;
			this.vbox2.Add (this.toggleLandscapeRight);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.toggleLandscapeRight]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Landscape\nRight");
			this.label11.Justify = ((global::Gtk.Justification)(2));
			this.vbox2.Add (this.label11);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label11]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.hbox2.Add (this.vbox2);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox2]));
			w22.Position = 3;
			w22.Expand = false;
			w22.Fill = false;
			this.table1.Add (this.hbox2);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox2]));
			w23.TopAttach = ((uint)(4));
			w23.BottomAttach = ((uint)(5));
			w23.LeftAttach = ((uint)(2));
			w23.RightAttach = ((uint)(3));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.interfacePicker = new global::MonoDevelop.Ide.Gui.Components.ProjectFileEntry ();
			this.interfacePicker.WidthRequest = 300;
			this.interfacePicker.Name = "interfacePicker";
			this.interfacePicker.VerifyFileExistsInProject = false;
			this.interfacePicker.EntryIsEditable = false;
			this.hbox5.Add (this.interfacePicker);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.interfacePicker]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			this.table1.Add (this.hbox5);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox5]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			w25.LeftAttach = ((uint)(2));
			w25.RightAttach = ((uint)(3));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.table1.Add (this.hseparator1);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator1]));
			w26.TopAttach = ((uint)(2));
			w26.BottomAttach = ((uint)(3));
			w26.RightAttach = ((uint)(4));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.table1.Add (this.hseparator2);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator2]));
			w27.TopAttach = ((uint)(5));
			w27.BottomAttach = ((uint)(6));
			w27.RightAttach = ((uint)(4));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.table1.Add (this.hseparator3);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1 [this.hseparator3]));
			w28.TopAttach = ((uint)(8));
			w28.BottomAttach = ((uint)(9));
			w28.RightAttach = ((uint)(4));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.WidthRequest = 12;
			this.label12.Name = "label12";
			this.label12.Xalign = 1F;
			this.table1.Add (this.label12);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.label12]));
			w29.TopAttach = ((uint)(1));
			w29.BottomAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.WidthRequest = 6;
			this.label13.Name = "label13";
			this.label13.Xalign = 1F;
			this.table1.Add (this.label13);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1 [this.label13]));
			w30.TopAttach = ((uint)(1));
			w30.BottomAttach = ((uint)(2));
			w30.LeftAttach = ((uint)(3));
			w30.RightAttach = ((uint)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(24));
			// Container child table3.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Retina Display");
			this.label14.Justify = ((global::Gtk.Justification)(2));
			this.table3.Add (this.label14);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table3 [this.label14]));
			w31.TopAttach = ((uint)(1));
			w31.BottomAttach = ((uint)(2));
			w31.LeftAttach = ((uint)(1));
			w31.RightAttach = ((uint)(2));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.vbox11 = new global::Gtk.VBox ();
			this.vbox11.Name = "vbox11";
			// Container child vbox11.Gtk.Box+BoxChild
			this.alignment10 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment10.Name = "alignment10";
			this.vbox11.Add (this.alignment10);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.alignment10]));
			w32.Position = 0;
			// Container child vbox11.Gtk.Box+BoxChild
			this.imageIPhoneAppIconRetina = new global::MonoDevelop.MacDev.PlistEditor.ImageChooser ();
			this.imageIPhoneAppIconRetina.Name = "imageIPhoneAppIconRetina";
			this.imageIPhoneAppIconRetina.Label = null;
			this.vbox11.Add (this.imageIPhoneAppIconRetina);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.imageIPhoneAppIconRetina]));
			w33.Position = 1;
			w33.Expand = false;
			w33.Fill = false;
			this.table3.Add (this.vbox11);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table3 [this.vbox11]));
			w34.LeftAttach = ((uint)(1));
			w34.RightAttach = ((uint)(2));
			w34.XOptions = ((global::Gtk.AttachOptions)(0));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.vbox13 = new global::Gtk.VBox ();
			this.vbox13.Name = "vbox13";
			// Container child vbox13.Gtk.Box+BoxChild
			this.alignment12 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment12.Name = "alignment12";
			this.vbox13.Add (this.alignment12);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox13 [this.alignment12]));
			w35.Position = 0;
			// Container child vbox13.Gtk.Box+BoxChild
			this.imageIPhoneAppIcon = new global::MonoDevelop.MacDev.PlistEditor.ImageChooser ();
			this.imageIPhoneAppIcon.Name = "imageIPhoneAppIcon";
			this.imageIPhoneAppIcon.Label = null;
			this.vbox13.Add (this.imageIPhoneAppIcon);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox13 [this.imageIPhoneAppIcon]));
			w36.Position = 1;
			w36.Expand = false;
			w36.Fill = false;
			this.table3.Add (this.vbox13);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table3 [this.vbox13]));
			w37.XOptions = ((global::Gtk.AttachOptions)(0));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table1.Add (this.table3);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table1 [this.table3]));
			w38.TopAttach = ((uint)(7));
			w38.BottomAttach = ((uint)(8));
			w38.LeftAttach = ((uint)(2));
			w38.RightAttach = ((uint)(3));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.table4 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(24));
			// Container child table4.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Retina Display");
			this.label6.Justify = ((global::Gtk.Justification)(2));
			this.table4.Add (this.label6);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table4 [this.label6]));
			w39.TopAttach = ((uint)(1));
			w39.BottomAttach = ((uint)(2));
			w39.LeftAttach = ((uint)(1));
			w39.RightAttach = ((uint)(2));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.vbox14 = new global::Gtk.VBox ();
			this.vbox14.Name = "vbox14";
			// Container child vbox14.Gtk.Box+BoxChild
			this.alignment13 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment13.Name = "alignment13";
			this.vbox14.Add (this.alignment13);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.alignment13]));
			w40.Position = 0;
			// Container child vbox14.Gtk.Box+BoxChild
			this.imageIPhoneLaunch = new global::MonoDevelop.MacDev.PlistEditor.ImageChooser ();
			this.imageIPhoneLaunch.Name = "imageIPhoneLaunch";
			this.imageIPhoneLaunch.Label = null;
			this.vbox14.Add (this.imageIPhoneLaunch);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.imageIPhoneLaunch]));
			w41.Position = 1;
			w41.Expand = false;
			w41.Fill = false;
			this.table4.Add (this.vbox14);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table4 [this.vbox14]));
			w42.XOptions = ((global::Gtk.AttachOptions)(0));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.vbox15 = new global::Gtk.VBox ();
			this.vbox15.Name = "vbox15";
			// Container child vbox15.Gtk.Box+BoxChild
			this.alignment14 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment14.Name = "alignment14";
			this.vbox15.Add (this.alignment14);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.alignment14]));
			w43.Position = 0;
			// Container child vbox15.Gtk.Box+BoxChild
			this.imageIPhoneLaunchRetina = new global::MonoDevelop.MacDev.PlistEditor.ImageChooser ();
			this.imageIPhoneLaunchRetina.Name = "imageIPhoneLaunchRetina";
			this.imageIPhoneLaunchRetina.Label = null;
			this.vbox15.Add (this.imageIPhoneLaunchRetina);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.imageIPhoneLaunchRetina]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			this.table4.Add (this.vbox15);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table4 [this.vbox15]));
			w45.LeftAttach = ((uint)(1));
			w45.RightAttach = ((uint)(2));
			w45.XOptions = ((global::Gtk.AttachOptions)(0));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table1.Add (this.table4);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.table1 [this.table4]));
			w46.TopAttach = ((uint)(10));
			w46.BottomAttach = ((uint)(11));
			w46.LeftAttach = ((uint)(2));
			w46.RightAttach = ((uint)(3));
			w46.XOptions = ((global::Gtk.AttachOptions)(4));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}