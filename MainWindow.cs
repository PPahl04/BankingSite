using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BankingSite;

namespace BankingSite
{
	public partial class MainWindow : Form
	{
		string _connectionString;
		SqlConnection _connection;

		string _currentTabPage;
		bool _detailsHaveBeenUpdated;

		#region Server Connection
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Transaction' table. You can move, or remove it, as needed.
			this.transactionTableAdapter.Fill(this.bankingSiteDataSet.Transaction);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Account' table. You can move, or remove it, as needed.
			this.accountTableAdapter.Fill(this.bankingSiteDataSet.Account);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Address' table. You can move, or remove it, as needed.
			this.addressTableAdapter.Fill(this.bankingSiteDataSet.Address);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Customer' table. You can move, or remove it, as needed.
			this.customerTableAdapter.Fill(this.bankingSiteDataSet.Customer);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Customer' table. You can move, or remove it, as needed.
			customerTableAdapter.Fill(this.bankingSiteDataSet.Customer);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Transaction' table. You can move, or remove it, as needed.
			transactionTableAdapter.Fill(this.bankingSiteDataSet.Transaction);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Account' table. You can move, or remove it, as needed.
			accountTableAdapter.Fill(this.bankingSiteDataSet.Account);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Address' table. You can move, or remove it, as needed.
			addressTableAdapter.Fill(this.bankingSiteDataSet.Address);
		}


		void EstablisheDatabaseConnection()
		{	//string defaultCn = "Data Source=localhost;Initial Catalog=BankingSite;Integrated Security=True;TrustServerCertificate=True";
			string startDbName = string.IsNullOrWhiteSpace(cbDbNames.Text) ? "master" : cbDbNames.Text;
			_connectionString = string.Concat("Data Source=", txtbServerName.Text, ";Initial Catalog=", startDbName, ";UID=", txtbUsername.Text, ";Password=", txtbPassword.Text,
						";Integrated Security=False;TrustServerCertificate=True");

			 _connection = new SqlConnection(_connectionString);
		}


		private void txtbPassword_Leave(object sender, EventArgs e)
		{	//try to connect in order to show all dbs in the dropdown
			try
			{
				EstablisheDatabaseConnection();
				_connection.Open();

				SqlCommand cmd = _connection.CreateCommand();
				cmd.CommandText = "SELECT name FROM sys.databases";
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						string databaseName = reader.GetString(0);
						cbDbNames.Items.Add(databaseName);
					}	
				}
				_connection.Close();
			}
			catch { }
		}

		private void btnConnectToDB_Click(object sender, EventArgs e)
		{	//connect to the desired db
			try
			{
				EstablisheDatabaseConnection();
				_connection.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "An Error ocurred");
			}
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
				//transactionTableAdapter.DeleteTransactionWithID(id);
				//this.transactionTableAdapter.Fill(this.bankingSiteDataSet.Transaction);
			}
		}
		#endregion
	}
}