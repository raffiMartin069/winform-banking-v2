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

		private readonly IServiceProvider _serviceProvider;

		public AdminMDIParent(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		private void ShowNewForm(Form form)
		{
			form.MdiParent = this;
			form.Show();
		}

		private void CreateAccountButton_Click(object sender, MouseEventArgs e)
		{
			var createAccount = _serviceProvider.GetRequiredService<CreateAccountForm>();
			ShowNewForm(createAccount);
		}

		private void UpdateAccountButton_Click(object sender, EventArgs e)
		{
			var update = new UpdateAccountForm();
			ShowNewForm(update);
		}

		private void Deposit_Click(object sender, EventArgs e)
		{
			var deposit = new DepositForm();
			ShowNewForm(deposit);
		}

		private void Withdraw_Click(object sender, EventArgs e)
		{
			var withdraw = new WithdrawForm();
			ShowNewForm(withdraw);
		}
	}
}
