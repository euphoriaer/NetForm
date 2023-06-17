using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetForm.Data
{
	public class DesignerMeta
	{
		public DesignerMeta(DesignerLayer father)
		{
			this.Parent = father;
		}
		public string Name { get; set; }

		public string Description { get; set; }
		/// <summary>
		/// 值 数组 字典  Index(目标表的id)
		/// </summary>
		public ValueType Type { get; set; }

		public DesignerLayer Son { get; set; }

		public DesignerLayer Parent { get; set; }

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
