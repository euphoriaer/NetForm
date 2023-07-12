using Data;
using NetForm.Extension;
using NetForm.Windows;
using Sunny.UI;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;

namespace NetForm
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			formTabControl.DrawItem += FormTabControl_DrawItem;
			formTabControl.MouseDown += FormTabControl_MouseDown;
			InitData();
		}

		private void FormTabControl_MouseDown(object? sender, MouseEventArgs e)
		{
			for (int i = 0; i < this.formTabControl.TabPages.Count; i++)
			{
				Rectangle r = formTabControl.GetTabRect(i);

				if (e.Button==MouseButtons.Middle
					&& r.Contains(e.Location))
				{
					this.formTabControl.TabPages.RemoveAt(i);
					return;
				}
			}
		}

		private void FormTabControl_DrawItem(object? sender, DrawItemEventArgs e)
		{
			//这里我们添加一个新的Padding，来增加x的距离
			formTabControl.Padding = new System.Drawing.Point(0, 0);

			//这里我们用DrawString来画一个x字符
			e.Graphics.DrawString("X", e.Font, Brushes.White, e.Bounds.Right, e.Bounds.Top);
			e.Graphics.DrawString(this.formTabControl.TabPages[e.Index].Text, e.Font, Brushes.White, e.Bounds.Left, e.Bounds.Top);
			e.DrawFocusRectangle();
		}

		private void InitData()
		{
			//初始化LiteDb数据库
			var path = Path.Combine(Environment.CurrentDirectory, "Data", "Designer.litedb");
			var folder = Path.GetDirectoryName(path);
			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}
			if (!File.Exists(path))
			{
				using (File.Create(path))
				{

				}
			}
			new LiteDbContext(path);
			path = Path.Combine(Environment.CurrentDirectory, "Data", "Data.sqdb");
			if (!File.Exists(path))
			{
				using (File.Create(path))
				{

				}
			}
			string connectStr = $"Data Source={path}";

			//FormList
			var des = LiteDbContext.Litedb.Designer.GetDesigner();
			for (int i = 0; i < des.Count; i++)
			{
				FormList.Items.Add(des[i].Name);
			}
			FormList.DoubleClick += FormList_DoubleClick;

		}

		private void FormList_DoubleClick(object? sender, EventArgs e)
		{
			var des = LiteDbContext.Litedb.Designer.GetDesigner();
			var data = des[FormList.SelectedIndex];
			var layer = data.Root;

			//转到对应tab 选项卡,或者新建tab 选项卡,填充
			if (formTabControl.SetTab(data.Name))
			{
				return;
			}

			UIPage tabPage = new UIPage();
			tabPage.Name = data.Name;
			tabPage.Text = data.Name;

			BinGrid grid = new BinGrid();
			tabPage.Controls.Add(grid);
			formTabControl.AddPage(tabPage);
			var curIndex = formTabControl.TabCount - 1;
			formTabControl.SelectTab(curIndex);

			grid.Dock = DockStyle.Fill;
			grid.Init(ref layer, ref data);

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

		private void formTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
