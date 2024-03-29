using INI;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Globule
{

	public partial class ColorPickerCtrl : UserControl
	{

        static string CONFIG_ATTRIBUTE_COPYCLICK = "copyClick",
                      CONFIG_SECTION_GENERAL = "general",
                      FILE_CONFIG = Application.StartupPath + "\\config.ini";
        
		Color m_selectedColor = Color.AntiqueWhite;

        IniFile iniConfig = new IniFile(FILE_CONFIG);
		
        public Color SelectedColor
		{
			get { return Color.FromArgb((int)Math.Floor(255f*m_opacity), m_selectedColor); }
			set
			{
				m_opacity = (float)value.A / 255f;
				value = Color.FromArgb(255, value);
				m_colorWheel.SelectedColor = value;
				if (m_colorTable.ColorExist(value) == false)
					m_colorTable.SetCustomColor(value);
				m_colorTable.SelectedItem = value;
				m_opacitySlider.Percent = m_opacity;
			}
		}
        public string HexColor
        {
            get
            {
                Color c = this.SelectedColor;
                return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
        }
        public string RGBA
        {
            get
            {
                Color c = this.SelectedColor;
                return string.Format("rgba({0}, {1}, {2}, {3})", c.R, c.G, c.B, Math.Round( (c.A / 255f) , 2 ) );
            }
        }
		public ColorPickerCtrl()
		{
			InitializeComponent();

            // Register saved hot key if it exists.

            HotKeyManager.RegisterHotKey(Keys.A, KeyModifiers.Alt | KeyModifiers.Control);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);

			List<Color> colors = new List<Color>();
			float step = 100/8;
			for (float x = 0; x <= 100; x += step)
			{
				float v = 255 * x/100;
				colors.Add(Color.FromArgb(255, (int)v, (int)v, (int)v));
			}
			colors.Add(Color.White);

			colors.Add(Color.FromArgb(255, 255, 000, 000));
			colors.Add(Color.FromArgb(255, 255, 255, 000));
			colors.Add(Color.FromArgb(255, 000, 255, 000));
			colors.Add(Color.FromArgb(255, 000, 255, 255));
			colors.Add(Color.FromArgb(255, 000, 000, 255));
			colors.Add(Color.FromArgb(255, 255, 000, 255));

			int cols = 16;
			int rows = 3;
			float cnt = (rows * cols);
			float huestep = 360 / cnt;
			float hue = 0;
			while (hue < 360)
			{
				colors.Add(new HSLColor(hue, 1, 0.5).Color);
				hue += huestep;
			}
			hue = 0;
			while (hue < 360)
			{
				colors.Add(new HSLColor(hue, 0.5, 0.5).Color);
				hue += huestep;
			}
			m_colorTable.Colors = colors.ToArray();
			m_colorTable.Cols = cols;
			m_colorTable.SelectedIndexChanged += new EventHandler(OnColorTableSelectionChanged);

			m_colorWheel.SelectedColorChanged += new EventHandler(OnColorWheelSelectionChanged);
			m_opacitySlider.SelectedValueChanged += new EventHandler(OnOpacityValueChanged);
			m_eyedropColorPicker.SelectedColorChanged += new EventHandler(OnEyeDropperSelectionChanged);
			m_colorSample.Paint += new PaintEventHandler(OnColorSamplePaint);
		}
        void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            MessageBox.Show("Hello");
        }
        protected override void SetVisibleCore(bool value)
        {
            // Quick and dirty to keep the main window invisible      
            base.SetVisibleCore(false);
        }
		void OnEyeDropperSelectionChanged(object sender, EventArgs e)
		{
			m_colorWheel.SelectedColor = m_eyedropColorPicker.SelectedColor;
		}
		float m_opacity = 1;
		void OnOpacityValueChanged(object sender, EventArgs e)
		{
			m_opacity = Math.Max(0, m_opacitySlider.Percent);
			m_opacity = Math.Min(1, m_opacitySlider.Percent);
			m_colorSample.Refresh();
            UpdateInfo(m_colorWheel.SelectedColor, m_colorWheel.SelectedHSLColor);
		}
		void OnColorWheelSelectionChanged(object sender, EventArgs e)
		{
			Color selcol = m_colorWheel.SelectedColor;
			if (selcol != null && selcol != m_selectedColor)
			{
				m_selectedColor = selcol;
				m_colorSample.Refresh();
				if (lockColorTable == false && selcol != m_colorTable.SelectedItem)
					m_colorTable.SetCustomColor(selcol);
			}
            UpdateInfo(m_colorWheel.SelectedColor, m_colorWheel.SelectedHSLColor);
		}
		void UpdateInfo(Color c, HSLColor hsl)
		{
            
            // Set RGBA fields.

            txtR.Text = c.R.ToString();
            txtG.Text = c.G.ToString();
            txtB.Text = c.B.ToString();
            txtA.Text = Math.Round( (c.A / 255f) , 2 ).ToString();

            txtRGBA.Text = this.RGBA;

            // Set HSL fields.

            txtH.Text = Math.Round(hsl.Hue, 2).ToString();
            txtS.Text = Math.Round(hsl.Saturation * 255f, 2).ToString();
            txtL.Text = Math.Round(hsl.Lightness * 255f, 2).ToString();
            
            // Hex

            txtHex.Text = this.HexColor.ToString();

            //m_infoLabel.Text = sRGBA;

		}
		void OnColorSamplePaint(object sender, PaintEventArgs e)
		{
			Rectangle r = m_colorSample.ClientRectangle;
			r.Inflate(-4,-4);

			int width = r.Width;
			r.Width /= 2;
			
			Color c = Color.FromArgb((int)Math.Floor(255f*m_opacity), m_selectedColor);
			SolidBrush b = new SolidBrush(c);
			e.Graphics.FillRectangle(b, r);

			r.X += r.Width;

			e.Graphics.FillRectangle(Brushes.White, r);
			c = Color.FromArgb(255, m_selectedColor);
			b = new SolidBrush(c);
			e.Graphics.FillRectangle(b, r);
		}

		bool lockColorTable = false;
        void OnColorTableSelectionChanged(object sender, EventArgs e)
        {
            Color selcol = (Color)m_colorTable.SelectedItem;
            if (selcol != null && selcol != m_selectedColor)
            {
                lockColorTable = true;
                m_colorWheel.SelectedColor = selcol;
                lockColorTable = false;
                m_colorSample.Invalidate();
            }
        }

        void CopyText(object sender, EventArgs e) {

            // Copies textbox values to the clipboard (only if the checkbox for this option is checked).

            TextBox txtBox = (TextBox)sender;

            if (txtBox.Text != "" && chkCopy.Checked ) {
                
                Clipboard.SetText(txtBox.Text);
                
                Flash(txtBox, 100, Color.Red, 3);

            }

        }

        public void Flash(TextBox textBox, int interval, Color color, int flashes)
        {
            new Thread(() => FlashInternal(textBox, interval, color, flashes)).Start();
        }

        private delegate void UpdateTextboxDelegate(TextBox textBox, Color originalColor);
        public void UpdateTextbox(TextBox textBox, Color color)
        {
            if (textBox.InvokeRequired)
            {
                this.Invoke(new UpdateTextboxDelegate(UpdateTextbox), new object[] { textBox, color });
            }
            textBox.BackColor = color;
        }

        private void FlashInternal(TextBox textBox, int interval, Color flashColor, int flashes)
        {
            Color original = textBox.BackColor;
            for (int i = 0; i < flashes; i++)
            {

                UpdateTextbox(textBox, flashColor);
                Thread.Sleep(interval / 2);
                UpdateTextbox(textBox, original);
                Thread.Sleep(interval / 2);
            }
        }
        /*
        public OrderedDictionary loadConfig()
        {

            OrderedDictionary dicConfig = new OrderedDictionary();

            bool bCopyClick = (bool)Properties.Settings.Default[CONFIG_ATTRIBUTE_COPYCLICK];
            
            if (bCopyClick)
                dicConfig[CONFIG_ATTRIBUTE_COPYCLICK] = "true";

            return dicConfig;

        }
        */
        private void ColorPickerCtrl_Load(object sender, EventArgs e)
        {

            Color c = m_colorWheel.SelectedColor;
            HSLColor hsl = m_colorWheel.SelectedHSLColor;

            //OrderedDictionary dicConfig = loadConfig();

            if ((bool)Properties.Settings.Default[CONFIG_ATTRIBUTE_COPYCLICK])
                this.chkCopy.Checked = true;
            else
                this.chkCopy.Checked = false;

            UpdateInfo(m_colorWheel.SelectedColor, m_colorWheel.SelectedHSLColor);

        }

        private void chkCopy_CheckedChanged(object sender, EventArgs e)
        {

            if (chkCopy.Checked == true)
                Properties.Settings.Default[CONFIG_ATTRIBUTE_COPYCLICK] = true;
            else
                Properties.Settings.Default[CONFIG_ATTRIBUTE_COPYCLICK] = false;

            Properties.Settings.Default.Save();

        }

	}
	public class ColorListBox : ListBox
	{
		int m_knownColorCount = 0;
		public ColorListBox()
		{
			DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			PropertyInfo[] propinfos = typeof(Color).GetProperties(BindingFlags.Public | BindingFlags.Static);
			foreach (PropertyInfo info in propinfos)
			{
				if (info.PropertyType == typeof(Color))
				{
					Color c = (Color)info.GetValue(typeof(Color), null);
					if (c.A == 0) // skip transparent
						continue;
					Items.Add(c);
				}
			}
			m_knownColorCount = Items.Count;
		}
		int ColorIndex(Color color)
		{
			// have to search all colors by value;
			int argb = color.ToArgb();
			for (int index = 0; index < Items.Count; index++)
			{
				Color c = (Color)Items[index];
				if (c.ToArgb() == argb)
					return index;
			}
			return -1;
		}
		public void SelectColor(Color color)
		{
			int index = ColorIndex(color);
			if (index < 0)
				index = SetCustomColor(color);
			SelectedItem = Items[index];
		}
		void RemoveCustomColor()
		{
			if (Items.Count > m_knownColorCount)
				Items.RemoveAt(Items.Count - 1);
		}
		int SetCustomColor(Color col)
		{
			RemoveCustomColor();
			Items.Add(col);
			return Items.Count - 1;
		}
		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			if (e.Index > -1)
			{
				e.DrawBackground();
				Rectangle rect = e.Bounds;
				rect.Inflate(-2,-2);
				rect.Width = 50;
				Color textColor = Color.Empty;
				if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
					textColor = SystemColors.HighlightText;
				else
					textColor = this.ForeColor;
				Color color = (Color)Items[e.Index];
				using (Brush brush = new SolidBrush(color))
				{
					e.Graphics.FillRectangle(brush, rect);
				}
				if ((e.State & DrawItemState.Selected) != DrawItemState.Selected)
				{
					using (Pen pen = new Pen(e.ForeColor))
					{
						e.Graphics.DrawRectangle(pen, rect);
					}
				}
				using (Brush brush = new SolidBrush(e.ForeColor))
				{
					string name = color.Name + string.Format("({0})", e.Index);
					if (color.IsKnownColor == false)
						name = "<custom>";
					
					StringFormat format = new StringFormat();
					format.LineAlignment = StringAlignment.Center;
					rect = e.Bounds;
					rect.X += 60; 
					e.Graphics.DrawString(name, Font, brush, rect, format);
				}
				e.DrawFocusRectangle();
			}
		}
	}

}
