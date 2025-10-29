using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BankingSite
{
	public partial class MainWindow : Form
	{
		List<string> _missingTables;
		bool _isConnectedAndHasTables;

		DataTable _addressTable;
		DataTable _customerTable;
		DataTable _accountTable;
		DataTable _transactionTable;

		DatabaseInteraction _dbInt;

		//ToDo: Test every case and fix it. Goodluck!

		#region Server Connection
		public MainWindow()
		{
			InitializeComponent();

			_dbInt = new DatabaseInteraction();
		}

		private void Window_Load(object sender, EventArgs e)
		{
			txtbServerName.Text = string.Concat(Environment.MachineName, "\\");
		}

		private void tcWindow_Selecting(object sender, TabControlCancelEventArgs e)
		{
			e.Cancel = !_isConnectedAndHasTables;
		}

		/// <summary>
		/// Will try to connect with the server in order to display all available databases in the dropdown
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbDbNames_DropDown(object sender, EventArgs e)
		{
			LoadTables();
		}

		/// <summary>
		/// Will connect to the server and db in order to display all tables (except the system dbs) in the comboBox for selection.
		/// </summary>
		void LoadTables()
		{
			try
			{
				if (!CanConnectToServer())
				{
					MessageBox.Show("Error occurred while connecting to server", "Error");
					return;
				}

				cbDbNames.Items.Clear();
				string[] databaseNames = _dbInt.GetDatabases();
				cbDbNames.Items.AddRange(databaseNames);
			}
			catch { }
		}

		/// <summary>
		/// Will insert new data into the address, customer and account tables
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnInsertData_Click(object sender, EventArgs e)
		{
			InsertDataToTables();
		}

		void InsertDataToTables()
		{
			if (!CanConnectToServer() || String.IsNullOrWhiteSpace(cbDbNames.Text))
			{
				MessageBox.Show("Please make sure to establish an connection to the server and database first.", "Error trying to connect.");
				return;
			}

			if (_missingTables.Count != 0)
			{
				if (DialogResult.Yes == MessageBox.Show("In order to insert data the database needs to contain all required tables: customer, address, account and transaction." +
						"\nDo you want to create these tables?", "Tables missing", MessageBoxButtons.YesNo))
				{
					CreateTables();
					MessageBox.Show("Missing tables have been succssessfully created!", "Required tables created.");
				}
				else
				{
					return;
				}
			}

			try
			{
				_dbInt.InsertToAllTables();

				RefillDGVs();
				btnInsertData.Enabled = false;
				_isConnectedAndHasTables = true;
				MessageBox.Show("Data has been succsessfully been inserted into the Address, Customer and Account tables!", "Data succsessfully inserted");
			}
			catch { }
		}

		private void btnConnectToDB_Click(object sender, EventArgs e)
		{
			try
			{
				if (!CanConnectToServer())
				{
					MessageBox.Show("Error occurred while connecting to server", "Error");
					return;
				}

				if (!DatabaseContainsAllTables())
				{
					ConnectedToDatabase();
					if (DialogResult.Yes ==  MessageBox.Show("The selected database does not contain the required tables customer, address, account and transaction." +
								"\nDo you want to create these tables?", "Tables missing", MessageBoxButtons.YesNo))
					{
						CreateTables();
						MessageBox.Show("Missing tables have been succssessfully created, so all of them are empty.", "Empty tables created.");
					}
					else
					{
						_isConnectedAndHasTables = false;
					}
					return; 
				}
				else 
				{
					RefillDGVs();
					ConnectedToDatabase();
					MessageBox.Show("Succsessfully connected to database!", "Connection to database established.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "An Error ocurred");
			}
		}

		bool CanConnectToServer()
		{
			return _dbInt.CanConnectToServer(String.IsNullOrWhiteSpace(cbDbNames.Text) ? "master" : cbDbNames.Text, txtbServerName.Text, txtbUsername.Text, txtbPassword.Text);
		}

		/// <summary>
		/// Uses the TableAdapters to refill all dataGridViews.
		/// </summary>
		void RefillDGVs()
		{
			_addressTable = _dbInt.GetDataTable("SELECT * FROM [dbo].[Address]");
			_customerTable = _dbInt.GetDataTable("SELECT * FROM [dbo].[Customer]");
			_accountTable = _dbInt.GetDataTable("SELECT * FROM [dbo].[Account]");
			_transactionTable = _dbInt.GetDataTable("SELECT * FROM [dbo].[Transaction]");

			dgvAddresses.DataSource = _addressTable;
			dgvCustomers.DataSource = _customerTable;
			dgvAccounts.DataSource = _accountTable;
			dgvTransactions.DataSource = _transactionTable;

			//customer ui controls
			SetDataBindings(customerIDTextBox, _customerTable, "ID");
			SetDataBindings(firstNameTextBox, _customerTable, "FirstName");
			SetDataBindings(lastNameTextBox, _customerTable, "LastName");
			SetDataBindings(phoneNumberTextBox, _customerTable, "PhoneNumber");
			SetDataBindings(emailAddressTextBox, _customerTable, "EmailAddress");
			SetDataBindings(customerAddressIDTextBox, _customerTable, "Address_ID");

			//address ui controls
			SetDataBindings(addressIDTextBox, _addressTable, "ID");
			SetDataBindings(streetNameTextBox, _addressTable, "StreetName");
			SetDataBindings(streetNumberTextBox, _addressTable, "StreetNumber");
			SetDataBindings(zipCodeTextBox, _addressTable, "ZipCode");
			SetDataBindings(cityTextBox, _addressTable, "City");

			//account and transaction ui control
			SetDataBindings(accountIDTextBox, _accountTable, "ID");
			SetDataBindings(transactionIDTextBox, _transactionTable, "ID");
		}

		/// <summary>
		/// Will re-set the DataBinding for myUiElement.
		/// </summary>
		/// <param name="myUiElement"></param>
		/// <param name="myDataSource"></param>
		/// <param name="myDataMember"></param>
		void SetDataBindings(Control myUiElement, DataTable myDataSource, string myDataMember)
		{
			myUiElement.DataBindings.Clear();
			myUiElement.DataBindings.Add(new Binding("Text", myDataSource, myDataMember));
		}

		/// <summary>
		/// Will check if the selected Database contains all requered tables such as: Address, Customer, Account and Transaction.
		/// Will return false if one of them doesn't exist.
		/// </summary>
		/// <returns></returns>
		bool DatabaseContainsAllTables()
		{
			_missingTables = _dbInt.GetMissingTables();
			return _missingTables.Count == 0;
		}

		/// <summary>
		/// Creates the required tables that are missing.
		/// </summary>
		void CreateTables()
		{
			_dbInt.CreateTables(_missingTables);
			_missingTables.Clear();
			RefillDGVs();
		}

		/// <summary>
		/// Will change the text of the window and allow changing the tab pages and inserting data
		/// </summary>
		void ConnectedToDatabase()
		{
			btnInsertData.Enabled = true;
			_isConnectedAndHasTables = true;
			Text = string.Concat("BankingSite - Connected to ", cbDbNames.Text);
		}

		#endregion 

		#region Customer Tab
		private void btnCreateNewCustomer_Click(object sender, EventArgs e)
		{
			CreateNew cnForm = new CreateNew();
			cnForm.SetUp(customerTableAdapter, CreateNew.CreateType.Customer);

			if (cnForm.ShowDialog() == DialogResult.Cancel)
			{ 
				return;
			}

			customerTableAdapter.Fill(this.bankingSiteDataSet.Customer);
		}

		void btnUpdateCustomer_Click(object sender, EventArgs e)
		{   //Update the dataTable but check if all of them are valid first
			if (!int.TryParse(customerIDTextBox.Text, out int custID) || !int.TryParse(customerAddressIDTextBox.Text, out int addrID) || !int.TryParse(phoneNumberTextBox.Text, out int phoneN))
			{
				MessageBox.Show("Please make sure to only input numbers for the address ID and phonenumber.", "Error using inputs for updating dataset");
				return;
			}
			
			string firstN = firstNameTextBox.Text;
			string lastN = lastNameTextBox.Text;
			string email = emailAddressTextBox.Text;

			if (int.TryParse(firstN, out int a) || int.TryParse(lastN, out int b) || int.TryParse(email, out int c))
			{
				MessageBox.Show("Please make sure to only input strings for the names and email.", "Error using inputs for updating dataset");
				return;
			}

			try
			{
				customerTableAdapter.UpdateCustomer(firstN, lastN, phoneN, email, custID, addrID);
				dgvCustomers.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error oocurred while updating a customer.");
			}
		}

		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(customerIDTextBox.Text))
			{
				return;
			}

			int id = Convert.ToInt32(customerIDTextBox.Text);
			if (MessageBox.Show(string.Concat("Are you sure you want to delete the customer with the ID: ", id, "?" +
				"\nThis will also delete all accounts they own."), "Delete selected customer",
						MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				customerTableAdapter.DeleteCustomerWithID(id);
				this.customerTableAdapter.Fill(this.bankingSiteDataSet.Customer);
				this.accountTableAdapter.Fill(this.bankingSiteDataSet.Account);
			}
		}

		/// <summary>
		/// Creates a Window to display all Accounts the selecetd Customer owns.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnShowOwnedAccounts_Click(object sender, EventArgs e)
		{
			int custID = Convert.ToInt32(customerIDTextBox.Text);
			DataTable accounts = accountTableAdapter.GetOwnedAccountsByCustomerID(Convert.ToInt32(custID));

			if (accounts.Rows.Count == 0)
			{
				MessageBox.Show("The selected customer has no accounts.", "Customer has no accounts.");
				return;
			}

			AssotiatedDataTables owned = new AssotiatedDataTables(accounts);
			owned.Text = string.Concat("Owned Accounts From Customer with ID ", custID);
			owned.Show();
		}
		#endregion

		#region Address Tab
		private void btnCreateNewAddress_Click(object sender, EventArgs e)
		{
			CreateNew cnForm = new CreateNew();
			cnForm.SetUp(addressTableAdapter, CreateNew.CreateType.Address);

			if (cnForm.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}

			addressTableAdapter.Fill(this.bankingSiteDataSet.Address);
		}

		void btnUpdateAddress_Click(object sender, EventArgs e)
		{	//Update the dataTable but check if all of them are valid first
			if (!int.TryParse(streetNumberTextBox.Text, out int streetNumber) || !int.TryParse(zipCodeTextBox.Text, out int zipCode))
			{
				MessageBox.Show("Please make sure to only input numbers for the street number and zip code.", "Error using inputs for updating dataset");
				return;
			}

			string streetName = streetNameTextBox.Text;
			string city = cityTextBox.Text;

			if (int.TryParse(streetName, out int a) || int.TryParse(city, out int b))
			{
				MessageBox.Show("Please make sure to only input strings for the street name and city.", "Error using inputs for updating dataset");
				return;
			}

			try
			{
				addressTableAdapter.UpdateAddress(streetName, streetNumber, zipCode, city, Convert.ToInt32(addressIDTextBox.Text));
				dgvAddresses.Refresh();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error occured while updating an address.");
			}
		}

		private void btnDeleteAddress_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(addressIDTextBox.Text))
			{
				return;
			}

			int id = Convert.ToInt32(addressIDTextBox.Text);
			if (MessageBox.Show(string.Concat("Are you sure you want to delete the address with the ID: ", id, "?" +
				"\nCustomers living at this place will become homeless."), "Delete selected address",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				addressTableAdapter.DeleteAddressWithID(id);
				this.addressTableAdapter.Fill(this.bankingSiteDataSet.Address);
				this.customerTableAdapter.Fill(this.bankingSiteDataSet.Customer);
			}
		}
		#endregion

		#region Account Tab
		private void btnCreateNewAccount_Click(object sender, EventArgs e)
		{
			CreateNew cnForm = new CreateNew();
			cnForm.SetUp(accountTableAdapter, CreateNew.CreateType.Account);

			if (cnForm.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}

			accountTableAdapter.Fill(this.bankingSiteDataSet.Account);
		}

		/// <summary>
		/// Will open a window to show all transactions the account is assotiated with.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnShowTransactions_Click(object sender, EventArgs e)
		{
			int accID = Convert.ToInt32(accountIDTextBox.Text);
			DataTable transactions = transactionTableAdapter.GetAllTransactionsFromAccountID(Convert.ToInt32(accID));

			if (transactions.Rows.Count == 0)
			{
				MessageBox.Show("The selected account is not assostiated with any transactions.", "Account has no transactions.");
				return;
			}

			AssotiatedDataTables owned = new AssotiatedDataTables(transactions);
			owned.Text = string.Concat("Assotiated transactions from Account with ID ", accID);
			owned.Show();
		}

		private void btnDeleteSelectedAccount_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(accountIDTextBox.Text))
			{
				return;
			}

			int id = Convert.ToInt32(accountIDTextBox.Text);
			if (MessageBox.Show(string.Concat("Are you sure you want to delete the account with the ID: ", id, "?" +
				"\n this may also delete transactions assosiated with this account."), "Delete selected account",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				accountTableAdapter.DeleteAccountWithID(id);
				this.accountTableAdapter.Fill(this.bankingSiteDataSet.Account);
				this.transactionTableAdapter.Fill(this.bankingSiteDataSet.Transaction);
			}
		}
		#endregion

		#region Transaction Tab
		private void btnCreateNewTransaction_Click(object sender, EventArgs e)
		{
			CreateNew cnForm = new CreateNew();
			cnForm.SetUp(transactionTableAdapter, CreateNew.CreateType.Transaction);

			cnForm.GetAccountTableAdapter(accountTableAdapter);

			if (cnForm.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}

			transactionTableAdapter.Fill(this.bankingSiteDataSet.Transaction);
			accountTableAdapter.Fill(this.bankingSiteDataSet.Account);
		}
	
		private void btnDeleteTransaction_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(transactionIDTextBox.Text))
			{
				return;
			}

			int id = Convert.ToInt32(transactionIDTextBox.Text);
			if (MessageBox.Show(string.Concat("Are you sure you want to delete the transaction with the ID: ", transactionIDTextBox.Text, "?"), "Delete selected Transaction",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				transactionTableAdapter.DeleteTransactionWithID(id);
				this.transactionTableAdapter.Fill(this.bankingSiteDataSet.Transaction);
			}
		}
		#endregion
	}
}