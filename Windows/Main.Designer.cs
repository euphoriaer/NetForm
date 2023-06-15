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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			mainToolStrip = new ToolStrip();
			toolStripButton2 = new ToolStripButton();
			toolStripButton1 = new ToolStripButton();
			FormList = new Sunny.UI.UIListBox();
			FormDataGrid = new Sunny.UI.UIDataGridView();
			errorProvider1 = new ErrorProvider(components);
			mainToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)FormDataGrid).BeginInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// mainToolStrip
			// 
			mainToolStrip.Dock = DockStyle.Left;
			mainToolStrip.GripStyle = ToolStripGripStyle.Hidden;
			mainToolStrip.ImageScalingSize = new Size(32, 32);
			mainToolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton1 });
			mainToolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
			mainToolStrip.Location = new Point(0, 0);
			mainToolStrip.Name = "mainToolStrip";
			mainToolStrip.Size = new Size(61, 965);
			mainToolStrip.TabIndex = 1;
			mainToolStrip.Text = "toolStrip1";
			mainToolStrip.ItemClicked += toolStrip1_ItemClicked;
			// 
			// toolStripButton2
			// 
			toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
			toolStripButton2.ImageTransparentColor = Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new Size(58, 53);
			toolStripButton2.Text = "打开表";
			toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton2.Click += toolStripButton2_Click;
			// 
			// toolStripButton1
			// 
			toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(58, 53);
			toolStripButton1.Text = "创建新表";
			toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton1.Click += toolStripButton1_Click_1;
			// 
			// FormList
			// 
			FormList.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			FormList.HoverColor = Color.FromArgb(155, 200, 255);
			FormList.ItemSelectForeColor = Color.White;
			FormList.Location = new Point(77, 0);
			FormList.Margin = new Padding(4, 5, 4, 5);
			FormList.MinimumSize = new Size(1, 1);
			FormList.Name = "FormList";
			FormList.Padding = new Padding(2);
			FormList.ShowText = false;
			FormList.Size = new Size(256, 937);
			FormList.Style = Sunny.UI.UIStyle.Custom;
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
			FormDataGrid.Location = new Point(340, 0);
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
			FormDataGrid.Size = new Size(1313, 937);
			FormDataGrid.StripeOddColor = Color.FromArgb(235, 243, 255);
			FormDataGrid.Style = Sunny.UI.UIStyle.Custom;
			FormDataGrid.TabIndex = 3;
			FormDataGrid.CellContentClick += FormDataGrid_CellContentClick;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1700, 965);
			Controls.Add(FormDataGrid);
			Controls.Add(FormList);
			Controls.Add(mainToolStrip);
			Name = "Main";
			Text = "Main";
			Load += Main_Load;
			KeyDown += Main_KeyDown;
			MouseClick += Main_MouseClick;
			mainToolStrip.ResumeLayout(false);
			mainToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)FormDataGrid).EndInit();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ToolStripButton toolStripButton2;
		public ToolStrip mainToolStrip;
		private Sunny.UI.UIListBox FormList;
		private Sunny.UI.UIDataGridView FormDataGrid;
		private ToolStripButton toolStripButton1;
		private ErrorProvider errorProvider1;
	}
}