namespace NetForm.Windows
{
	partial class SearchCombox
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
			uiComboBox1 = new Sunny.UI.UIComboBox();
			uiComboDataGridView1 = new Sunny.UI.UIComboDataGridView();
			uiComboTreeView1 = new Sunny.UI.UIComboTreeView();
			SuspendLayout();
			// 
			// uiComboBox1
			// 
			uiComboBox1.DataSource = null;
			uiComboBox1.FillColor = Color.White;
			uiComboBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiComboBox1.Location = new Point(14, 18);
			uiComboBox1.Margin = new Padding(4, 5, 4, 5);
			uiComboBox1.MinimumSize = new Size(63, 0);
			uiComboBox1.Name = "uiComboBox1";
			uiComboBox1.Padding = new Padding(0, 0, 30, 2);
			uiComboBox1.Size = new Size(150, 29);
			uiComboBox1.TabIndex = 0;
			uiComboBox1.Text = "uiComboBox1";
			uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
			uiComboBox1.Watermark = "";
			// 
			// uiComboDataGridView1
			// 
			uiComboDataGridView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
			uiComboDataGridView1.FillColor = Color.White;
			uiComboDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiComboDataGridView1.Location = new Point(14, 57);
			uiComboDataGridView1.Margin = new Padding(4, 5, 4, 5);
			uiComboDataGridView1.MinimumSize = new Size(63, 0);
			uiComboDataGridView1.Name = "uiComboDataGridView1";
			uiComboDataGridView1.Padding = new Padding(0, 0, 30, 2);
			uiComboDataGridView1.Size = new Size(226, 40);
			uiComboDataGridView1.TabIndex = 1;
			uiComboDataGridView1.Text = "uiComboDataGridView1";
			uiComboDataGridView1.TextAlignment = ContentAlignment.MiddleLeft;
			uiComboDataGridView1.Watermark = "";
			// 
			// uiComboTreeView1
			// 
			uiComboTreeView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
			uiComboTreeView1.FillColor = Color.White;
			uiComboTreeView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiComboTreeView1.Location = new Point(14, 107);
			uiComboTreeView1.Margin = new Padding(4, 5, 4, 5);
			uiComboTreeView1.MinimumSize = new Size(63, 0);
			uiComboTreeView1.Name = "uiComboTreeView1";
			uiComboTreeView1.Padding = new Padding(0, 0, 30, 2);
			uiComboTreeView1.Size = new Size(217, 37);
			uiComboTreeView1.TabIndex = 2;
			uiComboTreeView1.Text = "uiComboTreeView1";
			uiComboTreeView1.TextAlignment = ContentAlignment.MiddleLeft;
			uiComboTreeView1.Watermark = "";
			// 
			// SearchCombox
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(uiComboTreeView1);
			Controls.Add(uiComboDataGridView1);
			Controls.Add(uiComboBox1);
			Name = "SearchCombox";
			Size = new Size(305, 213);
			ResumeLayout(false);
		}

		#endregion

		private Sunny.UI.UIComboBox uiComboBox1;
		private Sunny.UI.UIComboDataGridView uiComboDataGridView1;
		private Sunny.UI.UIComboTreeView uiComboTreeView1;
	}
}
