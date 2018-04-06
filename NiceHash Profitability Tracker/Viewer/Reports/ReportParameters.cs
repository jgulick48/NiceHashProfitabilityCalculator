using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewer.Reports
{
    public class ReportParameters
    {
        public string stat { get; set; }
		public string WalletAddress { get; set; }
		public DateTime start { get; set; }
		public DateTime end { get; set; }
		public int resolution { get; set; }
		public bool sum { get; set; }
		public LiveCharts.WinForms.CartesianChart chart { get; set; }
		public string YKey { get; set; }
		public string LegendColumn { get; set; }
		public string numberFormat { get; set; }
	}
}
