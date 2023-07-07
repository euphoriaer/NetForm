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
		public SelectForm()
		{
			InitializeComponent();
		}
		public List<string> result = new List<string>();
		private void SelectForm_Load(object sender, EventArgs e)
		{
			//单选 多选
		}
	}
}
