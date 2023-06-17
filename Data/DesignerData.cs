using LiteDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetForm.Data
{
	public class DesignerData
	{
		[BsonId]
		public ObjectId CustomerId { get; set; }

		public DataSet Data { get; set; }

		public string Name { get; set; }

		public Layer Root { get; set; }
		public DesignerData(Layer root) 
		{
			Data.Tables.Add(root.Data);
			Root = root;
		}
		public DesignerData()
		{
			
		}
	}

	public class Layer
	{
		public int Level = 0;

		public List<DesignerMeta> metas  { get; set; }=new List<DesignerMeta>();

		public DataTable Data { get; set; }

		public void CreateDefaultMeta(Layer rootLayer)
		{
			
			DesignerMeta root = new DesignerMeta(rootLayer)
			{
				Name = "ID",
				Description = "null",

			};
			metas.Add(root);
		}
		
	}

	public class DesignerMeta
	{
		public DesignerMeta(Layer father)
		{
			this.Parent = father;
		}
		public string Name { get; set; }

		public string Description { get; set; }
		/// <summary>
		/// 值 数组 字典  Index(目标表的id)
		/// </summary>
		public ValueType Type { get; set; }

		public Layer Son { get; set; }

		public Layer Parent { get; set; }

		public void Delete()
		{
			Parent.metas.Remove(this);
		}

		public class Index
		{
			public string FormName { get; set; }

			public int ID { get; set; }
		}

		public enum ValueType
		{
			Int,
			Float,
			String,
			Index,
			Bool,
		}
	}

}
