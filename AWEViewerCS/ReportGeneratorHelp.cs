using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AWEViewerCS
{
	public partial class ReportGeneratorHelp : Form
	{
		public ReportGeneratorHelp()
		{
			InitializeComponent();
		}

		private void ReportGeneratorHelp_Load(object sender, EventArgs e)
		{
			try
			{
				// Get the path to the help file.
				string sFileLocation = Path.GetFullPath("..\\..\\Supporting Files\\HelpFile.htm");
				// Display the help file in the WebBrowser control.		
				helpWebBrowser.Url = new Uri(sFileLocation);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}