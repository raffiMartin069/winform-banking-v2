using Martinez_Bank.Persistence.Data;
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

namespace Martinez_Bank.View.Reports
{
	public partial class DepositReportForm : Form
	{
		public DepositReportForm()
		{
			InitializeComponent();
		}

		private void DepositReportForm_Load(object sender, EventArgs e)
		{
			try
			{
				var _context = new PCBDataContext();
				var logs = _context.SP_GetAllDepositRecords();
				var table = new DataTable();
				string reportFilePath = ConfigurationManager.AppSettings["DEPOSIT_REPORT"];
				string excess = @"\bin\Debug";
				reportViewer1.LocalReport.DataSources.Clear();
				string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace(excess, ""), reportFilePath);
				reportViewer1.LocalReport.ReportPath = path;

				if (logs == null)
				{
					MessageBox.Show("No data found");
					return;
				}

				reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DepositDataSet", logs.ToList()));
				this.reportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
        }
    }
}
