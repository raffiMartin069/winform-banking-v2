namespace Martinez_Bank.View.Mdi
{
	partial class ClientMDIParent
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMDIParent));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Deposit = new System.Windows.Forms.Button();
			this.Withdraw = new System.Windows.Forms.Button();
			this.statusStrip.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 789);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
			this.statusStrip.Size = new System.Drawing.Size(1524, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel.Text = "Status";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
			this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
			this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(250, 759);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 789);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(12)))));
			this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel2.Controls.Add(this.label3);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
			this.flowLayoutPanel2.Size = new System.Drawing.Size(253, 150);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(76, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label3.Location = new System.Drawing.Point(8, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(236, 27);
			this.label3.TabIndex = 1;
			this.label3.Text = "Welcome Internal Test!";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.Deposit, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Withdraw, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 153);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 158);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// Deposit
			// 
			this.Deposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Deposit.FlatAppearance.BorderSize = 0;
			this.Deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Deposit.ForeColor = System.Drawing.Color.White;
			this.Deposit.Image = global::Martinez_Bank.Properties.Resources.icons8_deposit_48;
			this.Deposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Deposit.Location = new System.Drawing.Point(3, 15);
			this.Deposit.Name = "Deposit";
			this.Deposit.Size = new System.Drawing.Size(241, 48);
			this.Deposit.TabIndex = 1;
			this.Deposit.Text = "Deposit";
			this.Deposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Deposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Deposit.UseVisualStyleBackColor = true;
			this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
			// 
			// Withdraw
			// 
			this.Withdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Withdraw.FlatAppearance.BorderSize = 0;
			this.Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Withdraw.ForeColor = System.Drawing.Color.White;
			this.Withdraw.Image = global::Martinez_Bank.Properties.Resources.icons8_withdraw_48;
			this.Withdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Withdraw.Location = new System.Drawing.Point(3, 94);
			this.Withdraw.Name = "Withdraw";
			this.Withdraw.Size = new System.Drawing.Size(241, 48);
			this.Withdraw.TabIndex = 1;
			this.Withdraw.Text = "Withdraw";
			this.Withdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Withdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Withdraw.UseVisualStyleBackColor = true;
			this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
			// 
			// ClientMDIParent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1524, 811);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.statusStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(1540, 850);
			this.Name = "ClientMDIParent";
			this.Text = "ClientMDIParent";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button Deposit;
		private System.Windows.Forms.Button Withdraw;
	}
}



