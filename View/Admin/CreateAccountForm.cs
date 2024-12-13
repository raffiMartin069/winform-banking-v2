using Martinez_Bank.Repository.Common;
using Martinez_Bank.Utilities;
using System;
using System.Windows.Forms;

namespace Martinez_Bank.View.Admin
{
	public partial class CreateAccountForm : Form
	{

		private readonly CommonRepository _commonRepo;

		public CreateAccountForm(CommonRepository commonRepo)
		{
			InitializeComponent();
			_commonRepo = commonRepo;
		}

		private void LoadDropDowns()
		{
			var iterator = new CommonIteratorUtility();
			var gender = _commonRepo.GetAllGender();
			var marriageStatus = _commonRepo.GetAllMarriageStatus();
			var role = _commonRepo.GetAllRole();
			GenderComboBox.DataSource = iterator.Iterator(gender, g => g.Name);
			MaritalStatusComboBox.DataSource = iterator.Iterator(marriageStatus, m => m.Name);
			RoleComboBox.DataSource = iterator.Iterator(role, r => r.RoleType);
		}

		private void CreateAccountForm_Load(object sender, EventArgs e)
		{
			LoadDropDowns();
		}

		private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool isPassHidden = true;
			if (ShowPasswordCheckBox.Checked)
			{
				PasswordTextBox.UseSystemPasswordChar = !isPassHidden;
				RepeatPasswordTextBox.UseSystemPasswordChar = !isPassHidden;
				ShowPasswordCheckBox.Text = "Hide password";
			}
			else
			{
				PasswordTextBox.UseSystemPasswordChar = isPassHidden;
				RepeatPasswordTextBox.UseSystemPasswordChar = isPassHidden;
				ShowPasswordCheckBox.Text = "Hide password";
			}
		}
	}
}
