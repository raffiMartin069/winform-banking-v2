using Martinez_Bank.Repository.Admin;
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
		private readonly CashTransferRepository _cashTransferRepository;
		public CashTransferForm(CashTransferRepository cashTransferRepository)
		{
			InitializeComponent();
			_cashTransferRepository = cashTransferRepository;
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

		private void BasicValidations()
		{
			if (string.IsNullOrEmpty(SenderAccountNumberTextBox.Text))
				throw new Exception("Sender account number is required.");

			if (string.IsNullOrEmpty(RecipientAccountNumberTextBox.Text))
				throw new Exception("Recipient account number is required.");

			if (SenderAccountNumberTextBox.Text == RecipientAccountNumberTextBox.Text)
				throw new Exception("Sender and recipient account number must not be the same.");

			if(SenderAccountNumberTextBox.Text.Length != 17)
				throw new Exception("Sender account number must be 17 digits.");

			if (RecipientAccountNumberTextBox.Text.Length != 17)
				throw new Exception("Recipient account number must be 17 digits.");

		}

		private decimal AmountValidation()
		{
			if (string.IsNullOrEmpty(AmountTextBox.Text))
				throw new Exception("Amount is required.");

			if (!decimal.TryParse(AmountTextBox.Text, out decimal amount))
				throw new Exception("Amount must be a number.");

			if (amount <= 1)
				throw new Exception("Amount must be greater than Php 1.00");

			return amount;
		}

		private void Clear()
		{
			SenderAccountNumberTextBox.Text = string.Empty;
			RecipientAccountNumberTextBox.Text = string.Empty;
			AmountTextBox.Text = string.Empty;
		}

		private void SendACashButton_Click(object sender, EventArgs e)
		{
			try
			{
				BasicValidations();
				string senderAcc = SenderAccountNumberTextBox.Text;
				string recipientAcc = RecipientAccountNumberTextBox.Text;
				decimal amount = AmountValidation();

				var isSuccess = _cashTransferRepository.Send(senderAcc, recipientAcc, amount);

				if (!isSuccess)
				{
					MessageBox.Show("Failed to send cash.");
					return;
				}

				var senderName = _cashTransferRepository.GetUser(senderAcc);
				var recipientName = _cashTransferRepository.GetUser(recipientAcc);

				MessageBox.Show($"Cash sent successfully from {senderName} to {recipientName}.");
				Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
	}
}
