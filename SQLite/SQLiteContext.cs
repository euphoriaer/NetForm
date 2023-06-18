using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetForm.SQLite
{
	internal class SQLiteContext
	{
		public DataSet Dataset;
		public SQLiteContext(string connectString)
		{
			using (var connection = new SqlConnection(connectString))
			{
				connection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter("show databases;",connection);
				adapter.Fill(Dataset);
			}
		}
	}
}
