using Martinez_Bank.Model;
using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Repository.Admin;
using Martinez_Bank.Repository.Common;
using Martinez_Bank.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_Bank.View.Admin
{
	public partial class UpdateAccountForm : Form
	{
		private readonly CommonRepository _commonRepository;
		private readonly UpdateAccountRepository _repo;
		private const string DEFAULT_GENDER = "Male";
		private const string DEFAULT_MARITAL_STATUS = "Single";
		private const string DEFAULT_ROLE = "Client";
		private int _Id = 0;

		public UpdateAccountForm(CommonRepository commonRepository, UpdateAccountRepository repo)
		{
			InitializeComponent();
			_commonRepository = commonRepository;
			_repo = repo;
		}

		private void OnSelectGridView()
		{
			// TODO: When user select a row, put the data in the textboxes
			_Id = Convert.ToInt32(AccountsGridView.CurrentRow.Cells[1].Value.ToString());
			EmailTextBox.Text = AccountsGridView.CurrentRow.Cells[3].Value.ToString();
			DateOfBirthDateTimePicker.Text = AccountsGridView.CurrentRow.Cells[5].Value.ToString();
			PhoneTextBox.Text = AccountsGridView.CurrentRow.Cells[4].Value.ToString();
			AddressTextBox.Text = AccountsGridView.CurrentRow.Cells[8].Value.ToString();
			MaritalStatusComboBox.Text = AccountsGridView.CurrentRow.Cells[6].Value.ToString();
			GenderComboBox.Text = AccountsGridView.CurrentRow.Cells[7].Value.ToString();
			MothersNameTextBox.Text = AccountsGridView.CurrentRow.Cells[9].Value.ToString();
			FathersNameTextBox.Text = AccountsGridView.CurrentRow.Cells[10].Value.ToString();
			RoleComboBox.Text = AccountsGridView.CurrentRow.Cells[11].Value.ToString();
			BalanceTextBox.Text = AccountsGridView.CurrentRow.Cells[12].Value.ToString();

			ProfileImagePictureBox.Image = (Image)AccountsGridView.CurrentRow.Cells[13].Value;
			ProfileImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

			FullNameTextBox.Text = AccountsGridView.CurrentRow.Cells[2].Value.ToString();
		}

		private void ClearAllField()
		{
			_Id = 0;
			EmailTextBox.Clear();
			DateOfBirthDateTimePicker.Text = DateTime.Now.Date.ToString();
			PhoneTextBox.Clear();
			AddressTextBox.Clear();
			MaritalStatusComboBox.Text = DEFAULT_MARITAL_STATUS;
			GenderComboBox.Text = DEFAULT_GENDER;
			MothersNameTextBox.Clear();
			FathersNameTextBox.Clear();
			RoleComboBox.Text = DEFAULT_ROLE;
			BalanceTextBox.Clear();
			ImageUtility.DefaultImage(ProfileImagePictureBox);
			FullNameTextBox.Clear();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			string password = PasswordTextBox.Text;
			string repeatPassword = RepeatPasswordTextBox.Text;
			bool isChangePassword = PasswordUtility.UserPasswordDecision(password, repeatPassword);
			
			if (!isChangePassword) return;

			try
			{
				var model = new UpdateAccountModel(
					EmailTextBox.Text, DateOfBirthDateTimePicker.Text,
					PasswordTextBox.Text, RepeatPasswordTextBox.Text, FullNameTextBox.Text,
					PhoneTextBox.Text, AddressTextBox.Text, MaritalStatusComboBox.Text,
					GenderComboBox.Text, MothersNameTextBox.Text, FathersNameTextBox.Text,
					RoleComboBox.Text, BalanceTextBox.Text, _commonRepository, ProfileImagePictureBox.Image, _repo, _Id);

				bool result = model.UpdateAccount();

				if(!result)
				{
					MessageBox.Show("Unable to update account now. Please try again later.");
					return;
				}

				MessageBox.Show("Account updated successfully.");
				GetAllAccount();
				ClearAllField();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Headers()
		{
			AccountsGridView.Columns["Id"].HeaderText = "Identification Number";
			AccountsGridView.Columns["Email"].HeaderText = "Email";
			AccountsGridView.Columns["DateOfBirth"].HeaderText = "Date of birth";
			AccountsGridView.Columns["Phonenumber"].HeaderText = "Phone number";
			AccountsGridView.Columns["Address"].HeaderText = "Address";
			AccountsGridView.Columns["MarriageStatus"].HeaderText = "Marriage Status";
			AccountsGridView.Columns["Gender"].HeaderText = "Gender";
			AccountsGridView.Columns["Mothername"].HeaderText = "Mother's name";
			AccountsGridView.Columns["Fathername"].HeaderText = "Father's name";
			AccountsGridView.Columns["Role"].HeaderText = "Role";
			AccountsGridView.Columns["Balance"].HeaderText = "Current Balance";
			AccountsGridView.Columns["ProfileImage"].HeaderText = "Profile Image";
			AccountsGridView.Columns["OriginalSizeProfileImage"].Visible = false;
		}

		private void GetAllAccount()
		{
			var result = _commonRepository.GetAll();
			AccountsGridView.DataSource = result?.ToList();
			Headers();
		}


		private void UpdateAccountForm_Load(object sender, EventArgs e)
		{
			GetAllAccount();
			ImageUtility.DefaultImage(ProfileImagePictureBox);
		}

		private void AccountsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			OnSelectGridView();
		}

		private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string key = textBox1.Text;
			var result = _repo.FindByKey(key);

			AccountsGridView.DataSource = result?.ToList();
			Headers();
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

		private void ClearAllFieldButton_Click(object sender, EventArgs e)
		{
			ClearAllField();
		}
	}
}
