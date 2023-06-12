using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetForm.Data
{
	public class DesignerData
	{
		public Dictionary<string,DesignerMeta> metas = new Dictionary<string, DesignerMeta>();
		public DesignerData(Layer root) 
		{

		}
	}

	public class Layer
	{
		public Dictionary<string, DesignerMeta> metas = new Dictionary<string, DesignerMeta>();
	}

	public class DesignerMeta
	{
		public string Name { get; set; }

		public string Description { get; set; }
		/// <summary>
		/// 值 数组 字典  Index(目标表的id)
		/// </summary>
		public Object Value;

		public Layer Son { get; set; }

		public class Index
		{
			public string FormName { get; set; }

			public int ID { get; set; }
		}
	}

}
