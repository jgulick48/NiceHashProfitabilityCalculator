using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Objects
{
	public class GraphicsCard
	{
		public int ID { get; set; }
		public long RigID { get; set; }
		public string GUID { get; set; }
		public string DeviceName { get; set; }
		public string FriendlyName { get; set; }
		public Objects.GraphicsCardMetrics LastGPUMetric { get; set; }
		public List<Objects.WorkUnit> LastWorkUnits { get; set; }
	}
}
