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
			get { return "����JSon"; }
			set { }
		}

		public void OutputFile(string FilePath, DesignerData data)
		{
			//����Json
			var metas= data.Root.metas;

		
		}
	}
}
