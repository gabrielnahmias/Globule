using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Globule
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
            // NOTE: This is where the initially displayed dialog is called.
            
            Application.Run( new ColorPickerDialog() ); // was Main()

		}

	}
}