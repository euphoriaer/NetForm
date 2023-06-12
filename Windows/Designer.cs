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
		private void InitDesigner()
		{
			foreach (var item in designer.Root.metas)
			{
				var button = new Sunny.UI.UIButton();
				button.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
				button.MinimumSize = new Size(1, 1);
				button.Name = "newFormBtn";
				button.Size = new Size(100, 35);
				button.Location = new Point(Width / 2 - 50, Height / 2 - 17);
				button.TabIndex = 0;
				button.Text = item.Value.Name;
				button.Click += Button_Click;
				Controls.Add(button);
				uIControls.Add(button);
			}
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
				LastPos = curPos;
			}

		}

		private void Designer_MouseUp(object sender, MouseEventArgs e)
		{

		}
	}
}
