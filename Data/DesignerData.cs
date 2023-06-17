using LiteDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NetForm.Data
{
	public class DesignerData
	{
		[BsonId]
		public ObjectId CustomerId { get; set; }

		public DataSet Data { get; set; }

		public string Name { get; set; }

		public DesignerLayer Root { get; set; }

		
		public DesignerData()
		{
			
		}

		public void CreateLayer(string layerName)
		{
			DesignerLayer rootLayer = new DesignerLayer(this, layerName);
		}
	}

	

}
