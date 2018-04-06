using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;


namespace Viewer.DataHelper
{
	public static class SqliteHandler
	{
		static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NHWM", "data", "database.sqlite");
		public static void Intialize()
		{
			
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
