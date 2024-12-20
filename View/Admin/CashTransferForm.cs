using Martinez_Bank.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_Bank.View.Admin
{
	public partial class CashTransferForm : Form
	{
		public CashTransferForm()
		{
			InitializeComponent();
		}

		private void SenderAccountNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}

		private void RecipientAccountNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}

		private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}
	}
}
