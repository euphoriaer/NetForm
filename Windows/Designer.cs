using LiteDB;
using NetForm.Data;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetForm.LiteDB;

namespace NetForm
{
	public partial class Designer : Form
	{
		private DesignerData designer;
		public Designer(DesignerData designerData)
		{
			designer = designerData;
			InitializeComponent();
			InitDesigner();
		}
		private List<UIControl> uIControls = new List<UIControl>();

		public int HorizontalInternal = 20;
		public int VerticalInternal = 40;
		/// <summary>
		/// dx,dy
		/// </summary>
		public Action<int, int> MiddleMove;
		private void InitDesigner()
		{

			DrawDesigner(designer.Root);
		}

		private void DrawDesigner(Layer layer)
		{
			var original = new Point(Width / 2 - 50, Height / 2 - 17);
			int Maxhight = layer.metas.Count * VerticalInternal;
			int width = layer.Level * HorizontalInternal;

			var firstPos = new Point(original.X + width, original.Y +-Maxhight / 2);
			MiddleMove += (x, y) =>
			{
				firstPos.X += x;
				firstPos.Y += y;
			};

			var CreateNewBtn = new UIButton();
			for (int i = 0; i < layer.metas.Count; i++)
			{
				var item = layer.metas[i];

				CreateButton(new Point(firstPos.X, firstPos.Y + i * VerticalInternal), item.Name, (o, e) =>
				{
					MessageBox.Show(item.Name);
				});
				if (item.Son != null)
				{
					DrawDesigner(item.Son);
				}

			}

			//绘制当前layer 的增加按钮
			CreateNewBtn = CreateButton(new Point(firstPos.X, firstPos.Y + (layer.metas.Count) * VerticalInternal), "新字段", (o, e) =>
			{
				var newbtn = new DesignerMeta()
				{
					Name = "New"
				};
				layer.metas.Add(newbtn);
				CreateNewBtn.Location = new Point(firstPos.X, firstPos.Y + (layer.metas.Count) * VerticalInternal);
				CreateButton(new Point(firstPos.X, firstPos.Y + (layer.metas.Count - 1) * VerticalInternal), newbtn.Name, (o, e) =>
				{
					//Todo 
				});


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

		private void Button_Click(object? sender, EventArgs e)
		{
			MessageBox.Show($"按下按钮");
		}

		private void Designer_Load(object sender, EventArgs e)
		{

		}

		private void Designer_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void uiFlowLayoutPanel1_Click(object sender, EventArgs e)
		{

		}

		private void uiFlowLayoutPanel1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.MButton:
					MessageBox.Show("按下中键");
					break;
				default:
					break;
			}
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
			//保存测试
			LiteDbContext.Litedb.Designer.Update(designer);
		}
	}
}
