using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;


namespace NiceHashStatsViewer.DataHelper
{
	public static class SQLITEHandler
	{
		static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NHWM", "data", "database.sqlite");
		static bool initialized = false;
		public static void Intialize()
		{
			string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NHWM", "data");
			if (!File.Exists(path))
			{
			}
		}
		public static DataTable GetDataTableFromSQL(string sql)
		{
			SQLiteConnection m_cn = new SQLiteConnection(String.Format("Data Source={0};", path));
			SQLiteDataAdapter returnVal = new SQLiteDataAdapter(sql, m_cn);
			m_cn.Open();
			DataTable dt = new DataTable();
			returnVal.Fill(dt);
			m_cn.Close();
			return dt;
		}
	}
}
