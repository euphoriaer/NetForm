using System.Data;
using System.Data.SQLite;

namespace NetForm.SQLite
{
	internal class SQLiteContext
	{
		public DataSet Dataset=new DataSet();
		public SQLiteContext(string connectString)
		{
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();
				SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Test", connection);
				adapter.Fill(Dataset);
			}
		}
	}
}
