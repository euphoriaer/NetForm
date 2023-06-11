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
			newFormBtn = new Sunny.UI.UIButton();
			SuspendLayout();
			// 
			// newFormBtn
			// 
			newFormBtn.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			newFormBtn.Location = new Point(12, 12);
			newFormBtn.MinimumSize = new Size(1, 1);
			newFormBtn.Name = "newFormBtn";
			newFormBtn.Size = new Size(100, 35);
			newFormBtn.TabIndex = 0;
			newFormBtn.Text = "创建新表";
			newFormBtn.Click += CreateForm_Click;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1700, 965);
			Controls.Add(newFormBtn);
			Name = "Main";
			Text = "Main";
			ResumeLayout(false);
		}

		#endregion

		private Sunny.UI.UIButton newFormBtn;
	}
}