using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSite
{
	class DatabaseInteraction
	{
		string _connectionString;

		const string SQL_FOLDER = @"..\..\SQL\";
		const string INSERT_DATA_FOLDER = SQL_FOLDER + @"InsertData\";
		const string CREATE_TABLE_FOLDER = SQL_FOLDER + @"CreateTable\";
		const string GET_DATA_FOLDER = SQL_FOLDER + @"GetData\";

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

				List<string> tableNames = new List<string> { "Address", "Customer", "Account", "Transaction" };

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

					if (missingTable.Equals("Address"))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(CREATE_TABLE_FOLDER, "Address.sql"));
						cmd.ExecuteNonQuery();
						continue;
					}

					if (missingTable.Equals("Customer"))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(CREATE_TABLE_FOLDER, "Customer.sql"));
						cmd.ExecuteNonQuery();
						continue;
					}

					if (missingTable.Equals("Account"))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(CREATE_TABLE_FOLDER, "Account.sql"));
						cmd.ExecuteNonQuery();
						continue;
					}

					if (missingTable.Equals("Transaction"))
					{
						cmd.CommandText = File.ReadAllText(string.Concat(CREATE_TABLE_FOLDER, "Transaction.sql"));
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

				cmd.CommandText = File.ReadAllText(string.Concat(INSERT_DATA_FOLDER, "Address.sql"));
				cmd.ExecuteNonQuery();

				cmd.CommandText = File.ReadAllText(string.Concat(INSERT_DATA_FOLDER, "Customer.sql"));
				cmd.ExecuteNonQuery();

				cmd.CommandText = File.ReadAllText(string.Concat(INSERT_DATA_FOLDER, "Account.sql"));
				cmd.ExecuteNonQuery();

				cmd.CommandText = File.ReadAllText(string.Concat(INSERT_DATA_FOLDER, "Transaction.sql"));
				cmd.ExecuteNonQuery();
			}
		}
	}
}
