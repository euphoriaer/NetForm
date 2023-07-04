using LiteDB;

namespace Data
{
	public class LiteDbContext
	{
		public static LiteDbContext Litedb;
		private string _dbConnectionString;
		public DesignerDb Designer;

		public LiteDbContext(string dbPath)
		{
			_dbConnectionString = dbPath;
			if (Litedb==null)
			{
				Litedb = this;
			}
			Designer = new DesignerDb(dbPath);

		}
		public class DesignerDb
		{
			private string dbPath;

			public DesignerDb(string dbPath)
			{
				this.dbPath = dbPath;
			}

			public LiteDatabase GetDB()
			{
				return new LiteDatabase(dbPath);
			}

			/// <summary>
			/// 所有的表设计
			/// </summary>
			/// <returns></returns>
			public List<DesignerData> GetDesigner()
			{
				using (var db = GetDB())
				{
					var col = db.GetCollection<DesignerData>();
					var list = col.FindAll().OrderBy(x => x.CustomerId.CreationTime).ToList();
					return list;
				}
			}

			public List<DesignerData> GetDesigner(ObjectId id)
			{
				using (var db = GetDB())
				{
					var col = db.GetCollection<DesignerData>();
					var res = col.Query()
					.Where(x => x.CustomerId == id);

					return res.ToList();
				}
			}

			public bool Update(DesignerData item)
			{
				using (var db = GetDB())
				{
					var col = db.GetCollection<DesignerData>();
					return col.Upsert(item);
				}
			}

			public void Add(params DesignerData[] designer)
			{
				using (var db = GetDB())
				{
					var col = db.GetCollection<DesignerData>();
					col.Insert(designer);
				}
			}

			public void Delete(DesignerData designer)
			{
				using (var db = GetDB())
				{
					var col = db.GetCollection<DesignerData>();
					bool isOk = col.Delete(designer.CustomerId);
				}
			}
		}
	}
}
