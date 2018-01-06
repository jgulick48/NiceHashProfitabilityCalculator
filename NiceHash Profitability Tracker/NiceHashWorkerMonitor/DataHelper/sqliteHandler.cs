using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

using System.IO;

namespace NiceHashWorkerMonitor.DataHelper
{
	public static class sqliteHandler
	{
		static string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLHome"].ToString();
		static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NHWM", "data", "database.sqlite");
		static bool initialized = false;
		public static void Intialize()
		{
			string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NHWM", "data");
			if (!File.Exists(path))
			{
				if(!Directory.Exists(directory))
				{
					Directory.CreateDirectory(directory);
				}
				File.Copy("Data\\Nicehash.sqlite", path);
			}
		}
		public static void ProcessSQLNonQuery(string sql)
		{
			SQLiteConnection m_dbConnection = new SQLiteConnection(String.Format("Data Source={0};", path));
			m_dbConnection.Open();
			SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();
			m_dbConnection.Close();

		}

		private static string GetSingleValue(string TableName, string ColumnName, string WhereClause)
		{
			string sql = String.Format("select {0} from {1} {2} limit (1);", ColumnName, TableName, WhereClause);
			SQLiteConnection m_dbConnection = new SQLiteConnection(String.Format("Data Source={0};", path));
			SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
			m_dbConnection.Open();
			SQLiteDataReader reader = command.ExecuteReader();
			string value = "";
			if(!reader.HasRows)
			{
				return null;
			}
			while (reader.Read())
			{
				if (!string.IsNullOrEmpty(reader[ColumnName].ToString()))
				{
					value = reader[ColumnName].ToString();
				}
			}
			m_dbConnection.Close();
			return value;
		}
		private static int GetNextID(string TableName, string ColumnName)
		{
			string sql = String.Format("select MAX({0}) from {1};",ColumnName, TableName);
			SQLiteConnection m_dbConnection = new SQLiteConnection(String.Format("Data Source={0};", path));
			SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
			m_dbConnection.Open();
			SQLiteDataReader reader = command.ExecuteReader();
			int NewID = 0;
			while (reader.Read())
			{
				if (!string.IsNullOrEmpty(reader[String.Format("MAX({0})", ColumnName)].ToString()))
				{
					NewID = int.Parse(reader[String.Format("MAX({0})", ColumnName)].ToString());
				}
			}
			m_dbConnection.Close();
			return NewID+1;
		}
		private static bool HasRows(string sql)
		{
			bool hasRows;
			SQLiteConnection m_dbConnection = new SQLiteConnection(String.Format("Data Source={0};", path));
			SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
			m_dbConnection.Open();
			SQLiteDataReader reader = command.ExecuteReader();
			hasRows = reader.HasRows;
			m_dbConnection.Close();
			return hasRows;
		}
		public static void CreateOrGetRig(Objects.MiningRig rig)
		{
			if(!initialized)
			{
				Intialize();
			}
			string sql = string.Format("select MiningRigID from MiningRig Where WalletAddress = '{0}' and WorkerName = '{1}';", rig.WalletAddress, rig.WorkerName);
			SQLiteConnection m_dbConnection = new SQLiteConnection(String.Format("Data Source={0};", path));
			SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
			m_dbConnection.Open();
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				rig.ID = int.Parse(reader["MiningRigID"].ToString());
			}
			m_dbConnection.Close();
			if(rig.ID == 0)
			{
				rig.ID = GetNextID("MiningRigID","MiningRig");
				sql = string.Format("insert into MiningRig (WalletAddress, WorkerName, MiningRigID) values ('{0}','{1}',{2})", rig.WalletAddress, rig.WorkerName, rig.ID);
				ProcessSQLNonQuery(sql);

			}
		}

		public static string CreateOrUpdateGraphicsCard(Objects.GraphicsCard cardInfo)
		{
			string sql;
			string FriendlyName = GetSingleValue("GraphicsCard", "FriendlyName", String.Format("Where uuid = '{0}'", cardInfo.GUID));
			if(FriendlyName == null)
			{
				sql = string.Format("insert into GraphicsCard (uuid, RigID, Name, DeviceID) Values('{0}',{1},'{2}',{3})",cardInfo.GUID, cardInfo.RigID, cardInfo.DeviceName, cardInfo.ID);
			}
			else
			{
				sql = string.Format("update GraphicsCard set RigID = {0}, Name = '{1}',DeviceID = {2} where uuid = '{3}'", cardInfo.RigID, cardInfo.DeviceName, cardInfo.ID, cardInfo.GUID);
			}
			ProcessSQLNonQuery(sql);
			return FriendlyName;
		}

		public static void InsertGraphicsCardMetric(Objects.GraphicsCardMetrics metric)
		{
			string sql = String.Format("insert into CardStats (CardUUID,Time,Temp,GPUUsage,Power,FanSpeedPercent,FanSpeedRPM,TimeRecorded)" +
				"values ('{0}',{1},{2},{3},{4},{5},{6},{7})", metric.card.GUID, metric.TimeElapsed,metric.Temprature, metric.GPUUsage, metric.Power, metric.FanSpeedPercent, metric.FanSpeedRPM, metric.TimeRecorded);
			ProcessSQLNonQuery(sql);
		}
		public static void InsertGraphicsWorkUnit(Objects.WorkUnit workUnit)
		{
			string sql = String.Format("insert into WorkUnit (CardUUID,AlgoID,Speed,Time,Efficiency,CalculatedEarnings,TimeRecorded,WorkUnitID)" +
				"values ('{0}',{1},{2},{3},{4},{5},{6},{7})", workUnit.card.GUID, workUnit.algo.GetNiceHashID(),workUnit.speed, workUnit.Time, workUnit.efficiency, workUnit.caclulatedEarnings,workUnit.TimeRecorded,GetNextID("WorkUnit","WorkUnitID"));
			ProcessSQLNonQuery(sql);
		}
		public static float GetAlgoFloatMultiplierByName(string name)
		{
			return float.Parse(GetSingleValue("Algorithm","HashMultiplier",string.Format("Where Name = '{0}'", name)));
		}
		public static void UpdateGraphicsCardFirendlyName(Objects.GraphicsCard card)
		{
			string sql = String.Format("Update GraphicsCard set FriendlyName = '{0}' where uuid = '{1}'", card.FriendlyName, card.GUID);
			ProcessSQLNonQuery(sql);
		}
	}
}
