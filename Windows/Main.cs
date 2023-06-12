using NetForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetForm
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

		}

		private void CreateForm_Click(object sender, EventArgs e)
		{
			//构建一个根设计
			Layer layer = new Layer();
			layer.CreateDefaultMeta();
			DesignerData data = new DesignerData(layer);
			var des = new Designer(data);
			des.ShowDialog();
		}

		private void Main_KeyDown(object sender, KeyEventArgs e)
		{
			
		}

		private void Main_MouseClick(object sender, MouseEventArgs e)
		{
			
		}
	}
}
