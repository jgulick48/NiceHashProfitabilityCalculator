using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashStatsViewer.Reports
{
    public class ReportParameters
    {
        public string stat;
        public string WalletAddress;
        public DateTime start;
        public DateTime end;
        public int resolution;
        public bool sum;
        public LiveCharts.WinForms.CartesianChart chart;
        public string YKey;
        public string LegendColumn;
        public string numberFormat;
    }
}
