using LiteDB;
using NetForm.Data;
using Sunny.UI;
using System.Diagnostics;
using NetForm.LiteDB;


namespace NetForm
{
	public partial class Designer : Form
	{
		public DesignerData designer;
		public DesignerLayer root;
		public Designer(DesignerData designerData)
		{
			designer = designerData;

			InitializeComponent();
			InitDesigner();
		}
		private List<UIControl> uIControls = new List<UIControl>();
		private List<UserControl> userControl = new List<UserControl>();

		public int HorizontalInternal = 20;
		public int VerticalInternal = 80;
		/// <summary>
		/// dx,dy
		/// </summary>
		public Action<int, int> MiddleMove;
		private void InitDesigner()
		{
			DrawDesigner(designer.Root);
		}

		private void DrawDesigner(DesignerLayer layer)
		{
			var original = new Point(Width / 2 - 50, Height / 2 - 17);
			int Maxhight = layer.metas.Count * VerticalInternal;
			int width = layer.Level * HorizontalInternal;

			var firstPos = new Point(original.X + width, original.Y + -Maxhight / 2);
			MiddleMove += (x, y) =>
			{
				firstPos.X += x;
				firstPos.Y += y;
			};

			var CreateNewBtn = new UIButton();
			for (int i = 0; i < layer.metas.Count; i++)
			{
				var item = layer.metas[i];
				CreateMeta(new Point(firstPos.X, firstPos.Y + i * VerticalInternal), item);

			}

			//绘制当前layer 的增加按钮
			CreateNewBtn = CreateButton(new Point(firstPos.X, firstPos.Y + (layer.metas.Count) * VerticalInternal), "新字段", (o, e) =>
			{
				var newMeta = new DesignerMeta(root)
				{
					Name = "New"
				};
				layer.metas.Add(newMeta);
				CreateNewBtn.Location = new Point(firstPos.X, firstPos.Y + (layer.metas.Count) * VerticalInternal);
				CreateMeta(new Point(firstPos.X, firstPos.Y + (layer.metas.Count - 1) * VerticalInternal), newMeta);
			});
		}

		private UIButton CreateButton(Point point, string name, EventHandler action)
		{
			var button = new Sunny.UI.UIButton();
			button.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button.MinimumSize = new Size(1, 1);
			button.Name = "newFormBtn";
			button.Size = new Size(100, 35);
			button.Location = point;
			button.TabIndex = 0;
			button.Text = name;
			button.Click += action;
			Controls.Add(button);
			uIControls.Add(button);
			return button;
		}

		private Windows.DesignerMeta CreateMeta(Point point, DesignerMeta meta)
		{
			var metaPanel = new Windows.DesignerMeta(meta);
			metaPanel.Location = point;
			Controls.Add(metaPanel);
			userControl.Add(metaPanel);
			return metaPanel;
		}

		private void Button_Click(object? sender, EventArgs e)
		{
			MessageBox.Show($"按下按钮");
		}

		private void Designer_Load(object sender, EventArgs e)
		{

		}

		private void Designer_KeyPress(object sender, KeyPressEventArgs e)
		{

			MessageBox.Show($"按下,{e.KeyChar}");

		}
		private bool MiddleDown = false;

		private void Designer_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Middle)
			{
				LastPos = e.Location;
				MiddleDown = true;
				Debug.WriteLine($"Down {e.Button}  {e.Clicks} {e.Location}  {e.X}  {e.Y}");
			}
		}
		private Point LastPos;
		private void Designer_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Middle)
			{
				var curPos = e.Location;
				var dx = curPos.X - LastPos.X;
				var dy = curPos.Y - LastPos.Y;
				for (int i = 0; i < uIControls.Count; i++)
				{
					var curUI = uIControls[i];
					curUI.Location = new Point(curUI.Location.X + dx, curUI.Location.Y + dy);
				}

				for (int i = 0; i < userControl.Count; i++)
				{
					var curUI = userControl[i];
					curUI.Location = new Point(curUI.Location.X + dx, curUI.Location.Y + dy);
				}

				if (MiddleMove != null)
				{
					MiddleMove(dx, dy);
				}

				LastPos = curPos;
			}

		}

		private void Designer_MouseUp(object sender, MouseEventArgs e)
		{

		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{

			if (designer.CustomerId!=null)
			{
				LiteDbContext.Litedb.Designer.Update(designer);
			}
			else
			{
				string name = "";
				if (UIInputDialog.InputStringDialog(this, ref name, desc: "表名"))
				{
					designer.Name = name;
					LiteDbContext.Litedb.Designer.Update(designer);
				}
			}
			this.DialogResult = DialogResult.OK;
		}
	}
}
