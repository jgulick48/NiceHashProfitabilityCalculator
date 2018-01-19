using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Viewer.DataHelper
{
	public static class DataBaseHandler
	{
		public static int DataBaseMethod = 0;
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
					break;
			}
			return -1;
		}
		public static DataTable GetReports(int ReportType)
		{
			switch (DataBaseMethod)
			{
				case 0:
					return DataHelper.MySQLHandler.GetAvaialbleReports(ReportType);
					break;
				case 1:
					return null;
					break;
			}
			return new DataTable();
		}
		public static DataTable RunExportReport(string SprocName, string WalletAddress, double Start, double End, int resolution)
		{
			switch (DataBaseMethod)
			{
				case 0:
					return DataHelper.MySQLHandler.RunExportReport(SprocName, WalletAddress, Start, End, resolution);
					break;
				case 1:
					break;
			}
			return null;
		}
	}
}
