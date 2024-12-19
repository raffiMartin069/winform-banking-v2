using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Repository.Admin;
using Martinez_Bank.Repository.Common;
using Martinez_Bank.View.Admin;
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
			var withdraw = new WithdrawForm();
			ShowNewForm(withdraw);
		}
	}
}
