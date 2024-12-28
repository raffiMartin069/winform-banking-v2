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
			this.FullNameLabel = new System.Windows.Forms.Label();
			this.BalanceLabel = new System.Windows.Forms.Label();
			this.AccountNumberLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Deposit = new System.Windows.Forms.Button();
			this.Withdraw = new System.Windows.Forms.Button();
			this.WithdrawHistoryButton = new System.Windows.Forms.Button();
			this.DepositHistoryButton = new System.Windows.Forms.Button();
			this.LogOutButton = new System.Windows.Forms.Button();
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
			this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 789);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(12)))));
			this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel2.Controls.Add(this.FullNameLabel);
			this.flowLayoutPanel2.Controls.Add(this.BalanceLabel);
			this.flowLayoutPanel2.Controls.Add(this.AccountNumberLabel);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
			this.flowLayoutPanel2.Size = new System.Drawing.Size(284, 219);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(92, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// FullNameLabel
			// 
			this.FullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FullNameLabel.Location = new System.Drawing.Point(5, 111);
			this.FullNameLabel.Margin = new System.Windows.Forms.Padding(0);
			this.FullNameLabel.Name = "FullNameLabel";
			this.FullNameLabel.Size = new System.Drawing.Size(275, 27);
			this.FullNameLabel.TabIndex = 1;
			this.FullNameLabel.Text = "Welcome Internal Test!";
			this.FullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.FullNameLabel.Click += new System.EventHandler(this.FullNameLabel_Click);
			// 
			// BalanceLabel
			// 
			this.BalanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BalanceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BalanceLabel.Location = new System.Drawing.Point(5, 138);
			this.BalanceLabel.Margin = new System.Windows.Forms.Padding(0);
			this.BalanceLabel.Name = "BalanceLabel";
			this.BalanceLabel.Size = new System.Drawing.Size(275, 27);
			this.BalanceLabel.TabIndex = 1;
			this.BalanceLabel.Text = "Balance: 0.00";
			this.BalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BalanceLabel.Click += new System.EventHandler(this.BalanceLabel_Click);
			// 
			// AccountNumberLabel
			// 
			this.AccountNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.AccountNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.AccountNumberLabel.Location = new System.Drawing.Point(5, 165);
			this.AccountNumberLabel.Margin = new System.Windows.Forms.Padding(0);
			this.AccountNumberLabel.Name = "AccountNumberLabel";
			this.AccountNumberLabel.Size = new System.Drawing.Size(275, 27);
			this.AccountNumberLabel.TabIndex = 1;
			this.AccountNumberLabel.Text = "Account Number: 00000000000000000";
			this.AccountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AccountNumberLabel.Click += new System.EventHandler(this.AccountNumberLabel_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.Deposit, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Withdraw, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.WithdrawHistoryButton, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.DepositHistoryButton, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.LogOutButton, 0, 4);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 222);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 306);
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
			this.Deposit.Location = new System.Drawing.Point(3, 3);
			this.Deposit.Name = "Deposit";
			this.Deposit.Size = new System.Drawing.Size(272, 55);
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
			this.Withdraw.Location = new System.Drawing.Point(3, 64);
			this.Withdraw.Name = "Withdraw";
			this.Withdraw.Size = new System.Drawing.Size(272, 55);
			this.Withdraw.TabIndex = 1;
			this.Withdraw.Text = "Withdraw";
			this.Withdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Withdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Withdraw.UseVisualStyleBackColor = true;
			this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
			// 
			// WithdrawHistoryButton
			// 
			this.WithdrawHistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.WithdrawHistoryButton.FlatAppearance.BorderSize = 0;
			this.WithdrawHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WithdrawHistoryButton.ForeColor = System.Drawing.Color.White;
			this.WithdrawHistoryButton.Image = global::Martinez_Bank.Properties.Resources.icons8_history_50;
			this.WithdrawHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.WithdrawHistoryButton.Location = new System.Drawing.Point(3, 125);
			this.WithdrawHistoryButton.Name = "WithdrawHistoryButton";
			this.WithdrawHistoryButton.Size = new System.Drawing.Size(272, 55);
			this.WithdrawHistoryButton.TabIndex = 1;
			this.WithdrawHistoryButton.Text = "Withdrawal Logs";
			this.WithdrawHistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.WithdrawHistoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.WithdrawHistoryButton.UseVisualStyleBackColor = true;
			this.WithdrawHistoryButton.Click += new System.EventHandler(this.WithdrawHistoryButton_Click);
			// 
			// DepositHistoryButton
			// 
			this.DepositHistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.DepositHistoryButton.FlatAppearance.BorderSize = 0;
			this.DepositHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DepositHistoryButton.ForeColor = System.Drawing.Color.White;
			this.DepositHistoryButton.Image = global::Martinez_Bank.Properties.Resources.icons8_history_501;
			this.DepositHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DepositHistoryButton.Location = new System.Drawing.Point(3, 186);
			this.DepositHistoryButton.Name = "DepositHistoryButton";
			this.DepositHistoryButton.Size = new System.Drawing.Size(272, 55);
			this.DepositHistoryButton.TabIndex = 1;
			this.DepositHistoryButton.Text = "Deposit Logs";
			this.DepositHistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DepositHistoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.DepositHistoryButton.UseVisualStyleBackColor = true;
			this.DepositHistoryButton.Click += new System.EventHandler(this.DepositHistoryButton_Click);
			// 
			// LogOutButton
			// 
			this.LogOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.LogOutButton.FlatAppearance.BorderSize = 0;
			this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LogOutButton.ForeColor = System.Drawing.Color.White;
			this.LogOutButton.Image = global::Martinez_Bank.Properties.Resources.icons8_log_out_48;
			this.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LogOutButton.Location = new System.Drawing.Point(3, 247);
			this.LogOutButton.Name = "LogOutButton";
			this.LogOutButton.Size = new System.Drawing.Size(272, 56);
			this.LogOutButton.TabIndex = 1;
			this.LogOutButton.Text = "Log Out";
			this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.LogOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.LogOutButton.UseVisualStyleBackColor = true;
			this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
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
			this.Load += new System.EventHandler(this.ClientMDIParent_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
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
		private System.Windows.Forms.Label FullNameLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button Deposit;
		private System.Windows.Forms.Button Withdraw;
		private System.Windows.Forms.Button WithdrawHistoryButton;
		private System.Windows.Forms.Button DepositHistoryButton;
		private System.Windows.Forms.Button LogOutButton;
		private System.Windows.Forms.Label BalanceLabel;
		private System.Windows.Forms.Label AccountNumberLabel;
	}
}



