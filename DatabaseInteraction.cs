using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace BankingSite
{
	class DatabaseInteraction
	{
		string _connectionString;

		const string SQL_FOLDER = @"..\..\SQL\";
		const string INSERT_DATA_FOLDER = SQL_FOLDER + @"InsertData\";
		const string CREATE_TABLE_FOLDER = SQL_FOLDER + @"CreateTable\";
		const string GET_DATA_FOLDER = SQL_FOLDER + @"GetData\";
		const string UPDATE_TABLE_FOLDER = SQL_FOLDER + @"UpdateTable\";
		const string DELETE_FOLDER = SQL_FOLDER + @"DeleteData\";

		const string ADDRESS = "Address";
		const string CUSTOMER = "Customer";
		const string ACCOUNT = "Account";
		const string TRANSACTION = "Transaction";

		const string SQL_EXTENSION = ".sql";

		/// <summary>
		/// If a connection can be made then the connection string will be changed to that.
		/// </summary>
		/// <param name="myDb"></param>
		/// <param name="myServerName"></param>
		/// <param name="myUsername"></param>
		/// <param name="myPassword"></param>
		/// <returns></returns>
		public bool CanConnectToServer(string myDb, string myServerName, string myUsername, string myPassword)
		{
			string cnString = string.Concat("Data Source=", myServerName, ";Initial Catalog=", myDb, ";UID=", myUsername, ";Password=", myPassword,
						";Integrated Security=False;TrustServerCertificate=True");
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cnString);
			builder.ConnectTimeout = 5;

			using (SqlConnection cn = new SqlConnection(builder.ConnectionString))
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
		/// Will execute any INSERT and DELETE clauses.
		/// </summary>
		/// <param name="myCommandText"></param>
		public void ExecuteSQL(string myCommandText)
		{
			using (SqlConnection cn = new SqlConnection(_connectionString))
			{
				cn.Open();
				SqlCommand cmd = cn.CreateCommand();
				cmd.CommandTimeout = 5;

				cmd.CommandText = myCommandText;
				cmd.ExecuteNonQuery();
			}
		}

		public DataTable GetDataTable(string myCommandText)
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection cn = new SqlConnection(_connectionString))
				{
					cn.Open();
					SqlCommand cmd = cn.CreateCommand();

					cmd.CommandTimeout = 5;
					cmd.CommandText = myCommandText;

					SqlDataReader reader = cmd.ExecuteReader();
					dt.Load(reader);
				}
			}
			catch { }
			return dt;
		}

		/// <summary>
		/// Gets all Database Names within the currently connected server.
		/// </summary>
		/// <returns></returns>
		public string[] GetDatabases()
		{
			using (SqlConnection cn = new SqlConnection(_connectionString))
			{
				cn.Open();

				SqlCommand cmd = cn.CreateCommand();
				cmd.CommandText = "SELECT name FROM sys.databases";
				cmd.CommandTimeout = 5;

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					string[] systemDatabases = { "master", "tempdb", "model", "msdb" };
					List<string> returnedDatabases = new List<string>();

					while (reader.Read())
					{
						string databaseName = reader.GetString(0);

						if (!systemDatabases.Contains(databaseName))
						{
							returnedDatabases.Add(databaseName);
						}
					}
					return returnedDatabases.ToArray();
				}
			}
		}

		public List<string> GetMissingTables()
		{
			using (SqlConnection cn = new SqlConnection(_connectionString))
			{
				cn.Open();

				SqlCommand cmd = cn.CreateCommand();
				cmd.CommandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
				cmd.CommandTimeout = 5;

				List<string> tableNames = new List<string> { ADDRESS, CUSTOMER, ACCOUNT, TRANSACTION };

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
					return new List<string>(tableNames);
				}
			}
		}

		/// <summary>
		/// Creates the required tables that are missing.
		/// </summary>
		public void CreateTables(List<string> myMissingTables)
		{
			foreach (string missingTable in myMissingTables)
			{
				using (SqlConnection cn = new SqlConnection(_connectionString))
				{
					cn.Open();
					SqlCommand cmd = cn.CreateCommand();
					cmd.CommandTimeout = 5;

					if (missingTable.Equals(ADDRESS))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(CREATE_TABLE_FOLDER, ADDRESS, SQL_EXTENSION));
						cmd.ExecuteNonQuery();
						continue;
					}

					if (missingTable.Equals(CUSTOMER))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(CREATE_TABLE_FOLDER, CUSTOMER, SQL_EXTENSION));
						cmd.ExecuteNonQuery();
						continue;
					}

					if (missingTable.Equals(ACCOUNT))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(CREATE_TABLE_FOLDER, ACCOUNT, SQL_EXTENSION));
						cmd.ExecuteNonQuery();
						continue;
					}

					if (missingTable.Equals(TRANSACTION))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(CREATE_TABLE_FOLDER, TRANSACTION, SQL_EXTENSION));
						cmd.ExecuteNonQuery();
						continue;
					}
				}
			}
		}

		public void InsertToAllTables()
		{
			using (SqlConnection cn = new SqlConnection(_connectionString))
			{
				cn.Open();
				SqlCommand cmd = cn.CreateCommand();
				cmd.CommandTimeout = 5;

				cmd.CommandText = File.ReadAllText(string.Concat(INSERT_DATA_FOLDER, ADDRESS, SQL_EXTENSION));
				cmd.ExecuteNonQuery();

				cmd.CommandText = File.ReadAllText(string.Concat(INSERT_DATA_FOLDER, CUSTOMER, SQL_EXTENSION));
				cmd.ExecuteNonQuery();

				cmd.CommandText = File.ReadAllText(string.Concat(INSERT_DATA_FOLDER, ACCOUNT, SQL_EXTENSION));
				cmd.ExecuteNonQuery();

				cmd.CommandText = File.ReadAllText(string.Concat(INSERT_DATA_FOLDER, TRANSACTION, SQL_EXTENSION));
				cmd.ExecuteNonQuery();
			}
		}

		public void UpdateCustomer(string myFirstName, string myLastName, int myPhoneNumber, string myEmail, int myAddressID, int myCustomerID)
		{
			using (SqlConnection cn = new SqlConnection(_connectionString))
			{
				cn.Open();
				SqlCommand cmd = cn.CreateCommand();
				cmd.CommandText = File.ReadAllText(string.Concat(UPDATE_TABLE_FOLDER, CUSTOMER, SQL_EXTENSION));
				cmd.CommandTimeout = 5; 
				
				cmd.Parameters.AddWithValue("@FirstName", myFirstName);
				cmd.Parameters.AddWithValue("@LastName", myLastName);
				cmd.Parameters.AddWithValue("@PhoneNumber", myPhoneNumber);
				cmd.Parameters.AddWithValue("@EmailAddress", myEmail);
				cmd.Parameters.AddWithValue("@AddressID", myAddressID);
				cmd.Parameters.AddWithValue("@ID", myCustomerID);
				cmd.ExecuteNonQuery();
			}
		}

		public void UpdateAddress(string myStreetName, int myStreetNumber, int myZipCode, string myCity, int myID)
		{
			using (SqlConnection cn = new SqlConnection(_connectionString))
			{
				cn.Open();
				SqlCommand cmd = cn.CreateCommand();
				cmd.CommandText = File.ReadAllText(string.Concat(UPDATE_TABLE_FOLDER, ADDRESS, SQL_EXTENSION));
				cmd.CommandTimeout = 5;

				cmd.Parameters.AddWithValue("@StreetName", myStreetName);
				cmd.Parameters.AddWithValue("@StreetNumber", myStreetNumber);
				cmd.Parameters.AddWithValue("@ZipCode", myZipCode);
				cmd.Parameters.AddWithValue("@City", myCity);
				cmd.Parameters.AddWithValue("@ID", myID);
				cmd.ExecuteNonQuery();
			}
		}

		void DeleteData(string myType, int myID)
		{
			using (SqlConnection cn = new SqlConnection(_connectionString))
			{
				cn.Open();
				SqlCommand cmd = cn.CreateCommand();
				cmd.CommandText = File.ReadAllText(string.Concat(DELETE_FOLDER, myType, SQL_EXTENSION));
				cmd.CommandTimeout = 5;

				cmd.Parameters.AddWithValue("@ID", myID);
				cmd.ExecuteNonQuery();
			}
		}

		public void DeleteCustomerWithID(int myCustomerID)
		{
			DeleteData(CUSTOMER, myCustomerID);
		}

		public void DeleteAccountWithID(int myAccountID)
		{
			DeleteData(ACCOUNT, myAccountID);
		}

		public void DeleteTransactionWithID(int myTransactionID)
		{
			DeleteData(TRANSACTION, myTransactionID);
		}

		public void DeleteAddressWithID(int myAddressID)
		{
			DeleteData(ADDRESS, myAddressID);
		}

		public DataTable GetOwnedAccountsByCustomerID(int myCustomerID)
		{
			return GetDataTable(string.Concat("SELECT * FROM Account WHERE Customer_ID = ", myCustomerID));
		}

		public DataTable GetAllTransactionsFromAccountID(int myAccountID)
		{
			return GetDataTable(string.Concat("SELECT * FROM [dbo].[Transaction] WHERE AccountSender_ID = ", myAccountID, " OR AccountReceiver_ID = ", myAccountID));
		}
	}
}