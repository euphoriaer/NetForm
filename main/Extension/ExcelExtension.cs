﻿using Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NetForm.Extension
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
			return count - 1;
		}

		public static bool IsMetaType(this object? value, DesignerMeta.ValueType checkType)
		{

			if (value is int)
			{
				if (checkType != DesignerMeta.ValueType.Int
					 && checkType != DesignerMeta.ValueType.String
					 && checkType != DesignerMeta.ValueType.Index
					)
				{
					return false;
				}
			}
			else if (value is double)
			{
				if (checkType != DesignerMeta.ValueType.Float
					 && checkType != DesignerMeta.ValueType.Int
					 && checkType != DesignerMeta.ValueType.String
					 && checkType != DesignerMeta.ValueType.Index
					)
				{
					return false;
				}
			}
			else if (value is bool)
			{
				if (checkType != DesignerMeta.ValueType.Bool
					)
				{
					return false;
				}
			}
			else if (value is string)
			{
				if (checkType != DesignerMeta.ValueType.String
					&& checkType != DesignerMeta.ValueType.Dictionary
					&& checkType != DesignerMeta.ValueType.Array
					&& checkType != DesignerMeta.ValueType.Index
					)
				{
					return false;
				}
			}

			return true;

		}
	}
}
