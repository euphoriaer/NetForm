namespace NetForm.Windows
{
	partial class SelectForm
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
			SelectGrid = new BinGrid();
			SuspendLayout();
			// 
			// SelectGrid
			// 
			SelectGrid.Location = new Point(12, 12);
			SelectGrid.Name = "SelectGrid";
			SelectGrid.Size = new Size(1036, 604);
			SelectGrid.TabIndex = 0;
			SelectGrid.Load += SelectGrid_Load;
			// 
			// SelectForm
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1060, 628);
			Controls.Add(SelectGrid);
			Name = "SelectForm";
			Text = "SelectForm";
			Load += SelectForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private BinGrid SelectGrid;
	}
}