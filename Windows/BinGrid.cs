using Microsoft.Win32;
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

		public BinGrid(object dataSource)
		{
			InitializeComponent();
			dataGridView1.DataSource = dataSource;
		}

		public void SetDataSource(object dataSource)
		{
			dataGridView1.DataSource = dataSource;
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
