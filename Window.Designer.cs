namespace TrimbleTest
{
	partial class Window
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
			this.tpTransactions = new System.Windows.Forms.TabPage();
			this.tpAccounts = new System.Windows.Forms.TabPage();
			this.tpCustomers = new System.Windows.Forms.TabPage();
			this.tpDBConnection = new System.Windows.Forms.TabPage();
			this.tcWindow = new System.Windows.Forms.TabControl();
			this.tpDetails = new System.Windows.Forms.TabPage();
			this.tpAddTransaction = new System.Windows.Forms.TabPage();
			this.tcWindow.SuspendLayout();
			this.SuspendLayout();
			// 
			// tpTransactions
			// 
			this.tpTransactions.Location = new System.Drawing.Point(4, 22);
			this.tpTransactions.Name = "tpTransactions";
			this.tpTransactions.Padding = new System.Windows.Forms.Padding(3);
			this.tpTransactions.Size = new System.Drawing.Size(576, 475);
			this.tpTransactions.TabIndex = 3;
			this.tpTransactions.Text = "Transactions";
			this.tpTransactions.UseVisualStyleBackColor = true;
			// 
			// tpAccounts
			// 
			this.tpAccounts.Location = new System.Drawing.Point(4, 22);
			this.tpAccounts.Name = "tpAccounts";
			this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccounts.Size = new System.Drawing.Size(576, 475);
			this.tpAccounts.TabIndex = 2;
			this.tpAccounts.Text = "Accounts";
			this.tpAccounts.UseVisualStyleBackColor = true;
			// 
			// tpCustomers
			// 
			this.tpCustomers.Location = new System.Drawing.Point(4, 22);
			this.tpCustomers.Name = "tpCustomers";
			this.tpCustomers.Padding = new System.Windows.Forms.Padding(3);
			this.tpCustomers.Size = new System.Drawing.Size(576, 475);
			this.tpCustomers.TabIndex = 1;
			this.tpCustomers.Text = "Customers";
			this.tpCustomers.UseVisualStyleBackColor = true;
			// 
			// tpDBConnection
			// 
			this.tpDBConnection.Location = new System.Drawing.Point(4, 22);
			this.tpDBConnection.Name = "tpDBConnection";
			this.tpDBConnection.Padding = new System.Windows.Forms.Padding(3);
			this.tpDBConnection.Size = new System.Drawing.Size(576, 475);
			this.tpDBConnection.TabIndex = 0;
			this.tpDBConnection.Text = "DB Connection";
			this.tpDBConnection.UseVisualStyleBackColor = true;
			// 
			// tcWindow
			// 
			this.tcWindow.Controls.Add(this.tpDBConnection);
			this.tcWindow.Controls.Add(this.tpCustomers);
			this.tcWindow.Controls.Add(this.tpAccounts);
			this.tcWindow.Controls.Add(this.tpTransactions);
			this.tcWindow.Controls.Add(this.tpDetails);
			this.tcWindow.Controls.Add(this.tpAddTransaction);
			this.tcWindow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcWindow.Location = new System.Drawing.Point(0, 0);
			this.tcWindow.Name = "tcWindow";
			this.tcWindow.SelectedIndex = 0;
			this.tcWindow.Size = new System.Drawing.Size(584, 501);
			this.tcWindow.TabIndex = 0;
			// 
			// tpDetails
			// 
			this.tpDetails.Location = new System.Drawing.Point(4, 22);
			this.tpDetails.Name = "tpDetails";
			this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tpDetails.Size = new System.Drawing.Size(576, 475);
			this.tpDetails.TabIndex = 4;
			this.tpDetails.Text = "Details";
			this.tpDetails.UseVisualStyleBackColor = true;
			// 
			// tpAddTransaction
			// 
			this.tpAddTransaction.Location = new System.Drawing.Point(4, 22);
			this.tpAddTransaction.Name = "tpAddTransaction";
			this.tpAddTransaction.Padding = new System.Windows.Forms.Padding(3);
			this.tpAddTransaction.Size = new System.Drawing.Size(576, 475);
			this.tpAddTransaction.TabIndex = 5;
			this.tpAddTransaction.Text = "Add Transaction";
			this.tpAddTransaction.UseVisualStyleBackColor = true;
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 501);
			this.Controls.Add(this.tcWindow);
			this.MinimumSize = new System.Drawing.Size(600, 540);
			this.Name = "Window";
			this.ShowIcon = false;
			this.Text = "Banking Site";
			this.tcWindow.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tpTransactions;
		private System.Windows.Forms.TabPage tpAccounts;
		private System.Windows.Forms.TabPage tpCustomers;
		private System.Windows.Forms.TabPage tpDBConnection;
		private System.Windows.Forms.TabControl tcWindow;
		private System.Windows.Forms.TabPage tpDetails;
		private System.Windows.Forms.TabPage tpAddTransaction;
	}
}

