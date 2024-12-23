using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Repository.Admin;
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
	public partial class SearchClientForm : Form
	{
		private readonly SearchClientRepository _repo;
		public SearchClientForm(SearchClientRepository repo)
		{
			InitializeComponent();
			_repo = repo;
		}

		private void Headers()
		{
			dataGridView1.Columns["Id"].HeaderText = "Id";
			dataGridView1.Columns["AccountNumber"].HeaderText = "Account Number";
			dataGridView1.Columns["ProfileImage"].HeaderText = "Profile Image";
			dataGridView1.Columns["Fullname"].HeaderText = "Fullname";
			dataGridView1.Columns["Balance"].HeaderText = "Balance";
			dataGridView1.Columns["Email"].HeaderText = "Email";
			dataGridView1.Columns["Address"].HeaderText = "Address";
			dataGridView1.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
			dataGridView1.Columns["PhoneNumber"].HeaderText = "Phone Number";
			dataGridView1.Columns["Gender"].HeaderText = "Gender";
			dataGridView1.Columns["Role"].HeaderText = "Role";
			dataGridView1.Columns["Marriage"].HeaderText = "Marriage";
			dataGridView1.Columns["Fathername"].HeaderText = "Father's name";
			dataGridView1.Columns["Mothername"].HeaderText = "Mother's name";
		}

		private void SearchClientForm_Load(object sender, EventArgs e)
		{
			var data = _repo.GetAllClient();
			dataGridView1.DataSource = data.ToList();
			Headers();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string key = textBox1.Text;
			var data = _repo.FindClientByKey(key);
			dataGridView1.DataSource = data.ToList();
			Headers();
		}
	}
}
