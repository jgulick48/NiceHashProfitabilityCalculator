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
	public partial class WorkerAddressInfo : Form
	{
		public WorkerAddressInfo()
		{
			InitializeComponent();
		}

		private void btnResetAllRigs_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure that you want to reset all rig information?","Reset All Rigs?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				DataHelper.DataManager.SetMiningRigInactive(tbWalletAddress.Text);
			}
		}
	}
}
