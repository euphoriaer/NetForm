namespace NetForm
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			newFormBtn = new Sunny.UI.UIButton();
			mainToolStrip = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			toolStripButton2 = new ToolStripButton();
			FormList = new Sunny.UI.UIListBox();
			FormDataGrid = new Sunny.UI.UIDataGridView();
			mainToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)FormDataGrid).BeginInit();
			SuspendLayout();
			// 
			// newFormBtn
			// 
			newFormBtn.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			newFormBtn.Location = new Point(52, 12);
			newFormBtn.MinimumSize = new Size(1, 1);
			newFormBtn.Name = "newFormBtn";
			newFormBtn.Size = new Size(100, 35);
			newFormBtn.TabIndex = 0;
			newFormBtn.Text = "创建新表";
			newFormBtn.Click += CreateForm_Click;
			// 
			// mainToolStrip
			// 
			mainToolStrip.Dock = DockStyle.Left;
			mainToolStrip.GripStyle = ToolStripGripStyle.Hidden;
			mainToolStrip.ImageScalingSize = new Size(32, 32);
			mainToolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
			mainToolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
			mainToolStrip.Location = new Point(0, 0);
			mainToolStrip.Name = "mainToolStrip";
			mainToolStrip.Size = new Size(49, 965);
			mainToolStrip.TabIndex = 1;
			mainToolStrip.Text = "toolStrip1";
			mainToolStrip.ItemClicked += toolStrip1_ItemClicked;
			// 
			// toolStripButton1
			// 
			toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(46, 53);
			toolStripButton1.Text = "初始化";
			toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton1.ToolTipText = "初始化数据库";
			toolStripButton1.Click += toolStripButton1_Click;
			// 
			// toolStripButton2
			// 
			toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
			toolStripButton2.ImageTransparentColor = Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new Size(46, 36);
			toolStripButton2.Text = "toolStripButton2";
			toolStripButton2.Click += toolStripButton2_Click;
			// 
			// FormList
			// 
			FormList.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			FormList.HoverColor = Color.FromArgb(155, 200, 255);
			FormList.ItemSelectForeColor = Color.White;
			FormList.Location = new Point(159, 14);
			FormList.Margin = new Padding(4, 5, 4, 5);
			FormList.MinimumSize = new Size(1, 1);
			FormList.Name = "FormList";
			FormList.Padding = new Padding(2);
			FormList.ShowText = false;
			FormList.Size = new Size(305, 937);
			FormList.TabIndex = 2;
			FormList.Text = "uiListBox1";
			// 
			// FormDataGrid
			// 
			dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
			FormDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			FormDataGrid.BackgroundColor = Color.White;
			FormDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
			dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			FormDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			FormDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			FormDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
			FormDataGrid.EnableHeadersVisualStyles = false;
			FormDataGrid.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			FormDataGrid.GridColor = Color.FromArgb(80, 160, 255);
			FormDataGrid.Location = new Point(471, 14);
			FormDataGrid.Name = "FormDataGrid";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
			dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
			dataGridViewCellStyle4.SelectionForeColor = Color.White;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			FormDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.BackColor = Color.White;
			dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			FormDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
			FormDataGrid.RowTemplate.Height = 25;
			FormDataGrid.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
			FormDataGrid.SelectedIndex = -1;
			FormDataGrid.Size = new Size(1217, 937);
			FormDataGrid.StripeOddColor = Color.FromArgb(235, 243, 255);
			FormDataGrid.TabIndex = 3;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1700, 965);
			Controls.Add(FormDataGrid);
			Controls.Add(FormList);
			Controls.Add(mainToolStrip);
			Controls.Add(newFormBtn);
			Name = "Main";
			Text = "Main";
			Load += Main_Load;
			KeyDown += Main_KeyDown;
			MouseClick += Main_MouseClick;
			mainToolStrip.ResumeLayout(false);
			mainToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)FormDataGrid).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Sunny.UI.UIButton newFormBtn;
		private ToolStripButton toolStripButton1;
		private ToolStripButton toolStripButton2;
		public ToolStrip mainToolStrip;
		private Sunny.UI.UIListBox FormList;
		private Sunny.UI.UIDataGridView FormDataGrid;
	}
}