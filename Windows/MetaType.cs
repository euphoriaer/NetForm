using NetForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignerMeta = NetForm.Data.DesignerMeta;

namespace NetForm.Windows
{
	public partial class MetaType : Form
	{
		public NetForm.Data.DesignerMeta meta;
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
						$"{NetForm.Data.DesignerMeta.ValueType.Int}",
						$"{NetForm.Data.DesignerMeta.ValueType.Float}",
						$"{NetForm.Data.DesignerMeta.ValueType.String}",
						$"{NetForm.Data.DesignerMeta.ValueType.Index}",
						$"{NetForm.Data.DesignerMeta.ValueType.Bool}"});

			uiTextBoxName.Text = meta.Name;
			uiTextBoxDes.Text=meta.Description;
			uiComboBoxType.SelectedIndex = (int)meta.Type;
			if (meta.Type == NetForm.Data.DesignerMeta.ValueType.Index)
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
			meta.Type = (NetForm.Data.DesignerMeta.ValueType)uiComboBoxType.SelectedIndex;
			if (meta.Type == NetForm.Data.DesignerMeta.ValueType.Index)
			{
				//todo 设置索引

			}
			this.DialogResult = DialogResult.OK;

		}
	}
}
