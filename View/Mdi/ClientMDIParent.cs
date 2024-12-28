using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Repository.Admin;
using Martinez_Bank.Utilities;
using Martinez_Bank.View.Client;
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

namespace Martinez_Bank.View.Mdi
{
	public partial class ClientMDIParent : Form
	{
		public ClientMDIParent()
		{
			InitializeComponent();
		}

		private void ShowForm(Form form)
		{
			form.MdiParent = this;
			form.Show();
		}

		private void Deposit_Click(object sender, EventArgs e)
		{
			var context = new PCBDataContext();
			var depositRepo = new DepositRepository(context);
			var form = new DepositForm(depositRepo);
			form.BalanceUpdated += OnBalanceUpdated;
			ShowForm(form);
		}

		private void Withdraw_Click(object sender, EventArgs e)
		{
			var context = new PCBDataContext();
			var withdrawRepo = new WithdrawRepository(context);
			var form = new WithdrawForm(withdrawRepo);
			form.BalanceUpdated += OnBalanceUpdated;
			ShowForm(form);
		}

		private void OnBalanceUpdated(string newBalance)
		{
			BalanceLabel.Text = "Wallet: " + newBalance.ToString();
		}

		private void ClientMDIParent_Load(object sender, EventArgs e)
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
			BalanceLabel.Text = "Wallet: " + Session.Get("Balance").ToString();
			AccountNumberLabel.Text = "Account Number: " + Session.Get("AccountNumber").ToString();
		}

		private void WithdrawHistoryButton_Click(object sender, EventArgs e)
		{
			var report = new WithdrawLogsForm();
			ShowForm(report);
		}

		private void DepositHistoryButton_Click(object sender, EventArgs e)
		{
			var report = new DepositHistoryForm();
			ShowForm(report);
		}

		private void LogOutButton_Click(object sender, EventArgs e)
		{
			Session.Clear();
			Application.Restart();
		}

		private void AccountNumberLabel_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Session.Get("AccountNumber").ToString());
			MessageBox.Show("Account number copied to clipboard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BalanceLabel_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Session.Get("Balance").ToString());
			MessageBox.Show("Balance copied to clipboard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void FullNameLabel_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Session.Get("Email").ToString());
			MessageBox.Show("Name copied to clipboard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
	}
}
