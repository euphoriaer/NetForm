using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetForm.Tools
{
	public static class ExcelExtension
	{
		public static int GetRealRowCount(this ExcelWorksheet? sheet)
		{
			int count = 1;
			var cell = sheet.Cells[count, 1];
			var value = cell?.Value?.ToString();
			while (!(string.IsNullOrEmpty(value)
				   || string.IsNullOrWhiteSpace(value)))
			{
				count++;
				cell = sheet.Cells[count, 1];
				value = cell?.Value?.ToString();
			}
			return count-1;
		}
	}
}
