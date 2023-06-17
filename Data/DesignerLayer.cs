using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetForm.Data
{
	public class DesignerLayer
	{
		public int Level = 0;

		public string Name { get; set; }

		public List<DesignerMeta> metas { get; set; } = new List<DesignerMeta>();

		public DataTable Data { get; set; } =new DataTable();

		private void CreateDefaultMeta(DesignerLayer rootLayer)
		{
			DesignerMeta root = new DesignerMeta(rootLayer)
			{
				Name = "ID",
				Description = "null",

			};
			metas.Add(root);
		}

		public DesignerLayer(DesignerData data,string layerName)
		{
			Name=layerName;
			Data.TableName = layerName;
			data.Data.Tables.Add(Data);
			//创建默认元素
			CreateDefaultMeta(this);
		}
	}


}
