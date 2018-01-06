using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashWorkerMonitor.DataHelper
{
	public static class DataManager
	{
		public static int DataSaveMethod = 0;
		public static void CreateOrGetRig(Objects.MiningRig rig)
		{
			switch(DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHandler.CreateOrGetRig(rig);
					break;
			}
		}
		public static void CreateOrUpdateGraphicsCard(Objects.GraphicsCard cardInfo)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHandler.CreateOrUpdateGraphicsCard(cardInfo);
					break;
			}
		}
		public static void InsertGraphicsCardMetric(Objects.GraphicsCardMetrics metric)
		{
			switch (DataSaveMethod)
			{
				case 0:
					DataHelper.MySQLHandler.InsertGraphicsCardMetric(metric);
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
			}
		}
		public static float GetAlgoFloatMultiplierByName(string name)
		{
			switch (DataSaveMethod)
			{
				case 0:
					return DataHelper.MySQLHandler.GetAlgoFloatMultiplierByName(name);
					break;
			}
			return 0;
		}
	}
}
