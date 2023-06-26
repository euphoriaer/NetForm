using LiteDB;
using NetForm.FileHelper;
using Sunny.UI;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using DataGridView = Sunny.UI.UIDataGridView;

namespace NetForm.Data
{
	public class DesignerLayer
	{
		public int Level { get; set; } = 0;

		public string Name { get; set; }

		//[BsonIgnore]
		//public DataTable table
		//{
		//	get
		//	{
		//		var table = CSVHelper.StringToTable(DataTableString);
		//		return table;
		//	}
		//	set
		//	{
		//		var tb = value;
		//		DataTableString = CSVHelper.DataTableToString(tb);
		//	}
		//}

		public string DataTableString { get; set; }

		public List<DesignerMeta> metas { get; set; } = new List<DesignerMeta>();

		/// <summary>
		/// 展示Layer数据
		/// </summary>
		/// <returns></returns>
		public void SetGridView(UIDataGridView gridView)
		{
			
			gridView.Columns.Clear();
			var count = metas.Count;
			for (int col = 0; col < count; col++)
			{
				DesignerMeta meta= metas[col];
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
						columnFloat.ValueType = typeof(double);
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
						var columnBool = new DataGridViewCheckBoxColumn();
						columnBool.ValueType = typeof(bool);
						columnBool.Name = meta.Name;
						columnBool.ReadOnly = false;
						columnBool.HeaderText = meta.Name;
						columnBool.CellTemplate = new DataGridViewCheckBoxCell();
						columnBool.ToolTipText = meta.Description;
						columnBool.TrueValue = true;
						columnBool.FalseValue = false;
						gridView.Columns.Add(columnBool);
						break;
					default:
						break;
				}

				//填充Bsondocument 数据到 gridView
				if (meta.Data == null)
				{
					continue;
				}
				var bson =meta.Data;
				var dataArray = bson[meta.Name].AsArray;
				while(gridView.Rows.Count< dataArray.Count)
				{
					gridView.Rows.Add();
				}
				for (int row = 0; row < dataArray.Count; row++)
				{
					var value = dataArray[row];
					switch (value.Type)
					{
						case BsonType.MinValue:
							break;
						case BsonType.Null:
							break;
						case BsonType.Int32:
							gridView.Rows[row].Cells[col].Value = value.AsInt32;
							break;
						case BsonType.Int64:
							break;
						case BsonType.Double:
							gridView.Rows[row].Cells[col].Value = value.AsDouble;
							break;
						case BsonType.Decimal:
							break;
						case BsonType.String:
							gridView.Rows[row].Cells[col].Value = value.AsString;
							break;
						case BsonType.Document:
							break;
						case BsonType.Array:
							break;
						case BsonType.Binary:
							break;
						case BsonType.ObjectId:
							break;
						case BsonType.Guid:
							break;
						case BsonType.Boolean:
							gridView.Rows[row].Cells[col].Value = value.AsBoolean;
							break;
						case BsonType.DateTime:
							break;
						case BsonType.MaxValue:
							break;
						default:
							break;
					}
					
				}
			}
		}

		public void SaveData(UIDataGridView dataGrid)
		{
			//按列存储
			var colIndex = dataGrid.Columns.Count;

			for (int col = 0; col < colIndex; col++)
			{
				var curCol = dataGrid.Columns[col];
				var cellIndex = dataGrid.RowCount;
				//每一列
				BsonArray bson = new BsonArray();
				for (int row = 0; row < cellIndex; row++)
				{
					var dataType = curCol.ValueType;
					var cell = dataGrid.Rows[row]?.Cells[col].Value;
					if (cell == null&&
						!string.IsNullOrEmpty(cell.ToString()))
					{
						bson.Add(null);
						continue;
					}
					BsonValue value = new BsonValue(cell);
					Debug.WriteLine($"BsonType {value.Type}");
					bson.Add(value);
				}
				var curMeta = metas[col];
				BsonDocument bsonData = new BsonDocument();
				bsonData.Add(curCol.Name, bson);
				curMeta.Data = bsonData;
			}
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
