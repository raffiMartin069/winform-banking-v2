using Martinez_Bank.Model;
using Martinez_Bank.Repository.Admin;
using Martinez_Bank.Repository.Common;
using Martinez_Bank.Utilities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Martinez_Bank.View.Admin
{
	public partial class CreateAccountForm : Form
	{
		private readonly CommonRepository _commonRepo;
		private readonly CreateAccountRepository _repo;
		private const string DEFAULT_GENDER = "Male";
		private const string DEFAULT_MARITAL_STATUS = "Single";
		private const string DEFAULT_ROLE = "Client";

		public CreateAccountForm(CommonRepository commonRepo, CreateAccountRepository repo)
		{
			InitializeComponent();
			_commonRepo = commonRepo;
			_repo = repo;
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
			GenderComboBox.Text = DEFAULT_GENDER;
			MaritalStatusComboBox.Text = DEFAULT_MARITAL_STATUS;
			RoleComboBox.Text = DEFAULT_ROLE;
			DisplayNewAccounts();
		}

		private void Headers()
		{
			NewAccountGridView.Columns["Id"].HeaderText = "Identification Number";
			NewAccountGridView.Columns["Email"].HeaderText = "Email";
			NewAccountGridView.Columns["DateOfBirth"].HeaderText = "Date of birth";
			NewAccountGridView.Columns["Phonenumber"].HeaderText = "Phone number";
			NewAccountGridView.Columns["Address"].HeaderText = "Address";
			NewAccountGridView.Columns["MarriageStatus"].HeaderText = "Marriage Status";
			NewAccountGridView.Columns["Gender"].HeaderText = "Gender";
			NewAccountGridView.Columns["Mothername"].HeaderText = "Mother's name";
			NewAccountGridView.Columns["Fathername"].HeaderText = "Father's name";
			NewAccountGridView.Columns["Role"].HeaderText = "Role";
			NewAccountGridView.Columns["Balance"].HeaderText = "Current Balance";
			NewAccountGridView.Columns["ProfileImage"].HeaderText = "Profile Image";
		}

		private void DisplayNewAccounts()
		{
			var result = _repo.GetAll();
			NewAccountGridView.DataSource = result?.ToList();
			Headers();
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
				ShowPasswordCheckBox.Text = "Show password";
			}
		}

		private void ClearFields()
		{
			EmailTextBox.Clear();
			DateOfBirthDateTimePicker.Text = DateOfBirthDateTimePicker.Value.ToShortDateString();
			PasswordTextBox.Clear();
			RepeatPasswordTextBox.Clear();
			FullNameTextBox.Clear();
			PhoneTextBox.Clear();
			AddressTextBox.Clear();
			MaritalStatusComboBox.Text = DEFAULT_MARITAL_STATUS;
			GenderComboBox.Text = DEFAULT_GENDER;
			MothersNameTextBox.Clear();
			FathersNameTextBox.Clear();
			RoleComboBox.Text = DEFAULT_ROLE;
			BalanceTextBox.Clear();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				var model = new CreateAccountModel(
					EmailTextBox.Text, DateOfBirthDateTimePicker.Text,
					PasswordTextBox.Text, RepeatPasswordTextBox.Text, FullNameTextBox.Text,
					PhoneTextBox.Text, AddressTextBox.Text, MaritalStatusComboBox.Text,
					GenderComboBox.Text, MothersNameTextBox.Text, FathersNameTextBox.Text,
					RoleComboBox.Text, BalanceTextBox.Text, _commonRepo, ProfileImagePictureBox.Image, _repo);

				bool result = model.AddAccount();

				if (!result)
				{
					MessageBox.Show("Unable to create account, something went wrong! Please try again later.");
					return;
				}

				MessageBox.Show("Account successfully created!");
				ClearFields();
				DisplayNewAccounts();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}");
			}
		}

		private void ClearAllFieldButton_Click(object sender, EventArgs e)
		{
			ClearFields();
		}


		private void ProfileImagePictureBox_Click(object sender, EventArgs e)
		{
			try
			{
				var opener = ImageUtility.OpenFileImage();
				if (opener == null)
				{
					return;
				}
				ProfileImagePictureBox.Image = opener;
				ProfileImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
				ProfileImagePictureBox.Size = new Size(150, 150);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}");
			}
		}

		private void SearchTextBox_TextChanged(object sender, EventArgs e)
		{
			var key = SearchTextBox.Text;
			var result = _repo.FindByKey(key);
			NewAccountGridView.DataSource = result?.ToList();
			Headers();
		}
	}
}
