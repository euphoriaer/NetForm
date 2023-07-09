using NetForm.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetForm.Windows
{
	public partial class SelectForm : Form
	{
		public string selectValues = "Null";
		public enum SelectMode
		{
			Multiple, Single, Null
		}
		public SelectForm()
		{
			InitializeComponent();
		}

		public SelectForm(SelectMode selectMode, ref Data.DesignerMeta meta, ref Data.DesignerData data)
		{
			InitializeComponent();
			var layer = meta.Son;
			//行列填充
			SelectGrid.Init(ref layer, ref data, selectMode);

		}

		public List<string> result = new List<string>();
		private void SelectForm_Load(object sender, EventArgs e)
		{
			//单选 多选
		}

		private void SelectGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void SelectGrid_Load(object sender, EventArgs e)
		{

		}

		private void OkBtn_Click(object sender, EventArgs e)
		{
			//将选择的check box 合并
			var grid = SelectGrid.uiDataGridView1;
			List<string> result = new List<string>();
			for (int i = 0; i < grid.RowCount; i++)
			{
				bool isCheck = false;
				if (grid.Rows[i].Cells[0].Value == null)
				{
					continue;
				}
				try
				{
					isCheck = (bool)grid.Rows[i].Cells[0].Value;
				}
				catch (Exception)
				{

					continue;
				}
				
				if (isCheck == true)
				{
					var checkValue = grid.Rows[i].Cells[1].Value.ToString();
					result.Add(checkValue);
				}
			}
			var reFinValue = string.Join(",", result);
			selectValues = reFinValue;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void ShowAll_Click(object sender, EventArgs e)
		{
			//todo 只显示选择，显示所有
		}
	}
}
