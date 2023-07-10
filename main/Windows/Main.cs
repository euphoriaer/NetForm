using Data;
using NetForm.Windows;
using Sunny.UI;
using System.Windows.Forms;

namespace NetForm
{
	public partial class Main : Form
	{
		private Dictionary<string, int> Tabmap = new Dictionary<string, int>();
		public Main()
		{
			InitializeComponent();
			InitData();
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
			if (Tabmap.ContainsKey(data.Name))
			{
				formTabControl.SelectTab(Tabmap[data.Name]);
				return;
			}

			UIPage tabPage = new UIPage();
			tabPage.Name = data.Name;
			tabPage.Text = data.Name;

			BinGrid grid = new BinGrid();
			tabPage.Controls.Add(grid);
			formTabControl.AddPage(tabPage);
			var curIndex = formTabControl.TabCount - 1;
			Tabmap.Add(data.Name, curIndex);
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
	}
}
