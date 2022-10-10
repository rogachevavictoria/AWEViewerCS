using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AWEViewerCS
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
			// Startup form for the application.
			Application.Run(new Main());
		}
	}
}