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

		public BinGrid()
		{
			InitializeComponent();
		}

		public BinGrid(DesignerLayer layer)
		{
			InitializeComponent();
			//dataGridView1.DataSource = layer.;
			//列类型根据Designer Meta
		}

		public void SetDataSource(object dataSource)
		{
			uiDataGridView1.DataSource = dataSource;
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
	}
}
