using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiceHashWorkerMonitor
{
	public partial class NiceHashWorkerMonitor : Form
	{
		private Objects.MiningRig rig;
		private double TimeSinceLastScan;
		private bool Loading;
		private Queue<Objects.WorkUnit> pendingWU = new Queue<Objects.WorkUnit>();
		private Queue<Objects.GraphicsCardMetrics> pendingGCM = new Queue<Objects.GraphicsCardMetrics>();
		public NiceHashWorkerMonitor()
		{
			InitializeComponent();
		}
		
		private void PopulateRigInformation()
		{
			rig = new Objects.MiningRig();
			rig.IPAddress = "127.0.0.1";
			rig.Port = 4000;
			rig.Name = "DevCetner";
			List<Objects.GraphicsCard> cards = DataHelper.GraphicsCardHelper.GetGraphicsCardDataForRig(rig);
			rig.CardList = new Dictionary<int, Objects.GraphicsCard>();
			foreach(Objects.GraphicsCard card in cards)
			{
				rig.CardList.Add(card.ID, card);
			}
		}

		private void NiceHashWorkerMonitor_Load(object sender, EventArgs e)
		{
			Loading = true;
			Forms.WorkerAddressInfo WAI = new Forms.WorkerAddressInfo();
			WAI.tbWalletAddress.Text = Properties.Settings.Default.WalletAddress;
			WAI.tbWorkerName.Text = Properties.Settings.Default.WorkerName;
			if (WAI.ShowDialog() == DialogResult.OK)
			{
				Properties.Settings.Default.WalletAddress = WAI.tbWalletAddress.Text;
				Properties.Settings.Default.WorkerName = WAI.tbWorkerName.Text;
				Properties.Settings.Default.Save();
				rig = new Objects.MiningRig();
				rig.WalletAddress = WAI.tbWalletAddress.Text;
				rig.WorkerName = WAI.tbWorkerName.Text;
				rig.IPAddress = "127.0.0.1";
				rig.Port = 4000;
				rig.Name = "DevCetner";
				DataHelper.DataManager.CreateOrGetRig(rig);
				List<Objects.GraphicsCard> cards = DataHelper.GraphicsCardHelper.GetGraphicsCardDataForRig(rig);
				rig.CardList = new Dictionary<int, Objects.GraphicsCard>();
				foreach (Objects.GraphicsCard card in cards)
				{
					rig.CardList.Add(card.ID, card);
					DataHelper.DataManager.CreateOrUpdateGraphicsCard(card);
				}
			}
			else
			{
				this.Close();
			}
		}

		private void nudRefresh_ValueChanged(object sender, EventArgs e)
		{
			if(!Loading)
			{
				Properties.Settings.Default.RefreshTimer = nudRefresh.Value;
				Properties.Settings.Default.Save();
			}
			timerCardStatsRefresh.Interval = (int)(nudRefresh.Value * 1000);
		}

		private void btnStartStop_Click(object sender, EventArgs e)
		{
			if(btnStartStop.Text == "Start")
			{
				btnStartStop.Text = "Stop";
				timerCardStatsRefresh.Start();
			}
			else
			{
				timerCardStatsRefresh.Stop();
				btnStartStop.Text = "Start";
			}
		}

		private void timerCardStatsRefresh_Tick(object sender, EventArgs e)
		{
			if(!bgwCardStatsRefresh.IsBusy)
			{
				bgwCardStatsRefresh.RunWorkerAsync();
			}
		}

		private void bgwCardStatsRefresh_DoWork(object sender, DoWorkEventArgs e)
		{
			double timeElapsed = 0;
			double newCheckTime = DataHelper.DateTimeHelper.GetUnixTimeStamp();
			if (rig.LastCheckTime != 0)
			{
				timeElapsed = (newCheckTime - rig.LastCheckTime);
			}
			rig.LastCheckTime = newCheckTime;
			List<Objects.WorkUnit> workUnits = DataHelper.GraphicsCardHelper.GetWorkUnitsForRig(rig, DataHelper.NiceHashAPIHelper.GetNiceHashData("https://api.nicehash.com/api?method=simplemultialgo.info"), timeElapsed);
			foreach(Objects.WorkUnit workUnit in workUnits)
			{
				pendingWU.Enqueue(workUnit);
			}
			List<Objects.GraphicsCardMetrics> gpuMetrics = DataHelper.GraphicsCardHelper.GetGraphicsCardsMetrics(rig, timeElapsed);
			foreach(Objects.GraphicsCardMetrics gpuMetric in gpuMetrics)
			{
				pendingGCM.Enqueue(gpuMetric);
			}
		}

		private void bgwCardStatsRefresh_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if(!bgwDataBaseSave.IsBusy)
			{
				bgwDataBaseSave.RunWorkerAsync();
			}
		}

		private void bgwDataBaseSave_DoWork(object sender, DoWorkEventArgs e)
		{

			while(pendingGCM.Count > 0)
			{
				DataHelper.DataManager.InsertGraphicsCardMetric(pendingGCM.Dequeue());
			}
			while(pendingWU.Count > 0)
			{
				DataHelper.DataManager.InsertGraphicsWorkUnit(pendingWU.Dequeue());
			}
		}
	}
}
