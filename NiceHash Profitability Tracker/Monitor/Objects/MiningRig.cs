using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Objects
{
	public class MiningRig
	{
		public string WalletAddress { get; set; }
		public string WorkerName { get; set; }
		public long ID { get; set; }
		public string IPAddress { get; set; }
		public int Port { get; set; }
		public string Name { get; set; }
		public Dictionary<int,GraphicsCard> CardList { get; set; }
		public double LastCheckTime { get; set; }
		public int CurrencyID { get; set; }
		public void ClearWorkMetrics()
		{
			foreach(GraphicsCard card in CardList.Values)
			{
				card.LastWorkUnits = new List<WorkUnit>();
			}
		}
	}
}
