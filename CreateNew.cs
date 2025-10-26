using BankingSite.BankingSiteDataSetTableAdapters;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System;

namespace BankingSite
{
	public partial class CreateNew : Form
	{
		TransactionTableAdapter _transactionTableAdapter;
		CustomerTableAdapter _customerTableAdapter;
		AddressTableAdapter _addressTableAdapter;
		AccountTableAdapter _accountTableAdapter;

		bool _hasCanceled = true;
		CreateType _type;

		public CreateNew()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Will determine which tableAdapter and panel (which holds all neccesary UI) to use by its parameters
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="myTableAdapter"></param>
		/// <param name="myCreateType"></param>
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

					DataTable table = new DataTable();
					table.Columns.Add("Type");

					table.Rows.Add(TransactionType.Withdrawal.ToString());
					table.Rows.Add(TransactionType.Deposit.ToString());
					table.Rows.Add(TransactionType.Transfer.ToString());
					table.Rows.Add(TransactionType.Incoming.ToString());

					typeComboBox.DataSource = table;
					typeComboBox.DisplayMember = "Type";

					accountReceiver_IDComboBox.Enabled = false;
				break;
			}
			
			Text = title;
		}

		void UsePanel(Panel myPanel)
		{
			myPanel.Visible = true;
			Size = new Size(myPanel.Size.Width + 17, myPanel.Size.Height + 37);
			myPanel.Location = new Point(0, 0);
		}

		/// <summary>
		/// Gets the Account Table Adapter to get all account ids and use the adapter when creating the transaction.
		/// </summary>
		/// <param name="myATA"></param>
		public void GetAccountTableAdapter(AccountTableAdapter myATA)
		{
			_accountTableAdapter = myATA;
			DataTable myAccountIDs = _accountTableAdapter.GetData();
		
			accountReceiver_IDComboBox.DataSource = new DataView(myAccountIDs.Columns["ID"].Table);
			accountSender_IDComboBox.DataSource = new DataView(myAccountIDs.Columns["ID"].Table);

			accountReceiver_IDComboBox.DisplayMember = "ID";
			accountSender_IDComboBox.DisplayMember = "ID";
		}

		/// <summary>
		/// Will choose the correct Create method (Address, Customer, Account or Transaction) based on the type of data the user wants to create.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void btnCreateNew_Click(object sender, EventArgs e)
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
		{   //Create a new Customer dataTable but check if all of the inputs are valid first
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
		{	//Create new address dataTable but check if all of them are valid first
			if (!int.TryParse(streetNumberTextBox.Text, out int streetNumber) || !int.TryParse(zipCodeTextBox.Text, out int zipCode))
			{
				MessageBox.Show("Please make sure to only input numbers for the street receiverID and zip code.", "Error using inputs for creating new dataset");
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
		{   //Create a new Account dataTable but check if all of the inputs are valid first
			if (!int.TryParse(balanceTextBox.Text, out int balance) || !int.TryParse(numberTextBox.Text, out int number) || !int.TryParse(customer_IDTextBox.Text, out int custID))
			{
				MessageBox.Show("Please make sure to only input numbers for the amount, bumber and customer id.", "Error using inputs for creating new dataset");
				return;
			}

			string iban = iBANTextBox.Text;
			if (int.TryParse(iban, out int a))
			{
				MessageBox.Show("Please make sure to only input strings for the intendedUse.", "Error using inputs for creating new dataset");
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

		/// <summary>
		/// Creates a new Transaction and change the balance of the sender and receiver accounts based on which type of transaction was chosen.
		/// </summary>
		void CreateNewTransaction()
		{	//Create a new transaction but check if all of the inputs are valid first
			if (!int.TryParse(amountTextBox.Text, out int amount) || !int.TryParse(accountReceiver_IDComboBox.Text, out int receiverID) || !int.TryParse(accountSender_IDComboBox.Text, out int senderID))
			{
				MessageBox.Show("Please make sure to only input numbers for the amount, account receiver and sender id.", "Error using inputs for creating new dataset");
				return;
			}

			if (amount < 1)
			{
				MessageBox.Show(string.Concat("You cant start a transaction with the amount of ", amount, ". Please input a greater number than 0"), "Invalid amount");
				return;
			}

			string intendedUse = intendedUseTextBox.Text;
			string type = typeComboBox.Text;

			if (int.TryParse(intendedUse, out int a))
			{
				MessageBox.Show("Please make sure to only input strings for the intended use.", "Error using inputs for creating new dataset");
				return;
			}

			try
			{
				_transactionTableAdapter.InsertNewTransaction(dateDateTimePicker.Value.ToString(), amount, intendedUse, type, receiverID, senderID);
				_hasCanceled = false;
				Close();

				//get balance from sender and update it based on the transaction balance
				if (type == TransactionType.Withdrawal.ToString())
				{
					WithdrawFromAccount(senderID, amount);
					return;
				}

				//get balance from sender and update it based on the transaction balance
				if (type == TransactionType.Deposit.ToString())
				{
					DepositToAccount(senderID, amount);
					return;
				}

				//get balance from both ids and update it based on the transaction balance
				if (type == TransactionType.Transfer.ToString())
				{
					TransferFromSenderToReceiver(senderID, receiverID, amount);
					return;
				}               
				
				//What is this
				if (type == TransactionType.Incoming.ToString())
				{
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error oocurred while creating a new transaction.");
			}
		}

		/// <summary>
		///Will remove myAmount from balance of Account with ID myAccountID.
		/// </summary>
		/// <param name="myAccountID"></param>
		/// <param name="myAmount"></param>
		void WithdrawFromAccount(int myAccountID, int myAmount)
		{
			int currentBalance = (int)_accountTableAdapter.GetBalanceFromAccountWithID(myAccountID);
			int newBalance = currentBalance - myAmount;
			_accountTableAdapter.UpdateBalanceFromAccountWithID(newBalance, myAccountID);
		}

		/// <summary>
		///Will add myAmount to balance of Account with ID myAccountID.
		/// </summary>
		/// <param name="myAccountID"></param>
		/// <param name="myAmount"></param>
		void DepositToAccount(int myAccountID, int myAmount)
		{
			int currentBalance = (int)_accountTableAdapter.GetBalanceFromAccountWithID(myAccountID);
			int newBalance = currentBalance + myAmount;
			_accountTableAdapter.UpdateBalanceFromAccountWithID(newBalance, myAccountID);
		}

		/// <summary>
		///Will remove myAmount from balance of the sender and add it into the balance of the receiver Account.
		/// </summary>
		/// <param name="mySenderID"></param>
		/// <param name="myReceiverID"></param>
		/// <param name="myAmount"></param>
		void TransferFromSenderToReceiver(int mySenderID, int myReceiverID, int myAmount)
		{
			WithdrawFromAccount(mySenderID, myAmount);
			DepositToAccount(myReceiverID, myAmount);
		}

		void CreateNew_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult = _hasCanceled ? DialogResult.Cancel : DialogResult.OK;
		}

		/// <summary>
		/// Contains all different types of DataTables the User can create.
		/// Customer, Address, Account and Transaction.
		/// </summary>
		public enum CreateType
		{
			Customer,
			Address,
			Account,
			Transaction,
		}

		public enum TransactionType
		{
			Withdrawal,
			Deposit,
			Transfer,
			Incoming
		}

		/// <summary>
		/// Disable the selection of receiver id if withdrawal or deposit have been selected.
		/// The receiver will be the same as the sender on these types.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			accountReceiver_IDComboBox.Enabled = typeComboBox.Text != TransactionType.Withdrawal.ToString() && typeComboBox.Text != TransactionType.Deposit.ToString();

			if (!accountReceiver_IDComboBox.Enabled)
			{
				accountSender_IDComboBox_SelectedIndexChanged(sender, e);
			}
		}

		/// <summary>
		/// Will make the selected Index of both comboBoxes equal if the one for the receiver is disabled.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void accountSender_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!accountReceiver_IDComboBox.Enabled)
			{
				accountReceiver_IDComboBox.SelectedIndex = accountSender_IDComboBox.SelectedIndex;
			}
		}
	}
}