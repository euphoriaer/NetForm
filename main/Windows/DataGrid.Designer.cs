namespace NetForm
{
	partial class DataGrid
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
			binGrid1 = new Windows.BinGrid();
			SuspendLayout();
			// 
			// binGrid1
			// 
			binGrid1.Location = new Point(1, 1);
			binGrid1.Name = "binGrid1";
			binGrid1.Size = new Size(1093, 640);
			binGrid1.TabIndex = 0;
			// 
			// DataGrid
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1095, 674);
			Controls.Add(binGrid1);
			Name = "DataGrid";
			Text = "DataGrid";
			Load += DataGrid_Load;
			ResumeLayout(false);
		}

		#endregion

		private Windows.BinGrid binGrid1;
	}
}