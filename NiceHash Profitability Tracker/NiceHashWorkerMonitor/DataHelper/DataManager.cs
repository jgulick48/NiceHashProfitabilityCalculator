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
			switch(DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHelper.UpdateGraphicsCardFirendlyName(card);
					break;
				case 1:
					DataHelper.sqliteHelper.UpdateGraphicsCardFirendlyName(card);
					break;
			}
		}
	}
}
