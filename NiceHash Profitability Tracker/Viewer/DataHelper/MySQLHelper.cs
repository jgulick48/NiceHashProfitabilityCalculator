using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace Viewer.DataHelper
{
	public static class MySqlHandler
	{
		public static DataTable GetDataTableFromSQL(string sql)
		{
			MySqlConnection m_cn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NiceHashReader"].ToString());
			MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, m_cn);
			m_cn.Open();
			DataTable dt = new DataTable();
			returnVal.Fill(dt);
			m_cn.Close();
			return dt;
		}
		public static int SaveExceptionLogAndReturnID(string ExceptionDetails, string ExceptionMethod)
		{
			MySqlConnection m_cn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NiceHashStats"].ToString());
			MySqlCommand cmd = new MySqlCommand("createExceptionLog", m_cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("?E_TEXT", ExceptionDetails);
			cmd.Parameters["?E_TEXT"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?E_METHOD", ExceptionMethod);
			cmd.Parameters["?E_METHOD"].Direction = ParameterDirection.Input;
			cmd.Parameters.Add("?E_ID", MySqlDbType.Int16);
			cmd.Parameters["?E_ID"].Direction = ParameterDirection.Output;
			m_cn.Open();
			cmd.ExecuteNonQuery();
			m_cn.Close();

			return int.Parse(cmd.Parameters["?E_ID"].Value.ToString());

		}
		public static DataTable GetAvaialbleReports(int ReportType)
		{
			MySqlConnection m_cn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NiceHashStats"].ToString());
			MySqlDataAdapter cmd = new MySqlDataAdapter("getAvailableReports", m_cn);
			cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
			cmd.SelectCommand.Parameters.AddWithValue("?T_ID", ReportType);
			cmd.SelectCommand.Parameters["?T_ID"].Direction = ParameterDirection.Input;
			m_cn.Open();
			DataTable dt = new DataTable();
			cmd.Fill(dt);
			m_cn.Close();
			return dt;
		}
		public static DataTable RunExportReport(string SprocName, string WalletAddress, double Start, double End, int resolution)
		{
			MySqlConnection m_cn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NiceHashStats"].ToString());
			MySqlDataAdapter cmd = new MySqlDataAdapter(SprocName, m_cn);
			cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
			cmd.SelectCommand.Parameters.AddWithValue("?W_ADDR", WalletAddress);
			cmd.SelectCommand.Parameters["?W_ADDR"].Direction = ParameterDirection.Input;
			cmd.SelectCommand.Parameters.AddWithValue("?S_TIME", Start);
			cmd.SelectCommand.Parameters["?S_TIME"].Direction = ParameterDirection.Input;
			cmd.SelectCommand.Parameters.AddWithValue("?E_TIME", End);
			cmd.SelectCommand.Parameters["?E_TIME"].Direction = ParameterDirection.Input;
			cmd.SelectCommand.Parameters.AddWithValue("?INTERVAL", resolution);
			cmd.SelectCommand.Parameters["?INTERVAL"].Direction = ParameterDirection.Input;
			m_cn.Open();
			DataTable dt = new DataTable();
			cmd.Fill(dt);
			m_cn.Close();
			return dt;
		}
	}
}
