using Martinez_Bank.Persistence.Data;
using Microsoft.Reporting.WinForms;
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

namespace Martinez_Bank.View.Reports
{
	public partial class DynamicReportForm : Form
	{
		public DynamicReportForm()
		{
			InitializeComponent();
		}

		private void DynamicReportForm_Load(object sender, EventArgs e)
		{
			var _context = new PCBDataContext();

			var logs = _context.SP_GetAllWithdrawLogs();

			var table = new DataTable();

			reportViewer1.LocalReport.DataSources.Clear();
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", ""), "resources\\reports\\WithdrawalReport.rdlc");
			reportViewer1.LocalReport.ReportPath = @"D:\Code-Space\VisualStudio\Martinez_Bank\resources\reports\WithdrawalReport.rdlc";

			if(logs == null)
			{
				MessageBox.Show("No data found");
				return;
			}

			reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("WithdrawDataSet", logs.ToList()));

			// make the report at the center of the page while not using print layout
			reportViewer1.SetDisplayMode(DisplayMode.Normal);

			this.reportViewer1.RefreshReport();
        }
	}
}
