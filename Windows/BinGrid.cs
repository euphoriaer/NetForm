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

		private DataTable dbTable;

		public BinGrid()
		{
			InitializeComponent();
			uiDataGridView1.AllowDrop = true;
		}

		public BinGrid(DesignerLayer layer)
		{
			InitializeComponent();
			uiDataGridView1.AllowDrop = true;
			layer.SetGridView(uiDataGridView1);
		}

		public void SetDataSource(DesignerLayer layer)
		{
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
			var table=uiDataGridView1.DataSource as DataTable;
		}
	}
}
