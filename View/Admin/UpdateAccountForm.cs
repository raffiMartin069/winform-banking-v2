using Martinez_Bank.Model;
using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Repository.Common;
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
	public partial class UpdateAccountForm : Form
	{
		private readonly CommonRepository _commonRepository;
		private int _id = 0;

		public UpdateAccountForm(CommonRepository commonRepository)
		{
			InitializeComponent();
			_commonRepository = commonRepository;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			//var model = new UpdateAccountModel();
			//if(_id == 0)
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
		}
	}
}
