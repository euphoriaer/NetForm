using System;
using Data;
using InterfacePlugIn;
using Newtonsoft.Json;

namespace ExportJson
{
	public class ExportJson : Export
	{
		public string Name
		{
			get { return "导出JSon"; }
			set { }
		}

		public void OutputFile(string FilePath, DesignerData data)
		{
			//导出Json
			var metas= data.Root.metas;

		
		}
	}
}
