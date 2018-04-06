using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewer.Reports
{
	public class Export
	{
		public int ReportID { get; set; }
		public string SprocName { get; set; }
		public string DisplayName { get; set; }
		public int ReportType { get; set; }
		public string ToolTip { get; set; }
	}
}
