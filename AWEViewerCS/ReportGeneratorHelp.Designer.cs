namespace AWEViewerCS
{
	partial class ReportGeneratorHelp
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.helpWebBrowser = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// helpWebBrowser
			// 
			this.helpWebBrowser.AllowWebBrowserDrop = false;
			this.helpWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.helpWebBrowser.Location = new System.Drawing.Point(0, 0);
			this.helpWebBrowser.Name = "helpWebBrowser";
			this.helpWebBrowser.Size = new System.Drawing.Size(522, 423);
			// 
			// ReportGeneratorHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 423);
			this.Controls.Add(this.helpWebBrowser);
			this.Name = "ReportGeneratorHelp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report Generator Help";
			this.Load += new System.EventHandler(this.ReportGeneratorHelp_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser helpWebBrowser;
	}
}