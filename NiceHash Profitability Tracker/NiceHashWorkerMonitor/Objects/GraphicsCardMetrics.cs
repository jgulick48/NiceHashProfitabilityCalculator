using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashWorkerMonitor.Objects
{
	public class GraphicsCardMetrics
	{
		public GraphicsCard card;
		public double TimeRecorded;
		public float Temprature;
		public float Power;
		public float GPUUsage;
		public float FanSpeedPercent;
		public float FanSpeedRPM;
		public double TimeElapsed;
	}
}
