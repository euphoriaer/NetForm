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
			OkBtn = new Sunny.UI.UIButton();
			ShowAll = new Sunny.UI.UIButton();
			SuspendLayout();
			// 
			// SelectGrid
			// 
			SelectGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			SelectGrid.Location = new Point(113, 2);
			SelectGrid.Name = "SelectGrid";
			SelectGrid.Size = new Size(943, 622);
			SelectGrid.TabIndex = 0;
			SelectGrid.Load += SelectGrid_Load;
			// 
			// OkBtn
			// 
			OkBtn.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			OkBtn.Location = new Point(7, 12);
			OkBtn.MinimumSize = new Size(1, 1);
			OkBtn.Name = "OkBtn";
			OkBtn.Size = new Size(100, 35);
			OkBtn.TabIndex = 1;
			OkBtn.Text = "确定";
			OkBtn.Click += OkBtn_Click;
			// 
			// ShowAll
			// 
			ShowAll.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			ShowAll.Location = new Point(7, 53);
			ShowAll.MinimumSize = new Size(1, 1);
			ShowAll.Name = "ShowAll";
			ShowAll.Size = new Size(100, 35);
			ShowAll.TabIndex = 2;
			ShowAll.Text = "只显示选择";
			ShowAll.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
			ShowAll.Click += ShowAll_Click;
			// 
			// SelectForm
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1060, 628);
			Controls.Add(ShowAll);
			Controls.Add(OkBtn);
			Controls.Add(SelectGrid);
			Name = "SelectForm";
			Text = "SelectForm";
			Load += SelectForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private BinGrid SelectGrid;
		private Sunny.UI.UIButton OkBtn;
		private Sunny.UI.UIButton ShowAll;
	}
}