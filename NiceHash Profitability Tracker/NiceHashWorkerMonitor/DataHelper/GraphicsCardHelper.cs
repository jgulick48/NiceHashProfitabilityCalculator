using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashWorkerMonitor.DataHelper
{
	class GraphicsCardHelper
	{
		public static string GetDetailsForAllGraphicsCards(Objects.MiningRig[] rigs)
		{
			string results = "";
			foreach(Objects.MiningRig rig in rigs)
			{
				List<Objects.GraphicsCard> cards = GetGraphicsCardDataForRig(rig);
				foreach(Objects.GraphicsCard card in cards)
				{
					results += GetGraphicsCardDetailsString(rig, card) + Environment.NewLine;
				}
			}
			return results;
		}
		public static List<Objects.GraphicsCard> GetGraphicsCardDataForRig(Objects.MiningRig rig)
		{
			List<Objects.GraphicsCard> cards = new List<Objects.GraphicsCard>();
			dynamic deviceList = DataHelper.ExcavatorSocket.Client(rig, 0, "device.list", new string[0]);
			foreach(dynamic device in deviceList.devices)
			{
				Objects.GraphicsCard card = new Objects.GraphicsCard();
				card.ID = device.device_id;
				card.DeviceName = device.name;
				FillExtraGCDetails(rig, card);
				card.RigID = rig.ID;
				cards.Add(card);
			}
			return cards;
		}
		public static List<Objects.WorkUnit> GetWorkUnitsForRig(Objects.MiningRig rig, dynamic PayRate, double timeElapsed)
		{
			List<Objects.WorkUnit> workUnits = new List<Objects.WorkUnit>();
			Dictionary<int, Objects.Algorithm> algorithmKey = new Dictionary<int, Objects.Algorithm>();
			dynamic work = DataHelper.ExcavatorSocket.Client(rig, 0, "algorithm.list", new string[0]);
			foreach(dynamic algorithm in work.algorithms)
			{
				if(!algorithmKey.ContainsKey((int)algorithm.algorithm_id))
				{
					Objects.Algorithm algo = new Objects.Algorithm();
					algo.ID = algorithm.algorithm_id;
					algo.Name = algorithm.name;
					algorithmKey.Add(algo.ID, algo);
				}
				foreach(dynamic worker in algorithm.workers)
				{
					if(rig.CardList.ContainsKey((int)worker.device_id))
					{
						Objects.WorkUnit workUnit = new Objects.WorkUnit();
						workUnit.card = rig.CardList[(int)worker.device_id];
						workUnit.speed = (float)worker.speed[0];
						workUnit.algo = algorithmKey[(int)algorithm.algorithm_id];
						workUnit.efficiency = (float)algorithm.pools[0].details.last_efficiency;
						workUnit.Time = timeElapsed;
						workUnit.caclulatedEarnings = getEarningsInfo(workUnit.speed, ParseFloatFromString(PayRate.result.simplemultialgo[workUnit.algo.GetNiceHashID()].paying.ToString()), workUnit.algo.GetHashMultiplier());
						workUnit.TimeRecorded = rig.LastCheckTime;
						workUnits.Add(workUnit);
					}
				}
			}
			return workUnits;
		}
		public static List<Objects.GraphicsCardMetrics> GetGraphicsCardsMetrics(Objects.MiningRig rig, double timeElapsed)
		{
			List<Objects.GraphicsCardMetrics> cardMetrics = new List<Objects.GraphicsCardMetrics>();
			foreach(Objects.GraphicsCard card in rig.CardList.Values)
			{
				cardMetrics.Add(GetGraphicsCardMetric(rig, card, timeElapsed));
			}
			return cardMetrics;
		}

		public static Objects.GraphicsCardMetrics GetGraphicsCardMetric(Objects.MiningRig rig, Objects.GraphicsCard card, double timeElapsed)
		{
			dynamic CardInfo = DataHelper.ExcavatorSocket.Client(rig, 0, "device.get", new string[] { card.ID.ToString() });
			Objects.GraphicsCardMetrics metric = new Objects.GraphicsCardMetrics();
			metric.card = card;
			metric.FanSpeedPercent = CardInfo.gpu_fan_speed;
			metric.FanSpeedRPM = CardInfo.gpu_fan_speed_rpm;
			metric.GPUUsage = CardInfo.gpu_load;
			metric.Power = CardInfo.gpu_power_usage;
			metric.Temprature = CardInfo.gpu_temp;
			metric.TimeElapsed = timeElapsed;
			metric.TimeRecorded = rig.LastCheckTime;
			return metric;
		}
		public static string GetGraphicsCardDetailsString(Objects.MiningRig rig, Objects.GraphicsCard card)
		{
			dynamic CardInfo = DataHelper.ExcavatorSocket.Client(rig, 0, "device.get", new string[] { card.ID.ToString() });
			return string.Format("DeviceName:\t{0}" +
				"\tTemp:\t{1}" +
				"\tLoad:\t{2}" +
				"\tPower (Watts):" +
				"\t{3}", 
				CardInfo.name, 
				CardInfo.gpu_temp, 
				CardInfo.gpu_load, 
				CardInfo.gpu_power_usage);
		}
		public static void FillExtraGCDetails(Objects.MiningRig rig, Objects.GraphicsCard card)
		{
			dynamic CardInfo = DataHelper.ExcavatorSocket.Client(rig, 0, "device.get", new string[] { card.ID.ToString() });
			card.GUID = CardInfo.uuid;
		}
		private static float getEarningsInfo(float speed, float paying, float hashMultiplier)
		{
			return (paying / hashMultiplier) * (speed/(60*60*24));
		}
		private static float ParseFloatFromString(string value)
		{
			return float.Parse(value, CultureInfo.InvariantCulture);
		}
	}
}
