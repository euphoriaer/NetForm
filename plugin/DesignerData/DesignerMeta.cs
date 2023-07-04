using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	/// <summary>
	/// 一个Meta 是一列数据
	/// </summary>
	public class DesignerMeta
	{
		public DesignerMeta()
		{
			
		}

		public string Name { get; set; }

		public string Description { get; set; } = "我是注释";

		public BsonDocument Data { get; set; }

		/// <summary>
		/// 值 数组 字典  Index(目标表的id)
		/// </summary>
		public ValueType Type { get; set; }

		public DesignerLayer Son { get; set; }

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
