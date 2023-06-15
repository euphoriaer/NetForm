
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
	public partial class DesignerMeta : UserControl
	{
		public DesignerMeta()
		{
			InitializeComponent();
		}

		public DesignerMeta(NetForm.Data.DesignerMeta meta)
		{
			InitializeComponent();
			mainBtn.Name= meta.Name;
		}

		private void foldBtn_Click(object sender, EventArgs e)
		{

		}

		private void newSon_Click(object sender, EventArgs e)
		{

		}

		private void DeleteSon_Click(object sender, EventArgs e)
		{

		}

		private void mainBtn_Click(object sender, EventArgs e)
		{

		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{

		}
	}
}
