using LiteDB;
using NetForm.FileHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NetForm.Data
{
	public class DesignerLayer
	{
		public int Level { get; set; }=0;

		public string Name { get; set; }

		[BsonIgnore]
		public DataTable table
		{
			get
			{
				var table= CSVHelper.StringToTable(DataTableString);
				return table;
			}
			set
			{
				var tb = value;
				DataTableString=CSVHelper.DataTableToString(tb);
			}
		}

		public string DataTableString { get; set; }

		public List<DesignerMeta> metas { get; set; } = new List<DesignerMeta>();

		//public DataTable Data { get; set; } =new DataTable();
		public void SetTableColumn()
		{
			DataTable temptable = new DataTable();
			foreach (DesignerMeta meta in metas)
			{
				DataColumn column = new DataColumn();
				switch (meta.Type)
				{
					case DesignerMeta.ValueType.Int:
						column.DataType = typeof(int);
						break;
					case DesignerMeta.ValueType.Float:
						column.DataType = typeof(float);
						break;
					case DesignerMeta.ValueType.String:
						column.DataType = typeof(string);
						break;
					case DesignerMeta.ValueType.Index:
						//下拉
						column.DataType = typeof(int);
						break;
					case DesignerMeta.ValueType.Bool:
						column.DataType = typeof(bool);
						break;
					default:
						break;
				}
				column.ColumnName = meta.Name;
				column.ReadOnly = false;
				//todo 非数组layer 唯一
				column.Unique = false;
				//注释
				column.Caption = meta.Description;
				column.AutoIncrement = true;
				temptable.Columns.Add(column);
			}
			table = temptable;
		}

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
