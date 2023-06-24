using LiteDB;
using NetForm.FileHelper;
using Sunny.UI;
using System.Data;
using System.Data.Common;
using System.Windows.Controls;
using DataGridView = Sunny.UI.UIDataGridView;

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

		/// <summary>
		/// 展示列
		/// </summary>
		/// <returns></returns>
		public void SetGridView(UIDataGridView gridView)
		{
			gridView.Columns.Clear();
			foreach (DesignerMeta meta in metas)
			{
				switch (meta.Type)
				{
					case DesignerMeta.ValueType.Int:
						var columnInt = new DataGridViewColumn();
						columnInt.ValueType = typeof(int);
						columnInt.Name = meta.Name;
						columnInt.ReadOnly = false;
						columnInt.HeaderText = meta.Name;
						columnInt.CellTemplate = new DataGridViewTextBoxCell();
						columnInt.ToolTipText = meta.Description;
						gridView.Columns.Add(columnInt);
						break;
					case DesignerMeta.ValueType.Float:
						var columnFloat = new DataGridViewColumn();
						columnFloat.ValueType = typeof(float);
						columnFloat.Name = meta.Name;
						columnFloat.ReadOnly = false;
						columnFloat.HeaderText = meta.Name;
						columnFloat.CellTemplate = new DataGridViewTextBoxCell();
						columnFloat.ToolTipText = meta.Description;
						gridView.Columns.Add(columnFloat);
						break;
					case DesignerMeta.ValueType.String:
						var columnString = new DataGridViewColumn();
						columnString.ValueType = typeof(string);
						columnString.Name = meta.Name;
						columnString.ReadOnly = false;
						columnString.HeaderText = meta.Name;
						columnString.ToolTipText = meta.Description;
						columnString.CellTemplate = new DataGridViewTextBoxCell();
						gridView.Columns.Add(columnString);
						break;
					case DesignerMeta.ValueType.Index:
						var columnIndex = new DataGridViewColumn();
						//todo 下拉/弹出 选ID 输入检测
						columnIndex.ValueType = typeof(int);
						columnIndex.Name = meta.Name;
						columnIndex.ReadOnly = false;
						columnIndex.HeaderText = meta.Name;
						columnIndex.CellTemplate = new DataGridViewTextBoxCell();
						columnIndex.ToolTipText = meta.Description;
						gridView.Columns.Add(columnIndex);
						break;
					case DesignerMeta.ValueType.Bool:
						var columnBool= new DataGridViewCheckBoxColumn();
						columnBool.ValueType = typeof(bool);
						columnBool.Name = meta.Name;
						columnBool.ReadOnly = false;
						columnBool.HeaderText = meta.Name;
						columnBool.CellTemplate = new DataGridViewCheckBoxCell();
						columnBool.ToolTipText = meta.Description;
						columnBool.TrueValue = "1";
						columnBool.FalseValue = "0";
						gridView.Columns.Add(columnBool);
						break;
					default:
						break;
				}
				
			}
			
			//todo 填充Bsondocument 数据到 DataTable,
			var table= gridView.DataSource as DataTable;
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
