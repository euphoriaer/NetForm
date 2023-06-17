using LiteDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NetForm.Data
{
	public class DesignerData
	{
		[BsonId]
		public ObjectId CustomerId { get; set; }

		public DataSet Data { get; set; }=new DataSet();

		public string Name { get; set; } = "";

		public DesignerLayer Root { get; set; }

		
		public DesignerData()
		{
			
		}

		public DesignerLayer CreateRootLayer(string layerName,string DesignerName)
		{
			Data.DataSetName = DesignerName;
			Name = DesignerName;
			DesignerLayer Layer = new DesignerLayer(this, layerName);
			Root = Layer;
			return Layer;
		}
	}

	

}
