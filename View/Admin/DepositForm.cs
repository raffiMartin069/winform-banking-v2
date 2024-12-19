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

namespace Martinez_Bank.View.Admin
{
	public partial class DepositForm : Form
	{

		private readonly DepositRepository _depositRepository;

		public DepositForm(DepositRepository depositRepository)
		{
			InitializeComponent();
			_depositRepository = depositRepository;
		}

		private void ClearFields()
		{
			AccountNumberTextBox.Clear();
			NameTextBox.Clear();
			CurrentBalanceTextBox.Clear();
			DepositAmountTextBox.Clear();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				var model = new DepositModel
					(_depositRepository, AccountNumberTextBox.Text, NameTextBox.Text, ModeComboBox.Text,
					CurrentBalanceTextBox.Text, DepositAmountTextBox.Text);

				bool isAdded = model.AddDeposit();

				if(!isAdded)
				{
					MessageBox.Show("Deposit failed. Please try again later.");
					return;
				}

				MessageBox.Show("Deposit successful.");
				GridViewLogs();
				ClearFields();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ClearAllFieldButton_Click(object sender, EventArgs e)
		{
			AccountNumberTextBox.Clear();
			NameTextBox.Clear();
			CurrentBalanceTextBox.Clear();
			DepositAmountTextBox.Clear();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			var result = _depositRepository.FindLogsByKey(textBox1.Text);
			DepositGridView.DataSource = result?.ToList();
			Headers();
		}

		private void Headers()
		{
			DepositGridView.Columns["Id"].HeaderText = "Deposit Transaction Id";
			DepositGridView.Columns["AccountNumber"].HeaderText = "Account Number";
			DepositGridView.Columns["PreviousBalance"].HeaderText = "Previous Balance";
			DepositGridView.Columns["CurrentBalance"].HeaderText = "Current Balance";
			DepositGridView.Columns["DateUpdated"].HeaderText = "Date Updated";
			DepositGridView.Columns["TimeUpdated"].HeaderText = "Time Updated";
		}

		private void GridViewLogs()
		{
			var logs = _depositRepository.GetAllDepositLogs();
			DepositGridView.DataSource = logs?.ToList();
			Headers();
		}

		private void GetModes()
		{
			var container = new List<string>();
			var result = _depositRepository.GetAllMode();

			foreach(var item in result)
			{
				container.Add(item.Mode);
			}

			ModeComboBox.DataSource = container;
		}

		private void DepositForm_Load(object sender, EventArgs e)
		{
			GridViewLogs();
			GetModes();
		}

		private void AccountNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}

		private void CurrentBalanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}

		private void DepositAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}
	}
}
