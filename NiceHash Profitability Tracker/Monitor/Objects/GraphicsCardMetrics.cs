using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Objects
{
	public class GraphicsCardMetrics
	{
		public GraphicsCard card { get; set; }
		public double TimeRecorded { get; set; }
		public float Temprature { get; set; }
		public float Power { get; set; }
		public float GPUUsage { get; set; }
		public float FanSpeedPercent { get; set; }
		public float FanSpeedRPM { get; set; }
		public double TimeElapsed { get; set; }
	}
}
