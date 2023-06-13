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
			newFormBtn = new Sunny.UI.UIButton();
			mainToolStrip = new ToolStrip();
			toolStripButton1 = new ToolStripButton();
			toolStripButton2 = new ToolStripButton();
			mainToolStrip.SuspendLayout();
			SuspendLayout();
			// 
			// newFormBtn
			// 
			newFormBtn.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			newFormBtn.Location = new Point(52, 0);
			newFormBtn.MinimumSize = new Size(1, 1);
			newFormBtn.Name = "newFormBtn";
			newFormBtn.Size = new Size(100, 35);
			newFormBtn.TabIndex = 0;
			newFormBtn.Text = "创建新表";
			newFormBtn.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1700, 965);
			Controls.Add(mainToolStrip);
			Controls.Add(newFormBtn);
			Name = "Main";
			Text = "Main";
			Load += Main_Load;
			KeyDown += Main_KeyDown;
			MouseClick += Main_MouseClick;
			mainToolStrip.ResumeLayout(false);
			mainToolStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Sunny.UI.UIButton newFormBtn;
		private ToolStripButton toolStripButton1;
		private ToolStripButton toolStripButton2;
		public ToolStrip mainToolStrip;
	}
}