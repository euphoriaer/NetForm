using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetForm.Data
{
	public class DesignerData
	{
		public Layer Root;
		public DesignerData(Layer root) 
		{
			Root = root;
		}
	}

	public class Layer
	{
		public int Level = 0;

		public List<DesignerMeta> metas = new List<DesignerMeta>();
		public void CreateDefaultMeta()
		{
			DesignerMeta root = new DesignerMeta()
			{
				Name = "ID",
				Value = 0,
				Description = "null",

			};
			metas.Add(root);
		}
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
