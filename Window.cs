using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingSite
{
	public partial class Window : Form
	{
		public Window()
		{
			InitializeComponent();
		}

		private void Window_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Customer' table. You can move, or remove it, as needed.
			this.customerTableAdapter.Fill(this.bankingSiteDataSet.Customer);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Transaction' table. You can move, or remove it, as needed.
			this.transactionTableAdapter.Fill(this.bankingSiteDataSet.Transaction);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Account' table. You can move, or remove it, as needed.
			this.accountTableAdapter.Fill(this.bankingSiteDataSet.Account);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Address' table. You can move, or remove it, as needed.
			this.addressTableAdapter.Fill(this.bankingSiteDataSet.Address);
			// TODO: This line of code loads data into the 'bankingSiteDataSet.Customer' table. You can move, or remove it, as needed.
			this.customerTableAdapter.Fill(this.bankingSiteDataSet.Customer);
		}

		string _connectionString;
		SqlConnection _connection;

		string _currentTabPage;
		bool _detailsHaveBeenUpdated;

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

		private void tcWindow_TabIndexChanged(object sender, EventArgs e)
		{
			//TabControl tc = (TabControl)sender;

			//if (tpDetails.Name.Equals(tcWindow.TabPages[tcWindow.SelectedIndex].Name) && !_detailsHaveBeenUpdated)
			//{
			//	tcWindow.SelectedTab = tcWindow.TabPages[_currentTabPage];
			//	return;
			//}

			//_currentTabPage = tcWindow.TabPages[tcWindow.SelectedIndex].Name;
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
			if (MessageBox.Show(string.Concat("Are you sure you want to delete the customer with the ID: ", customerIDTextBox.Text, "?"), "Delete selected customer",
						MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				customerTableAdapter.DeleteCustomerWithID(Convert.ToInt32(customerIDTextBox.Text));
				this.customerTableAdapter.Fill(this.bankingSiteDataSet.Customer);
			}
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

		private void button3_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(string.Concat("Are you sure you want to delete the address with the ID: ", addressIDTextBox.Text, "?"), "Delete selected address",
			MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				addressTableAdapter.DeleteAddressWithID(Convert.ToInt32(addressIDTextBox.Text));
				this.addressTableAdapter.Fill(this.bankingSiteDataSet.Address);
			}
		}
	}
}