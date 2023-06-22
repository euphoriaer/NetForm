namespace NetForm.Windows
{
	public partial class DesignerMeta : UserControl
	{
		public Action DeleteLayerClick;
		public Action MainBtnClick;
		public Action NewLayerClick;
		public Action ShowLayerClick;
		public Data.DesignerMeta meta;
		public DesignerMeta()
		{
			InitializeComponent();
		}

		public DesignerMeta(NetForm.Data.DesignerMeta meta)
		{
			InitializeComponent();
			this.meta = meta;
			mainBtn.Text = meta.Name;
			mainBtn.Click += MainBtn_Click;
			foldBtn.Click += FoldBtn_Click;
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (DeleteLayerClick != null)
			{
				DeleteLayerClick();
			}
		}

		private void DeleteSon_Click(object sender, EventArgs e)
		{
		}

		private void foldBtn_Click(object sender, EventArgs e)
		{
		}

		private void FoldBtn_Click(object? sender, EventArgs e)
		{
			if (ShowLayerClick != null)
			{
				ShowLayerClick();
			}
		}

		private void mainBtn_Click(object sender, EventArgs e)
		{
			MetaType metaType = new MetaType(meta);
			metaType.ShowDialog();
			if (metaType.DialogResult == DialogResult.OK)
			{
				mainBtn.Text = meta.Name;
				MessageBox.Show($"{meta.Name}");
			}
		}

		private void MainBtn_Click(object? sender, EventArgs e)
		{
			if (MainBtnClick != null)
			{
				MainBtnClick();
			}
		}

		private void newSon_Click(object sender, EventArgs e)
		{
			if (NewLayerClick != null)
			{
				NewLayerClick();
			}
		}
	}
}