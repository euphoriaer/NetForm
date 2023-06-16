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
			dataGridView1 = new DataGridView();
			tableLayoutPanel1 = new TableLayoutPanel();
			designerMetaBindingSource = new BindingSource(components);
			nameDataGridViewTextBoxColumn = new DataGridViewButtonColumn();
			descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			sonDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)designerMetaBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, sonDataGridViewTextBoxColumn });
			dataGridView1.DataSource = designerMetaBindingSource;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(3, 43);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(1280, 824);
			dataGridView1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(1286, 870);
			tableLayoutPanel1.TabIndex = 1;
			tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
			// 
			// designerMetaBindingSource
			// 
			designerMetaBindingSource.DataSource = typeof(Data.DesignerMeta);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			nameDataGridViewTextBoxColumn.HeaderText = "Name";
			nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			nameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
			nameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// typeDataGridViewTextBoxColumn
			// 
			typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			typeDataGridViewTextBoxColumn.HeaderText = "Type";
			typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			// 
			// sonDataGridViewTextBoxColumn
			// 
			sonDataGridViewTextBoxColumn.DataPropertyName = "Son";
			sonDataGridViewTextBoxColumn.HeaderText = "Son";
			sonDataGridViewTextBoxColumn.Name = "sonDataGridViewTextBoxColumn";
			sonDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
			sonDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// BinGrid
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Name = "BinGrid";
			Size = new Size(1292, 876);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)designerMetaBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private TableLayoutPanel tableLayoutPanel1;
		private DataGridViewButtonColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private DataGridViewComboBoxColumn sonDataGridViewTextBoxColumn;
		private BindingSource designerMetaBindingSource;
	}
}
