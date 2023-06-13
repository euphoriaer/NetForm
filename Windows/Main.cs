using NetForm.Data;
using NetForm.LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
			Layer rootLayer = new Layer();

			rootLayer.CreateDefaultMeta();

			DesignerData data = new DesignerData(rootLayer);

			var des = new Designer(data);

			des.ShowDialog();
		}

		private void Main_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void Main_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void Main_Load(object sender, EventArgs e)
		{

		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			//初始化数据库
			var path = Path.Combine(Environment.CurrentDirectory, "Data.db");
			if (!File.Exists(path))
			{
				using (File.Create(path))
				{

				}
			}
			new LiteDbContext(path);
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			var des= LiteDbContext.Litedb.Designer.GetDesigner();
			var designer = des[0];
	
			var desWin = new Designer(designer);

			desWin.ShowDialog();
		}
	}
}
