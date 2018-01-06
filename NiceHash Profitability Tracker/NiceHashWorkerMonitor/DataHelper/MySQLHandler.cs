using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace NiceHashWorkerMonitor.DataHelper
{
	public class MySQLHandler
	{
		static string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLHome"].ToString();
		public static void CreateOrGetRig(Objects.MiningRig rig)
		{
			MySqlConnection m_cn = new MySqlConnection(connectionstring);
			MySqlCommand cmd = new MySqlCommand("createOrGetMiningRig", m_cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("?Wallet_Address", rig.WalletAddress);
			cmd.Parameters["?Wallet_Address"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?Worker_Name", rig.WorkerName);
			cmd.Parameters["?Worker_Name"].Direction = ParameterDirection.Input;
			cmd.Parameters.Add("?Rig_ID", MySqlDbType.Int16);
			cmd.Parameters["?Rig_ID"].Direction = ParameterDirection.Output;
			m_cn.Open();
			cmd.ExecuteNonQuery();
			rig.ID = long.Parse(cmd.Parameters["?Rig_ID"].Value.ToString());
			m_cn.Close();
		}
		public static string CreateOrUpdateGraphicsCard(Objects.GraphicsCard cardInfo)
		{
			MySqlConnection m_cn = new MySqlConnection(connectionstring);
			MySqlCommand cmd = new MySqlCommand("createOrUpdateGraphicsCard", m_cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("?Rig_ID", cardInfo.RigID);
			cmd.Parameters["?Rig_ID"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?UU_ID", cardInfo.GUID);
			cmd.Parameters["?UU_ID"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?GC_NAME", cardInfo.DeviceName);
			cmd.Parameters["?GC_NAME"].Direction = ParameterDirection.Input;
			cmd.Parameters.Add("?F_NAME", MySqlDbType.VarChar);
			cmd.Parameters["?F_NAME"].Direction = ParameterDirection.Output;
			cmd.Parameters.AddWithValue("?D_ID", cardInfo.ID);
			cmd.Parameters["?D_ID"].Direction = ParameterDirection.Input;
			m_cn.Open();
			cmd.ExecuteNonQuery();
			m_cn.Close();
			return cmd.Parameters["?F_NAME"].Value.ToString();
		}
		public static void InsertGraphicsCardMetric(Objects.GraphicsCardMetrics metric)
		{
			MySqlConnection m_cn = new MySqlConnection(connectionstring);
			MySqlCommand cmd = new MySqlCommand("insertGraphicsCardStat", m_cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("?C_UUID", metric.card.GUID);
			cmd.Parameters["?C_UUID"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?T_RECORDED", metric.TimeRecorded);
			cmd.Parameters["?T_RECORDED"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?GC_TEMP", metric.Temprature);
			cmd.Parameters["?GC_TEMP"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?GC_POWER", metric.Power);
			cmd.Parameters["?GC_POWER"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?GC_USEAGE", metric.Power);
			cmd.Parameters["?GC_USEAGE"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?GC_FANSPEED", metric.FanSpeedPercent);
			cmd.Parameters["?GC_FANSPEED"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?GC_FANRPM", metric.FanSpeedRPM);
			cmd.Parameters["?GC_FANRPM"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?T_ELAPSED", metric.TimeElapsed);
			cmd.Parameters["?T_ELAPSED"].Direction = ParameterDirection.Input;
			m_cn.Open();
			cmd.ExecuteNonQuery();
			m_cn.Close();
		}
		public static void InsertGraphicsWorkUnit(Objects.WorkUnit workUnit)
		{
			try
			{
				MySqlConnection m_cn = new MySqlConnection(connectionstring);
				MySqlCommand cmd = new MySqlCommand("insertWorkUnitStat", m_cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("?G_UUID", workUnit.card.GUID);
				cmd.Parameters["?G_UUID"].Direction = ParameterDirection.Input;
				cmd.Parameters.AddWithValue("?A_ID", workUnit.algo.GetNiceHashID());
				cmd.Parameters["?A_ID"].Direction = ParameterDirection.Input;
				cmd.Parameters.AddWithValue("?T_RECORDED", workUnit.TimeRecorded);
				cmd.Parameters["?T_RECORDED"].Direction = ParameterDirection.Input;
				cmd.Parameters.AddWithValue("?H_SPEED", workUnit.speed);
				cmd.Parameters["?H_SPEED"].Direction = ParameterDirection.Input;
				cmd.Parameters.AddWithValue("?T_ELAPSED", workUnit.Time);
				cmd.Parameters["?T_ELAPSED"].Direction = ParameterDirection.Input;
				cmd.Parameters.AddWithValue("?E_PERCENT", workUnit.efficiency);
				cmd.Parameters["?E_PERCENT"].Direction = ParameterDirection.Input;
				cmd.Parameters.AddWithValue("?C_EARNINGS", workUnit.caclulatedEarnings);
				cmd.Parameters["?C_EARNINGS"].Direction = ParameterDirection.Input;
				m_cn.Open();
				cmd.ExecuteNonQuery();
				m_cn.Close();
			}
			catch(Exception ex)
			{

			}
		}
		public static float GetAlgoFloatMultiplierByName(string name)
		{
			MySqlConnection m_cn = new MySqlConnection(connectionstring);
			MySqlCommand cmd = new MySqlCommand("GetAlgoFloatMultiplierByName", m_cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("?A_NAME", name);
			cmd.Parameters["?A_NAME"].Direction = ParameterDirection.Input;
			cmd.Parameters.Add("?A_MULTIPLIER", MySqlDbType.Float);
			cmd.Parameters["?A_MULTIPLIER"].Direction = ParameterDirection.Output;
			m_cn.Open();
			cmd.ExecuteNonQuery();
			m_cn.Close();

			return float.Parse(cmd.Parameters["?A_MULTIPLIER"].Value.ToString());
		}
		public static void UpdateGraphicsCardFirendlyName(Objects.GraphicsCard card)
		{
			MySqlConnection m_cn = new MySqlConnection(connectionstring);
			MySqlCommand cmd = new MySqlCommand("UpdateGraphicsCardFirendlyName", m_cn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("?F_NAME", card.FriendlyName);
			cmd.Parameters["?F_NAME"].Direction = ParameterDirection.Input;
			cmd.Parameters.AddWithValue("?UU_ID", card.GUID);
			cmd.Parameters["?UU_ID"].Direction = ParameterDirection.Input;
			m_cn.Open();
			cmd.ExecuteNonQuery();
			m_cn.Close();
		}
	}
}
