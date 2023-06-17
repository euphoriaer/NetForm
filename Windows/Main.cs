using NetForm.Data;
using NetForm.FileHelper;
using NetForm.LiteDB;
using Sunny.UI;
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
using System.Xml.Linq;

namespace NetForm
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			InitData();
		}

		private void InitData()
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

			//FormList
			var des = LiteDbContext.Litedb.Designer.GetDesigner();
			for (int i = 0; i < des.Count; i++)
			{
				FormList.Items.Add(des[i].Name);
			}

			//DataTable dt = CSVHelper.ReadCSV("C:\\gitProject\\drgclient\\Csv\\1.7\\item\\item.CSV");
			binGrid1.SetDataSource(des);


		}

		private void CreateForm_Click(object sender, EventArgs e)
		{

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

		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			var des = LiteDbContext.Litedb.Designer.GetDesigner();
			var index = FormList.SelectedIndex;
			if (index == -1)
			{
				return;
			}
			var designer = des[index];
			var desWin = new Designer(designer, designer.Root);

			var res = desWin.ShowDialog();

		}

		private void toolStripButton1_Click_1(object sender, EventArgs e)
		{
			string name = "";
			if (UIInputDialog.InputStringDialog(this, ref name, desc: "表名"))
			{

				//构建一个根设计
				DesignerData data = new DesignerData();
				var layer = data.CreateRootLayer("Root", name);
				var des = new Designer(data, layer);

				var res = des.ShowDialog();
				if (res == DialogResult.OK)
				{
					FormList.Items.Add(des.designer.Name);
				}
			}

			
		}

		private void FormDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void binGrid1_Load(object sender, EventArgs e)
		{

		}
	}
}
