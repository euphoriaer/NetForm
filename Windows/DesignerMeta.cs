﻿namespace NetForm.Windows
{
	public partial class DesignerMeta : UserControl
	{
		public Action DeleteLayerClick;
		public Action MainBtnClick;
		public Action NewLayerClick;
		public Action ShowLayerClick;

		public DesignerMeta()
		{
			InitializeComponent();
		}

		public DesignerMeta(NetForm.Data.DesignerMeta meta)
		{
			InitializeComponent();
			mainBtn.Name = meta.Name;
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