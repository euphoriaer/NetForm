using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignerMeta = Data.DesignerMeta;

namespace NetForm.Windows
{
	public partial class MetaType : Form
	{
		public Data.DesignerMeta meta;
		public MetaType()
		{
			InitializeComponent();

		}
		public MetaType(Data.DesignerMeta data)
		{
			InitializeComponent();
			meta = data;

			uiComboBoxType.Items.AddRange(new object[]
					{
						$"{Data.DesignerMeta.ValueType.Int}",
						$"{Data.DesignerMeta.ValueType.Float}",
						$"{Data.DesignerMeta.ValueType.String}",
						$"{Data.DesignerMeta.ValueType.Index}",
						$"{Data.DesignerMeta.ValueType.Bool}"});

			uiTextBoxName.Text = meta.Name;
			uiTextBoxDes.Text=meta.Description;
			uiComboBoxType.SelectedIndex = (int)meta.Type;
			if (meta.Type == Data.DesignerMeta.ValueType.Index)
			{
				//todo 设置索引选中

			}
		}

		private void MetaType_Load(object sender, EventArgs e)
		{

		}

		private void enterBtn_Click(object sender, EventArgs e)
		{
			if (meta == null)
			{
				this.DialogResult = DialogResult.No;
				return;
			}
			meta.Name = uiTextBoxName.Text;
			meta.Description = uiTextBoxDes.Text;
			meta.Type = (Data.DesignerMeta.ValueType)uiComboBoxType.SelectedIndex;
			if (meta.Type == Data.DesignerMeta.ValueType.Index)
			{
				//todo 设置索引

			}
			this.DialogResult = DialogResult.OK;

		}
	}
}
