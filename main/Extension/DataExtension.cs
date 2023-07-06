using LiteDB;
using Sunny.UI;
using System.Diagnostics;
using NetForm.Tools;
using Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NetForm.Extension
{
	internal static class DataExtension
	{
		/// <summary>
		/// 展示Layer数据
		/// </summary>
		/// <returns></returns>
		public static void SetGridView(this DesignerLayer Layer, UIDataGridView gridView)
		{
			gridView.AutoSize = true;
			var metas = Layer.metas;
			gridView.Columns.Clear();
			var count = metas.Count;
			for (int col = 0; col < count; col++)
			{
				DesignerMeta meta = metas[col];
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
					case DesignerMeta.ValueType.Dictionary:
						var columnCustom = new DataGridViewColumn();
						columnCustom.Name = meta.Name;
						columnCustom.ReadOnly = true;
						columnCustom.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
						columnCustom.CellTemplate = new DataGridViewTextBoxCell();
						var Index=gridView.Columns.Add(columnCustom);
						gridView.CellDoubleClick += (sender, e) =>
						{
							if (e.ColumnIndex == Index)
							{
								MessageBox.Show("弹出Meta layer 单选框");
								gridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Test";
							}
						};

						break;
					case DesignerMeta.ValueType.Array:
						var columnCustomMult = new DataGridViewColumn();
						columnCustomMult.Name = meta.Name;
						columnCustomMult.ReadOnly = true;
						columnCustomMult.ValueType = typeof(string);
						columnCustomMult.CellTemplate = new DataGridViewTextBoxCell();
						var arrayColIndex1 = gridView.Columns.Add(columnCustomMult);
						//弹出多选框
						gridView.CellDoubleClick += (sender, e) =>
						{
							if (e.ColumnIndex == arrayColIndex1)
							{
								MessageBox.Show("弹出Meta layer 多选框");
								int s=0;
								if (UIInputDialog.InputIntegerDialog(ref s))
								{
									gridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = s;
								}
									
							}
						};
						break;
					default:
						break;
				}

				//填充Bsondocument 数据到 gridView
				if (meta.Data == null)
				{
					continue;
				}
				var bson = meta.Data;
				var dataArray = bson[meta.Name].AsArray;
				while (gridView.Rows.Count < dataArray.Count)
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

		public static void SaveData(this DesignerLayer Layer, UIDataGridView dataGrid)
		{
			//按列存储
			var colIndex = dataGrid.Columns.Count;
			var metas = Layer.metas;
			for (int col = 0; col < colIndex; col++)
			{
				var curCol = dataGrid.Columns[col];
				var cellIndex = dataGrid.RowCount;
				//每一列
				BsonArray bson = new BsonArray();
				for (int row = 0; row < cellIndex; row++)
				{
					try
					{

						var cell = dataGrid.Rows[row]?.Cells[col].Value;
						var colMetaType = metas[col].Type;
						bool suitableType = cell.IsMetaType(colMetaType);
						if (!suitableType)
						{
							bson.Add(null);
							MessageBox.Show($"数据格式错误 行{row} 列{col}");
							continue;
						}
						if (cell == null ||
							string.IsNullOrEmpty(cell.ToString()))
						{
							bson.Add(null);
							continue;
						}
						BsonValue value = new BsonValue(cell);
						Debug.WriteLine($"BsonType {value.Type}");
						bson.Add(value);
					}
					catch (Exception)
					{
						MessageBox.Show($"数据格式错误 行{row} 列{col}");
						break;
					}

				}
				var curMeta = metas[col];
				BsonDocument bsonData = new BsonDocument();
				bsonData.Add(curCol.Name, bson);
				curMeta.Data = bsonData;
			}
		}
	}
}
