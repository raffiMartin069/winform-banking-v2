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
	public partial class DepositForm : Form
	{
		private readonly DepositRepository _depositRepo;
		public DepositForm(DepositRepository depositRepo)
		{
			InitializeComponent();
			_depositRepo = depositRepo;
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
					(_depositRepo, AccountNumberTextBox.Text, NameTextBox.Text, ModeComboBox.Text,
					CurrentBalanceTextBox.Text, DepositAmountTextBox.Text);

				bool isAdded = model.AddDeposit();

				if (!isAdded)
				{
					MessageBox.Show("Deposit failed. Please try again later.");
					return;
				}

				MessageBox.Show("Deposit successful.");
				ClearFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ClearAllFieldButton_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private void GetModes()
		{
			var container = new List<string>();
			var result = _depositRepo.GetAllMode();

			foreach (var item in result)
			{
				container.Add(item.Mode);
			}

			ModeComboBox.DataSource = container;
		}

		private void RestrictNumericOnly(object sender, KeyPressEventArgs e)
		{
			RestrictionUtility.KeyPressAllowDigitOnly(sender, e);
		}

		private void DepositForm_Load(object sender, EventArgs e)
		{
			GetModes();
		}
	}
}
