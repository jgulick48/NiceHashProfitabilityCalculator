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
		public static int DataSaveMethod = 0;
		public static void CreateOrGetRig(Objects.MiningRig rig)
		{
			switch(DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHelper.CreateOrGetRig(rig);
					break;
				case 1:
					DataHelper.sqliteHelper.CreateOrGetRig(rig);
					break;
			}
		}
		public static string CreateOrUpdateGraphicsCard(Objects.GraphicsCard cardInfo)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySQLHelper.CreateOrUpdateGraphicsCard(cardInfo);
					break;
				case 1:
					return DataHelper.sqliteHelper.CreateOrUpdateGraphicsCard(cardInfo);
			}
			return "";
		}
		public static void InsertGraphicsCardMetric(Objects.GraphicsCardMetrics metric)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHelper.InsertGraphicsCardMetric(metric);
					break;
				case 1:
					DataHelper.sqliteHelper.InsertGraphicsCardMetric(metric);
					break;
			}
		}
		public static void InsertGraphicsWorkUnit(Objects.WorkUnit workUnit)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHelper.InsertGraphicsWorkUnit(workUnit);
					break;
				case 1:
					DataHelper.sqliteHelper.InsertGraphicsWorkUnit(workUnit);
					break;
			}
		}
		public static float GetAlgoFloatMultiplierByName(string name)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySQLHelper.GetAlgoFloatMultiplierByName(name);
					break;
				case 1:
					return DataHelper.sqliteHelper.GetAlgoFloatMultiplierByName(name);
					break;
			}
			return 0;
		}
		public static void UpdateGraphicsCardFirendlyName(Objects.GraphicsCard card)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHelper.UpdateGraphicsCardFirendlyName(card);
					break;
				case 1:
					DataHelper.sqliteHelper.UpdateGraphicsCardFirendlyName(card);
					break;
			}
		}
		public static int SaveExceptionLogAndReturnID(string ExceptionDetails, string ExceptionMethod)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySQLHelper.SaveExceptionLogAndReturnID(ExceptionDetails, ExceptionMethod);
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
					return DataHelper.MySQLHelper.RunLiveStatsReport(walletAddress, Time);
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
					return DataHelper.MySQLHelper.RunLiveCardStatsReport(walletAddress, Time, UseFriendlyName);
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
					return DataHelper.MySQLHelper.GetRigCurrencyPowerCost(RigID);
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
					return DataHelper.MySQLHelper.GetCurrencies();
					break;
				case 1:
					break;
			}
			return null;
		}
		public static void UpdateRigCurrencyPowerCost(long RigID, int CurrencyID, int BasePower, double PowerCost)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHelper.UpdateRigCurrencyPowerCost(RigID, CurrencyID, BasePower, PowerCost);
					break;
				case 1:
					break;
			}
		}
	}
}
