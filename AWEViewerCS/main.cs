using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AWEViewerCS
{
	public partial class Main : Form
	{
		private static bool _userAuthenticated = false;
		private static string _userName = "";
		private static string _userRole = "";
		private Button userAdminButton = new Button();

		public Main()
		{
			InitializeComponent();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			// Exit application.
			System.Environment.Exit(0);
		}

		private void Main_Load(object sender, EventArgs e)
		{
			// Display the Logon form as a modal dialog box.
			Form newLogon = new Logon();
			newLogon.ShowDialog();
			try
			{
				// If user authenticated, display name of user in Currentuser textbox.
				if (UserAuthenticated)
				{
					currentUserTextBox.Text = UserName;
					// If user is an administrator, add User Admin button to flowlayoutpanel.
					if (UserRole == "Administrator")
					{
						userAdminButton.Name = "UserAdminButton";
						userAdminButton.Size = new System.Drawing.Size(113, 24);
						userAdminButton.Text = "User Admin";
						navigationFlowLayout.Controls.Add(userAdminButton);
						// Add event handler for UserAdmin button.
						userAdminButton.Click += new EventHandler(userAdminButton_Click);
						// Add event handler for UserAdmin menu item.
						userAdminToolStripMenuItem.Click += new EventHandler(userAdminButton_Click);
						// Display and enable Tools menu.
						toolsToolStripMenuItem.Visible = true;
						toolsToolStripMenuItem.Enabled = true;
					}
				}
				// If user not authenticated, end the application.
				else
				{
					this.Close();
					System.Environment.Exit(0);
				}
				// Load the Copyright.rtf file into the RichTextBox on the Main form.
				copyrightRichText.LoadFile("..\\..\\Supporting Files\\Copyright.rtf");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}
		private void userAdminButton_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("User Admin form");
		}

		private void websiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				// Navigate to Adventure Works web site.
				this.websiteLinkLabel.LinkVisited = true;
				System.Diagnostics.Process.Start("http://www.adventure-works.com");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Error encountered",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}

		//  Public properties used to set and retrieve
		//  private variables
		public static string UserName
		{
			get
			{
				return _userName;
			}
			set
			{
				_userName = value;
			}
		}
		public static bool UserAuthenticated
		{
			get
			{
				return _userAuthenticated;
			}
			set
			{
				_userAuthenticated = value;
			}
		}
		public static string UserRole
		{
			get
			{
				return _userRole;
			}
			set
			{
				_userRole = value;
			}
		}

		

		
		private void employeeViewerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				// Open EmployeeViewer form
				Form newEmployeeViewer = new EmployeeViewer();
				newEmployeeViewer.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void reportGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				// Open ReportGenerator form
				Form newReportGenerator = new ReportGenerator();
				newReportGenerator.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

			}
}