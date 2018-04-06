using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Objects
{
	public class WorkUnit
	{
		public GraphicsCard card { get; set; }
		public Algorithm algo { get; set; }
		public double TimeRecorded { get; set; }
		public float speed { get; set; }
		public double Time { get; set; }
		public float efficiency { get; set; }
		public float caclulatedEarnings { get; set; }
	}
}
