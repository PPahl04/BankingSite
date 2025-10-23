namespace BankingSite
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label iDLabel;
			System.Windows.Forms.Label firstNameLabel;
			System.Windows.Forms.Label address_IDLabel;
			System.Windows.Forms.Label lastNameLabel;
			System.Windows.Forms.Label emailAddressLabel;
			System.Windows.Forms.Label phoneNumberLabel;
			System.Windows.Forms.Label iDLabel1;
			System.Windows.Forms.Label streetNameLabel;
			System.Windows.Forms.Label streetNumberLabel;
			System.Windows.Forms.Label zipCodeLabel;
			System.Windows.Forms.Label cityLabel;
			System.Windows.Forms.Label iDLabel2;
			System.Windows.Forms.Label iBANLabel;
			System.Windows.Forms.Label balanceLabel;
			System.Windows.Forms.Label numberLabel;
			System.Windows.Forms.Label customer_IDLabel;
			this.tpTransactions = new System.Windows.Forms.TabPage();
			this.dgvTransactions = new System.Windows.Forms.DataGridView();
			this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tpAccounts = new System.Windows.Forms.TabPage();
			this.iDTextBox = new System.Windows.Forms.TextBox();
			this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bankingSiteDataSet = new BankingSite.BankingSiteDataSet();
			this.iBANTextBox = new System.Windows.Forms.TextBox();
			this.balanceTextBox = new System.Windows.Forms.TextBox();
			this.numberTextBox = new System.Windows.Forms.TextBox();
			this.customer_IDTextBox = new System.Windows.Forms.TextBox();
			this.dgvAccounts = new System.Windows.Forms.DataGridView();
			this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tpCustomers = new System.Windows.Forms.TabPage();
			this.tlpCostumerAddress = new System.Windows.Forms.TableLayoutPanel();
			this.dgvCustomers = new System.Windows.Forms.DataGridView();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dgvAddresses = new System.Windows.Forms.DataGridView();
			this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pnlCustomerDetails = new System.Windows.Forms.Panel();
			this.btnDeleteCustomer = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnUpdateCustomer = new System.Windows.Forms.Button();
			this.customerIDTextBox = new System.Windows.Forms.TextBox();
			this.address_IDTextBox = new System.Windows.Forms.TextBox();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.emailAddressTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.pnlAddressTableAdapter = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.btnCreateNewAddress = new System.Windows.Forms.Button();
			this.btnUpdateAddress = new System.Windows.Forms.Button();
			this.addressIDTextBox = new System.Windows.Forms.TextBox();
			this.streetNameTextBox = new System.Windows.Forms.TextBox();
			this.streetNumberTextBox = new System.Windows.Forms.TextBox();
			this.zipCodeTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
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
			this.tpDetails = new System.Windows.Forms.TabPage();
			this.lblSelectedCustomerAccounts = new System.Windows.Forms.Label();
			this.dgvSelectedCostumerAccounts = new System.Windows.Forms.DataGridView();
			this.tpAddTransaction = new System.Windows.Forms.TabPage();
			this.lblIntendedUse = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lblReceiver = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lblSelectedAccount = new System.Windows.Forms.Label();
			this.lblAmount = new System.Windows.Forms.Label();
			this.lblTransactionType = new System.Windows.Forms.Label();
			this.nudAmount = new System.Windows.Forms.NumericUpDown();
			this.cbTransactionType = new System.Windows.Forms.ComboBox();
			this.accountTableAdapter = new BankingSite.BankingSiteDataSetTableAdapters.AccountTableAdapter();
			this.customerTableAdapter = new BankingSite.BankingSiteDataSetTableAdapters.CustomerTableAdapter();
			this.addressTableAdapter = new BankingSite.BankingSiteDataSetTableAdapters.AddressTableAdapter();
			this.transactionTableAdapter = new BankingSite.BankingSiteDataSetTableAdapters.TransactionTableAdapter();
			this.tableAdapterManager = new BankingSite.BankingSiteDataSetTableAdapters.TableAdapterManager();
			this.bankingSiteDataSet1 = new BankingSite.BankingSiteDataSet();
			this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			iDLabel = new System.Windows.Forms.Label();
			firstNameLabel = new System.Windows.Forms.Label();
			address_IDLabel = new System.Windows.Forms.Label();
			lastNameLabel = new System.Windows.Forms.Label();
			emailAddressLabel = new System.Windows.Forms.Label();
			phoneNumberLabel = new System.Windows.Forms.Label();
			iDLabel1 = new System.Windows.Forms.Label();
			streetNameLabel = new System.Windows.Forms.Label();
			streetNumberLabel = new System.Windows.Forms.Label();
			zipCodeLabel = new System.Windows.Forms.Label();
			cityLabel = new System.Windows.Forms.Label();
			iDLabel2 = new System.Windows.Forms.Label();
			iBANLabel = new System.Windows.Forms.Label();
			balanceLabel = new System.Windows.Forms.Label();
			numberLabel = new System.Windows.Forms.Label();
			customer_IDLabel = new System.Windows.Forms.Label();
			this.tpTransactions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
			this.tpAccounts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankingSiteDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
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
			this.tpDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCostumerAccounts)).BeginInit();
			this.tpAddTransaction.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bankingSiteDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// iDLabel
			// 
			iDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			iDLabel.AutoSize = true;
			iDLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			iDLabel.Location = new System.Drawing.Point(18, 13);
			iDLabel.Name = "iDLabel";
			iDLabel.Size = new System.Drawing.Size(24, 23);
			iDLabel.TabIndex = 8;
			iDLabel.Text = "ID:";
			// 
			// firstNameLabel
			// 
			firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			firstNameLabel.AutoSize = true;
			firstNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			firstNameLabel.Location = new System.Drawing.Point(18, 47);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new System.Drawing.Size(81, 23);
			firstNameLabel.TabIndex = 10;
			firstNameLabel.Text = "First Name:";
			// 
			// address_IDLabel
			// 
			address_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			address_IDLabel.AutoSize = true;
			address_IDLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			address_IDLabel.Location = new System.Drawing.Point(18, 183);
			address_IDLabel.Name = "address_IDLabel";
			address_IDLabel.Size = new System.Drawing.Size(79, 23);
			address_IDLabel.TabIndex = 18;
			address_IDLabel.Text = "Address ID:";
			// 
			// lastNameLabel
			// 
			lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			lastNameLabel.AutoSize = true;
			lastNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lastNameLabel.Location = new System.Drawing.Point(18, 81);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new System.Drawing.Size(79, 23);
			lastNameLabel.TabIndex = 12;
			lastNameLabel.Text = "Last Name:";
			// 
			// emailAddressLabel
			// 
			emailAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			emailAddressLabel.AutoSize = true;
			emailAddressLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			emailAddressLabel.Location = new System.Drawing.Point(18, 149);
			emailAddressLabel.Name = "emailAddressLabel";
			emailAddressLabel.Size = new System.Drawing.Size(103, 23);
			emailAddressLabel.TabIndex = 16;
			emailAddressLabel.Text = "Email Address:";
			// 
			// phoneNumberLabel
			// 
			phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			phoneNumberLabel.AutoSize = true;
			phoneNumberLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			phoneNumberLabel.Location = new System.Drawing.Point(18, 115);
			phoneNumberLabel.Name = "phoneNumberLabel";
			phoneNumberLabel.Size = new System.Drawing.Size(103, 23);
			phoneNumberLabel.TabIndex = 14;
			phoneNumberLabel.Text = "Phone Number:";
			// 
			// iDLabel1
			// 
			iDLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			iDLabel1.AutoSize = true;
			iDLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			iDLabel1.Location = new System.Drawing.Point(22, 21);
			iDLabel1.Name = "iDLabel1";
			iDLabel1.Size = new System.Drawing.Size(24, 23);
			iDLabel1.TabIndex = 0;
			iDLabel1.Text = "ID:";
			// 
			// streetNameLabel
			// 
			streetNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			streetNameLabel.AutoSize = true;
			streetNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			streetNameLabel.Location = new System.Drawing.Point(22, 58);
			streetNameLabel.Name = "streetNameLabel";
			streetNameLabel.Size = new System.Drawing.Size(90, 23);
			streetNameLabel.TabIndex = 2;
			streetNameLabel.Text = "Street Name:";
			// 
			// streetNumberLabel
			// 
			streetNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			streetNumberLabel.AutoSize = true;
			streetNumberLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			streetNumberLabel.Location = new System.Drawing.Point(22, 95);
			streetNumberLabel.Name = "streetNumberLabel";
			streetNumberLabel.Size = new System.Drawing.Size(103, 23);
			streetNumberLabel.TabIndex = 4;
			streetNumberLabel.Text = "Street Number:";
			// 
			// zipCodeLabel
			// 
			zipCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			zipCodeLabel.AutoSize = true;
			zipCodeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			zipCodeLabel.Location = new System.Drawing.Point(22, 132);
			zipCodeLabel.Name = "zipCodeLabel";
			zipCodeLabel.Size = new System.Drawing.Size(66, 23);
			zipCodeLabel.TabIndex = 6;
			zipCodeLabel.Text = "Zip Code:";
			// 
			// cityLabel
			// 
			cityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			cityLabel.AutoSize = true;
			cityLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			cityLabel.Location = new System.Drawing.Point(22, 169);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(36, 23);
			cityLabel.TabIndex = 8;
			cityLabel.Text = "City:";
			// 
			// iDLabel2
			// 
			iDLabel2.AutoSize = true;
			iDLabel2.Location = new System.Drawing.Point(32, 27);
			iDLabel2.Name = "iDLabel2";
			iDLabel2.Size = new System.Drawing.Size(21, 13);
			iDLabel2.TabIndex = 1;
			iDLabel2.Text = "ID:";
			// 
			// iBANLabel
			// 
			iBANLabel.AutoSize = true;
			iBANLabel.Location = new System.Drawing.Point(32, 53);
			iBANLabel.Name = "iBANLabel";
			iBANLabel.Size = new System.Drawing.Size(35, 13);
			iBANLabel.TabIndex = 3;
			iBANLabel.Text = "IBAN:";
			// 
			// balanceLabel
			// 
			balanceLabel.AutoSize = true;
			balanceLabel.Location = new System.Drawing.Point(32, 79);
			balanceLabel.Name = "balanceLabel";
			balanceLabel.Size = new System.Drawing.Size(49, 13);
			balanceLabel.TabIndex = 5;
			balanceLabel.Text = "Balance:";
			// 
			// numberLabel
			// 
			numberLabel.AutoSize = true;
			numberLabel.Location = new System.Drawing.Point(32, 105);
			numberLabel.Name = "numberLabel";
			numberLabel.Size = new System.Drawing.Size(47, 13);
			numberLabel.TabIndex = 7;
			numberLabel.Text = "Number:";
			// 
			// customer_IDLabel
			// 
			customer_IDLabel.AutoSize = true;
			customer_IDLabel.Location = new System.Drawing.Point(32, 131);
			customer_IDLabel.Name = "customer_IDLabel";
			customer_IDLabel.Size = new System.Drawing.Size(68, 13);
			customer_IDLabel.TabIndex = 9;
			customer_IDLabel.Text = "Customer ID:";
			// 
			// tpTransactions
			// 
			this.tpTransactions.Controls.Add(this.dgvTransactions);
			this.tpTransactions.Location = new System.Drawing.Point(4, 22);
			this.tpTransactions.Name = "tpTransactions";
			this.tpTransactions.Padding = new System.Windows.Forms.Padding(3);
			this.tpTransactions.Size = new System.Drawing.Size(998, 620);
			this.tpTransactions.TabIndex = 3;
			this.tpTransactions.Text = "Transactions";
			this.tpTransactions.UseVisualStyleBackColor = true;
			// 
			// dgvTransactions
			// 
			this.dgvTransactions.AutoGenerateColumns = false;
			this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransactions.DataSource = this.transactionBindingSource;
			this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTransactions.Location = new System.Drawing.Point(3, 3);
			this.dgvTransactions.Name = "dgvTransactions";
			this.dgvTransactions.ReadOnly = true;
			this.dgvTransactions.Size = new System.Drawing.Size(992, 614);
			this.dgvTransactions.TabIndex = 1;
			// 
			// tpAccounts
			// 
			this.tpAccounts.AutoScroll = true;
			this.tpAccounts.Controls.Add(iDLabel2);
			this.tpAccounts.Controls.Add(this.iDTextBox);
			this.tpAccounts.Controls.Add(iBANLabel);
			this.tpAccounts.Controls.Add(this.iBANTextBox);
			this.tpAccounts.Controls.Add(balanceLabel);
			this.tpAccounts.Controls.Add(this.balanceTextBox);
			this.tpAccounts.Controls.Add(numberLabel);
			this.tpAccounts.Controls.Add(this.numberTextBox);
			this.tpAccounts.Controls.Add(customer_IDLabel);
			this.tpAccounts.Controls.Add(this.customer_IDTextBox);
			this.tpAccounts.Controls.Add(this.dgvAccounts);
			this.tpAccounts.Location = new System.Drawing.Point(4, 22);
			this.tpAccounts.Name = "tpAccounts";
			this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccounts.Size = new System.Drawing.Size(998, 620);
			this.tpAccounts.TabIndex = 2;
			this.tpAccounts.Text = "Accounts";
			this.tpAccounts.UseVisualStyleBackColor = true;
			// 
			// iDTextBox
			// 
			this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource1, "ID", true));
			this.iDTextBox.Location = new System.Drawing.Point(106, 24);
			this.iDTextBox.Name = "iDTextBox";
			this.iDTextBox.Size = new System.Drawing.Size(100, 20);
			this.iDTextBox.TabIndex = 2;
			// 
			// accountBindingSource1
			// 
			this.accountBindingSource1.DataMember = "Account";
			this.accountBindingSource1.DataSource = this.bankingSiteDataSet;
			// 
			// bankingSiteDataSet
			// 
			this.bankingSiteDataSet.DataSetName = "BankingSiteDataSet";
			this.bankingSiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// iBANTextBox
			// 
			this.iBANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource1, "IBAN", true));
			this.iBANTextBox.Location = new System.Drawing.Point(106, 50);
			this.iBANTextBox.Name = "iBANTextBox";
			this.iBANTextBox.Size = new System.Drawing.Size(100, 20);
			this.iBANTextBox.TabIndex = 4;
			// 
			// balanceTextBox
			// 
			this.balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource1, "Balance", true));
			this.balanceTextBox.Location = new System.Drawing.Point(106, 76);
			this.balanceTextBox.Name = "balanceTextBox";
			this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
			this.balanceTextBox.TabIndex = 6;
			// 
			// numberTextBox
			// 
			this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource1, "Number", true));
			this.numberTextBox.Location = new System.Drawing.Point(106, 102);
			this.numberTextBox.Name = "numberTextBox";
			this.numberTextBox.Size = new System.Drawing.Size(100, 20);
			this.numberTextBox.TabIndex = 8;
			// 
			// customer_IDTextBox
			// 
			this.customer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource1, "Customer_ID", true));
			this.customer_IDTextBox.Location = new System.Drawing.Point(106, 128);
			this.customer_IDTextBox.Name = "customer_IDTextBox";
			this.customer_IDTextBox.Size = new System.Drawing.Size(100, 20);
			this.customer_IDTextBox.TabIndex = 10;
			// 
			// dgvAccounts
			// 
			this.dgvAccounts.AllowUserToAddRows = false;
			this.dgvAccounts.AutoGenerateColumns = false;
			this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccounts.DataSource = this.accountBindingSource;
			this.dgvAccounts.Location = new System.Drawing.Point(232, 3);
			this.dgvAccounts.MultiSelect = false;
			this.dgvAccounts.Name = "dgvAccounts";
			this.dgvAccounts.ReadOnly = true;
			this.dgvAccounts.RowHeadersWidth = 10;
			this.dgvAccounts.Size = new System.Drawing.Size(763, 440);
			this.dgvAccounts.TabIndex = 1;
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
			this.dgvCustomers.DataSource = this.customerBindingSource1;
			this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCustomers.Location = new System.Drawing.Point(346, 4);
			this.dgvCustomers.MultiSelect = false;
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.ReadOnly = true;
			this.dgvCustomers.ShowEditingIcon = false;
			this.dgvCustomers.Size = new System.Drawing.Size(642, 296);
			this.dgvCustomers.TabIndex = 0;
			// 
			// dgvAddresses
			// 
			this.dgvAddresses.AllowUserToAddRows = false;
			this.dgvAddresses.AutoGenerateColumns = false;
			this.dgvAddresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddresses.DataSource = this.addressBindingSource;
			this.dgvAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAddresses.Location = new System.Drawing.Point(346, 307);
			this.dgvAddresses.MultiSelect = false;
			this.dgvAddresses.Name = "dgvAddresses";
			this.dgvAddresses.ReadOnly = true;
			this.dgvAddresses.ShowEditingIcon = false;
			this.dgvAddresses.Size = new System.Drawing.Size(642, 303);
			this.dgvAddresses.TabIndex = 1;
			// 
			// pnlCustomerDetails
			// 
			this.pnlCustomerDetails.Controls.Add(this.btnDeleteCustomer);
			this.pnlCustomerDetails.Controls.Add(this.button2);
			this.pnlCustomerDetails.Controls.Add(this.btnUpdateCustomer);
			this.pnlCustomerDetails.Controls.Add(iDLabel);
			this.pnlCustomerDetails.Controls.Add(this.customerIDTextBox);
			this.pnlCustomerDetails.Controls.Add(this.address_IDTextBox);
			this.pnlCustomerDetails.Controls.Add(firstNameLabel);
			this.pnlCustomerDetails.Controls.Add(address_IDLabel);
			this.pnlCustomerDetails.Controls.Add(this.firstNameTextBox);
			this.pnlCustomerDetails.Controls.Add(this.emailAddressTextBox);
			this.pnlCustomerDetails.Controls.Add(lastNameLabel);
			this.pnlCustomerDetails.Controls.Add(emailAddressLabel);
			this.pnlCustomerDetails.Controls.Add(this.lastNameTextBox);
			this.pnlCustomerDetails.Controls.Add(this.phoneNumberTextBox);
			this.pnlCustomerDetails.Controls.Add(phoneNumberLabel);
			this.pnlCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCustomerDetails.Location = new System.Drawing.Point(4, 4);
			this.pnlCustomerDetails.Name = "pnlCustomerDetails";
			this.pnlCustomerDetails.Size = new System.Drawing.Size(335, 296);
			this.pnlCustomerDetails.TabIndex = 21;
			// 
			// btnDeleteCustomer
			// 
			this.btnDeleteCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDeleteCustomer.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnDeleteCustomer.Location = new System.Drawing.Point(87, 254);
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.Size = new System.Drawing.Size(157, 32);
			this.btnDeleteCustomer.TabIndex = 22;
			this.btnDeleteCustomer.Text = "Delete Customer";
			this.btnDeleteCustomer.UseVisualStyleBackColor = true;
			this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.button2.Location = new System.Drawing.Point(166, 216);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(157, 32);
			this.button2.TabIndex = 21;
			this.button2.Text = "Create New Customer";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnUpdateCustomer
			// 
			this.btnUpdateCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnUpdateCustomer.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnUpdateCustomer.Location = new System.Drawing.Point(11, 216);
			this.btnUpdateCustomer.Name = "btnUpdateCustomer";
			this.btnUpdateCustomer.Size = new System.Drawing.Size(140, 32);
			this.btnUpdateCustomer.TabIndex = 20;
			this.btnUpdateCustomer.Text = "Update Customer";
			this.btnUpdateCustomer.UseVisualStyleBackColor = true;
			this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
			// 
			// customerIDTextBox
			// 
			this.customerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ID", true));
			this.customerIDTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerIDTextBox.Location = new System.Drawing.Point(127, 10);
			this.customerIDTextBox.Name = "customerIDTextBox";
			this.customerIDTextBox.ReadOnly = true;
			this.customerIDTextBox.Size = new System.Drawing.Size(185, 30);
			this.customerIDTextBox.TabIndex = 9;
			// 
			// address_IDTextBox
			// 
			this.address_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.address_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address_ID", true));
			this.address_IDTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.address_IDTextBox.Location = new System.Drawing.Point(127, 180);
			this.address_IDTextBox.Name = "address_IDTextBox";
			this.address_IDTextBox.Size = new System.Drawing.Size(185, 30);
			this.address_IDTextBox.TabIndex = 19;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FirstName", true));
			this.firstNameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameTextBox.Location = new System.Drawing.Point(127, 44);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(185, 30);
			this.firstNameTextBox.TabIndex = 11;
			// 
			// emailAddressTextBox
			// 
			this.emailAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "EmailAddress", true));
			this.emailAddressTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailAddressTextBox.Location = new System.Drawing.Point(127, 146);
			this.emailAddressTextBox.Name = "emailAddressTextBox";
			this.emailAddressTextBox.Size = new System.Drawing.Size(185, 30);
			this.emailAddressTextBox.TabIndex = 17;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "LastName", true));
			this.lastNameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameTextBox.Location = new System.Drawing.Point(127, 78);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(185, 30);
			this.lastNameTextBox.TabIndex = 13;
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PhoneNumber", true));
			this.phoneNumberTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phoneNumberTextBox.Location = new System.Drawing.Point(127, 112);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(185, 30);
			this.phoneNumberTextBox.TabIndex = 15;
			// 
			// pnlAddressTableAdapter
			// 
			this.pnlAddressTableAdapter.AutoScroll = true;
			this.pnlAddressTableAdapter.Controls.Add(this.button3);
			this.pnlAddressTableAdapter.Controls.Add(this.btnCreateNewAddress);
			this.pnlAddressTableAdapter.Controls.Add(this.btnUpdateAddress);
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
			this.pnlAddressTableAdapter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAddressTableAdapter.Location = new System.Drawing.Point(4, 307);
			this.pnlAddressTableAdapter.Name = "pnlAddressTableAdapter";
			this.pnlAddressTableAdapter.Size = new System.Drawing.Size(335, 303);
			this.pnlAddressTableAdapter.TabIndex = 22;
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.button3.Location = new System.Drawing.Point(87, 253);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(157, 32);
			this.button3.TabIndex = 23;
			this.button3.Text = "Delete Address";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnCreateNewAddress
			// 
			this.btnCreateNewAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCreateNewAddress.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
			this.btnCreateNewAddress.Location = new System.Drawing.Point(166, 215);
			this.btnCreateNewAddress.Name = "btnCreateNewAddress";
			this.btnCreateNewAddress.Size = new System.Drawing.Size(157, 32);
			this.btnCreateNewAddress.TabIndex = 23;
			this.btnCreateNewAddress.Text = "Create New Address";
			this.btnCreateNewAddress.UseVisualStyleBackColor = true;
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
			// addressIDTextBox
			// 
			this.addressIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.addressIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "ID", true));
			this.addressIDTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.addressIDTextBox.Location = new System.Drawing.Point(128, 17);
			this.addressIDTextBox.Name = "addressIDTextBox";
			this.addressIDTextBox.ReadOnly = true;
			this.addressIDTextBox.Size = new System.Drawing.Size(185, 30);
			this.addressIDTextBox.TabIndex = 1;
			// 
			// streetNameTextBox
			// 
			this.streetNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.streetNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "StreetName", true));
			this.streetNameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.streetNameTextBox.Location = new System.Drawing.Point(128, 54);
			this.streetNameTextBox.Name = "streetNameTextBox";
			this.streetNameTextBox.Size = new System.Drawing.Size(185, 30);
			this.streetNameTextBox.TabIndex = 3;
			// 
			// streetNumberTextBox
			// 
			this.streetNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.streetNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "StreetNumber", true));
			this.streetNumberTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.streetNumberTextBox.Location = new System.Drawing.Point(128, 91);
			this.streetNumberTextBox.Name = "streetNumberTextBox";
			this.streetNumberTextBox.Size = new System.Drawing.Size(185, 30);
			this.streetNumberTextBox.TabIndex = 5;
			// 
			// zipCodeTextBox
			// 
			this.zipCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "ZipCode", true));
			this.zipCodeTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.zipCodeTextBox.Location = new System.Drawing.Point(128, 128);
			this.zipCodeTextBox.Name = "zipCodeTextBox";
			this.zipCodeTextBox.Size = new System.Drawing.Size(185, 30);
			this.zipCodeTextBox.TabIndex = 7;
			// 
			// cityTextBox
			// 
			this.cityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "City", true));
			this.cityTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
			this.cityTextBox.Location = new System.Drawing.Point(128, 165);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(185, 30);
			this.cityTextBox.TabIndex = 9;
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
			this.pnlDbConnection.Location = new System.Drawing.Point(310, 76);
			this.pnlDbConnection.Name = "pnlDbConnection";
			this.pnlDbConnection.Size = new System.Drawing.Size(383, 323);
			this.pnlDbConnection.TabIndex = 24;
			// 
			// lblDbConnectionTitle
			// 
			this.lblDbConnectionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDbConnectionTitle.AutoSize = true;
			this.lblDbConnectionTitle.Font = new System.Drawing.Font("Bahnschrift", 15F);
			this.lblDbConnectionTitle.Location = new System.Drawing.Point(52, 2);
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
			this.btnConnectToDB.Location = new System.Drawing.Point(126, 261);
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
			this.cbDbNames.Size = new System.Drawing.Size(255, 26);
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
			this.txtbPassword.Size = new System.Drawing.Size(255, 26);
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
			this.txtbServerName.Size = new System.Drawing.Size(255, 26);
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
			this.txtbUsername.Size = new System.Drawing.Size(255, 26);
			this.txtbUsername.TabIndex = 18;
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
			this.tcWindow.Size = new System.Drawing.Size(1006, 646);
			this.tcWindow.TabIndex = 0;
			this.tcWindow.TabIndexChanged += new System.EventHandler(this.tcWindow_TabIndexChanged);
			// 
			// tpDetails
			// 
			this.tpDetails.AutoScroll = true;
			this.tpDetails.Controls.Add(this.lblSelectedCustomerAccounts);
			this.tpDetails.Controls.Add(this.dgvSelectedCostumerAccounts);
			this.tpDetails.Location = new System.Drawing.Point(4, 22);
			this.tpDetails.Name = "tpDetails";
			this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tpDetails.Size = new System.Drawing.Size(998, 620);
			this.tpDetails.TabIndex = 4;
			this.tpDetails.Text = "Details";
			this.tpDetails.UseVisualStyleBackColor = true;
			// 
			// lblSelectedCustomerAccounts
			// 
			this.lblSelectedCustomerAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSelectedCustomerAccounts.AutoSize = true;
			this.lblSelectedCustomerAccounts.Font = new System.Drawing.Font("Bahnschrift", 15F);
			this.lblSelectedCustomerAccounts.Location = new System.Drawing.Point(8, 261);
			this.lblSelectedCustomerAccounts.Name = "lblSelectedCustomerAccounts";
			this.lblSelectedCustomerAccounts.Size = new System.Drawing.Size(162, 24);
			this.lblSelectedCustomerAccounts.TabIndex = 7;
			this.lblSelectedCustomerAccounts.Text = "Owned accounts:";
			this.lblSelectedCustomerAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvSelectedCostumerAccounts
			// 
			this.dgvSelectedCostumerAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSelectedCostumerAccounts.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvSelectedCostumerAccounts.Location = new System.Drawing.Point(3, 433);
			this.dgvSelectedCostumerAccounts.Name = "dgvSelectedCostumerAccounts";
			this.dgvSelectedCostumerAccounts.ReadOnly = true;
			this.dgvSelectedCostumerAccounts.Size = new System.Drawing.Size(992, 184);
			this.dgvSelectedCostumerAccounts.TabIndex = 1;
			// 
			// tpAddTransaction
			// 
			this.tpAddTransaction.Controls.Add(this.lblIntendedUse);
			this.tpAddTransaction.Controls.Add(this.textBox1);
			this.tpAddTransaction.Controls.Add(this.comboBox1);
			this.tpAddTransaction.Controls.Add(this.lblReceiver);
			this.tpAddTransaction.Controls.Add(this.button1);
			this.tpAddTransaction.Controls.Add(this.lblSelectedAccount);
			this.tpAddTransaction.Controls.Add(this.lblAmount);
			this.tpAddTransaction.Controls.Add(this.lblTransactionType);
			this.tpAddTransaction.Controls.Add(this.nudAmount);
			this.tpAddTransaction.Controls.Add(this.cbTransactionType);
			this.tpAddTransaction.Location = new System.Drawing.Point(4, 22);
			this.tpAddTransaction.Name = "tpAddTransaction";
			this.tpAddTransaction.Padding = new System.Windows.Forms.Padding(3);
			this.tpAddTransaction.Size = new System.Drawing.Size(998, 620);
			this.tpAddTransaction.TabIndex = 5;
			this.tpAddTransaction.Text = "Add Transaction";
			this.tpAddTransaction.UseVisualStyleBackColor = true;
			// 
			// lblIntendedUse
			// 
			this.lblIntendedUse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblIntendedUse.AutoSize = true;
			this.lblIntendedUse.Font = new System.Drawing.Font("Bahnschrift", 15F);
			this.lblIntendedUse.Location = new System.Drawing.Point(88, 259);
			this.lblIntendedUse.Name = "lblIntendedUse";
			this.lblIntendedUse.Size = new System.Drawing.Size(133, 24);
			this.lblIntendedUse.TabIndex = 16;
			this.lblIntendedUse.Text = "Intended Use:";
			this.lblIntendedUse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 15F);
			this.textBox1.Location = new System.Drawing.Point(260, 259);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 32);
			this.textBox1.TabIndex = 15;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Select Type Here",
            "Withdrawal",
            "Deposit",
            "Transfer",
            "Incoming"});
			this.comboBox1.Location = new System.Drawing.Point(260, 226);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 14;
			// 
			// lblReceiver
			// 
			this.lblReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblReceiver.AutoSize = true;
			this.lblReceiver.Font = new System.Drawing.Font("Bahnschrift", 15F);
			this.lblReceiver.Location = new System.Drawing.Point(88, 222);
			this.lblReceiver.Name = "lblReceiver";
			this.lblReceiver.Size = new System.Drawing.Size(94, 24);
			this.lblReceiver.TabIndex = 13;
			this.lblReceiver.Text = "Receiver:";
			this.lblReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(92, 385);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 44);
			this.button1.TabIndex = 12;
			this.button1.Text = "Start Transaction";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// lblSelectedAccount
			// 
			this.lblSelectedAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSelectedAccount.AutoSize = true;
			this.lblSelectedAccount.Font = new System.Drawing.Font("Bahnschrift", 15F);
			this.lblSelectedAccount.Location = new System.Drawing.Point(88, 131);
			this.lblSelectedAccount.Name = "lblSelectedAccount";
			this.lblSelectedAccount.Size = new System.Drawing.Size(172, 24);
			this.lblSelectedAccount.TabIndex = 11;
			this.lblSelectedAccount.Text = "Selected Account:";
			this.lblSelectedAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAmount
			// 
			this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblAmount.AutoSize = true;
			this.lblAmount.Font = new System.Drawing.Font("Bahnschrift", 15F);
			this.lblAmount.Location = new System.Drawing.Point(88, 188);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(85, 24);
			this.lblAmount.TabIndex = 10;
			this.lblAmount.Text = "Amount:";
			this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTransactionType
			// 
			this.lblTransactionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTransactionType.AutoSize = true;
			this.lblTransactionType.Font = new System.Drawing.Font("Bahnschrift", 15F);
			this.lblTransactionType.Location = new System.Drawing.Point(88, 158);
			this.lblTransactionType.Name = "lblTransactionType";
			this.lblTransactionType.Size = new System.Drawing.Size(166, 24);
			this.lblTransactionType.TabIndex = 9;
			this.lblTransactionType.Text = "Transaction Type:";
			this.lblTransactionType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nudAmount
			// 
			this.nudAmount.Enabled = false;
			this.nudAmount.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudAmount.Location = new System.Drawing.Point(261, 188);
			this.nudAmount.Name = "nudAmount";
			this.nudAmount.Size = new System.Drawing.Size(120, 23);
			this.nudAmount.TabIndex = 2;
			// 
			// cbTransactionType
			// 
			this.cbTransactionType.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTransactionType.FormattingEnabled = true;
			this.cbTransactionType.Items.AddRange(new object[] {
            "Select Type Here",
            "Withdrawal",
            "Deposit",
            "Transfer",
            "Incoming"});
			this.cbTransactionType.Location = new System.Drawing.Point(260, 158);
			this.cbTransactionType.Name = "cbTransactionType";
			this.cbTransactionType.Size = new System.Drawing.Size(121, 24);
			this.cbTransactionType.TabIndex = 0;
			// 
			// accountTableAdapter
			// 
			this.accountTableAdapter.ClearBeforeFill = true;
			// 
			// customerTableAdapter
			// 
			this.customerTableAdapter.ClearBeforeFill = true;
			// 
			// addressTableAdapter
			// 
			this.addressTableAdapter.ClearBeforeFill = true;
			// 
			// transactionTableAdapter
			// 
			this.transactionTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
			this.tableAdapterManager.AddressTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomerTableAdapter = null;
			this.tableAdapterManager.TransactionTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = BankingSite.BankingSiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// bankingSiteDataSet1
			// 
			this.bankingSiteDataSet1.DataSetName = "BankingSiteDataSet";
			this.bankingSiteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// customerBindingSource1
			// 
			this.customerBindingSource1.DataMember = "Customer";
			this.customerBindingSource1.DataSource = this.bankingSiteDataSet1;
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
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1006, 646);
			this.Controls.Add(this.tcWindow);
			this.MinimumSize = new System.Drawing.Size(1022, 685);
			this.Name = "Window";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Banking Site";
			this.Load += new System.EventHandler(this.Window_Load);
			this.tpTransactions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
			this.tpAccounts.ResumeLayout(false);
			this.tpAccounts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankingSiteDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
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
			this.tpDetails.ResumeLayout(false);
			this.tpDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCostumerAccounts)).EndInit();
			this.tpAddTransaction.ResumeLayout(false);
			this.tpAddTransaction.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bankingSiteDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
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
		private System.Windows.Forms.DataGridView dgvTransactions;
		private System.Windows.Forms.DataGridView dgvAccounts;
		private System.Windows.Forms.DataGridView dgvCustomers;
		private System.Windows.Forms.DataGridView dgvSelectedCostumerAccounts;
		private System.Windows.Forms.ComboBox cbTransactionType;
		private System.Windows.Forms.NumericUpDown nudAmount;
		private System.Windows.Forms.Label lblSelectedCustomerAccounts;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblSelectedAccount;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.Label lblTransactionType;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lblReceiver;
		private System.Windows.Forms.Label lblServerName;
		private System.Windows.Forms.Button btnConnectToDB;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txtbServerName;
		private System.Windows.Forms.Label lblIntendedUse;
		private System.Windows.Forms.TextBox txtbPassword;
		private System.Windows.Forms.Label lblPasword;
		private System.Windows.Forms.TextBox txtbUsername;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblDataBaseName;
		private System.Windows.Forms.ComboBox cbDbNames;
		private System.Windows.Forms.DataGridView dgvAddresses;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private System.Windows.Forms.BindingSource addressBindingSource;
		private System.Windows.Forms.BindingSource accountBindingSource;
		private System.Windows.Forms.BindingSource transactionBindingSource;
		private System.Windows.Forms.Panel pnlDbConnection;
		private System.Windows.Forms.Label lblDbConnectionTitle;
		private System.Windows.Forms.TableLayoutPanel tlpCostumerAddress;
		private System.Windows.Forms.Panel pnlCustomerDetails;
		private System.Windows.Forms.TextBox customerIDTextBox;
		private System.Windows.Forms.TextBox address_IDTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox emailAddressTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnUpdateCustomer;
		private System.Windows.Forms.Panel pnlAddressTableAdapter;
		private System.Windows.Forms.TextBox addressIDTextBox;
		private System.Windows.Forms.TextBox streetNameTextBox;
		private System.Windows.Forms.TextBox streetNumberTextBox;
		private System.Windows.Forms.TextBox zipCodeTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Button btnCreateNewAddress;
		private System.Windows.Forms.Button btnUpdateAddress;
		private System.Windows.Forms.Button btnDeleteCustomer;
		private System.Windows.Forms.Button button3;
		private BankingSiteDataSet bankingSiteDataSet;
		private System.Windows.Forms.BindingSource accountBindingSource1;
		private BankingSiteDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
		private BankingSiteDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
		private BankingSiteDataSetTableAdapters.AddressTableAdapter addressTableAdapter;
		private BankingSiteDataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
		private BankingSiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox iDTextBox;
		private System.Windows.Forms.TextBox iBANTextBox;
		private System.Windows.Forms.TextBox balanceTextBox;
		private System.Windows.Forms.TextBox numberTextBox;
		private System.Windows.Forms.TextBox customer_IDTextBox;
		private BankingSiteDataSet bankingSiteDataSet1;
		private System.Windows.Forms.BindingSource customerBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressIDDataGridViewTextBoxColumn;
	}
}

