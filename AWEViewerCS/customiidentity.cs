// This class checks for valid user names and passwords.
// Values are stored in private variables and
//  retrieved using public readonly properties.
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AWEViewerCS
{
	class CustomIIdentity
	{
		private string nameValue;
		private bool authenticatedValue;
		private string roleValue;

		public bool IsAuthenticated
		{
			get
			{
				return authenticatedValue;
			}
		}
		public string Name
		{
			get
			{
				return nameValue;
			}
		}
		public string Role
		{
			get
			{
				return roleValue;
			}
		}
		// Class constructor.
		// Check whether provided username and password is valid.
		// Set private variables to appropriate values.
		public CustomIIdentity(string name, string password)
		{
			try
			{
				if (IsValidNameAndPassword(name, password))
				{
					string sname = name.ToLower();
					if (sname == "user1")
					{
						nameValue = name;
						authenticatedValue = true;
						roleValue = "Administrator";
					}
					else
					{
						nameValue = name;
						authenticatedValue = true;
						roleValue = "User";
					}
				}
				else
				{
					nameValue = "";
					authenticatedValue = false;
					roleValue = "Guest";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				nameValue = "";
				authenticatedValue = false;
				roleValue = "Guest";
			}
		}
		// Check for valid username and password.
		private bool IsValidNameAndPassword(string username, string password)
		{
			try
			{
				if (username.ToLower() == "user1")
				{
					if (password == "User1")
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else if (username.ToLower() == "user2")
				{
					if (password == "User2")
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
		}




	}
}
