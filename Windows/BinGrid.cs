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

		public BinGrid(Layer layer)
		{
			InitializeComponent();
			dataGridView1.DataSource = layer.Data;
			//列类型根据Designer Meta
		}

		public void SetDataSource(object dataSource)
		{
			dataGridView1.DataSource = dataSource;
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
