using Martinez_Bank.Dto;
using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Utilities;
using Martinez_Bank.View.Mdi;
using Martinez_Bank.WinForm.Sessions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_Bank
{
	public partial class SignInForm : Form
	{

		private PCBDataContext _context = new PCBDataContext();

		public SignInForm()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				PasswordTextBox.UseSystemPasswordChar = false;
				checkBox1.Text = "Hide Password";
			}
			else
			{
				PasswordTextBox.UseSystemPasswordChar = true;
				checkBox1.Text = "Show Password";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(EmailTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
				{
					MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				var userInfo = (from i in _context.SP_Authentication(EmailTextBox.Text, PasswordTextBox.Text)
							   select new AuthenticationDto()
							   {
								Id = i.Id,
								Email = i.Fullname,
								ProfilImage = i.ProfileImage.ToArray(),
								Role = i.Role,
								Balance = i.Balance.ToString(),
								AccountNumber = i.AccountNumber
							   }).FirstOrDefault();

				// set session Id, Email, and ProfileImage
				Session.Set("Id", userInfo.Id);
				Session.Set("Email", userInfo.Email);
				Session.Set("ProfileImage", userInfo.ProfilImage);
				Session.Set("Balance", userInfo.Balance);
				Session.Set("AccountNumber", userInfo.AccountNumber);

				string role = userInfo.Role;

				if (role == "Admin" || role == "admin")
				{
					AdminMDIParent adminForm = new AdminMDIParent();
					adminForm.Show();
					this.Hide();
				}
				else if (role == "Client" || role == "client")
				{
					ClientMDIParent userForm = new ClientMDIParent();
					userForm.Show();
					this.Hide();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			EmailTextBox.Clear();
			PasswordTextBox.Clear();
		}
	}
}
