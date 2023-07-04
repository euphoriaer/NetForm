
namespace Data
{
	public class DesignerLayer
	{
		public int Level { get; set; } = 0;

		public string Name { get; set; }

		public string DataTableString { get; set; }

		public List<DesignerMeta> metas { get; set; } = new List<DesignerMeta>();

		private void CreateDefaultMeta(DesignerLayer rootLayer)
		{
			DesignerMeta root = new DesignerMeta()
			{
				Name = "ID",
				Description = "null",

			};
			metas.Add(root);
		}

		public DesignerLayer(DesignerData data, string layerName)
		{
			Name = layerName;
			//Data.TableName = layerName;
			//创建默认元素
			CreateDefaultMeta(this);
		}

		public DesignerLayer()
		{

		}
	}


}
