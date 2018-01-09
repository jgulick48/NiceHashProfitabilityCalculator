using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NiceHashStatsViewer.DataHelper
{
	public static class DataBaseHandler
	{
		public static int DataBaseMethod = 1;
		public static DataTable GetDataTableFromSQL(string sql)
		{
			switch(DataBaseMethod)
			{
				case 0:
					return DataHelper.MySQLHandler.GetDataTableFromSQL(sql);
					break;
				case 1:
					return DataHelper.SQLITEHandler.GetDataTableFromSQL(sql);
					break;
			}
			return new DataTable();
		}
		public static int SaveExceptionLogAndReturnID(string ExceptionDetails, string ExceptionMethod)
		{
			switch (DataBaseMethod)
			{
				case 0:
					return DataHelper.MySQLHandler.SaveExceptionLogAndReturnID(ExceptionDetails, ExceptionMethod);
					break;
				case 1:
                    return -1;
					break;
			}
			return -1;
		}
	}
}
