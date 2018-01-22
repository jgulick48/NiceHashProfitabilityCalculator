using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Objects
{
	public class MiningRig
	{
		public string WalletAddress;
		public string WorkerName;
		public long ID;
		public string IPAddress;
		public int Port;
		public string Name;
		public Dictionary<int,GraphicsCard> CardList;
		public double LastCheckTime;
		public int CurrencyID;
		public void ClearWorkMetrics()
		{
			foreach(GraphicsCard card in CardList.Values)
			{
				card.LastWorkUnits = new List<WorkUnit>();
			}
		}
	}
}
