
using System;
using System.Web;
using System.Web.UI;
using System.Data;
using MySql.Data.MySqlClient;

namespace FamilyTree
{
	
	public class DataBaseFilter : System.Web.UI.Page
	{
		private MySqlConnection dbCon;
		//private IDbConnection dbCon;
		private string connectString;
		public string Connection {
			get {
				return connectString;
			}
			set {
				connectString = value;
				dbCon = new MySqlConnection(value);
			}
		}
		
		public DataBaseFilter(string connectionString) {
			Connection = connectionString;
		}
		
		public void WriteQuery(string query) {
			dbCon.Open();
			IDbCommand dbCmd = dbCon.CreateCommand();
			dbCmd.CommandText = query;
			IDataReader reader = dbCmd.ExecuteReader();
			
			reader.Close();
			reader = null;
			dbCmd.Dispose();
			dbCmd = null;
			dbCon.Close();
		}
		
		public DataTable ReadQuery(string query) {
			DataTable dbTable = new DataTable();
			dbCon.Open();
			//IDbCommand dbCmd = dbCon.CreateCommand();
			MySqlCommand dbCmd = dbCon.CreateCommand();
			dbCmd.CommandText = query;
			MySqlDataAdapter dbAdapt = new MySqlDataAdapter(dbCmd);
			dbAdapt.Fill(dbTable);
			
			return dbTable;
		}
		
		
		/*
			IDbConnection dbCon;
			//MySqlConnection dbCon;
			dbCon = new MySqlConnection(connectionString);
			dbCon.Open();
			IDbCommand dbcmd = dbCon.CreateCommand ();
			// requires a table to be created named employee
			// with columns firstname and lastname
			// such as,
			//        CREATE TABLE employee (
			//           firstname varchar(32),
			//           lastname varchar(32));
			string sql = "SELECT First_Name, Last_Name FROM Person";
			//string sql = "SELECT * FROM Person";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader ();
			//reader.Read();
			while (reader.Read ()) {
				string FirstName = (string)reader["First_Name"];
				string LastName = (string)reader["Last_Name"];
				Console.WriteLine ("Name: " + FirstName + " " + LastName);
				button1.Text = "Name: " + FirstName + " " + LastName;
			}
			// clean up
			reader.Close ();
			reader = null;
			dbcmd.Dispose ();
			dbcmd = null;
			dbCon.Close ();
			dbCon = null;
			*/
	}
}
