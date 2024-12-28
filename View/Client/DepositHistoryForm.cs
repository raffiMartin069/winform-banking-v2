using Martinez_Bank.Persistence.Data;
using Martinez_Bank.WinForm.Sessions;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_Bank.View.Client
{
	public partial class DepositHistoryForm : Form
	{
		public DepositHistoryForm()
		{
			InitializeComponent();
		}

		private void DepositHistoryForm_Load(object sender, EventArgs e)
		{
			try
			{
				var _context = new PCBDataContext();
				var key = Convert.ToInt32(Session.Get("Id"));
				var logs = _context.SP_DepositHistory(key);
				var table = new DataTable();
				string reportFilePath = ConfigurationManager.AppSettings["DEPOSIT_HISTORY"];
				string excess = @"\bin\Debug";
				reportViewer1.LocalReport.DataSources.Clear();
				string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace(excess, ""), reportFilePath);
				reportViewer1.LocalReport.ReportPath = path;

				if (logs == null)
				{
					MessageBox.Show("No data found");
					return;
				}

				reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DepositHistoryDataSet", logs.ToList()));
				this.reportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			this.reportViewer1.RefreshReport();
		}
    }
}
