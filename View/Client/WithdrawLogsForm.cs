using Martinez_Bank.Persistence.Data;
using Martinez_Bank.WinForm.Sessions;
using Microsoft.Reporting.WinForms;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Martinez_Bank.View.Client
{
	public partial class WithdrawLogsForm : Form
	{
		public WithdrawLogsForm()
		{
			InitializeComponent();
		}

		private void WithdrawLogsForm_Load(object sender, EventArgs e)
		{
			try
			{
				var _context = new PCBDataContext();
				var key = Convert.ToInt32(Session.Get("Id"));
				var logs = _context.SP_WithdrawHistory(key);
				var table = new DataTable();
				string reportFilePath = ConfigurationManager.AppSettings["WITHDRAWAL_REPORT_BY_KEY"];
				string excess = @"\bin\Debug";
				reportViewer1.LocalReport.DataSources.Clear();
				string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace(excess, ""), reportFilePath);
				reportViewer1.LocalReport.ReportPath = path;

				if (logs == null)
				{
					MessageBox.Show("No data found");
					return;
				}

				reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("WithdrawReportByIdDataSet", logs.ToList()));
				this.reportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
        }
	}
}
