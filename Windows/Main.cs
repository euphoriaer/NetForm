using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetForm
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

		}

		private void CreateForm_Click(object sender, EventArgs e)
		{
			var des= new Designer();
			des.ShowDialog();
		}
	}
}
