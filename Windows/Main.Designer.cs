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
			mainToolStrip = new ToolStrip();
			toolStripButton2 = new ToolStripButton();
			toolStripButton1 = new ToolStripButton();
			FormList = new Sunny.UI.UIListBox();
			errorProvider1 = new ErrorProvider(components);
			binGrid1 = new Windows.BinGrid();
			mainToolStrip.SuspendLayout();
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
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// binGrid1
			// 
			binGrid1.Location = new Point(340, 12);
			binGrid1.Name = "binGrid1";
			binGrid1.Size = new Size(1348, 925);
			binGrid1.TabIndex = 3;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1700, 965);
			Controls.Add(binGrid1);
			Controls.Add(FormList);
			Controls.Add(mainToolStrip);
			Name = "Main";
			Text = "Main";
			Load += Main_Load;
			KeyDown += Main_KeyDown;
			MouseClick += Main_MouseClick;
			mainToolStrip.ResumeLayout(false);
			mainToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ToolStripButton toolStripButton2;
		public ToolStrip mainToolStrip;
		private Sunny.UI.UIListBox FormList;
		private ToolStripButton toolStripButton1;
		private ErrorProvider errorProvider1;
		private Windows.BinGrid binGrid1;
	}
}