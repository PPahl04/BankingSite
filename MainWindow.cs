using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BankingSite
{
	public partial class MainWindow : Form
	{
		string _connectionString;
		List<string> _missingTables;
		bool _isConnectedAndHasTables;

		//ToDo: Test every case and fix it. Goodluck!

		#region Server Connection
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Load(object sender, EventArgs e)
		{
			txtbServerName.Text = string.Concat(Environment.MachineName, "\\");
		}

		private void tcWindow_Selecting(object sender, TabControlCancelEventArgs e)
		{
			e.Cancel = !_isConnectedAndHasTables;
		}

		bool CanConnectToServer()
		{	
			string startDbName = string.IsNullOrWhiteSpace(cbDbNames.Text) ? "master" : cbDbNames.Text;
			string cnString = string.Concat("Data Source=", txtbServerName.Text, ";Initial Catalog=", startDbName, ";UID=", txtbUsername.Text, ";Password=", txtbPassword.Text,
						";Integrated Security=False;TrustServerCertificate=True");
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cnString);
			builder.ConnectTimeout = 5;

			using(SqlConnection cn = new SqlConnection(builder.ConnectionString))
			{
				try
				{
					cn.Open();
					_connectionString = cnString;
					return true;
				}
				catch 
				{
					return false;
				}
			}
		}

		/// <summary>
		/// Will try to connect with the server in order to display all available databases in the dropdown
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtbPassword_Leave(object sender, EventArgs e)
		{
			LoadTables();
		}

		private void btnGetTables_Click(object sender, EventArgs e)
		{
			LoadTables();
		}

		void LoadTables()
		{
			//try to connect in order to show all dbs in the dropdown
			try
			{
				if (!CanConnectToServer())
				{
					MessageBox.Show("Error occurred while connecting to server", "Error");
					return;
				}

				using (SqlConnection cn = new SqlConnection(_connectionString))
				{
					cn.Open();

					SqlCommand cmd = cn.CreateCommand();
					cmd.CommandText = "SELECT name FROM sys.databases";
					cmd.CommandTimeout = 5;

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						string[] systemDatabases = { "master", "tempdb", "model", "msdb" };
						cbDbNames.Items.Clear();

						while (reader.Read())
						{
							string databaseName = reader.GetString(0);

							if (!systemDatabases.Contains(databaseName))
							{
								cbDbNames.Items.Add(databaseName);
							}
						}
					}
				}
			}
			catch { }
		}

		private void btnConnectToDB_Click(object sender, EventArgs e)
		{   //connect to the desired db
			try
			{
				if (!CanConnectToServer())
				{
					MessageBox.Show("Error occurred while connecting to server", "Error");
					return;
				}

				accountTableAdapter.Connection.ConnectionString = _connectionString;
				customerTableAdapter.Connection.ConnectionString = _connectionString;
				transactionTableAdapter.Connection.ConnectionString = _connectionString;
				addressTableAdapter.Connection.ConnectionString = _connectionString;

				tableAdapterManager.Connection.ConnectionString = _connectionString;

				if (!DatabaseContainsAllTables())
				{
					if (DialogResult.Yes ==  MessageBox.Show("The selected database does not contain the required tables customer, address, account and transaction." +
								"\nDo you want to create these tables?", "Tables missing", MessageBoxButtons.YesNo))
					{
						CreateTables();
						ConnectedToDatabase();
						MessageBox.Show("Missing tables have been succssessfully created, so all of them are empty.", "Empty tables created.");
					}
					else
					{ 
						return; 
					}
				}
				else 
				{
					ConnectedToDatabase();
					MessageBox.Show("Succsessfully connected to database!", "Connection to database established.");
				}

				this.customerTableAdapter.Fill(this.bankingSiteDataSet.Customer);
				this.transactionTableAdapter.Fill(this.bankingSiteDataSet.Transaction);
				this.accountTableAdapter.Fill(this.bankingSiteDataSet.Account);
				this.addressTableAdapter.Fill(this.bankingSiteDataSet.Address);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "An Error ocurred");
			}
		}

		bool DatabaseContainsAllTables()
		{
			using (SqlConnection cn = new SqlConnection(_connectionString))
			{
				cn.Open();

				SqlCommand cmd = cn.CreateCommand();
				cmd.CommandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
				cmd.CommandTimeout = 5;

				List<string> tableNames = new List<string>{ "Address", "Customer", "Account", "Transaction" };

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						string currentTableName = reader.GetString(0);
						if (tableNames.Contains(currentTableName))
						{
							tableNames.Remove(currentTableName);
						}
					}
					_missingTables = new List<string>(tableNames);
				}
			}
			return _missingTables.Count == 0;
		}

		void CreateTables()
		{
			foreach (string missingTable in _missingTables)
			{
				using(SqlConnection cn =  new SqlConnection(_connectionString))
				{
					cn.Open();
					SqlCommand cmd = cn.CreateCommand();
					cmd.CommandTimeout = 5;
					
					string folderPath = @"..\..\CreateTableQuery\";

					if (missingTable.Equals("Address"))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(folderPath, "Address.sql"));
						cmd.ExecuteNonQuery();
						continue;
					}

					if (missingTable.Equals("Customer"))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(folderPath, "Customer.sql"));
						cmd.ExecuteNonQuery();
						continue;
					}

					if (missingTable.Equals("Account"))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(folderPath, "Account.sql"));
						cmd.ExecuteNonQuery();
						continue;
					}

					if (missingTable.Equals("Transaction"))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(folderPath, "Transaction.sql"));
						cmd.ExecuteNonQuery();
						continue;
					}
				}
			}
		}

		/// <summary>
		/// Will change the text of the window and allow changing the tab pages
		/// </summary>
		void ConnectedToDatabase()
		{
			_isConnectedAndHasTables = true;
			Text = string.Concat("BankingSite - Connected to ", cbDbNames.Text);
		}
		#endregion 

		#region Customer
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
		{   //Update the dataset but check if all of them are valid first
			if (!int.TryParse(customerIDTextBox.Text, out int custID) || !int.TryParse(address_IDTextBox.Text, out int addrID) || !int.TryParse(phoneNumberTextBox.Text, out int phoneN))
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
			if (MessageBox.Show(string.Concat("Are you sure you want to delete the customer with the ID: ", id, "?"), "Delete selected customer",
						MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				customerTableAdapter.DeleteCustomerWithID(id);
				this.customerTableAdapter.Fill(this.bankingSiteDataSet.Customer);
			}
		}

		private void btnShowOwnedAccounts_Click(object sender, EventArgs e)
		{
			int custID = Convert.ToInt32(customerIDTextBox.Text);
			DataTable accounts = accountTableAdapter.GetOwnedAccountsByCustomerID(Convert.ToInt32(custID));

			if (accounts.Rows.Count == 0)
			{
				MessageBox.Show("The selected customer has no accounts.", "Customer has no accounts.");
				return;
			}

			OwnedAccounts owned = new OwnedAccounts(accounts);
			owned.Text = string.Concat("Owned Accounts From Customer with ID ", custID);
			owned.Show();
		}
		#endregion

		#region Address
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
		{	//Update the dataset but check if all of them are valid first
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
			if (MessageBox.Show(string.Concat("Are you sure you want to delete the address with the ID: ", id, "?"), "Delete selected address",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				addressTableAdapter.DeleteAddressWithID(id);
				this.addressTableAdapter.Fill(this.bankingSiteDataSet.Address);
			}
		}
		#endregion

		#region Account
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
		
		private void btnDeleteSelectedAccount_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(accountIDTextBox.Text))
			{
				return;
			}

			int id = Convert.ToInt32(accountIDTextBox.Text);
			if (MessageBox.Show(string.Concat("Are you sure you want to delete the account with the ID: ", id, "?"), "Delete selected account",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				accountTableAdapter.DeleteAccountWithID(id);
				this.accountTableAdapter.Fill(this.bankingSiteDataSet.Account);
			}
		}
		#endregion

		#region Transaction
		private void btnCreateNewTransaction_Click(object sender, EventArgs e)
		{
			CreateNew cnForm = new CreateNew();
			cnForm.SetUp(transactionTableAdapter, CreateNew.CreateType.Transaction);

			DataTable temp = accountTableAdapter.GetData();
			cnForm.GetAccountIDs(temp.Columns["ID"].Table);

			if (cnForm.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}

			transactionTableAdapter.Fill(this.bankingSiteDataSet.Transaction);
		}
	
		private void btnDeleteTransaction_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(transactionIDTextBox.Text))
			{
				return;
			}

			int id = Convert.ToInt32(transactionIDTextBox.Text);
			if (MessageBox.Show(string.Concat("Are you sure you want to delete the account with the ID: ", transactionIDTextBox.Text, "?"), "Delete selected account",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				transactionTableAdapter.DeleteTransactionWithID(id);
				this.transactionTableAdapter.Fill(this.bankingSiteDataSet.Transaction);
			}
		}
		#endregion
	}
}