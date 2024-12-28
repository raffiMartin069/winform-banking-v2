using Martinez_Bank.Model;
using Martinez_Bank.Repository.Admin;
using Martinez_Bank.Utilities;
using Martinez_Bank.View.Reports;
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
	public partial class WithdrawForm : Form
	{

		private readonly WithdrawRepository _withdrawRepository;

		public WithdrawForm(WithdrawRepository withdrawRepository)
		{
			InitializeComponent();
			_withdrawRepository = withdrawRepository;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				var model = new WithdrawModel
					(_withdrawRepository, AccountNumberTextBox.Text, NameTextBox.Text,
					WithdrawModeComboBox.Text, CurrentBalanceTextBox.Text, WithdrawAmountTextbox.Text);

				bool result = model.Withdraw();

				if(!result)
				{
					MessageBox.Show("Unable to withdraw at the moment. Please try again later!");
					return;
				}

				MessageBox.Show("Withdraw successful!");
				ClearField();
				GetLogs();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ClearField()
		{
			AccountNumberTextBox.Clear();
			NameTextBox.Clear();
			CurrentBalanceTextBox.Clear();
			WithdrawAmountTextbox.Clear();
		}

		private void ClearAllFieldButton_Click(object sender, EventArgs e)
		{
			ClearField();
		}

		private void Headers()
		{
			dataGridView1.Columns["Id"].HeaderText = "Deposit Transaction Id";
			dataGridView1.Columns["AccountNumber"].HeaderText = "Account Number";
			dataGridView1.Columns["PreviousBalance"].HeaderText = "Previous Balance";
			dataGridView1.Columns["CurrentBalance"].HeaderText = "Current Balance";
			dataGridView1.Columns["DateUpdated"].HeaderText = "Date Updated";
			dataGridView1.Columns["TimeUpdated"].HeaderText = "Time Updated";
		}

		private void GetLogs()
		{
			try
			{
				var logs = _withdrawRepository.GetLogs()?.ToList();

				if(logs.Count() == 0)
				{
					MessageBox.Show("No logs found");
					return;
				}

				dataGridView1.DataSource = logs;
				Headers();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void GetModes()
		{
			var listOfModes = new List<string>();
			var modes = _withdrawRepository.GetAllMode()?.ToList();

			foreach(var i in modes)
			{
				listOfModes.Add(i.Mode);
			}

			WithdrawModeComboBox.DataSource = listOfModes;
		}

		private void WithdrawForm_Load(object sender, EventArgs e)
		{
			GetLogs();
			GetModes();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			var result = _withdrawRepository.FindByKey(textBox1.Text)?.ToList();

			if (result.Count() == 0)
			{
				MessageBox.Show("No logs found");
				return;
			}

			dataGridView1.DataSource = result;
			Headers();
		}

		private void AccountNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}

		private void CurrentBalanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}

		private void WithdrawAmountTextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var report = new WithdrawReportForm();
			report.MdiParent = this.MdiParent;
			report.Show();
		}
	}
}
