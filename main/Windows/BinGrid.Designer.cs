namespace NetForm.Windows
{
	partial class BinGrid
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinGrid));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			designerMetaBindingSource = new BindingSource(components);
			toolStrip1 = new ToolStrip();
			toolStripButton2 = new ToolStripButton();
			toolStripButton1 = new ToolStripButton();
			ExportExcel = new ToolStripSplitButton();
			常用路径ToolStripMenuItem = new ToolStripMenuItem();
			toolStripContainer1 = new ToolStripContainer();
			uiDataGridView1 = new Sunny.UI.UIDataGridView();
			contextMenu = new ContextMenuStrip(components);
			((System.ComponentModel.ISupportInitialize)designerMetaBindingSource).BeginInit();
			toolStrip1.SuspendLayout();
			toolStripContainer1.ContentPanel.SuspendLayout();
			toolStripContainer1.TopToolStripPanel.SuspendLayout();
			toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
			SuspendLayout();
			// 
			// designerMetaBindingSource
			// 
			designerMetaBindingSource.DataSource = typeof(Data.DesignerMeta);
			// 
			// toolStrip1
			// 
			toolStrip1.Dock = DockStyle.None;
			toolStrip1.ImageScalingSize = new Size(48, 48);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton1, ExportExcel });
			toolStrip1.Location = new Point(3, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(237, 72);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton2
			// 
			toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
			toolStripButton2.ImageTransparentColor = Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new Size(52, 69);
			toolStripButton2.Text = "保存";
			toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton2.ToolTipText = "保存";
			toolStripButton2.Click += toolStripButton2_Click;
			// 
			// toolStripButton1
			// 
			toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(65, 69);
			toolStripButton1.Text = "导入Excel";
			toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton1.Click += toolStripButton1_Click_1;
			// 
			// ExportExcel
			// 
			ExportExcel.DropDownItems.AddRange(new ToolStripItem[] { 常用路径ToolStripMenuItem });
			ExportExcel.Image = (Image)resources.GetObject("ExportExcel.Image");
			ExportExcel.ImageTransparentColor = Color.Magenta;
			ExportExcel.Name = "ExportExcel";
			ExportExcel.Size = new Size(77, 69);
			ExportExcel.Text = "导出Excel";
			ExportExcel.TextImageRelation = TextImageRelation.ImageAboveText;
			ExportExcel.ButtonClick += ExportExcel_ButtonClick;
			ExportExcel.Click += InputExcel_Click;
			// 
			// 常用路径ToolStripMenuItem
			// 
			常用路径ToolStripMenuItem.Name = "常用路径ToolStripMenuItem";
			常用路径ToolStripMenuItem.Size = new Size(180, 22);
			常用路径ToolStripMenuItem.Text = "常用路径";
			常用路径ToolStripMenuItem.Click += 常用路径ToolStripMenuItem_Click;
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			toolStripContainer1.ContentPanel.AutoScroll = true;
			toolStripContainer1.ContentPanel.Controls.Add(uiDataGridView1);
			toolStripContainer1.ContentPanel.Size = new Size(1292, 804);
			toolStripContainer1.Dock = DockStyle.Fill;
			toolStripContainer1.Location = new Point(0, 0);
			toolStripContainer1.Name = "toolStripContainer1";
			toolStripContainer1.Size = new Size(1292, 876);
			toolStripContainer1.TabIndex = 2;
			toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
			toolStripContainer1.TopToolStripPanel.Click += toolStripContainer1_TopToolStripPanel_Click;
			// 
			// uiDataGridView1
			// 
			uiDataGridView1.AllowDrop = true;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
			uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			uiDataGridView1.BackgroundColor = Color.White;
			uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
			dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			uiDataGridView1.Dock = DockStyle.Fill;
			uiDataGridView1.EnableHeadersVisualStyles = false;
			uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
			uiDataGridView1.Location = new Point(0, 0);
			uiDataGridView1.Name = "uiDataGridView1";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
			dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
			dataGridViewCellStyle4.SelectionForeColor = Color.White;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.BackColor = Color.White;
			dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
			uiDataGridView1.RowTemplate.Height = 25;
			uiDataGridView1.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
			uiDataGridView1.SelectedIndex = -1;
			uiDataGridView1.Size = new Size(1292, 804);
			uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
			uiDataGridView1.Style = Sunny.UI.UIStyle.Custom;
			uiDataGridView1.TabIndex = 0;
			uiDataGridView1.CellContentClick += uiDataGridView1_CellContentClick;
			// 
			// contextMenu
			// 
			contextMenu.Name = "contextMenu";
			contextMenu.Size = new Size(61, 4);
			// 
			// BinGrid
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(toolStripContainer1);
			Name = "BinGrid";
			Size = new Size(1292, 876);
			((System.ComponentModel.ISupportInitialize)designerMetaBindingSource).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			toolStripContainer1.ContentPanel.ResumeLayout(false);
			toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			toolStripContainer1.TopToolStripPanel.PerformLayout();
			toolStripContainer1.ResumeLayout(false);
			toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private BindingSource designerMetaBindingSource;
		private ToolStrip toolStrip1;
		private ToolStripContainer toolStripContainer1;
		private Sunny.UI.UIDataGridView uiDataGridView1;
		private ToolStripButton toolStripButton2;
		private ContextMenuStrip contextMenu;
		private ToolStripButton toolStripButton1;
		private ToolStripSplitButton ExportExcel;
		private ToolStripMenuItem 常用路径ToolStripMenuItem;
	}
}
