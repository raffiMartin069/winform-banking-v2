using Martinez_Bank.Model;
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

namespace Martinez_Bank.View.Client
{
	public partial class WithdrawForm : Form
	{
		private readonly WithdrawRepository _withdrawRepository;
		public WithdrawForm(WithdrawRepository withdrawRepository)
		{
			InitializeComponent();
			_withdrawRepository = withdrawRepository;
		}

		private void ClearField()
		{
			AccountNumberTextBox.Clear();
			NameTextBox.Clear();
			CurrentBalanceTextBox.Clear();
			WithdrawAmountTextbox.Clear();
		}

		private void GetModes()
		{
			var listOfModes = new List<string>();
			var modes = _withdrawRepository.GetAllMode()?.ToList();

			foreach (var i in modes)
			{
				listOfModes.Add(i.Mode);
			}

			WithdrawModeComboBox.DataSource = listOfModes;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				var model = new WithdrawModel
					(_withdrawRepository, AccountNumberTextBox.Text, NameTextBox.Text,
					WithdrawModeComboBox.Text, CurrentBalanceTextBox.Text, WithdrawAmountTextbox.Text);

				bool result = model.Withdraw();

				if (!result)
				{
					MessageBox.Show("Unable to withdraw at the moment. Please try again later!");
					return;
				}

				MessageBox.Show("Withdraw successful!");
				ClearField();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void WithdrawForm_Load(object sender, EventArgs e)
		{
			GetModes();
		}

		private void RestrictNumericOnly(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}

		private void ClearAllFieldButton_Click(object sender, EventArgs e)
		{
			ClearField();
		}
	}
}
