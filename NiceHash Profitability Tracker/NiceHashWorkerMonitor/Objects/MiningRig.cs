using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashWorkerMonitor.Objects
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
	}
}
