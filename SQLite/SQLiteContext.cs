using System.Data;
using System.Data.SQLite;

namespace NetForm.SQLite
{
	internal class SQLiteContext
	{
		public static SQLiteContext SQLiteData
		{ 
			get;
			private set; 
		}
		public DataTable Datas=new DataTable();
		public SQLiteContext(string connectString)
		{
			if (connectString == null)
			{
				SQLiteData = this;
			}
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();
				SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM sqlite_master", connection);
				adapter.Fill(Datas);
			}
		}
	}
}
