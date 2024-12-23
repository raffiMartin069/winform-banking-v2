using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Repository.Admin;
using Martinez_Bank.View.Client;
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
			ShowForm(form);
		}

		private void Withdraw_Click(object sender, EventArgs e)
		{
			var context = new PCBDataContext();
			var withdrawRepo = new WithdrawRepository(context);
			var form = new WithdrawForm(withdrawRepo);
			ShowForm(form);
		}
	}
}
