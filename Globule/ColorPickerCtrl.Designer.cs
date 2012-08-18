using INI;
using System;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace Globule
{
	partial class ColorPickerCtrl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_colorWheel = new Globule.ColorWheelCtrl();
            this.m_opacitySlider = new Globule.ColorSlider();
            this.m_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.lblL = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.m_eyedropColorPicker = new Globule.EyedropColorPicker();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblHex = new System.Windows.Forms.Label();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.lblRGBA = new System.Windows.Forms.Label();
            this.txtRGBA = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.chkCopy = new System.Windows.Forms.CheckBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblOptionsGroup = new Globule.LabelRotate();
            this.m_colorSample = new Globule.LabelRotate();
            this.m_infoLabel = new Globule.LabelRotate();
            this.m_colorTable = new Globule.ColorTable();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.m_colorWheel);
            this.panel1.Controls.Add(this.m_opacitySlider);
            this.panel1.Location = new System.Drawing.Point(257, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 242);
            this.panel1.TabIndex = 9;
            // 
            // m_colorWheel
            // 
            this.m_colorWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_colorWheel.BackColor = System.Drawing.Color.Transparent;
            this.m_colorWheel.Location = new System.Drawing.Point(-1, 0);
            this.m_colorWheel.Name = "m_colorWheel";
            this.m_colorWheel.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(205)))));
            this.m_colorWheel.Size = new System.Drawing.Size(254, 209);
            this.m_colorWheel.TabIndex = 0;
            // 
            // m_opacitySlider
            // 
            this.m_opacitySlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_opacitySlider.BackColor = System.Drawing.Color.Transparent;
            this.m_opacitySlider.BarPadding = new System.Windows.Forms.Padding(60, 12, 80, 25);
            this.m_opacitySlider.Color1 = System.Drawing.Color.White;
            this.m_opacitySlider.Color2 = System.Drawing.Color.Black;
            this.m_opacitySlider.Color3 = System.Drawing.Color.Black;
            this.m_opacitySlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_opacitySlider.ForeColor = System.Drawing.Color.Black;
            this.m_opacitySlider.Location = new System.Drawing.Point(2, 213);
            this.m_opacitySlider.Name = "m_opacitySlider";
            this.m_opacitySlider.NumberOfColors = Globule.ColorSlider.eNumberOfColors.Use2Colors;
            this.m_opacitySlider.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.m_opacitySlider.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.m_opacitySlider.Percent = 1F;
            this.m_opacitySlider.RotatePointAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_opacitySlider.Size = new System.Drawing.Size(248, 28);
            this.m_opacitySlider.TabIndex = 1;
            this.m_opacitySlider.Text = "Opacity";
            this.m_opacitySlider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_opacitySlider.TextAngle = 0F;
            this.m_opacitySlider.ValueOrientation = Globule.ColorSlider.eValueOrientation.MinToMax;
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL.Location = new System.Drawing.Point(135, 281);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(18, 13);
            this.lblL.TabIndex = 27;
            this.lblL.Text = "L:";
            this.m_tooltip.SetToolTip(this.lblL, "Lightness");
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(135, 255);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(19, 13);
            this.lblS.TabIndex = 26;
            this.lblS.Text = "S:";
            this.m_tooltip.SetToolTip(this.lblS, "Saturation");
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(135, 229);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(20, 13);
            this.lblH.TabIndex = 25;
            this.lblH.Text = "H:";
            this.m_tooltip.SetToolTip(this.lblH, "Hue");
            // 
            // m_eyedropColorPicker
            // 
            this.m_eyedropColorPicker.BackColor = System.Drawing.SystemColors.Control;
            this.m_eyedropColorPicker.Location = new System.Drawing.Point(193, 150);
            this.m_eyedropColorPicker.Name = "m_eyedropColorPicker";
            this.m_eyedropColorPicker.SelectedColor = System.Drawing.Color.Empty;
            this.m_eyedropColorPicker.Size = new System.Drawing.Size(60, 60);
            this.m_eyedropColorPicker.TabIndex = 2;
            this.m_eyedropColorPicker.TabStop = false;
            this.m_tooltip.SetToolTip(this.m_eyedropColorPicker, "This is the color selector. You may click and drag it anywhere on the screen to p" +
        "ick a color.");
            this.m_eyedropColorPicker.Zoom = 4;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(65, 226);
            this.txtR.MaxLength = 3;
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(55, 20);
            this.txtR.TabIndex = 10;
            this.txtR.Click += new System.EventHandler(this.CopyText);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(65, 252);
            this.txtG.MaxLength = 3;
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(55, 20);
            this.txtG.TabIndex = 11;
            this.txtG.Click += new System.EventHandler(this.CopyText);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(65, 278);
            this.txtB.MaxLength = 3;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(55, 20);
            this.txtB.TabIndex = 12;
            this.txtB.Click += new System.EventHandler(this.CopyText);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(39, 229);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(20, 13);
            this.lblR.TabIndex = 13;
            this.lblR.Text = "R:";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(39, 255);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(20, 13);
            this.lblG.TabIndex = 14;
            this.lblG.Text = "G:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(39, 281);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(19, 13);
            this.lblB.TabIndex = 15;
            this.lblB.Text = "B:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(39, 307);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(19, 13);
            this.lblA.TabIndex = 17;
            this.lblA.Text = "A:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(65, 304);
            this.txtA.MaxLength = 3;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(55, 20);
            this.txtA.TabIndex = 16;
            this.txtA.Click += new System.EventHandler(this.CopyText);
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHex.Location = new System.Drawing.Point(26, 359);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(33, 13);
            this.lblHex.TabIndex = 19;
            this.lblHex.Text = "Hex:";
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(65, 356);
            this.txtHex.MaxLength = 3;
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(88, 20);
            this.txtHex.TabIndex = 18;
            this.txtHex.Click += new System.EventHandler(this.CopyText);
            // 
            // lblRGBA
            // 
            this.lblRGBA.AutoSize = true;
            this.lblRGBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGBA.Location = new System.Drawing.Point(14, 333);
            this.lblRGBA.Name = "lblRGBA";
            this.lblRGBA.Size = new System.Drawing.Size(45, 13);
            this.lblRGBA.TabIndex = 21;
            this.lblRGBA.Text = "RGBA:";
            // 
            // txtRGBA
            // 
            this.txtRGBA.Location = new System.Drawing.Point(65, 330);
            this.txtRGBA.MaxLength = 3;
            this.txtRGBA.Name = "txtRGBA";
            this.txtRGBA.Size = new System.Drawing.Size(171, 20);
            this.txtRGBA.TabIndex = 20;
            this.txtRGBA.Click += new System.EventHandler(this.CopyText);
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(161, 278);
            this.txtL.MaxLength = 3;
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(55, 20);
            this.txtL.TabIndex = 24;
            this.txtL.Click += new System.EventHandler(this.CopyText);
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(161, 252);
            this.txtS.MaxLength = 3;
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(55, 20);
            this.txtS.TabIndex = 23;
            this.txtS.Click += new System.EventHandler(this.CopyText);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(161, 226);
            this.txtH.MaxLength = 3;
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(55, 20);
            this.txtH.TabIndex = 22;
            this.txtH.Click += new System.EventHandler(this.CopyText);
            // 
            // chkCopy
            // 
            this.chkCopy.AutoSize = true;
            this.chkCopy.Checked = true;
            this.chkCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopy.Location = new System.Drawing.Point(282, 277);
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.Size = new System.Drawing.Size(190, 17);
            this.chkCopy.TabIndex = 28;
            this.chkCopy.Text = "Copy text box values when clicked";
            this.chkCopy.UseVisualStyleBackColor = true;
            this.chkCopy.CheckedChanged += new System.EventHandler(this.chkCopy_CheckedChanged);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(269, 249);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(50, 13);
            this.lblOptions.TabIndex = 30;
            this.lblOptions.Text = "Options";
            // 
            // lblOptionsGroup
            // 
            this.lblOptionsGroup.Location = new System.Drawing.Point(259, 255);
            this.lblOptionsGroup.Name = "lblOptionsGroup";
            this.lblOptionsGroup.RotatePointAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOptionsGroup.Size = new System.Drawing.Size(248, 128);
            this.lblOptionsGroup.TabIndex = 29;
            this.lblOptionsGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOptionsGroup.TextAngle = 0F;
            // 
            // m_colorSample
            // 
            this.m_colorSample.Location = new System.Drawing.Point(1, 150);
            this.m_colorSample.Name = "m_colorSample";
            this.m_colorSample.RotatePointAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_colorSample.Size = new System.Drawing.Size(186, 60);
            this.m_colorSample.TabIndex = 1;
            this.m_colorSample.TabStop = false;
            this.m_colorSample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_colorSample.TextAngle = 0F;
            // 
            // m_infoLabel
            // 
            this.m_infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_infoLabel.Location = new System.Drawing.Point(1, 216);
            this.m_infoLabel.Name = "m_infoLabel";
            this.m_infoLabel.RotatePointAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_infoLabel.Size = new System.Drawing.Size(252, 167);
            this.m_infoLabel.TabIndex = 3;
            this.m_infoLabel.TabStop = false;
            this.m_infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_infoLabel.TextAngle = 0F;
            // 
            // m_colorTable
            // 
            this.m_colorTable.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.DarkSlateGray,
        System.Drawing.Color.Purple,
        System.Drawing.Color.Green,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Olive,
        System.Drawing.Color.Navy,
        System.Drawing.Color.Teal,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.DarkBlue,
        System.Drawing.Color.DarkMagenta,
        System.Drawing.Color.DarkOliveGreen,
        System.Drawing.Color.SaddleBrown,
        System.Drawing.Color.ForestGreen,
        System.Drawing.Color.OliveDrab,
        System.Drawing.Color.SeaGreen,
        System.Drawing.Color.DarkGoldenrod,
        System.Drawing.Color.DarkSlateBlue,
        System.Drawing.Color.MediumBlue,
        System.Drawing.Color.Sienna,
        System.Drawing.Color.Brown,
        System.Drawing.Color.DarkTurquoise,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.LightSeaGreen,
        System.Drawing.Color.DarkViolet,
        System.Drawing.Color.Firebrick,
        System.Drawing.Color.MediumVioletRed,
        System.Drawing.Color.MediumSeaGreen,
        System.Drawing.Color.Crimson,
        System.Drawing.Color.Chocolate,
        System.Drawing.Color.MediumSpringGreen,
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.Goldenrod,
        System.Drawing.Color.LawnGreen,
        System.Drawing.Color.DarkOrchid,
        System.Drawing.Color.Gold,
        System.Drawing.Color.Magenta,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.Aqua,
        System.Drawing.Color.SpringGreen,
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Chartreuse,
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkOrange,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Blue,
        System.Drawing.Color.CadetBlue,
        System.Drawing.Color.YellowGreen,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.SlateGray,
        System.Drawing.Color.Gray,
        System.Drawing.Color.Peru,
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.LightSlateGray,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.MediumTurquoise,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.Turquoise,
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.SlateBlue,
        System.Drawing.Color.DarkKhaki,
        System.Drawing.Color.MediumOrchid,
        System.Drawing.Color.IndianRed,
        System.Drawing.Color.GreenYellow,
        System.Drawing.Color.MediumAquamarine,
        System.Drawing.Color.Tomato,
        System.Drawing.Color.DarkSeaGreen,
        System.Drawing.Color.Orchid,
        System.Drawing.Color.MediumPurple,
        System.Drawing.Color.PaleVioletRed,
        System.Drawing.Color.RosyBrown,
        System.Drawing.Color.Coral,
        System.Drawing.Color.CornflowerBlue,
        System.Drawing.Color.DarkGray,
        System.Drawing.Color.SandyBrown,
        System.Drawing.Color.MediumSlateBlue,
        System.Drawing.Color.Tan,
        System.Drawing.Color.DarkSalmon,
        System.Drawing.Color.BurlyWood,
        System.Drawing.Color.HotPink,
        System.Drawing.Color.Salmon,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightCoral,
        System.Drawing.Color.SkyBlue,
        System.Drawing.Color.LightSalmon,
        System.Drawing.Color.Khaki,
        System.Drawing.Color.Plum,
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Aquamarine,
        System.Drawing.Color.Silver,
        System.Drawing.Color.LightSkyBlue,
        System.Drawing.Color.LightSteelBlue,
        System.Drawing.Color.PaleGreen,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.PowderBlue,
        System.Drawing.Color.Thistle,
        System.Drawing.Color.PaleGoldenrod,
        System.Drawing.Color.PaleTurquoise,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Wheat,
        System.Drawing.Color.NavajoWhite,
        System.Drawing.Color.Moccasin,
        System.Drawing.Color.LightPink,
        System.Drawing.Color.Gainsboro,
        System.Drawing.Color.PeachPuff,
        System.Drawing.Color.Pink,
        System.Drawing.Color.Bisque,
        System.Drawing.Color.LemonChiffon,
        System.Drawing.Color.LightGoldenrodYellow,
        System.Drawing.Color.BlanchedAlmond,
        System.Drawing.Color.AntiqueWhite,
        System.Drawing.Color.Beige,
        System.Drawing.Color.PapayaWhip,
        System.Drawing.Color.Cornsilk,
        System.Drawing.Color.LightCyan,
        System.Drawing.Color.LightYellow,
        System.Drawing.Color.Lavender,
        System.Drawing.Color.MistyRose,
        System.Drawing.Color.Linen,
        System.Drawing.Color.OldLace,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.SeaShell,
        System.Drawing.Color.Ivory,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.LavenderBlush,
        System.Drawing.Color.Honeydew,
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.Azure,
        System.Drawing.Color.MintCream,
        System.Drawing.Color.GhostWhite,
        System.Drawing.Color.Snow,
        System.Drawing.Color.White};
            this.m_colorTable.Cols = 16;
            this.m_colorTable.FieldSize = new System.Drawing.Size(12, 12);
            this.m_colorTable.Location = new System.Drawing.Point(1, 7);
            this.m_colorTable.Name = "m_colorTable";
            this.m_colorTable.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.m_colorTable.RotatePointAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_colorTable.SelectedItem = System.Drawing.Color.Black;
            this.m_colorTable.Size = new System.Drawing.Size(252, 138);
            this.m_colorTable.TabIndex = 0;
            this.m_colorTable.Text = "m_colorTable";
            this.m_colorTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_colorTable.TextAngle = 0F;
            // 
            // ColorPickerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.chkCopy);
            this.Controls.Add(this.lblOptionsGroup);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblRGBA);
            this.Controls.Add(this.txtRGBA);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.m_colorSample);
            this.Controls.Add(this.m_infoLabel);
            this.Controls.Add(this.m_colorTable);
            this.Controls.Add(this.m_eyedropColorPicker);
            this.Controls.Add(this.panel1);
            this.Name = "ColorPickerCtrl";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Size = new System.Drawing.Size(507, 394);
            this.Load += new System.EventHandler(this.ColorPickerCtrl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ColorWheelCtrl m_colorWheel;
		private ColorSlider m_opacitySlider;
		private System.Windows.Forms.Panel panel1;
		private EyedropColorPicker m_eyedropColorPicker;
		private System.Windows.Forms.ToolTip m_tooltip;
		private ColorTable m_colorTable;
		private LabelRotate m_infoLabel;
		private LabelRotate m_colorSample;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label lblRGBA;
        private System.Windows.Forms.TextBox txtRGBA;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.CheckBox chkCopy;
        private LabelRotate lblOptionsGroup;
        private System.Windows.Forms.Label lblOptions;
	}
}
