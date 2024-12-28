using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Repository.Admin;
using Martinez_Bank.Repository.Common;
using Martinez_Bank.Utilities;
using Martinez_Bank.View.Admin;
using Martinez_Bank.WinForm.Sessions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_Bank.View.Mdi
{
	public partial class AdminMDIParent : Form
	{
		public AdminMDIParent()
		{
			InitializeComponent();
		}

		private void ShowNewForm(Form form)
		{
			form.MdiParent = this;
			form.Show();
		}

		private void CreateAccountButton_Click(object sender, MouseEventArgs e)
		{
			var context = new PCBDataContext();
			var createAccount = new CreateAccountForm
				(new CommonRepository(context),
				new CreateAccountRepository(context));
			ShowNewForm(createAccount);
		}

		private void UpdateAccountButton_Click(object sender, EventArgs e)
		{
			var context = new PCBDataContext();
			var repo = new CommonRepository(context);
			var updateRepo = new UpdateAccountRepository(context);
			var update = new UpdateAccountForm(repo, updateRepo);
			ShowNewForm(update);
		}

		private void Deposit_Click(object sender, EventArgs e)
		{
			var context = new PCBDataContext();
			var depositRepo = new DepositRepository(context);
			var deposit = new DepositForm(depositRepo);
			ShowNewForm(deposit);
		}

		private void Withdraw_Click(object sender, EventArgs e)
		{
			var context = new PCBDataContext();
			var withdrawRepo = new WithdrawRepository(context);
			var withdraw = new WithdrawForm(withdrawRepo);
			ShowNewForm(withdraw);
		}

		private void ExpressSendButton_Click(object sender, EventArgs e)
		{
			var context = new PCBDataContext();
			var repo = new CashTransferRepository(context);
			var xpresend = new CashTransferForm(repo);
			ShowNewForm(xpresend);
		}

		private void SearchUserForm_Click(object sender, EventArgs e)
		{
			var context = new PCBDataContext();
			var repo = new SearchClientRepository(context);
			var searchUser = new SearchClientForm(repo);
			ShowNewForm(searchUser);
		}

		private void AdminMDIParent_Load(object sender, EventArgs e)
		{
			var profileImage = Session.Get("ProfileImage") as byte[];
			if (profileImage != null)
			{
				pictureBox1.Image = ImageUtility.ByteDefaultMdiImageArrayToBitmap(profileImage);
				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			}
			else
			{
				// Handle the case where the profile image is not available
				MessageBox.Show("Profile image not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			FullNameLabel.Text = Session.Get("Email").ToString();
		}

		private void LogOutButton_Click(object sender, EventArgs e)
		{
			Session.Clear();
			Application.Restart();
		}
	}
}
