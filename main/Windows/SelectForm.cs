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
			Multiple, Single,Null
		}
		public SelectForm()
		{
			InitializeComponent();
		}

		public SelectForm(SelectMode selectMode, ref Data.DesignerMeta meta,ref Data.DesignerData data)
		{
			InitializeComponent();
			var layer = meta.Son;
			//行列填充
			SelectGrid.Init(ref layer, ref data,selectMode);

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
	}
}
