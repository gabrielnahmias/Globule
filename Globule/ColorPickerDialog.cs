using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Globule
{

	public partial class ColorPickerDialog : Form
	{
		
        ColorPickerCtrl m_colorPicker;

		public ColorPickerDialog()
		{
			InitializeComponent();

			m_colorPicker = new ColorPickerCtrl();
			m_colorPicker.Dock = DockStyle.Fill;
			m_colorTabPage.Controls.Add(m_colorPicker);
		}

        public Color getColor() 
        {

            return m_colorPicker.SelectedColor;

        }

		private void OnSelected(object sender, TabControlEventArgs e)
		{
			if (e.TabPage == m_knownColorsTabPage)
				m_colorList.SelectColor(m_colorPicker.SelectedColor);
			if (e.TabPage == m_colorTabPage)
				m_colorPicker.SelectedColor = (Color)m_colorList.SelectedItem;
		}

	}

}