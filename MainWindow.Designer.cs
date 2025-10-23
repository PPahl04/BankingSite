namespace BankingSite
{
	partial class MainWindow
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
			System.Windows.Forms.Label iDLabel;
			System.Windows.Forms.Label firstNameLabel;
			System.Windows.Forms.Label lastNameLabel;
			System.Windows.Forms.Label phoneNumberLabel;
			System.Windows.Forms.Label emailAddressLabel;
			System.Windows.Forms.Label address_IDLabel;
			System.Windows.Forms.Label iDLabel1;
			System.Windows.Forms.Label streetNameLabel;
			System.Windows.Forms.Label streetNumberLabel;
			System.Windows.Forms.Label zipCodeLabel;
			System.Windows.Forms.Label cityLabel;
			System.Windows.Forms.Label iDLabel2;
			System.Windows.Forms.Label iDLabel3;
			this.tpTransactions = new System.Windows.Forms.TabPage();
			this.btnCreateNewTransaction = new System.Windows.Forms.Button();
			this.btnDeleteTransaction = new System.Windows.Forms.Button();
			this.transactionIDTextBox = new System.Windows.Forms.TextBox();
			this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bankingSiteDataSet = new BankingSite.BankingSiteDataSet();
			this.dgvTransactions = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.intendedUseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountReceiverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountSenderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpAccounts = new System.Windows.Forms.TabPage();
			this.tlpAccounts = new System.Windows.Forms.TableLayoutPanel();
			this.pnlAccountDetails = new System.Windows.Forms.Panel();
			this.accountIDTextBox = new System.Windows.Forms.TextBox();
			this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnCreateNewAccount = new System.Windows.Forms.Button();
			this.btnDeleteSelectedAccount = new System.Windows.Forms.Button();
			this.dgvAccounts = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpCustomers = new System.Windows.Forms.TabPage();
			this.tlpCostumerAddress = new System.Windows.Forms.TableLayoutPanel();
			this.dgvCustomers = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dgvAddresses = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.streetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.streetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pnlCustomerDetails = new System.Windows.Forms.Panel();
			this.customerIDTextBox = new System.Windows.Forms.TextBox();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.emailAddressTextBox = new System.Windows.Forms.TextBox();
			this.address_IDTextBox = new System.Windows.Forms.TextBox();
			this.btnShowOwnedAccounts = new System.Windows.Forms.Button();
			this.btnDeleteCustomer = new System.Windows.Forms.Button();
			this.btnCreateNewCustomer = new System.Windows.Forms.Button();
			this.btnUpdateCustomer = new System.Windows.Forms.Button();
			this.pnlAddressTableAdapter = new System.Windows.Forms.Panel();
			this.addressIDTextBox = new System.Windows.Forms.TextBox();
			this.streetNameTextBox = new System.Windows.Forms.TextBox();
			this.streetNumberTextBox = new System.Windows.Forms.TextBox();
			this.zipCodeTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.btnDeleteAddress = new System.Windows.Forms.Button();
			this.btnCreateNewAddress = new System.Windows.Forms.Button();
			this.btnUpdateAddress = new System.Windows.Forms.Button();
			this.tpDBConnection = new System.Windows.Forms.TabPage();
			this.pnlDbConnection = new System.Windows.Forms.Panel();
			this.lblDbConnectionTitle = new System.Windows.Forms.Label();
			this.lblDataBaseName = new System.Windows.Forms.Label();
			this.btnConnectToDB = new System.Windows.Forms.Button();
			this.cbDbNames = new System.Windows.Forms.ComboBox();
			this.lblServerName = new System.Windows.Forms.Label();
			this.txtbPassword = new System.Windows.Forms.TextBox();
			this.txtbServerName = new System.Windows.Forms.TextBox();
			this.lblPasword = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtbUsername = new System.Windows.Forms.TextBox();
			this.tcWindow = new System.Windows.Forms.TabControl();
			this.customerTableAdapter = new BankingSite.BankingSiteDataSetTableAdapters.CustomerTableAdapter();
			this.addressTableAdapter = new BankingSite.BankingSiteDataSetTableAdapters.AddressTableAdapter();
			this.accountTableAdapter = new BankingSite.BankingSiteDataSetTableAdapters.AccountTableAdapter();
			this.transactionTableAdapter = new BankingSite.BankingSiteDataSetTableAdapters.TransactionTableAdapter();
			this.tableAdapterManager = new BankingSite.BankingSiteDataSetTableAdapters.TableAdapterManager();
			this.tlpTransactions = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			iDLabel = new System.Windows.Forms.Label();
			firstNameLabel = new System.Windows.Forms.Label();
			lastNameLabel = new System.Windows.Forms.Label();
			phoneNumberLabel = new System.Windows.Forms.Label();
			emailAddressLabel = new System.Windows.Forms.Label();
			address_IDLabel = new System.Windows.Forms.Label();
			iDLabel1 = new System.Windows.Forms.Label();
			streetNameLabel = new System.Windows.Forms.Label();
			streetNumberLabel = new System.Windows.Forms.Label();
			zipCodeLabel = new System.Windows.Forms.Label();
			cityLabel = new System.Windows.Forms.Label();
			iDLabel2 = new System.Windows.Forms.Label();
			iDLabel3 = new System.Windows.Forms.Label();
			this.tpTransactions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankingSiteDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
			this.tpAccounts.SuspendLayout();
			this.tlpAccounts.SuspendLayout();
			this.pnlAccountDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
			this.tpCustomers.SuspendLayout();
			this.tlpCostumerAddress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
			this.pnlCustomerDetails.SuspendLayout();
			this.pnlAddressTableAdapter.SuspendLayout();
			this.tpDBConnection.SuspendLayout();
			this.pnlDbConnection.SuspendLayout();
			this.tcWindow.SuspendLayout();
			this.tlpTransactions.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// iDLabel
			// 
			iDLabel.AutoSize = true;
			iDLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			iDLabel.Location = new System.Drawing.Point(55, 35);
			iDLabel.Name = "iDLabel";
			iDLabel.Size = new System.Drawing.Size(24, 23);
			iDLabel.TabIndex = 23;
			iDLabel.Text = "ID:";
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			firstNameLabel.Location = new System.Drawing.Point(55, 61);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new System.Drawing.Size(81, 23);
			firstNameLabel.TabIndex = 25;
			firstNameLabel.Text = "First Name:";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			lastNameLabel.Location = new System.Drawing.Point(55, 87);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new System.Drawing.Size(79, 23);
			lastNameLabel.TabIndex = 27;
			lastNameLabel.Text = "Last Name:";
			// 
			// phoneNumberLabel
			// 
			phoneNumberLabel.AutoSize = true;
			phoneNumberLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			phoneNumberLabel.Location = new System.Drawing.Point(55, 113);
			phoneNumberLabel.Name = "phoneNumberLabel";
			phoneNumberLabel.Size = new System.Drawing.Size(103, 23);
			phoneNumberLabel.TabIndex = 29;
			phoneNumberLabel.Text = "Phone Number:";
			// 
			// emailAddressLabel
			// 
			emailAddressLabel.AutoSize = true;
			emailAddressLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			emailAddressLabel.Location = new System.Drawing.Point(55, 139);
			emailAddressLabel.Name = "emailAddressLabel";
			emailAddressLabel.Size = new System.Drawing.Size(103, 23);
			emailAddressLabel.TabIndex = 31;
			emailAddressLabel.Text = "Email Address:";
			// 
			// address_IDLabel
			// 
			address_IDLabel.AutoSize = true;
			address_IDLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			address_IDLabel.Location = new System.Drawing.Point(55, 165);
			address_IDLabel.Name = "address_IDLabel";
			address_IDLabel.Size = new System.Drawing.Size(79, 23);
			address_IDLabel.TabIndex = 33;
			address_IDLabel.Text = "Address ID:";
			// 
			// iDLabel1
			// 
			iDLabel1.AutoSize = true;
			iDLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			iDLabel1.Location = new System.Drawing.Point(73, 43);
			iDLabel1.Name = "iDLabel1";
			iDLabel1.Size = new System.Drawing.Size(24, 23);
			iDLabel1.TabIndex = 23;
			iDLabel1.Text = "ID:";
			// 
			// streetNameLabel
			// 
			streetNameLabel.AutoSize = true;
			streetNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			streetNameLabel.Location = new System.Drawing.Point(73, 69);
			streetNameLabel.Name = "streetNameLabel";
			streetNameLabel.Size = new System.Drawing.Size(90, 23);
			streetNameLabel.TabIndex = 25;
			streetNameLabel.Text = "Street Name:";
			// 
			// streetNumberLabel
			// 
			streetNumberLabel.AutoSize = true;
			streetNumberLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			streetNumberLabel.Location = new System.Drawing.Point(73, 95);
			streetNumberLabel.Name = "streetNumberLabel";
			streetNumberLabel.Size = new System.Drawing.Size(103, 23);
			streetNumberLabel.TabIndex = 27;
			streetNumberLabel.Text = "Street Number:";
			// 
			// zipCodeLabel
			// 
			zipCodeLabel.AutoSize = true;
			zipCodeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			zipCodeLabel.Location = new System.Drawing.Point(73, 121);
			zipCodeLabel.Name = "zipCodeLabel";
			zipCodeLabel.Size = new System.Drawing.Size(66, 23);
			zipCodeLabel.TabIndex = 29;
			zipCodeLabel.Text = "Zip Code:";
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			cityLabel.Location = new System.Drawing.Point(73, 147);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(36, 23);
			cityLabel.TabIndex = 31;
			cityLabel.Text = "City:";
			// 
			// iDLabel2
			// 
			iDLabel2.AutoSize = true;
			iDLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			iDLabel2.Location = new System.Drawing.Point(20, 24);
			iDLabel2.Name = "iDLabel2";
			iDLabel2.Size = new System.Drawing.Size(81, 23);
			iDLabel2.TabIndex = 33;
			iDLabel2.Text = "Selected ID:";
			// 
			// iDLabel3
			// 
			iDLabel3.AutoSize = true;
			iDLabel3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			iDLabel3.Location = new System.Drawing.Point(20, 24);
			iDLabel3.Name = "iDLabel3";
			iDLabel3.Size = new System.Drawing.Size(81, 23);
			iDLabel3.TabIndex = 1;
			iDLabel3.Text = "Selected ID:";
			// 
			// tpTransactions
			// 
			this.tpTransactions.AutoScroll = true;
			this.tpTransactions.Controls.Add(this.tlpTransactions);
			this.tpTransactions.Location = new System.Drawing.Point(4, 22);
			this.tpTransactions.Name = "tpTransactions";
			this.tpTransactions.Padding = new System.Windows.Forms.Padding(3);
			this.tpTransactions.Size = new System.Drawing.Size(998, 620);
			this.tpTransactions.TabIndex = 3;
			this.tpTransactions.Text = "Transactions";
			this.tpTransactions.UseVisualStyleBackColor = true;
			// 
			// btnCreateNewTransaction
			// 
			this.btnCreateNewTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCreateNewTransaction.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnCreateNewTransaction.Location = new System.Drawing.Point(24, 143);
			this.btnCreateNewTransaction.Name = "btnCreateNewTransaction";
			this.btnCreateNewTransaction.Size = new System.Drawing.Size(177, 32);
			this.btnCreateNewTransaction.TabIndex = 35;
			this.btnCreateNewTransaction.Text = "Create New Transaction...";
			this.btnCreateNewTransaction.UseVisualStyleBackColor = true;
			this.btnCreateNewTransaction.Click += new System.EventHandler(this.btnCreateNewTransaction_Click);
			// 
			// btnDeleteTransaction
			// 
			this.btnDeleteTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDeleteTransaction.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnDeleteTransaction.Location = new System.Drawing.Point(38, 68);
			this.btnDeleteTransaction.Name = "btnDeleteTransaction";
			this.btnDeleteTransaction.Size = new System.Drawing.Size(155, 32);
			this.btnDeleteTransaction.TabIndex = 34;
			this.btnDeleteTransaction.Text = "Delete Transaction";
			this.btnDeleteTransaction.UseVisualStyleBackColor = true;
			this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
			// 
			// transactionIDTextBox
			// 
			this.transactionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "ID", true));
			this.transactionIDTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.transactionIDTextBox.Location = new System.Drawing.Point(106, 21);
			this.transactionIDTextBox.Name = "transactionIDTextBox";
			this.transactionIDTextBox.ReadOnly = true;
			this.transactionIDTextBox.Size = new System.Drawing.Size(100, 30);
			this.transactionIDTextBox.TabIndex = 2;
			// 
			// transactionBindingSource
			// 
			this.transactionBindingSource.DataMember = "Transaction";
			this.transactionBindingSource.DataSource = this.bankingSiteDataSet;
			// 
			// bankingSiteDataSet
			// 
			this.bankingSiteDataSet.DataSetName = "BankingSiteDataSet";
			this.bankingSiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dgvTransactions
			// 
			this.dgvTransactions.AllowUserToAddRows = false;
			this.dgvTransactions.AllowUserToDeleteRows = false;
			this.dgvTransactions.AutoGenerateColumns = false;
			this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.intendedUseDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.accountReceiverIDDataGridViewTextBoxColumn,
            this.accountSenderIDDataGridViewTextBoxColumn});
			this.dgvTransactions.DataSource = this.transactionBindingSource;
			this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTransactions.Location = new System.Drawing.Point(241, 4);
			this.dgvTransactions.Name = "dgvTransactions";
			this.dgvTransactions.ReadOnly = true;
			this.dgvTransactions.RowHeadersWidth = 21;
			this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTransactions.Size = new System.Drawing.Size(747, 606);
			this.dgvTransactions.TabIndex = 1;
			// 
			// iDDataGridViewTextBoxColumn3
			// 
			this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
			this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn3.Width = 43;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateDataGridViewTextBoxColumn.Width = 55;
			// 
			// amountDataGridViewTextBoxColumn
			// 
			this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
			this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
			this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
			this.amountDataGridViewTextBoxColumn.ReadOnly = true;
			this.amountDataGridViewTextBoxColumn.Width = 68;
			// 
			// intendedUseDataGridViewTextBoxColumn
			// 
			this.intendedUseDataGridViewTextBoxColumn.DataPropertyName = "IntendedUse";
			this.intendedUseDataGridViewTextBoxColumn.HeaderText = "IntendedUse";
			this.intendedUseDataGridViewTextBoxColumn.Name = "intendedUseDataGridViewTextBoxColumn";
			this.intendedUseDataGridViewTextBoxColumn.ReadOnly = true;
			this.intendedUseDataGridViewTextBoxColumn.Width = 93;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeDataGridViewTextBoxColumn.Width = 56;
			// 
			// accountReceiverIDDataGridViewTextBoxColumn
			// 
			this.accountReceiverIDDataGridViewTextBoxColumn.DataPropertyName = "AccountReceiver_ID";
			this.accountReceiverIDDataGridViewTextBoxColumn.HeaderText = "AccountReceiver_ID";
			this.accountReceiverIDDataGridViewTextBoxColumn.Name = "accountReceiverIDDataGridViewTextBoxColumn";
			this.accountReceiverIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.accountReceiverIDDataGridViewTextBoxColumn.Width = 132;
			// 
			// accountSenderIDDataGridViewTextBoxColumn
			// 
			this.accountSenderIDDataGridViewTextBoxColumn.DataPropertyName = "AccountSender_ID";
			this.accountSenderIDDataGridViewTextBoxColumn.HeaderText = "AccountSender_ID";
			this.accountSenderIDDataGridViewTextBoxColumn.Name = "accountSenderIDDataGridViewTextBoxColumn";
			this.accountSenderIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.accountSenderIDDataGridViewTextBoxColumn.Width = 123;
			// 
			// tpAccounts
			// 
			this.tpAccounts.AutoScroll = true;
			this.tpAccounts.Controls.Add(this.tlpAccounts);
			this.tpAccounts.Location = new System.Drawing.Point(4, 22);
			this.tpAccounts.Name = "tpAccounts";
			this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccounts.Size = new System.Drawing.Size(998, 620);
			this.tpAccounts.TabIndex = 2;
			this.tpAccounts.Text = "Accounts";
			this.tpAccounts.UseVisualStyleBackColor = true;
			// 
			// tlpAccounts
			// 
			this.tlpAccounts.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlpAccounts.ColumnCount = 2;
			this.tlpAccounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.91524F));
			this.tlpAccounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.08476F));
			this.tlpAccounts.Controls.Add(this.pnlAccountDetails, 0, 0);
			this.tlpAccounts.Controls.Add(this.dgvAccounts, 1, 0);
			this.tlpAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpAccounts.Location = new System.Drawing.Point(3, 3);
			this.tlpAccounts.Name = "tlpAccounts";
			this.tlpAccounts.RowCount = 1;
			this.tlpAccounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.96737F));
			this.tlpAccounts.Size = new System.Drawing.Size(992, 614);
			this.tlpAccounts.TabIndex = 11;
			// 
			// pnlAccountDetails
			// 
			this.pnlAccountDetails.AutoScroll = true;
			this.pnlAccountDetails.Controls.Add(iDLabel2);
			this.pnlAccountDetails.Controls.Add(this.accountIDTextBox);
			this.pnlAccountDetails.Controls.Add(this.btnCreateNewAccount);
			this.pnlAccountDetails.Controls.Add(this.btnDeleteSelectedAccount);
			this.pnlAccountDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAccountDetails.Location = new System.Drawing.Point(4, 4);
			this.pnlAccountDetails.Name = "pnlAccountDetails";
			this.pnlAccountDetails.Size = new System.Drawing.Size(230, 606);
			this.pnlAccountDetails.TabIndex = 12;
			// 
			// accountIDTextBox
			// 
			this.accountIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "ID", true));
			this.accountIDTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.accountIDTextBox.Location = new System.Drawing.Point(106, 21);
			this.accountIDTextBox.Name = "accountIDTextBox";
			this.accountIDTextBox.ReadOnly = true;
			this.accountIDTextBox.Size = new System.Drawing.Size(100, 30);
			this.accountIDTextBox.TabIndex = 34;
			// 
			// accountBindingSource
			// 
			this.accountBindingSource.DataMember = "Account";
			this.accountBindingSource.DataSource = this.bankingSiteDataSet;
			// 
			// btnCreateNewAccount
			// 
			this.btnCreateNewAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCreateNewAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnCreateNewAccount.Location = new System.Drawing.Point(36, 153);
			this.btnCreateNewAccount.Name = "btnCreateNewAccount";
			this.btnCreateNewAccount.Size = new System.Drawing.Size(155, 32);
			this.btnCreateNewAccount.TabIndex = 33;
			this.btnCreateNewAccount.Text = "Create New Account...";
			this.btnCreateNewAccount.UseVisualStyleBackColor = true;
			this.btnCreateNewAccount.Click += new System.EventHandler(this.btnCreateNewAccount_Click);
			// 
			// btnDeleteSelectedAccount
			// 
			this.btnDeleteSelectedAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDeleteSelectedAccount.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnDeleteSelectedAccount.Location = new System.Drawing.Point(36, 66);
			this.btnDeleteSelectedAccount.Name = "btnDeleteSelectedAccount";
			this.btnDeleteSelectedAccount.Size = new System.Drawing.Size(155, 32);
			this.btnDeleteSelectedAccount.TabIndex = 23;
			this.btnDeleteSelectedAccount.Text = "Delete Account";
			this.btnDeleteSelectedAccount.UseVisualStyleBackColor = true;
			this.btnDeleteSelectedAccount.Click += new System.EventHandler(this.btnDeleteSelectedAccount_Click);
			// 
			// dgvAccounts
			// 
			this.dgvAccounts.AllowUserToAddRows = false;
			this.dgvAccounts.AllowUserToDeleteRows = false;
			this.dgvAccounts.AutoGenerateColumns = false;
			this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.iBANDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn});
			this.dgvAccounts.DataSource = this.accountBindingSource;
			this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAccounts.Location = new System.Drawing.Point(241, 4);
			this.dgvAccounts.MultiSelect = false;
			this.dgvAccounts.Name = "dgvAccounts";
			this.dgvAccounts.ReadOnly = true;
			this.dgvAccounts.RowHeadersWidth = 21;
			this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAccounts.Size = new System.Drawing.Size(747, 606);
			this.dgvAccounts.TabIndex = 1;
			// 
			// iDDataGridViewTextBoxColumn2
			// 
			this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
			this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn2.Width = 43;
			// 
			// iBANDataGridViewTextBoxColumn
			// 
			this.iBANDataGridViewTextBoxColumn.DataPropertyName = "IBAN";
			this.iBANDataGridViewTextBoxColumn.HeaderText = "IBAN";
			this.iBANDataGridViewTextBoxColumn.Name = "iBANDataGridViewTextBoxColumn";
			this.iBANDataGridViewTextBoxColumn.ReadOnly = true;
			this.iBANDataGridViewTextBoxColumn.Width = 57;
			// 
			// balanceDataGridViewTextBoxColumn
			// 
			this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
			this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
			this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
			this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
			this.balanceDataGridViewTextBoxColumn.Width = 71;
			// 
			// numberDataGridViewTextBoxColumn
			// 
			this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
			this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
			this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
			this.numberDataGridViewTextBoxColumn.ReadOnly = true;
			this.numberDataGridViewTextBoxColumn.Width = 69;
			// 
			// customerIDDataGridViewTextBoxColumn
			// 
			this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
			this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
			this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
			this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.customerIDDataGridViewTextBoxColumn.Width = 93;
			// 
			// tpCustomers
			// 
			this.tpCustomers.Controls.Add(this.tlpCostumerAddress);
			this.tpCustomers.Location = new System.Drawing.Point(4, 22);
			this.tpCustomers.Name = "tpCustomers";
			this.tpCustomers.Padding = new System.Windows.Forms.Padding(3);
			this.tpCustomers.Size = new System.Drawing.Size(998, 620);
			this.tpCustomers.TabIndex = 1;
			this.tpCustomers.Text = "Customers";
			this.tpCustomers.UseVisualStyleBackColor = true;
			// 
			// tlpCostumerAddress
			// 
			this.tlpCostumerAddress.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlpCostumerAddress.ColumnCount = 2;
			this.tlpCostumerAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.57739F));
			this.tlpCostumerAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.42262F));
			this.tlpCostumerAddress.Controls.Add(this.dgvCustomers, 1, 0);
			this.tlpCostumerAddress.Controls.Add(this.dgvAddresses, 1, 1);
			this.tlpCostumerAddress.Controls.Add(this.pnlCustomerDetails, 0, 0);
			this.tlpCostumerAddress.Controls.Add(this.pnlAddressTableAdapter, 0, 1);
			this.tlpCostumerAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpCostumerAddress.Location = new System.Drawing.Point(3, 3);
			this.tlpCostumerAddress.Name = "tlpCostumerAddress";
			this.tlpCostumerAddress.RowCount = 2;
			this.tlpCostumerAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpCostumerAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 309F));
			this.tlpCostumerAddress.Size = new System.Drawing.Size(992, 614);
			this.tlpCostumerAddress.TabIndex = 14;
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.AllowUserToAddRows = false;
			this.dgvCustomers.AllowUserToDeleteRows = false;
			this.dgvCustomers.AutoGenerateColumns = false;
			this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.addressIDDataGridViewTextBoxColumn});
			this.dgvCustomers.DataSource = this.customerBindingSource;
			this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCustomers.Location = new System.Drawing.Point(346, 4);
			this.dgvCustomers.MultiSelect = false;
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.ReadOnly = true;
			this.dgvCustomers.RowHeadersWidth = 21;
			this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomers.ShowEditingIcon = false;
			this.dgvCustomers.Size = new System.Drawing.Size(642, 296);
			this.dgvCustomers.TabIndex = 0;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn.Width = 43;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.firstNameDataGridViewTextBoxColumn.Width = 79;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.lastNameDataGridViewTextBoxColumn.Width = 80;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailAddressDataGridViewTextBoxColumn
			// 
			this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
			this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
			this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
			this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
			this.emailAddressDataGridViewTextBoxColumn.Width = 95;
			// 
			// addressIDDataGridViewTextBoxColumn
			// 
			this.addressIDDataGridViewTextBoxColumn.DataPropertyName = "Address_ID";
			this.addressIDDataGridViewTextBoxColumn.HeaderText = "Address_ID";
			this.addressIDDataGridViewTextBoxColumn.Name = "addressIDDataGridViewTextBoxColumn";
			this.addressIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.addressIDDataGridViewTextBoxColumn.Width = 87;
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataMember = "Customer";
			this.customerBindingSource.DataSource = this.bankingSiteDataSet;
			// 
			// dgvAddresses
			// 
			this.dgvAddresses.AllowUserToAddRows = false;
			this.dgvAddresses.AllowUserToDeleteRows = false;
			this.dgvAddresses.AutoGenerateColumns = false;
			this.dgvAddresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.streetNameDataGridViewTextBoxColumn,
            this.streetNumberDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
			this.dgvAddresses.DataSource = this.addressBindingSource;
			this.dgvAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAddresses.Location = new System.Drawing.Point(346, 307);
			this.dgvAddresses.MultiSelect = false;
			this.dgvAddresses.Name = "dgvAddresses";
			this.dgvAddresses.ReadOnly = true;
			this.dgvAddresses.RowHeadersWidth = 21;
			this.dgvAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAddresses.ShowEditingIcon = false;
			this.dgvAddresses.Size = new System.Drawing.Size(642, 303);
			this.dgvAddresses.TabIndex = 1;
			// 
			// iDDataGridViewTextBoxColumn1
			// 
			this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
			this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// streetNameDataGridViewTextBoxColumn
			// 
			this.streetNameDataGridViewTextBoxColumn.DataPropertyName = "StreetName";
			this.streetNameDataGridViewTextBoxColumn.HeaderText = "StreetName";
			this.streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
			this.streetNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// streetNumberDataGridViewTextBoxColumn
			// 
			this.streetNumberDataGridViewTextBoxColumn.DataPropertyName = "StreetNumber";
			this.streetNumberDataGridViewTextBoxColumn.HeaderText = "StreetNumber";
			this.streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
			this.streetNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// zipCodeDataGridViewTextBoxColumn
			// 
			this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
			this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
			this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
			this.zipCodeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cityDataGridViewTextBoxColumn
			// 
			this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
			this.cityDataGridViewTextBoxColumn.HeaderText = "City";
			this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
			this.cityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// addressBindingSource
			// 
			this.addressBindingSource.DataMember = "Address";
			this.addressBindingSource.DataSource = this.bankingSiteDataSet;
			// 
			// pnlCustomerDetails
			// 
			this.pnlCustomerDetails.AutoScroll = true;
			this.pnlCustomerDetails.Controls.Add(iDLabel);
			this.pnlCustomerDetails.Controls.Add(this.customerIDTextBox);
			this.pnlCustomerDetails.Controls.Add(firstNameLabel);
			this.pnlCustomerDetails.Controls.Add(this.firstNameTextBox);
			this.pnlCustomerDetails.Controls.Add(lastNameLabel);
			this.pnlCustomerDetails.Controls.Add(this.lastNameTextBox);
			this.pnlCustomerDetails.Controls.Add(phoneNumberLabel);
			this.pnlCustomerDetails.Controls.Add(this.phoneNumberTextBox);
			this.pnlCustomerDetails.Controls.Add(emailAddressLabel);
			this.pnlCustomerDetails.Controls.Add(this.emailAddressTextBox);
			this.pnlCustomerDetails.Controls.Add(address_IDLabel);
			this.pnlCustomerDetails.Controls.Add(this.address_IDTextBox);
			this.pnlCustomerDetails.Controls.Add(this.btnShowOwnedAccounts);
			this.pnlCustomerDetails.Controls.Add(this.btnDeleteCustomer);
			this.pnlCustomerDetails.Controls.Add(this.btnCreateNewCustomer);
			this.pnlCustomerDetails.Controls.Add(this.btnUpdateCustomer);
			this.pnlCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCustomerDetails.Location = new System.Drawing.Point(4, 4);
			this.pnlCustomerDetails.Name = "pnlCustomerDetails";
			this.pnlCustomerDetails.Size = new System.Drawing.Size(335, 296);
			this.pnlCustomerDetails.TabIndex = 21;
			// 
			// customerIDTextBox
			// 
			this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ID", true));
			this.customerIDTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.customerIDTextBox.Location = new System.Drawing.Point(158, 32);
			this.customerIDTextBox.Name = "customerIDTextBox";
			this.customerIDTextBox.ReadOnly = true;
			this.customerIDTextBox.Size = new System.Drawing.Size(100, 30);
			this.customerIDTextBox.TabIndex = 24;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FirstName", true));
			this.firstNameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.firstNameTextBox.Location = new System.Drawing.Point(158, 58);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(100, 30);
			this.firstNameTextBox.TabIndex = 26;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "LastName", true));
			this.lastNameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.lastNameTextBox.Location = new System.Drawing.Point(158, 84);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(100, 30);
			this.lastNameTextBox.TabIndex = 28;
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PhoneNumber", true));
			this.phoneNumberTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.phoneNumberTextBox.Location = new System.Drawing.Point(158, 110);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 30);
			this.phoneNumberTextBox.TabIndex = 30;
			// 
			// emailAddressTextBox
			// 
			this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "EmailAddress", true));
			this.emailAddressTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.emailAddressTextBox.Location = new System.Drawing.Point(158, 136);
			this.emailAddressTextBox.Name = "emailAddressTextBox";
			this.emailAddressTextBox.Size = new System.Drawing.Size(100, 30);
			this.emailAddressTextBox.TabIndex = 32;
			// 
			// address_IDTextBox
			// 
			this.address_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address_ID", true));
			this.address_IDTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.address_IDTextBox.Location = new System.Drawing.Point(158, 162);
			this.address_IDTextBox.Name = "address_IDTextBox";
			this.address_IDTextBox.Size = new System.Drawing.Size(100, 30);
			this.address_IDTextBox.TabIndex = 34;
			// 
			// btnShowOwnedAccounts
			// 
			this.btnShowOwnedAccounts.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnShowOwnedAccounts.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnShowOwnedAccounts.Location = new System.Drawing.Point(158, 254);
			this.btnShowOwnedAccounts.Name = "btnShowOwnedAccounts";
			this.btnShowOwnedAccounts.Size = new System.Drawing.Size(171, 32);
			this.btnShowOwnedAccounts.TabIndex = 23;
			this.btnShowOwnedAccounts.Text = "Show Owned Accounts...";
			this.btnShowOwnedAccounts.UseVisualStyleBackColor = true;
			this.btnShowOwnedAccounts.Click += new System.EventHandler(this.btnShowOwnedAccounts_Click);
			// 
			// btnDeleteCustomer
			// 
			this.btnDeleteCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDeleteCustomer.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnDeleteCustomer.Location = new System.Drawing.Point(12, 254);
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.Size = new System.Drawing.Size(140, 32);
			this.btnDeleteCustomer.TabIndex = 22;
			this.btnDeleteCustomer.Text = "Delete Customer";
			this.btnDeleteCustomer.UseVisualStyleBackColor = true;
			this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
			// 
			// btnCreateNewCustomer
			// 
			this.btnCreateNewCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCreateNewCustomer.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnCreateNewCustomer.Location = new System.Drawing.Point(158, 216);
			this.btnCreateNewCustomer.Name = "btnCreateNewCustomer";
			this.btnCreateNewCustomer.Size = new System.Drawing.Size(171, 32);
			this.btnCreateNewCustomer.TabIndex = 21;
			this.btnCreateNewCustomer.Text = "Create New Customer...";
			this.btnCreateNewCustomer.UseVisualStyleBackColor = true;
			this.btnCreateNewCustomer.Click += new System.EventHandler(this.btnCreateNewCustomer_Click);
			// 
			// btnUpdateCustomer
			// 
			this.btnUpdateCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnUpdateCustomer.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnUpdateCustomer.Location = new System.Drawing.Point(12, 216);
			this.btnUpdateCustomer.Name = "btnUpdateCustomer";
			this.btnUpdateCustomer.Size = new System.Drawing.Size(140, 32);
			this.btnUpdateCustomer.TabIndex = 20;
			this.btnUpdateCustomer.Text = "Update Customer";
			this.btnUpdateCustomer.UseVisualStyleBackColor = true;
			this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
			// 
			// pnlAddressTableAdapter
			// 
			this.pnlAddressTableAdapter.AutoScroll = true;
			this.pnlAddressTableAdapter.Controls.Add(iDLabel1);
			this.pnlAddressTableAdapter.Controls.Add(this.addressIDTextBox);
			this.pnlAddressTableAdapter.Controls.Add(streetNameLabel);
			this.pnlAddressTableAdapter.Controls.Add(this.streetNameTextBox);
			this.pnlAddressTableAdapter.Controls.Add(streetNumberLabel);
			this.pnlAddressTableAdapter.Controls.Add(this.streetNumberTextBox);
			this.pnlAddressTableAdapter.Controls.Add(zipCodeLabel);
			this.pnlAddressTableAdapter.Controls.Add(this.zipCodeTextBox);
			this.pnlAddressTableAdapter.Controls.Add(cityLabel);
			this.pnlAddressTableAdapter.Controls.Add(this.cityTextBox);
			this.pnlAddressTableAdapter.Controls.Add(this.btnDeleteAddress);
			this.pnlAddressTableAdapter.Controls.Add(this.btnCreateNewAddress);
			this.pnlAddressTableAdapter.Controls.Add(this.btnUpdateAddress);
			this.pnlAddressTableAdapter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAddressTableAdapter.Location = new System.Drawing.Point(4, 307);
			this.pnlAddressTableAdapter.Name = "pnlAddressTableAdapter";
			this.pnlAddressTableAdapter.Size = new System.Drawing.Size(335, 303);
			this.pnlAddressTableAdapter.TabIndex = 22;
			// 
			// addressIDTextBox
			// 
			this.addressIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "ID", true));
			this.addressIDTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.addressIDTextBox.Location = new System.Drawing.Point(181, 43);
			this.addressIDTextBox.Name = "addressIDTextBox";
			this.addressIDTextBox.ReadOnly = true;
			this.addressIDTextBox.Size = new System.Drawing.Size(100, 30);
			this.addressIDTextBox.TabIndex = 24;
			// 
			// streetNameTextBox
			// 
			this.streetNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "StreetName", true));
			this.streetNameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.streetNameTextBox.Location = new System.Drawing.Point(181, 69);
			this.streetNameTextBox.Name = "streetNameTextBox";
			this.streetNameTextBox.Size = new System.Drawing.Size(100, 30);
			this.streetNameTextBox.TabIndex = 26;
			// 
			// streetNumberTextBox
			// 
			this.streetNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "StreetNumber", true));
			this.streetNumberTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.streetNumberTextBox.Location = new System.Drawing.Point(181, 95);
			this.streetNumberTextBox.Name = "streetNumberTextBox";
			this.streetNumberTextBox.Size = new System.Drawing.Size(100, 30);
			this.streetNumberTextBox.TabIndex = 28;
			// 
			// zipCodeTextBox
			// 
			this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "ZipCode", true));
			this.zipCodeTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.zipCodeTextBox.Location = new System.Drawing.Point(181, 121);
			this.zipCodeTextBox.Name = "zipCodeTextBox";
			this.zipCodeTextBox.Size = new System.Drawing.Size(100, 30);
			this.zipCodeTextBox.TabIndex = 30;
			// 
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "City", true));
			this.cityTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.cityTextBox.Location = new System.Drawing.Point(181, 147);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(100, 30);
			this.cityTextBox.TabIndex = 32;
			// 
			// btnDeleteAddress
			// 
			this.btnDeleteAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDeleteAddress.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnDeleteAddress.Location = new System.Drawing.Point(89, 253);
			this.btnDeleteAddress.Name = "btnDeleteAddress";
			this.btnDeleteAddress.Size = new System.Drawing.Size(157, 32);
			this.btnDeleteAddress.TabIndex = 23;
			this.btnDeleteAddress.Text = "Delete Address";
			this.btnDeleteAddress.UseVisualStyleBackColor = true;
			this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
			// 
			// btnCreateNewAddress
			// 
			this.btnCreateNewAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCreateNewAddress.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnCreateNewAddress.Location = new System.Drawing.Point(166, 215);
			this.btnCreateNewAddress.Name = "btnCreateNewAddress";
			this.btnCreateNewAddress.Size = new System.Drawing.Size(157, 32);
			this.btnCreateNewAddress.TabIndex = 23;
			this.btnCreateNewAddress.Text = "Create New Address...";
			this.btnCreateNewAddress.UseVisualStyleBackColor = true;
			this.btnCreateNewAddress.Click += new System.EventHandler(this.btnCreateNewAddress_Click);
			// 
			// btnUpdateAddress
			// 
			this.btnUpdateAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnUpdateAddress.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnUpdateAddress.Location = new System.Drawing.Point(11, 215);
			this.btnUpdateAddress.Name = "btnUpdateAddress";
			this.btnUpdateAddress.Size = new System.Drawing.Size(140, 32);
			this.btnUpdateAddress.TabIndex = 22;
			this.btnUpdateAddress.Text = "Update Address";
			this.btnUpdateAddress.UseVisualStyleBackColor = true;
			this.btnUpdateAddress.Click += new System.EventHandler(this.btnUpdateAddress_Click);
			// 
			// tpDBConnection
			// 
			this.tpDBConnection.Controls.Add(this.pnlDbConnection);
			this.tpDBConnection.Location = new System.Drawing.Point(4, 22);
			this.tpDBConnection.Name = "tpDBConnection";
			this.tpDBConnection.Padding = new System.Windows.Forms.Padding(3);
			this.tpDBConnection.Size = new System.Drawing.Size(998, 620);
			this.tpDBConnection.TabIndex = 0;
			this.tpDBConnection.Text = "DB Connection";
			this.tpDBConnection.UseVisualStyleBackColor = true;
			// 
			// pnlDbConnection
			// 
			this.pnlDbConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlDbConnection.AutoSize = true;
			this.pnlDbConnection.Controls.Add(this.lblDbConnectionTitle);
			this.pnlDbConnection.Controls.Add(this.lblDataBaseName);
			this.pnlDbConnection.Controls.Add(this.btnConnectToDB);
			this.pnlDbConnection.Controls.Add(this.cbDbNames);
			this.pnlDbConnection.Controls.Add(this.lblServerName);
			this.pnlDbConnection.Controls.Add(this.txtbPassword);
			this.pnlDbConnection.Controls.Add(this.txtbServerName);
			this.pnlDbConnection.Controls.Add(this.lblPasword);
			this.pnlDbConnection.Controls.Add(this.lblUsername);
			this.pnlDbConnection.Controls.Add(this.txtbUsername);
			this.pnlDbConnection.Location = new System.Drawing.Point(271, 143);
			this.pnlDbConnection.Name = "pnlDbConnection";
			this.pnlDbConnection.Size = new System.Drawing.Size(456, 335);
			this.pnlDbConnection.TabIndex = 24;
			// 
			// lblDbConnectionTitle
			// 
			this.lblDbConnectionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDbConnectionTitle.AutoSize = true;
			this.lblDbConnectionTitle.Font = new System.Drawing.Font("Bahnschrift", 15F);
			this.lblDbConnectionTitle.Location = new System.Drawing.Point(89, 2);
			this.lblDbConnectionTitle.Name = "lblDbConnectionTitle";
			this.lblDbConnectionTitle.Size = new System.Drawing.Size(279, 24);
			this.lblDbConnectionTitle.TabIndex = 23;
			this.lblDbConnectionTitle.Text = "Connect to a Database Server";
			this.lblDbConnectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDataBaseName
			// 
			this.lblDataBaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDataBaseName.AutoSize = true;
			this.lblDataBaseName.Font = new System.Drawing.Font("Bahnschrift", 12F);
			this.lblDataBaseName.Location = new System.Drawing.Point(3, 200);
			this.lblDataBaseName.Name = "lblDataBaseName";
			this.lblDataBaseName.Size = new System.Drawing.Size(102, 19);
			this.lblDataBaseName.TabIndex = 22;
			this.lblDataBaseName.Text = "Selected DB:";
			this.lblDataBaseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnConnectToDB
			// 
			this.btnConnectToDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConnectToDB.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnectToDB.Location = new System.Drawing.Point(163, 261);
			this.btnConnectToDB.MaximumSize = new System.Drawing.Size(130, 54);
			this.btnConnectToDB.MinimumSize = new System.Drawing.Size(130, 54);
			this.btnConnectToDB.Name = "btnConnectToDB";
			this.btnConnectToDB.Size = new System.Drawing.Size(130, 54);
			this.btnConnectToDB.TabIndex = 13;
			this.btnConnectToDB.Text = "Connect";
			this.btnConnectToDB.UseVisualStyleBackColor = true;
			this.btnConnectToDB.Click += new System.EventHandler(this.btnConnectToDB_Click);
			// 
			// cbDbNames
			// 
			this.cbDbNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDbNames.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDbNames.FormattingEnabled = true;
			this.cbDbNames.Location = new System.Drawing.Point(119, 198);
			this.cbDbNames.MinimumSize = new System.Drawing.Size(255, 0);
			this.cbDbNames.Name = "cbDbNames";
			this.cbDbNames.Size = new System.Drawing.Size(328, 26);
			this.cbDbNames.TabIndex = 21;
			// 
			// lblServerName
			// 
			this.lblServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblServerName.AutoSize = true;
			this.lblServerName.Font = new System.Drawing.Font("Bahnschrift", 12F);
			this.lblServerName.Location = new System.Drawing.Point(3, 62);
			this.lblServerName.Name = "lblServerName";
			this.lblServerName.Size = new System.Drawing.Size(110, 19);
			this.lblServerName.TabIndex = 14;
			this.lblServerName.Text = "Server Name:";
			this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtbPassword
			// 
			this.txtbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtbPassword.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbPassword.Location = new System.Drawing.Point(119, 152);
			this.txtbPassword.MinimumSize = new System.Drawing.Size(255, 27);
			this.txtbPassword.Name = "txtbPassword";
			this.txtbPassword.Size = new System.Drawing.Size(328, 26);
			this.txtbPassword.TabIndex = 20;
			this.txtbPassword.UseSystemPasswordChar = true;
			this.txtbPassword.Leave += new System.EventHandler(this.txtbPassword_Leave);
			// 
			// txtbServerName
			// 
			this.txtbServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtbServerName.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbServerName.Location = new System.Drawing.Point(119, 60);
			this.txtbServerName.MinimumSize = new System.Drawing.Size(255, 27);
			this.txtbServerName.Name = "txtbServerName";
			this.txtbServerName.Size = new System.Drawing.Size(328, 26);
			this.txtbServerName.TabIndex = 16;
			// 
			// lblPasword
			// 
			this.lblPasword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPasword.AutoSize = true;
			this.lblPasword.Font = new System.Drawing.Font("Bahnschrift", 12F);
			this.lblPasword.Location = new System.Drawing.Point(3, 154);
			this.lblPasword.Name = "lblPasword";
			this.lblPasword.Size = new System.Drawing.Size(85, 19);
			this.lblPasword.TabIndex = 19;
			this.lblPasword.Text = "Password:";
			this.lblPasword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblUsername
			// 
			this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Bahnschrift", 12F);
			this.lblUsername.Location = new System.Drawing.Point(3, 108);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(88, 19);
			this.lblUsername.TabIndex = 17;
			this.lblUsername.Text = "Username:";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtbUsername
			// 
			this.txtbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtbUsername.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbUsername.Location = new System.Drawing.Point(119, 106);
			this.txtbUsername.MinimumSize = new System.Drawing.Size(255, 27);
			this.txtbUsername.Name = "txtbUsername";
			this.txtbUsername.Size = new System.Drawing.Size(328, 26);
			this.txtbUsername.TabIndex = 18;
			// 
			// tcWindow
			// 
			this.tcWindow.Controls.Add(this.tpDBConnection);
			this.tcWindow.Controls.Add(this.tpCustomers);
			this.tcWindow.Controls.Add(this.tpAccounts);
			this.tcWindow.Controls.Add(this.tpTransactions);
			this.tcWindow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcWindow.Location = new System.Drawing.Point(0, 0);
			this.tcWindow.Name = "tcWindow";
			this.tcWindow.SelectedIndex = 0;
			this.tcWindow.Size = new System.Drawing.Size(1006, 646);
			this.tcWindow.TabIndex = 0;
			// 
			// customerTableAdapter
			// 
			this.customerTableAdapter.ClearBeforeFill = true;
			// 
			// addressTableAdapter
			// 
			this.addressTableAdapter.ClearBeforeFill = true;
			// 
			// accountTableAdapter
			// 
			this.accountTableAdapter.ClearBeforeFill = true;
			// 
			// transactionTableAdapter
			// 
			this.transactionTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
			this.tableAdapterManager.AddressTableAdapter = this.addressTableAdapter;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
			this.tableAdapterManager.TransactionTableAdapter = this.transactionTableAdapter;
			this.tableAdapterManager.UpdateOrder = BankingSite.BankingSiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// tlpTransactions
			// 
			this.tlpTransactions.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tlpTransactions.ColumnCount = 2;
			this.tlpTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.91524F));
			this.tlpTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.08476F));
			this.tlpTransactions.Controls.Add(this.panel1, 0, 0);
			this.tlpTransactions.Controls.Add(this.dgvTransactions, 1, 0);
			this.tlpTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpTransactions.Location = new System.Drawing.Point(3, 3);
			this.tlpTransactions.Name = "tlpTransactions";
			this.tlpTransactions.RowCount = 1;
			this.tlpTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.96737F));
			this.tlpTransactions.Size = new System.Drawing.Size(992, 614);
			this.tlpTransactions.TabIndex = 36;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.btnCreateNewTransaction);
			this.panel1.Controls.Add(iDLabel3);
			this.panel1.Controls.Add(this.btnDeleteTransaction);
			this.panel1.Controls.Add(this.transactionIDTextBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(230, 606);
			this.panel1.TabIndex = 12;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1006, 646);
			this.Controls.Add(this.tcWindow);
			this.MinimumSize = new System.Drawing.Size(1022, 685);
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Banking Site";
			this.Load += new System.EventHandler(this.Window_Load);
			this.tpTransactions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankingSiteDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
			this.tpAccounts.ResumeLayout(false);
			this.tlpAccounts.ResumeLayout(false);
			this.pnlAccountDetails.ResumeLayout(false);
			this.pnlAccountDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
			this.tpCustomers.ResumeLayout(false);
			this.tlpCostumerAddress.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
			this.pnlCustomerDetails.ResumeLayout(false);
			this.pnlCustomerDetails.PerformLayout();
			this.pnlAddressTableAdapter.ResumeLayout(false);
			this.pnlAddressTableAdapter.PerformLayout();
			this.tpDBConnection.ResumeLayout(false);
			this.tpDBConnection.PerformLayout();
			this.pnlDbConnection.ResumeLayout(false);
			this.pnlDbConnection.PerformLayout();
			this.tcWindow.ResumeLayout(false);
			this.tlpTransactions.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tpTransactions;
		private System.Windows.Forms.TabPage tpAccounts;
		private System.Windows.Forms.TabPage tpCustomers;
		private System.Windows.Forms.TabPage tpDBConnection;
		private System.Windows.Forms.TabControl tcWindow;
		private System.Windows.Forms.DataGridView dgvTransactions;
		private System.Windows.Forms.DataGridView dgvCustomers;
		private System.Windows.Forms.Label lblServerName;
		private System.Windows.Forms.Button btnConnectToDB;
		private System.Windows.Forms.TextBox txtbServerName;
		private System.Windows.Forms.TextBox txtbPassword;
		private System.Windows.Forms.Label lblPasword;
		private System.Windows.Forms.TextBox txtbUsername;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblDataBaseName;
		private System.Windows.Forms.ComboBox cbDbNames;
		private System.Windows.Forms.DataGridView dgvAddresses;
		private System.Windows.Forms.Panel pnlDbConnection;
		private System.Windows.Forms.Label lblDbConnectionTitle;
		private System.Windows.Forms.TableLayoutPanel tlpCostumerAddress;
		private System.Windows.Forms.Panel pnlCustomerDetails;
		private System.Windows.Forms.Button btnCreateNewCustomer;
		private System.Windows.Forms.Button btnUpdateCustomer;
		private System.Windows.Forms.Panel pnlAddressTableAdapter;
		private System.Windows.Forms.Button btnCreateNewAddress;
		private System.Windows.Forms.Button btnUpdateAddress;
		private System.Windows.Forms.Button btnDeleteCustomer;
		private System.Windows.Forms.Button btnDeleteAddress;
		private System.Windows.Forms.DataGridView dgvAccounts;
		private System.Windows.Forms.Button btnShowOwnedAccounts;
		private System.Windows.Forms.TableLayoutPanel tlpAccounts;
		private System.Windows.Forms.Panel pnlAccountDetails;
		private System.Windows.Forms.Button btnDeleteSelectedAccount;
		private System.Windows.Forms.Button btnCreateNewAccount;
		private BankingSiteDataSet bankingSiteDataSet;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private BankingSiteDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource addressBindingSource;
		private BankingSiteDataSetTableAdapters.AddressTableAdapter addressTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn streetNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource accountBindingSource;
		private BankingSiteDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn iBANDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource transactionBindingSource;
		private BankingSiteDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn intendedUseDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountReceiverIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountSenderIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox customerIDTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.TextBox emailAddressTextBox;
		private System.Windows.Forms.TextBox address_IDTextBox;
		private System.Windows.Forms.TextBox addressIDTextBox;
		private System.Windows.Forms.TextBox streetNameTextBox;
		private System.Windows.Forms.TextBox streetNumberTextBox;
		private System.Windows.Forms.TextBox zipCodeTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private BankingSiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox accountIDTextBox;
		private System.Windows.Forms.TextBox transactionIDTextBox;
		private System.Windows.Forms.Button btnCreateNewTransaction;
		private System.Windows.Forms.Button btnDeleteTransaction;
		private System.Windows.Forms.TableLayoutPanel tlpTransactions;
		private System.Windows.Forms.Panel panel1;
	}
}