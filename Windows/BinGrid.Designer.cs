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
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			designerMetaBindingSource = new BindingSource(components);
			toolStrip1 = new ToolStrip();
			toolStripButton2 = new ToolStripButton();
			toolStripContainer1 = new ToolStripContainer();
			uiDataGridView1 = new Sunny.UI.UIDataGridView();
			contextMenu = new ContextMenuStrip(components);
			InputExcel = new ToolStripButton();
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
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, InputExcel });
			toolStrip1.Location = new Point(9, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(160, 72);
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
			dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
			uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			uiDataGridView1.BackgroundColor = Color.White;
			uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
			dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = Color.White;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = SystemColors.Window;
			dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
			uiDataGridView1.Dock = DockStyle.Fill;
			uiDataGridView1.EnableHeadersVisualStyles = false;
			uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
			uiDataGridView1.Location = new Point(0, 0);
			uiDataGridView1.Name = "uiDataGridView1";
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
			dataGridViewCellStyle9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
			dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
			dataGridViewCellStyle9.SelectionForeColor = Color.White;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			dataGridViewCellStyle10.BackColor = Color.White;
			dataGridViewCellStyle10.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
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
			// InputExcel
			// 
			InputExcel.Image = (Image)resources.GetObject("InputExcel.Image");
			InputExcel.ImageTransparentColor = Color.Magenta;
			InputExcel.Name = "InputExcel";
			InputExcel.Size = new Size(65, 69);
			InputExcel.Text = "导入Excel";
			InputExcel.TextImageRelation = TextImageRelation.ImageAboveText;
			InputExcel.Click += InputExcel_Click;
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
		private ToolStripButton InputExcel;
	}
}
