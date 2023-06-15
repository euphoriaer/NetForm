namespace NetForm
{
	partial class Designer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Designer));
			toolStripButton3 = new ToolStripButton();
			toolStrip1 = new ToolStrip();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStripButton3
			// 
			toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
			toolStripButton3.ImageTransparentColor = Color.Magenta;
			toolStripButton3.Name = "toolStripButton3";
			toolStripButton3.Size = new Size(36, 53);
			toolStripButton3.Text = "保存";
			toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton3.ToolTipText = "保存";
			toolStripButton3.Click += toolStripButton3_Click;
			// 
			// toolStrip1
			// 
			toolStrip1.BackColor = SystemColors.ButtonShadow;
			toolStrip1.GripMargin = new Padding(6);
			toolStrip1.ImageScalingSize = new Size(32, 32);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton3 });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1659, 56);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// Designer
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			AutoSize = true;
			ClientSize = new Size(1659, 854);
			Controls.Add(toolStrip1);
			Name = "Designer";
			Text = "Designer";
			Load += Designer_Load;
			KeyPress += Designer_KeyPress;
			MouseDown += Designer_MouseDown;
			MouseMove += Designer_MouseMove;
			MouseUp += Designer_MouseUp;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ToolStripButton toolStripButton3;
		private ToolStrip toolStrip1;
	}
}