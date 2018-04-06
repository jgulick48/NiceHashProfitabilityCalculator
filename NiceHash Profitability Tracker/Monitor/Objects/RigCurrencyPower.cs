using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Objects
{
	public class RigCurrencyPower
	{
		public int CurrencyID { get; set; }
		public int BasePowerUsage { get; set; }
		public double ElectricCost { get; set; }
		public string CurrencyShortName { get; set; }
		public string CurrencySymbol { get; set; }
	}
}
