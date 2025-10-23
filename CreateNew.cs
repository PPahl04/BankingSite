using BankingSite.BankingSiteDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace BankingSite
{
	public partial class CreateNew : Form
	{
		CustomerTableAdapter _customerTableAdapter;
		AddressTableAdapter _addressTableAdapter;
		AccountTableAdapter _accountTableAdapter;
		TransactionTableAdapter _transactionTableAdapter;

		bool _hasCanceled = true;
		CreateType _type;

		public CreateNew()
		{
			InitializeComponent();
		}

		public void SetUp<T> (T myTableAdapter, CreateType myCreateType) 
		{
			_type = myCreateType;
			string title = "Create New ";

			switch (_type)
			{
				case CreateType.Customer:
					_customerTableAdapter = myTableAdapter as CustomerTableAdapter;
					UsePanel(pnlCustomer);
					title += "Customer";
				break;
				case CreateType.Address:
					_addressTableAdapter = myTableAdapter as AddressTableAdapter;
					UsePanel(pnlAddress);
					title += "Address";
				break;
				case CreateType.Account:
					_accountTableAdapter = myTableAdapter as AccountTableAdapter;
					UsePanel(pnlAccount);
					title += "Account";
				break;
				case CreateType.Transaction:
					_transactionTableAdapter = myTableAdapter as TransactionTableAdapter;
					UsePanel(pnlTransaction);
					title += "Transaction";
				break;
			}
			Text = title;
		}

		void UsePanel(Panel myPanel)
		{
			myPanel.Visible = true;
			myPanel.Dock = DockStyle.Fill;
		}

		private void btnCreateNew_Click(object sender, EventArgs e)
		{
			switch (_type)
			{
				case CreateType.Customer:
					CreateNewCustomer();
				break;
				
				case CreateType.Address:
					CreateNewAddress();
					break;
			
				case CreateType.Account:
					CreateNewAccount();
				break;
			
				case CreateType.Transaction:
					CreateNewTransaction();
				break;
			}
			
		}

		void CreateNewCustomer()
		{   //Create a new Customer dataset but check if all of the inputs are valid first
			if (!int.TryParse(address_IDTextBox.Text, out int addrID) || !int.TryParse(phoneNumberTextBox.Text, out int phoneN))
			{
				MessageBox.Show("Please make sure to only input numbers for the address ID and phonenumber.", "Error using inputs for creating new dataset");
				return;
			}

			string firstN = firstNameTextBox.Text;
			string lastN = lastNameTextBox.Text;
			string email = emailAddressTextBox.Text;

			if (int.TryParse(firstN, out int a) || int.TryParse(lastN, out int b) || int.TryParse(email, out int c))
			{
				MessageBox.Show("Please make sure to only input strings for the names and email.", "Error using inputs for creating new dataset");
				return;
			}

			try
			{
				_customerTableAdapter.InsertNewCustomer(firstN, lastN, phoneN, email, addrID);
				_hasCanceled = false;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error oocurred while creating a new customer.");
			}
		}

		void CreateNewAddress()
		{	//Create new address the dataset but check if all of them are valid first
			if (!int.TryParse(streetNumberTextBox.Text, out int streetNumber) || !int.TryParse(zipCodeTextBox.Text, out int zipCode))
			{
				MessageBox.Show("Please make sure to only input numbers for the street number and zip code.", "Error using inputs for creating new dataset");
				return;
			}

			string streetName = streetNameTextBox.Text;
			string city = cityTextBox.Text;

			if (int.TryParse(streetName, out int a) || int.TryParse(city, out int b))
			{
				MessageBox.Show("Please make sure to only input strings for the street name and city.", "Error using inputs for creating new dataset");
				return;
			}

			try
			{
				_addressTableAdapter.Insert(streetName, streetNumber, zipCode, city);
				_hasCanceled = false;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error occured while creating a new address.");
			}
		}

		void CreateNewAccount()
		{   //Create a new Customer dataset but check if all of the inputs are valid first
			if (!int.TryParse(balanceTextBox.Text, out int balance) || !int.TryParse(numberTextBox.Text, out int number) || !int.TryParse(customer_IDTextBox.Text, out int custID))
			{
				MessageBox.Show("Please make sure to only input numbers for the balance, bumber and customer id.", "Error using inputs for creating new dataset");
				return;
			}

			string iban = iBANTextBox.Text;
			if (int.TryParse(iban, out int a))
			{
				MessageBox.Show("Please make sure to only input strings for the iban.", "Error using inputs for creating new dataset");
				return;
			}

			try
			{
				_accountTableAdapter.InsertNewAccount(iban, balance, number, custID);
				_hasCanceled = false;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error oocurred while creating a new customer.");
			}
		}

		void CreateNewTransaction()
		{	//Create a new Customer dataset but check if all of the inputs are valid first
			if (!int.TryParse(balanceTextBox.Text, out int balance) || !int.TryParse(numberTextBox.Text, out int number) || !int.TryParse(customer_IDTextBox.Text, out int custID))
			{
				MessageBox.Show("Please make sure to only input numbers for the balance, bumber and customer id.", "Error using inputs for creating new dataset");
				return;
			}

			string iban = iBANTextBox.Text;
			if (int.TryParse(iban, out int a))
			{
				MessageBox.Show("Please make sure to only input strings for the iban.", "Error using inputs for creating new dataset");
				return;
			}

			try
			{
				_accountTableAdapter.InsertNewAccount(iban, balance, number, custID);
				_hasCanceled = false;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error oocurred while creating a new customer.");
			}
		}

		void CreateNew_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult = _hasCanceled ? DialogResult.Cancel : DialogResult.OK;
		}

		public enum CreateType
		{
			Customer,
			Address,
			Account,
			Transaction,
		}

		enum TransactionType
		{

		}
	}
}
