using Microsoft.Win32;
using NetForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetForm.Windows
{
	public partial class BinGrid : UserControl
	{
		private DesignerData designerData;
		private DataTable dbTable;
		private DesignerLayer curLayer;
		public BinGrid()
		{
			InitializeComponent();
			uiDataGridView1.AllowDrop = true;
			uiDataGridView1.DataError += GridView_DataError;
		}

		public BinGrid(ref DesignerLayer layer,ref DesignerData data)
		{
			InitializeComponent();
			designerData= data;
			uiDataGridView1.AllowDrop = true;
			curLayer=layer;
			uiDataGridView1.DataError += GridView_DataError;
			layer.SetGridView(uiDataGridView1);
		}

		private void GridView_DataError(object? sender, DataGridViewDataErrorEventArgs e)
		{
			var index = e.ColumnIndex;
			var dataGridView= sender as DataGridView;
			var col = dataGridView.Columns[index];
			var type= col.ValueType.Name;
			MessageBox.Show($"输入类型错误! 请输入正确类型: {type}");
		}

		public void SetDataSource(ref DesignerLayer layer,ref DesignerData data)
		{
			designerData = data;
			curLayer = layer;
			layer.SetGridView(uiDataGridView1);
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
			curLayer.SaveData(uiDataGridView1);
			designerData.SaveToLiteDB();
		}
	}
}
