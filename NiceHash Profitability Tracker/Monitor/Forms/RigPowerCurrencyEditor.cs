using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor.Forms
{
	public partial class RigPowerCurrencyEditor : Form
	{
		public long RigID { get; set; }
		public int CurrencyID { get; set; }
		public Objects.Currency SelectedCurrency { get; set; }
		private Dictionary<int, Objects.Currency> CurrencyLookup;
		private Dictionary<int, int> CurrencyDropdown;
		public RigPowerCurrencyEditor()
		{
			InitializeComponent();
		}

		private void RigPowerCurrencyEditor_Load(object sender, EventArgs e)
		{
			CurrencyLookup = new Dictionary<int, Objects.Currency>();
			CurrencyDropdown = new Dictionary<int, int>();
			List<Objects.Currency> CurList = DataHelper.DataManager.GetCurrencies();
			foreach(Objects.Currency cur in CurList)
			{
				CurrencyLookup.Add(cbCurrency.Items.Count, cur);
				CurrencyDropdown.Add(cur.CurrencyID, cbCurrency.Items.Count);
				cbCurrency.Items.Add(cur.CurrencyLongName);
			}
			cbCurrency.SelectedIndex = CurrencyDropdown[CurrencyID];
		}

		private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbCurrency.SelectedIndex != -1)
			{
				SelectedCurrency = CurrencyLookup[cbCurrency.SelectedIndex];
			}
		}
	}
}
