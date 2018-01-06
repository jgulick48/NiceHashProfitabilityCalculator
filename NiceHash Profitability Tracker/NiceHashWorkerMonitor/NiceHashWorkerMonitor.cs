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
		private Dictionary<int, int> CardIDDropdown;
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
				CardIDDropdown = new Dictionary<int, int>();
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
					CardIDDropdown.Add(cbCardSelect.Items.Count, card.ID);
					cbCardSelect.Items.Add(card.DeviceName);
					rig.CardList.Add(card.ID, card);
					card.FriendlyName = DataHelper.DataManager.CreateOrUpdateGraphicsCard(card);
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
			UpdateCardStatsView();
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

		private void cbCardSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbCardSelect.SelectedIndex != -1)
			{
				btnSaveCard.Enabled = true;
				UpdateCardStatsView();
			}
			else
			{
				btnSaveCard.Enabled = false;
			}
		}

		private void btnEditRig_Click(object sender, EventArgs e)
		{
			NiceHashWorkerMonitor_Load(sender, e);
		}
		private void UpdateCardStatsView()
		{
			int CardSelect = cbCardSelect.SelectedIndex;
			if(CardSelect != -1)
			{
				Objects.GraphicsCard cardSelected = rig.CardList[CardIDDropdown[CardSelect]];
				tbGCName.Text = cardSelected.DeviceName;
				tbGCFriendlyName.Text = cardSelected.FriendlyName;
				if (cardSelected.LastWorkUnits != null)
				{
					string AlgoName = "";
					double totalTime = 0;
					float totalEarnings = 0;
					foreach (Objects.WorkUnit WU in cardSelected.LastWorkUnits)
					{
						AlgoName += WU.algo.Name + "\t";
						totalTime += WU.Time;
						totalEarnings += (WU.caclulatedEarnings * WU.efficiency) * ((float)WU.Time / (60 * 60 * 24));
					}
					float EarningsRate = (totalEarnings / (float)totalTime) * (60 * 60 * 24) * cardSelected.LastWorkUnits.Count();
					tbGCEarnings.Text = EarningsRate.ToString();
					tbAlogName.Text = AlgoName;
				}
				else
				{
					tbAlogName.Text = "";
					tbGCEarnings.Text = "";
				}
				if (cardSelected.LastGPUMetric != null)
				{
					tbGCTemp.Text = cardSelected.LastGPUMetric.Temprature.ToString();
					tbGCPower.Text = cardSelected.LastGPUMetric.Power.ToString();
					tbGPUPercent.Text = cardSelected.LastGPUMetric.GPUUsage.ToString();
					tbFanPercent.Text = cardSelected.LastGPUMetric.FanSpeedPercent.ToString();
					tbFanRPM.Text = cardSelected.LastGPUMetric.FanSpeedRPM.ToString();
				}
				tbCardUUID.Text = cardSelected.GUID;
			}
		}

		private void btnSaveCard_Click(object sender, EventArgs e)
		{
			if(cbCardSelect.SelectedIndex != -1)
			{
				Objects.GraphicsCard cardSelected = rig.CardList[CardIDDropdown[cbCardSelect.SelectedIndex]];
				cardSelected.FriendlyName = tbGCFriendlyName.Text;
				DataHelper.DataManager.UpdateGraphicsCardFirendlyName(cardSelected);
			}
		}
	}
}
