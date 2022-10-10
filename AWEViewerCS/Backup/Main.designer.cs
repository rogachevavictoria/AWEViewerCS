namespace AWEViewerCS
{
	partial class Main
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
			this.navigationFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.appTitleLabel = new System.Windows.Forms.Label();
			this.copyrightRichText = new System.Windows.Forms.RichTextBox();
			this.websiteLinkLabel = new System.Windows.Forms.LinkLabel();
			this.exitLabel = new System.Windows.Forms.Label();
			this.exitButton = new System.Windows.Forms.Button();
			this.currentUserLabel = new System.Windows.Forms.Label();
			this.currentUserTextBox = new System.Windows.Forms.TextBox();
			this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeeViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainFormMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// navigationFlowLayout
			// 
			this.navigationFlowLayout.Location = new System.Drawing.Point(80, 100);
			this.navigationFlowLayout.Name = "navigationFlowLayout";
			this.navigationFlowLayout.Size = new System.Drawing.Size(122, 186);
			this.navigationFlowLayout.TabIndex = 0;
			// 
			// appTitleLabel
			// 
			this.appTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.appTitleLabel.AutoSize = true;
			this.appTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appTitleLabel.Location = new System.Drawing.Point(80, 64);
			this.appTitleLabel.Name = "appTitleLabel";
			this.appTitleLabel.Size = new System.Drawing.Size(336, 24);
			this.appTitleLabel.TabIndex = 1;
			this.appTitleLabel.Text = "Adventure Works Employee Viewer";
			// 
			// copyrightRichText
			// 
			this.copyrightRichText.BackColor = System.Drawing.SystemColors.Info;
			this.copyrightRichText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.copyrightRichText.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.copyrightRichText.Location = new System.Drawing.Point(0, 362);
			this.copyrightRichText.Name = "copyrightRichText";
			this.copyrightRichText.ReadOnly = true;
			this.copyrightRichText.Size = new System.Drawing.Size(542, 51);
			this.copyrightRichText.TabIndex = 2;
			this.copyrightRichText.Text = "";
			// 
			// websiteLinkLabel
			// 
			this.websiteLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.websiteLinkLabel.AutoSize = true;
			this.websiteLinkLabel.Location = new System.Drawing.Point(12, 322);
			this.websiteLinkLabel.Name = "websiteLinkLabel";
			this.websiteLinkLabel.Size = new System.Drawing.Size(131, 13);
			this.websiteLinkLabel.TabIndex = 3;
			this.websiteLinkLabel.TabStop = true;
			this.websiteLinkLabel.Text = "Adventure Works Web site";
			this.websiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websiteLinkLabel_LinkClicked);
			// 
			// exitLabel
			// 
			this.exitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitLabel.AutoSize = true;
			this.exitLabel.Location = new System.Drawing.Point(297, 322);
			this.exitLabel.Name = "exitLabel";
			this.exitLabel.Size = new System.Drawing.Size(135, 13);
			this.exitLabel.TabIndex = 4;
			this.exitLabel.Text = "Click here to e&xit application";
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Location = new System.Drawing.Point(438, 313);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(92, 30);
			this.exitButton.TabIndex = 5;
			this.exitButton.Text = "Exit";
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// currentUserLabel
			// 
			this.currentUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.currentUserLabel.AutoSize = true;
			this.currentUserLabel.Location = new System.Drawing.Point(377, 29);
			this.currentUserLabel.Name = "currentUserLabel";
			this.currentUserLabel.Size = new System.Drawing.Size(65, 13);
			this.currentUserLabel.TabIndex = 6;
			this.currentUserLabel.Text = "Current User:";
			// 
			// currentUserTextBox
			// 
			this.currentUserTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.currentUserTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.currentUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.currentUserTextBox.Location = new System.Drawing.Point(448, 27);
			this.currentUserTextBox.Name = "currentUserTextBox";
			this.currentUserTextBox.ReadOnly = true;
			this.currentUserTextBox.Size = new System.Drawing.Size(63, 20);
			this.currentUserTextBox.TabIndex = 7;
			// 
			// mainFormMenuStrip
			// 
			this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
			this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainFormMenuStrip.Name = "mainFormMenuStrip";
			this.mainFormMenuStrip.Size = new System.Drawing.Size(542, 24);
			this.mainFormMenuStrip.TabIndex = 8;
			this.mainFormMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// goToToolStripMenuItem
			// 
			this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeViewerToolStripMenuItem,
            this.reportGeneratorToolStripMenuItem});
			this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
			this.goToToolStripMenuItem.Text = "&Go To";
			// 
			// employeeViewerToolStripMenuItem
			// 
			this.employeeViewerToolStripMenuItem.Image = AWEViewerCS.Properties.Resources.camera;
			this.employeeViewerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.employeeViewerToolStripMenuItem.Name = "employeeViewerToolStripMenuItem";
			this.employeeViewerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.employeeViewerToolStripMenuItem.Text = "&Employee Viewer";
			this.employeeViewerToolStripMenuItem.Click += new System.EventHandler(this.employeeViewerToolStripMenuItem_Click);
			// 
			// reportGeneratorToolStripMenuItem
			// 
			this.reportGeneratorToolStripMenuItem.Image = AWEViewerCS.Properties.Resources.VSProject_report;
			this.reportGeneratorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.reportGeneratorToolStripMenuItem.Name = "reportGeneratorToolStripMenuItem";
			this.reportGeneratorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.reportGeneratorToolStripMenuItem.Text = "&Report Generator";
			this.reportGeneratorToolStripMenuItem.Click += new System.EventHandler(this.reportGeneratorToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAdminToolStripMenuItem});
			this.toolsToolStripMenuItem.Enabled = false;
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Text = "&Tools";
			this.toolsToolStripMenuItem.Visible = false;
			// 
			// userAdminToolStripMenuItem
			// 
			this.userAdminToolStripMenuItem.Name = "userAdminToolStripMenuItem";
			this.userAdminToolStripMenuItem.Text = "&User Admin";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 413);
			this.Controls.Add(this.currentUserTextBox);
			this.Controls.Add(this.currentUserLabel);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.exitLabel);
			this.Controls.Add(this.websiteLinkLabel);
			this.Controls.Add(this.copyrightRichText);
			this.Controls.Add(this.appTitleLabel);
			this.Controls.Add(this.navigationFlowLayout);
			this.Controls.Add(this.mainFormMenuStrip);
			this.MainMenuStrip = this.mainFormMenuStrip;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AWE Viewer Main Form";
			this.Load += new System.EventHandler(this.Main_Load);
			this.mainFormMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel navigationFlowLayout;
		private System.Windows.Forms.Label appTitleLabel;
		private System.Windows.Forms.RichTextBox copyrightRichText;
		private System.Windows.Forms.LinkLabel websiteLinkLabel;
		private System.Windows.Forms.Label exitLabel;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Label currentUserLabel;
		private System.Windows.Forms.TextBox currentUserTextBox;
		private System.Windows.Forms.MenuStrip mainFormMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem employeeViewerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportGeneratorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userAdminToolStripMenuItem;
	}
}

