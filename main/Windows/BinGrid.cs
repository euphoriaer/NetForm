using Data;
using NetForm.Tools;
using OfficeOpenXml;
using System.Data;
using NetForm.Extension;
using LicenseContext = OfficeOpenXml.LicenseContext;
using static NetForm.Windows.SelectForm;

namespace NetForm.Windows
{
    public partial class BinGrid : UserControl
	{
		private DesignerData designerData;
		private DataTable dbTable;
		private DesignerLayer curLayer;
		public SelectMode selectMode=SelectMode.Null;
		public BinGrid()
		{
			InitializeComponent();
		}

		public BinGrid(ref DesignerLayer layer, ref DesignerData data)
		{
			InitializeComponent();

			Init(ref layer, ref data);
		}

		public void Init(ref DesignerLayer layer, ref DesignerData data, SelectMode mode =SelectMode.Null)
		{
			uiDataGridView1.AllowDrop = true;
			uiDataGridView1.DataError += GridView_DataError;
			uiDataGridView1.DragEnter += UiDataGridView1_DragEnter;
			uiDataGridView1.DragDrop += UiDataGridView1_DragDrop;
			designerData = data;
			curLayer = layer;
			selectMode = mode;
			if (mode == SelectMode.Null)
			{
				layer.SetGridView(uiDataGridView1, data);
			}
			else
			{
				layer.SetGridViewCanCheck(uiDataGridView1,data);
			}
			
		}

		private void UiDataGridView1_DragEnter(object? sender, DragEventArgs e)
		{
			string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
			//多文件
			string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (Path.GetExtension(path) == ".xlsx")
			{
				e.Effect = DragDropEffects.Copy; // Show Can Drag 鼠标图标改变
			}
			else
			{
				e.Effect = DragDropEffects.None; // Show Can No Drag 鼠标图标改变
			}
		}

		private void UiDataGridView1_DragDrop(object? sender, DragEventArgs e)
		{
			string path = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString(); ;
			//todo 读Excel 到Grid
			ExcelToGrid(path);
		}

		public void ExcelToGrid(string excelPath)
		{
			if (curLayer == null)
			{
				MessageBox.Show("未选择表");
				return;
			}
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			using (var excelPackage = new ExcelPackage(excelPath))
			{
				ExcelWorksheet sheet = excelPackage.Workbook.Worksheets[0];
				//遍历cell,符合条件的导入

				int sheetRowsCount = sheet.GetRealRowCount();

				var colIndex = uiDataGridView1.Columns.Count;

				while (uiDataGridView1.Rows.Count < sheetRowsCount)
				{
					uiDataGridView1.Rows.Add();
				}


				for (int col = 0; col < colIndex; col++)
				{
					var gridCol = uiDataGridView1.Columns[col];
					var sheetCol = sheet.Columns[col + 1];
					var sheetType = sheetCol.GetType();
					var gridType = gridCol.GetType();
					for (int row = 0; row < sheetRowsCount; row++)
					{
						var sheetCellValue = sheet.Cells[row + 1, col + 1].Value;
						try
						{
							//todo 定义true false 1 ,0 前4行存储Grid信息
							var gridCell = uiDataGridView1.Rows[row].Cells[col].Value = sheetCellValue;
						}
						catch (Exception)
						{

							MessageBox.Show($"类型错误 {col}列");//Todo  定义 Bool
							continue;
						}
					}
				}
			}
		}



		private void GridView_DataError(object? sender, DataGridViewDataErrorEventArgs e)
		{
			var index = e.ColumnIndex;
			var dataGridView = sender as DataGridView;
			var col = dataGridView.Columns[index];
			var type = col.ValueType.Name;
			MessageBox.Show($"输入类型错误! 请输入正确类型: {type}");
		}

		public void SetDataSource(ref DesignerLayer layer, ref DesignerData data)
		{
			designerData = data;
			curLayer = layer;
			layer.SetGridView(uiDataGridView1,data);
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}

		private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
		{
			var table = uiDataGridView1.DataSource as DataTable;
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			uiDataGridView1.CommitEdit(new DataGridViewDataErrorContexts());
			if (selectMode ==SelectMode.Null)
			{
				curLayer.SaveData(uiDataGridView1);
			}
			else
			{
				curLayer.SaveData(uiDataGridView1,true);
			}
			
			designerData.SaveToLiteDB();
		}

		private void InputExcel_Click(object sender, EventArgs e)
		{

		}

		private void 常用路径ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//todo 常用导出路径设定
		}

		private void ExportExcel_ButtonClick(object sender, EventArgs e)
		{

		}

		private void toolStripButton1_Click_1(object sender, EventArgs e)
		{
			var filePath = DialogTools.OpenFiles(out bool isOK, "Excel(*.xlsx)|*.xlsx");

			if (!isOK)
			{
				return;
			}

			ExcelToGrid(filePath[0]);
		}

	}
}
