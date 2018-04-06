using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Monitor
{
	public partial class Monitor : Form
	{
		private Objects.MiningRig rig;
		private Objects.RigCurrencyPower RCP;
		private bool Loading;
		private Dictionary<int, int> CardIDDropdown;
		private Queue<Objects.WorkUnit> pendingWU = new Queue<Objects.WorkUnit>();
		private Queue<Objects.GraphicsCardMetrics> pendingGCM = new Queue<Objects.GraphicsCardMetrics>();
		public Monitor()
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
            timerUpdateCheck.Start();
			Loading = true;
			bool SkipWAI = false;
			Forms.WorkerAddressInfo WAI = new Forms.WorkerAddressInfo();
			if (!string.IsNullOrEmpty(Properties.Settings.Default.WalletAddress) && !string.IsNullOrEmpty(Properties.Settings.Default.WorkerName) && sender != btnEditRig)
			{
				SkipWAI = true;
			}
			WAI.tbWalletAddress.Text = Properties.Settings.Default.WalletAddress;
			WAI.tbWorkerName.Text = Properties.Settings.Default.WorkerName;
			if (Properties.Settings.Default.IsRunning || SkipWAI || WAI.ShowDialog() == DialogResult.OK)
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
				RCP = DataHelper.DataManager.GetRigCurrencyPowerCost(rig.ID);
				LoadRigCurrencyPowerCost();
				List<Objects.GraphicsCard> cards = DataHelper.GraphicsCardHelper.GetGraphicsCardDataForRig(rig);
				rig.CardList = new Dictionary<int, Objects.GraphicsCard>();
				foreach (Objects.GraphicsCard card in cards)
				{
					CardIDDropdown.Add(cbCardSelect.Items.Count, card.ID);
					cbCardSelect.Items.Add(card.DeviceName);
					rig.CardList.Add(card.ID, card);
					card.FriendlyName = DataHelper.DataManager.CreateOrUpdateGraphicsCard(card);
				}
                if(Properties.Settings.Default.IsRunning)
                {
                    btnStartStop_Click(sender, e);
                }
			}
			else
			{
				this.Close();
			}
		}
		private void LoadRigCurrencyPowerCost()
		{
			lblBasePower.Text = RCP.BasePowerUsage.ToString();
			lblPricePerKWH.Text = RCP.ElectricCost.ToString();
			lblCurShort.Text = RCP.CurrencyShortName;
			lblPerKWH.Text = String.Format("{0}/kWH:", RCP.CurrencySymbol);
			rig.CurrencyID = RCP.CurrencyID;
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
				Properties.Settings.Default.IsRunning = true;
				Properties.Settings.Default.Save();
				timerCardStatsRefresh.Start();
			}
			else
			{
				timerCardStatsRefresh.Stop();
				Properties.Settings.Default.IsRunning = false;
				Properties.Settings.Default.Save();
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
			List<Objects.WorkUnit> workUnits = DataHelper.GraphicsCardHelper.GetWorkUnitsForRig(rig, DataHelper.NiceHashApiHelper.GetNiceHashData("https://api.nicehash.com/api?method=simplemultialgo.info"), timeElapsed);
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
			UpdateCardStatsView(false);
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
				UpdateCardStatsView(true);
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
		private void UpdateCardStatsView(bool UpdateFriendlyName)
		{
			int CardSelect = cbCardSelect.SelectedIndex;
			if(CardSelect != -1)
			{
				Objects.GraphicsCard cardSelected = rig.CardList[CardIDDropdown[CardSelect]];
				tbGCName.Text = cardSelected.DeviceName;
				if (UpdateFriendlyName)
				{
					tbGCFriendlyName.Text = cardSelected.FriendlyName;
				}
				if (cardSelected.LastWorkUnits != null)
				{
					string AlgoName = "";
					double totalTime = 0;
					float totalEarnings = 0;
					foreach (Objects.WorkUnit WU in cardSelected.LastWorkUnits)
					{
						AlgoName = string.Format("{0}{1}{2}", AlgoName, WU.algo.Name , "\t");
						totalTime += WU.Time;
						totalEarnings += (WU.caclulatedEarnings * WU.efficiency) * ((float)WU.Time / (60 * 60 * 24));
					}
					float EarningsRate = (totalEarnings / (float)totalTime) * (60 * 60 * 24) * cardSelected.LastWorkUnits.Count;
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

        private void lblNewRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnStartStop.Text == "Stop")
            {
                Properties.Settings.Default.IsRunning = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.IsRunning = false;
                Properties.Settings.Default.Save();
            }
            File.WriteAllText("RunningApp.txt", "Monitor.exe");
            Process.Start("Updater.exe");
            this.Close();

        }

        private void lblReleaseNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrEmpty(DataHelper.UpdateChecker.NewReleaseURL))
            {
                Process.Start(DataHelper.UpdateChecker.NewReleaseURL);
            }
        }

        private void timerUpdateCheck_Tick(object sender, EventArgs e)
        {
            UpdateReleaseInfoAndLabels();
        }
        private void UpdateReleaseInfoAndLabels()
        {
            if (DataHelper.UpdateChecker.CheckForUpdatedRelease())
            {
                lblNewRelease.Visible = true;
                lblReleaseNotes.Visible = true;
                lblNewRelease.Enabled = true;
                lblReleaseNotes.Enabled = true;
            }
            else
            {
                lblNewRelease.Visible = false;
                lblReleaseNotes.Visible = false;
                lblNewRelease.Enabled = false;
                lblReleaseNotes.Enabled = false;
            }

        }

		private void btnEditRigPowerCur_Click(object sender, EventArgs e)
		{
			Forms.RigPowerCurrencyEditor RPCE = new Forms.RigPowerCurrencyEditor();
			RPCE.RigID = rig.ID;
			RPCE.CurrencyID = RCP.CurrencyID;
			RPCE.nudBasePower.Value = (decimal)RCP.BasePowerUsage;
			RPCE.nudPowerPrice.Value = (decimal)RCP.ElectricCost;
			if(RPCE.ShowDialog() == DialogResult.OK)
			{
				DataHelper.DataManager.UpdateRigCurrencyPowerCost(rig.ID, RPCE.SelectedCurrency.CurrencyID, (int)RPCE.nudBasePower.Value, (double)RPCE.nudPowerPrice.Value);
				RCP.BasePowerUsage = (int)RPCE.nudBasePower.Value;
				RCP.ElectricCost = (double)RPCE.nudPowerPrice.Value;
				RCP.CurrencyShortName = RPCE.SelectedCurrency.CurrencySymbol;
				rig.CurrencyID = RPCE.SelectedCurrency.CurrencyID;
				RCP.CurrencyID = RPCE.SelectedCurrency.CurrencyID;
				LoadRigCurrencyPowerCost();
			}
		}
	}
}
