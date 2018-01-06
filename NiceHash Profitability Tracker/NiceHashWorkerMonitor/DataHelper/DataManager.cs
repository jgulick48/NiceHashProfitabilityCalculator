using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashWorkerMonitor.DataHelper
{
	public static class DataManager
	{
		public static int DataSaveMethod = 1;
		public static void CreateOrGetRig(Objects.MiningRig rig)
		{
			switch(DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHandler.CreateOrGetRig(rig);
					break;
				case 1:
					DataHelper.sqliteHandler.CreateOrGetRig(rig);
					break;
			}
		}
		public static string CreateOrUpdateGraphicsCard(Objects.GraphicsCard cardInfo)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySQLHandler.CreateOrUpdateGraphicsCard(cardInfo);
					break;
				case 1:
					return DataHelper.sqliteHandler.CreateOrUpdateGraphicsCard(cardInfo);
			}
			return "";
		}
		public static void InsertGraphicsCardMetric(Objects.GraphicsCardMetrics metric)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHandler.InsertGraphicsCardMetric(metric);
					break;
				case 1:
					DataHelper.sqliteHandler.InsertGraphicsCardMetric(metric);
					break;
			}
		}
		public static void InsertGraphicsWorkUnit(Objects.WorkUnit workUnit)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHandler.InsertGraphicsWorkUnit(workUnit);
					break;
				case 1:
					DataHelper.sqliteHandler.InsertGraphicsWorkUnit(workUnit);
					break;
			}
		}
		public static float GetAlgoFloatMultiplierByName(string name)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySQLHandler.GetAlgoFloatMultiplierByName(name);
					break;
				case 1:
					return DataHelper.sqliteHandler.GetAlgoFloatMultiplierByName(name);
					break;
			}
			return 0;
		}
		public static void UpdateGraphicsCardFirendlyName(Objects.GraphicsCard card)
		{
			switch(DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHandler.UpdateGraphicsCardFirendlyName(card);
					break;
				case 1:
					DataHelper.sqliteHandler.UpdateGraphicsCardFirendlyName(card);
					break;
			}
		}
	}
}
