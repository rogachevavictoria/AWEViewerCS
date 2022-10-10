using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWEViewerCS
{
	public partial class Logon : Form
	{
		private int logonAttemptCount = 0;
		public Logon()
		{
			InitializeComponent();
		}

		private void cancel_Click(object sender, EventArgs e)
		{
			// Close form.
			this.Close();
		}

		private void OK_Click(object sender, EventArgs e)
		{
			// Pass username and password to CustomIIdentity class for validation.
			CustomIIdentity checkUser = new CustomIIdentity(this.usernameTextBox.Text, this.passwordTextBox.Text);
			try
			{
				if ((!(checkUser.IsAuthenticated)))
				{
					// If username and password incorrect three times, close the form.
                    if (logonAttemptCount >= 2)
					{
						MessageBox.Show("Too many logon attempts. Exiting Application.");
						this.Close();
						return;
					}
					// If username and password incorrect, reset them.
					this.passwordTextBox.Text = "";
					this.usernameTextBox.Text = "";
					MessageBox.Show("The username and password pair is incorrect");
					this.usernameTextBox.Focus();
					// Increment counter keeping track of number of incorrect attempts.
                    logonAttemptCount = logonAttemptCount + 1;
				}
				else
				{
					// If user authenticated, set Main form properties appropriately.
					Main.UserAuthenticated = true;
					Main.UserName = checkUser.Name;
					Main.UserRole = checkUser.Role;
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		
	}
}