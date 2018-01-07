using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace NiceHashStatsViewer.DataHelper
{
	public static class MySQLHandler
	{
		public static string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLHome"].ToString();
		public static DataTable GetDataTableFromSQL(string sql)
		{
			MySqlConnection m_cn = new MySqlConnection(connectionstring);
			MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, m_cn);
			m_cn.Open();
			DataTable dt = new DataTable();
			returnVal.Fill(dt);
			m_cn.Close();
			return dt;
		}
	}
}
