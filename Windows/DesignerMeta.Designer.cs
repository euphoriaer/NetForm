namespace NetForm.Windows
{
	partial class DesignerMeta
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			mainBtn = new Sunny.UI.UIButton();
			foldBtn = new Sunny.UI.UIButton();
			newSon = new Sunny.UI.UIButton();
			DeleteSon = new Sunny.UI.UIButton();
			deleteBtn = new Sunny.UI.UIButton();
			SuspendLayout();
			// 
			// mainBtn
			// 
			mainBtn.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			mainBtn.Location = new Point(3, 3);
			mainBtn.MinimumSize = new Size(1, 1);
			mainBtn.Name = "mainBtn";
			mainBtn.Size = new Size(100, 56);
			mainBtn.TabIndex = 0;
			mainBtn.Text = "Name";
			mainBtn.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
			mainBtn.Click += mainBtn_Click;
			// 
			// foldBtn
			// 
			foldBtn.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
			foldBtn.Location = new Point(106, 2);
			foldBtn.MinimumSize = new Size(1, 1);
			foldBtn.Name = "foldBtn";
			foldBtn.Size = new Size(43, 15);
			foldBtn.TabIndex = 1;
			foldBtn.Text = "折叠";
			foldBtn.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
			foldBtn.Click += foldBtn_Click;
			// 
			// newSon
			// 
			newSon.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
			newSon.Location = new Point(106, 23);
			newSon.MinimumSize = new Size(1, 1);
			newSon.Name = "newSon";
			newSon.Size = new Size(43, 15);
			newSon.TabIndex = 2;
			newSon.Text = "新层";
			newSon.Click += newSon_Click;
			// 
			// DeleteSon
			// 
			DeleteSon.Font = new Font("微软雅黑", 8F, FontStyle.Regular, GraphicsUnit.Point);
			DeleteSon.Location = new Point(106, 44);
			DeleteSon.MinimumSize = new Size(1, 1);
			DeleteSon.Name = "DeleteSon";
			DeleteSon.Size = new Size(43, 15);
			DeleteSon.TabIndex = 3;
			DeleteSon.Text = "删层";
			DeleteSon.Click += DeleteSon_Click;
			// 
			// deleteBtn
			// 
			deleteBtn.FillColor = Color.Red;
			deleteBtn.Font = new Font("微软雅黑", 6F, FontStyle.Regular, GraphicsUnit.Point);
			deleteBtn.Location = new Point(85, 3);
			deleteBtn.MinimumSize = new Size(1, 1);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(15, 10);
			deleteBtn.Style = Sunny.UI.UIStyle.Custom;
			deleteBtn.TabIndex = 4;
			deleteBtn.Text = "X";
			deleteBtn.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
			deleteBtn.Click += deleteBtn_Click;
			// 
			// DesignerMeta
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(deleteBtn);
			Controls.Add(DeleteSon);
			Controls.Add(newSon);
			Controls.Add(foldBtn);
			Controls.Add(mainBtn);
			Name = "DesignerMeta";
			Size = new Size(152, 61);
			ResumeLayout(false);
		}

		#endregion

		private Sunny.UI.UIButton mainBtn;
		private Sunny.UI.UIButton foldBtn;
		private Sunny.UI.UIButton newSon;
		private Sunny.UI.UIButton DeleteSon;
		private Sunny.UI.UIButton deleteBtn;
	}
}
