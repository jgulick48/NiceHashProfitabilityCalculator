using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer.Forms
{
	public partial class ExceptionPopup : Form
	{
		public ExceptionPopup()
		{
			InitializeComponent();
		}

		private void btnReport_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/jgulick48/NiceHashProfitabilityCalculator/issues/new");
		}
	}
}
