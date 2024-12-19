using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_Bank.Utilities
{
	public static class PasswordUtility
	{
		public static bool UserPasswordDecision(string password, string repeatPassword)
		{
			string prompt = "";
			string title = "";
			if (!string.IsNullOrEmpty(repeatPassword) && string.IsNullOrEmpty(password))
			{
				prompt = "The password is empty but the repeat password is not,\nDo you want to change yout password?";
				title = "Warning";
				DialogResult dialogResult = MessageBox.Show(prompt, title, MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
				{
					return false;
				}
			}
			if (string.IsNullOrEmpty(repeatPassword) && !string.IsNullOrEmpty(password))
			{
				prompt = "The password is not empty but the repeat password is empty,\nDo you want to change yout password?";
				title = "Warning";
				DialogResult dialogResult = MessageBox.Show(prompt, title, MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
				{
					return false;
				}
			}
			if (!string.IsNullOrEmpty(repeatPassword) && !string.IsNullOrEmpty(password))
			{
				prompt = "You are about to change the password of this account with it's other information. Do you want to continue?";
				title = "Warning";
				DialogResult dialogResult = MessageBox.Show(prompt, title, MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
				{
					return false;
				}
			}
			return true;
		}
	}
}
