﻿namespace Martinez_Bank.View.Reports
{
	partial class WithdrawReportForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(819, 761);
			this.reportViewer1.TabIndex = 0;
			// 
			// WithdrawReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 761);
			this.Controls.Add(this.reportViewer1);
			this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximumSize = new System.Drawing.Size(835, 800);
			this.MinimumSize = new System.Drawing.Size(835, 800);
			this.Name = "WithdrawReportForm";
			this.Text = "DynamicReportForm";
			this.Load += new System.EventHandler(this.DynamicReportForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}