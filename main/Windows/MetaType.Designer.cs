namespace NetForm.Windows
{
	partial class MetaType
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
			uiTextBoxName = new Sunny.UI.UITextBox();
			uiComboBoxType = new Sunny.UI.UIComboBox();
			uiTextBoxDes = new Sunny.UI.UITextBox();
			uiListBox1 = new Sunny.UI.UIListBox();
			uiListBox2 = new Sunny.UI.UIListBox();
			enterBtn = new Sunny.UI.UIButton();
			SuspendLayout();
			// 
			// uiTextBoxName
			// 
			uiTextBoxName.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiTextBoxName.Location = new Point(13, 14);
			uiTextBoxName.Margin = new Padding(4, 5, 4, 5);
			uiTextBoxName.MinimumSize = new Size(1, 16);
			uiTextBoxName.Name = "uiTextBoxName";
			uiTextBoxName.Padding = new Padding(5);
			uiTextBoxName.ShowText = false;
			uiTextBoxName.Size = new Size(150, 29);
			uiTextBoxName.TabIndex = 0;
			uiTextBoxName.Text = "Name";
			uiTextBoxName.TextAlignment = ContentAlignment.MiddleLeft;
			uiTextBoxName.Watermark = "";
			// 
			// uiComboBoxType
			// 
			uiComboBoxType.DataSource = null;
			uiComboBoxType.FillColor = Color.White;
			uiComboBoxType.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiComboBoxType.Location = new Point(13, 67);
			uiComboBoxType.Margin = new Padding(4, 5, 4, 5);
			uiComboBoxType.MinimumSize = new Size(63, 0);
			uiComboBoxType.Name = "uiComboBoxType";
			uiComboBoxType.Padding = new Padding(0, 0, 30, 2);
			uiComboBoxType.Size = new Size(150, 29);
			uiComboBoxType.TabIndex = 1;
			uiComboBoxType.Text = "Type";
			uiComboBoxType.TextAlignment = ContentAlignment.MiddleLeft;
			uiComboBoxType.Watermark = "";
			uiComboBoxType.SelectedIndexChanged += uiComboBoxType_SelectedIndexChanged;
			// 
			// uiTextBoxDes
			// 
			uiTextBoxDes.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiTextBoxDes.Location = new Point(13, 121);
			uiTextBoxDes.Margin = new Padding(4, 5, 4, 5);
			uiTextBoxDes.MinimumSize = new Size(1, 16);
			uiTextBoxDes.Name = "uiTextBoxDes";
			uiTextBoxDes.Padding = new Padding(5);
			uiTextBoxDes.ShowText = false;
			uiTextBoxDes.Size = new Size(150, 29);
			uiTextBoxDes.TabIndex = 2;
			uiTextBoxDes.Text = "Des";
			uiTextBoxDes.TextAlignment = ContentAlignment.MiddleLeft;
			uiTextBoxDes.Watermark = "";
			// 
			// uiListBox1
			// 
			uiListBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiListBox1.HoverColor = Color.FromArgb(155, 200, 255);
			uiListBox1.ItemSelectForeColor = Color.White;
			uiListBox1.Location = new Point(183, 14);
			uiListBox1.Margin = new Padding(4, 5, 4, 5);
			uiListBox1.MinimumSize = new Size(1, 1);
			uiListBox1.Name = "uiListBox1";
			uiListBox1.Padding = new Padding(2);
			uiListBox1.ShowText = false;
			uiListBox1.Size = new Size(270, 430);
			uiListBox1.Style = Sunny.UI.UIStyle.Custom;
			uiListBox1.TabIndex = 3;
			uiListBox1.Text = "uiListBox1";
			// 
			// uiListBox2
			// 
			uiListBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			uiListBox2.HoverColor = Color.FromArgb(155, 200, 255);
			uiListBox2.ItemSelectForeColor = Color.White;
			uiListBox2.Location = new Point(461, 14);
			uiListBox2.Margin = new Padding(4, 5, 4, 5);
			uiListBox2.MinimumSize = new Size(1, 1);
			uiListBox2.Name = "uiListBox2";
			uiListBox2.Padding = new Padding(2);
			uiListBox2.ShowText = false;
			uiListBox2.Size = new Size(270, 430);
			uiListBox2.Style = Sunny.UI.UIStyle.Custom;
			uiListBox2.TabIndex = 4;
			uiListBox2.Text = "uiListBox2";
			// 
			// enterBtn
			// 
			enterBtn.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
			enterBtn.Location = new Point(13, 403);
			enterBtn.MinimumSize = new Size(1, 1);
			enterBtn.Name = "enterBtn";
			enterBtn.Size = new Size(150, 35);
			enterBtn.TabIndex = 5;
			enterBtn.Text = "确定";
			enterBtn.Click += enterBtn_Click;
			// 
			// MetaType
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(enterBtn);
			Controls.Add(uiListBox2);
			Controls.Add(uiListBox1);
			Controls.Add(uiTextBoxDes);
			Controls.Add(uiComboBoxType);
			Controls.Add(uiTextBoxName);
			Name = "MetaType";
			Text = "MetaType";
			Load += MetaType_Load;
			ResumeLayout(false);
		}

		#endregion

		private Sunny.UI.UITextBox uiTextBoxName;
		private Sunny.UI.UIComboBox uiComboBoxType;
		private Sunny.UI.UITextBox uiTextBoxDes;
		private Sunny.UI.UIListBox uiListBox1;
		private Sunny.UI.UIListBox uiListBox2;
		private Sunny.UI.UIButton enterBtn;
	}
}