using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Monitor.DataHelper
{
	public static class DataManager
	{
		public static int dataSaveMethod = 0;
		public static int DataSaveMethod {get; set; }
		public static void CreateOrGetRig(Objects.MiningRig rig)
		{
			switch(DataSaveMethod)
			{
				case 0:
					DataHelper.MySqlHelper.CreateOrGetRig(rig);
					break;
				case 1:
					DataHelper.SqliteHelper.CreateOrGetRig(rig);
					break;
			}
		}
		public static string CreateOrUpdateGraphicsCard(Objects.GraphicsCard cardInfo)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySqlHelper.CreateOrUpdateGraphicsCard(cardInfo);
					break;
				case 1:
					return DataHelper.SqliteHelper.CreateOrUpdateGraphicsCard(cardInfo);
			}
			return "";
		}
		public static void InsertGraphicsCardMetric(Objects.GraphicsCardMetrics metric)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySqlHelper.InsertGraphicsCardMetric(metric);
					break;
				case 1:
					DataHelper.SqliteHelper.InsertGraphicsCardMetric(metric);
					break;
			}
		}
		public static void InsertGraphicsWorkUnit(Objects.WorkUnit workUnit)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySqlHelper.InsertGraphicsWorkUnit(workUnit);
					break;
				case 1:
					DataHelper.SqliteHelper.InsertGraphicsWorkUnit(workUnit);
					break;
			}
		}
		public static float GetAlgoFloatMultiplierByName(string name)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySqlHelper.GetAlgoFloatMultiplierByName(name);
					break;
				case 1:
					return DataHelper.SqliteHelper.GetAlgoFloatMultiplierByName(name);
					break;
			}
			return 0;
		}
		public static void UpdateGraphicsCardFirendlyName(Objects.GraphicsCard card)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySqlHelper.UpdateGraphicsCardFirendlyName(card);
					break;
				case 1:
					DataHelper.SqliteHelper.UpdateGraphicsCardFirendlyName(card);
					break;
			}
		}
		public static int SaveExceptionLogAndReturnID(string ExceptionDetails, string ExceptionMethod)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySqlHelper.SaveExceptionLogAndReturnID(ExceptionDetails, ExceptionMethod);
					break;
				case 1:
					break;
			}
			return -1;
		}

		public static DataTable RunLiveStatsReport(string walletAddress, double Time)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySqlHelper.RunLiveStatsReport(walletAddress, Time);
					break;
				case 1:
					break;
			}
			return null;
		}
		public static DataTable RunLiveCardStatsReport(string walletAddress, double Time, bool UseFriendlyName)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySqlHelper.RunLiveCardStatsReport(walletAddress, Time, UseFriendlyName);
					break;
				case 1:
					break;
			}
			return null;
		}
		public static Objects.RigCurrencyPower GetRigCurrencyPowerCost(long RigID)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySqlHelper.GetRigCurrencyPowerCost(RigID);
					break;
				case 1:
					break;
			}
			return null;
		}
		public static List<Objects.Currency> GetCurrencies()
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySqlHelper.GetCurrencies();
					break;
				case 1:
					break;
			}
			return new List<Objects.Currency>();
		}
		public static void UpdateRigCurrencyPowerCost(long RigID, int CurrencyID, int BasePower, double PowerCost)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySqlHelper.UpdateRigCurrencyPowerCost(RigID, CurrencyID, BasePower, PowerCost);
					break;
				case 1:
					break;
			}
		}
		public static void SetMiningRigInactive(string SetMiningRigInactive)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySqlHelper.SetMiningRigInactive(SetMiningRigInactive);
					break;
				case 1:
					break;
			}
		}
	}
}
