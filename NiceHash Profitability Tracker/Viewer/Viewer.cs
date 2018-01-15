using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using LiveCharts; //Core of the library
using LiveCharts.WinForms;

namespace Viewer
{
	public partial class Viewer : Form
	{
		private bool loading = false;
		public Viewer()
		{
			InitializeComponent();
		}

		private void btnPlotData_Click(object sender, EventArgs e)
		{
			if (btnPlotData.Text == "Run Report")
			{
				if (cbLive.Checked)
				{
					
					RunRigStatReport(GetRigResolution());
					timerRigStatsGraphs.Interval = GetRigResolution() * 1000;
					timerRigStatsGraphs.Start();
					btnPlotData.Text = "Stop Reports";
				}
				else
				{
					RunRigStatReport(GetRigResolution());
				}
			}
			else
			{
				timerRigStatsGraphs.Stop();
				btnPlotData.Text = "Run Report";
			}
		}
		private void RunRigStatReport(int resolution)
		{
			try
            {
                string legend = "WorkerName";
                Reports.ReportParameters Params = new Reports.ReportParameters
                {
                    WalletAddress = tbRigStatsGraphWallet.Text,
                    start = dtpRigStatsGraphStartTime.Value,
                    end = dtpRigStatsGraphsEndTime.Value,
                    resolution = resolution,
                    chart = cartesianChart1,
                    LegendColumn = legend
                };
                switch (cbRigStatsGraphReport.SelectedIndex)
			    {
				    case 0:
                        Params.sum = true;
                        Params.stat = "Power";
                        Params.YKey = "Power(Watts)";
                        Params.numberFormat = "F";
                        Reports.RigReports.RunRigStatAndGenerateChart(Params);
					    break;
				    case 1:
                        Params.sum = false;
                        Params.stat = "Temp";
                        Params.YKey = "Temp(C)";
                        Params.numberFormat = "F";
                        Reports.RigReports.RunRigStatAndGenerateChart(Params);
					    break;
				    case 2:
                        Params.sum = false;
                        Params.stat = "Efficiency";
                        Params.YKey = "Efficiency %";
                        Params.numberFormat = "P";
                        Reports.RigReports.RunRigWorkStatAndGenerateChart(Params);
					    break;
				    case 3:
                        Params.sum = true;
                        Params.stat = "CalculatedEarnings";
                        Params.YKey = "CalculatedEarnings (BTC/Day)";
                        Params.numberFormat = "F9";
                        Reports.RigReports.RunRigWorkStatAndGenerateChart(Params);
					    break;
				}
			}
			catch (Exception ex)
			{
				string MethodDescriptor = String.Format("RunRigStatReport, Resolution:\t{0}\tReportType:\t{1}\tStartTime:\t{2}\tEndTime:\t{3}\tWallet:\t{4}", resolution, cbRigStatsGraphReport.SelectedIndex, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, tbCardStatsGraphWallet.Text);
				int errorID = DataHelper.DataBaseHandler.SaveExceptionLogAndReturnID(ex.ToString(), MethodDescriptor);
				if (errorID != -1)
				{
					Forms.ExceptionPopup errorPopup = new Forms.ExceptionPopup();
					errorPopup.lblErrorMessage.Text = "An error occured while trying to run your report. Please click the report button to open a case and refernce error number: " + errorID;
					errorPopup.tbErrorMessage.Text = ex.ToString();
					errorPopup.ShowDialog();
				}
			}
		}
		private void RunCardStatReport(int resolution)
		{
			try
			{
				string legend = "Name";
				if (cbCardUseFriendlyName.Checked)
				{
					legend = "FriendlyName";
				}
                Reports.ReportParameters Params = new Reports.ReportParameters
                {
                    WalletAddress = tbRigStatsGraphWallet.Text,
                    start = dtpCardStatsGraphStart.Value,
                    end = dtpCardStatsGraphEnd.Value,
                    resolution = resolution,
                    chart = cartesianChart2,
                    LegendColumn = legend

                };
				switch (cbCardStatsGraphReport.SelectedIndex)
				{
					case 0:
                        Params.sum = true;
                        Params.stat = "Power";
                        Params.YKey = "Power(Watts)";
                        Params.numberFormat = "F";
                        Reports.RigReports.RunCardStatAndGenerateChart(Params);
						break;
					case 1:
                        Params.sum = false;
                        Params.stat = "Temp";
                        Params.YKey = "Temp(C)";
                        Params.numberFormat = "F";
                        Reports.RigReports.RunCardStatAndGenerateChart(Params);
						break;
					case 2:
                        Params.sum = false;
                        Params.stat = "Efficiency";
                        Params.YKey = "Efficiency %";
                        Params.numberFormat = "P";
                        Reports.RigReports.RunCardWorkStatAndGenerateChart(Params);
						break;
					case 3:
                        Params.sum = true;
                        Params.stat = "CalculatedEarnings";
                        Params.YKey = "CalculatedEarnings (BTC/Day)";
                        Params.numberFormat = "F9";
                        Reports.RigReports.RunCardWorkStatAndGenerateChart(Params);
						break;
				}
			}
			catch(Exception ex)
			{
				string MethodDescriptor = String.Format("RunCardStatReport, Resolution:\t{0}\tReportType:\t{1}\tStartTime:\t{2}\tEndTime:\t{3}\tWallet:\t{4}", resolution, cbCardStatsGraphReport.SelectedIndex, dtpCardStatsGraphStart.Value, dtpCardStatsGraphEnd.Value, tbCardStatsGraphWallet.Text);
				int errorID = DataHelper.DataBaseHandler.SaveExceptionLogAndReturnID(ex.ToString(), MethodDescriptor);
				if (errorID != -1)
				{
					Forms.ExceptionPopup errorPopup = new Forms.ExceptionPopup();
					errorPopup.lblErrorMessage.Text = "An error occured while trying to run your report. Please click the report button to open a case and refernce error number: " + errorID;
					errorPopup.tbErrorMessage.Text = ex.ToString();
					errorPopup.ShowDialog();
				}
			}
		}

		private void timerRigStatsGraphs_Tick(object sender, EventArgs e)
		{
			timerRigStatsGraphs.Interval = GetRigResolution() * 1000;
			DateTime newEnd = DateTime.Now;
			dtpRigStatsGraphStartTime.Value = dtpRigStatsGraphStartTime.Value.Add(newEnd - dtpRigStatsGraphsEndTime.Value);
			dtpRigStatsGraphsEndTime.Value = newEnd;
			RunRigStatReport(GetRigResolution());
		}
		private int GetRigResolution()
		{
            return GetResolution((dtpRigStatsGraphsEndTime.Value - dtpRigStatsGraphStartTime.Value).TotalSeconds);
		}
		private int GetCardResolution()
		{
			return GetResolution((dtpCardStatsGraphEnd.Value - dtpCardStatsGraphStart.Value).TotalSeconds);
		}
        private int GetResolution(double SecondsContained)
        {
            int resolution = (60 * 60);
            if (SecondsContained > (60 * 60 * 24 * 5))
            {
                resolution = (60 * 60 * 12);
            }
            else if (SecondsContained > (60 * 60 * 6))
            {
                resolution = (60 * 10);
            }
            else if (SecondsContained > (60 * 60 * 2))
            {
                resolution = (60 * 5);
            }
            else if (SecondsContained > (60 * 60))
            {
                resolution = (60);
            }
            else if (SecondsContained > (60 * 10))
            {
                resolution = (30);
            }
            else
            {
                resolution = (10);
            }
            return resolution;
        }

		private void btnRunCardStatsGraphReport_Click(object sender, EventArgs e)
		{
            if (btnRunCardStatsGraphReport.Text == "Run Report")
            {
                if (cbGardStatsGraphLive.Checked)
                {

                    RunCardStatReport(GetCardResolution());
                    timerCardStatsGraphs.Interval = GetCardResolution() * 1000;
                    timerCardStatsGraphs.Start();
                    btnRunCardStatsGraphReport.Text = "Stop Reports";
                }
                else
                {
                    RunCardStatReport(GetCardResolution());
                }
            }
            else
            {
                timerCardStatsGraphs.Stop();
                btnRunCardStatsGraphReport.Text = "Run Report";
            }
		}

		private void NicehashStatsViewer_Load(object sender, EventArgs e)
		{
			loading = true;
			cbCardStatsGraphReport.SelectedIndex = Properties.Settings.Default.SelectedCardReport;
			cbRigStatsGraphReport.SelectedIndex = Properties.Settings.Default.SelectedRigReport;
			tbCardStatsGraphWallet.Text = Properties.Settings.Default.WalletAddress;
			tbRigStatsGraphWallet.Text = Properties.Settings.Default.WalletAddress;
			loading = false;
			dtpCardStatsGraphStart.Value = DateTime.Now.AddHours(-12);
			dtpRigStatsGraphStartTime.Value = DateTime.Now.AddHours(-12);
            UpdateReleaseInfoAndLabels();
            timerNewReleaseCheck.Start();

        }

		private void cbRigStatsGraphReport_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(!loading)
			{
				Properties.Settings.Default.SelectedRigReport = cbRigStatsGraphReport.SelectedIndex;
				Properties.Settings.Default.Save();
			}
		}

		private void tbRigStatsGraphWallet_TextChanged(object sender, EventArgs e)
		{
			if(!loading)
			{
				TextBox itemChanged = (TextBox)sender;
				Properties.Settings.Default.WalletAddress = itemChanged.Text;
				Properties.Settings.Default.Save();
				if (itemChanged == tbCardStatsGraphWallet)
				{
					loading = true;
					tbRigStatsGraphWallet.Text = itemChanged.Text;
					tbLiveRigWalletAddr.Text = itemChanged.Text;
					tbCardLiveWalletAddress.Text = itemChanged.Text;
					loading = false;
				}
				else if (itemChanged == tbRigStatsGraphWallet)
				{
					loading = true;
					tbCardStatsGraphWallet.Text = itemChanged.Text;
					tbLiveRigWalletAddr.Text = itemChanged.Text;
					tbCardLiveWalletAddress.Text = itemChanged.Text;
					loading = false;
				}
				else if (itemChanged == tbLiveRigWalletAddr)
				{
					loading = true;
					tbCardStatsGraphWallet.Text = itemChanged.Text;
					tbRigStatsGraphWallet.Text = itemChanged.Text;
					tbCardLiveWalletAddress.Text = itemChanged.Text;
					loading = false;
				}
				else if (itemChanged == tbCardLiveWalletAddress)
				{
					loading = true;
					tbCardStatsGraphWallet.Text = itemChanged.Text;
					tbRigStatsGraphWallet.Text = itemChanged.Text;
					tbLiveRigWalletAddr.Text = itemChanged.Text;
					loading = false;
				}
			}
		}

		private void cbCardStatsGraphReport_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(!loading)
			{
				Properties.Settings.Default.SelectedCardReport = cbCardStatsGraphReport.SelectedIndex;
				Properties.Settings.Default.Save();
			}
		}

        private void btnLast3Hours_Click(object sender, EventArgs e)
        {
            dtpRigStatsGraphStartTime.Value = DateTime.Now.AddHours(-3);
            dtpRigStatsGraphsEndTime.Value = DateTime.Now;
        }

        private void btnLast12Hours_Click(object sender, EventArgs e)
        {

            dtpRigStatsGraphStartTime.Value = DateTime.Now.AddHours(-12);
            dtpRigStatsGraphsEndTime.Value = DateTime.Now;
        }

        private void btnLastDay_Click(object sender, EventArgs e)
        {

            dtpRigStatsGraphStartTime.Value = DateTime.Now.AddDays(-1);
            dtpRigStatsGraphsEndTime.Value = DateTime.Now;
        }

        private void btnLastWeek_Click(object sender, EventArgs e)
        {
            dtpRigStatsGraphStartTime.Value = DateTime.Now.AddDays(-7);
            dtpRigStatsGraphsEndTime.Value = DateTime.Now;
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            dtpRigStatsGraphStartTime.Value = DateTime.Now.AddMonths(-1);
            dtpRigStatsGraphsEndTime.Value = DateTime.Now;
        }

        private void btnCardLast3Hours_Click(object sender, EventArgs e)
        {
            dtpCardStatsGraphStart.Value = DateTime.Now.AddHours(-3);
            dtpCardStatsGraphEnd.Value = DateTime.Now;
        }

        private void btnCardLast12Hours_Click(object sender, EventArgs e)
        {
            dtpCardStatsGraphStart.Value = DateTime.Now.AddHours(-12);
            dtpCardStatsGraphEnd.Value = DateTime.Now;
        }

        private void btnCardLastDay_Click(object sender, EventArgs e)
        {
            dtpCardStatsGraphStart.Value = DateTime.Now.AddDays(-1);
            dtpCardStatsGraphEnd.Value = DateTime.Now;
        }

        private void btnCardLastWeek_Click(object sender, EventArgs e)
        {
            dtpCardStatsGraphStart.Value = DateTime.Now.AddDays(-7);
            dtpCardStatsGraphEnd.Value = DateTime.Now;
        }

        private void btnCardLastMonth_Click(object sender, EventArgs e)
        {
            dtpCardStatsGraphStart.Value = DateTime.Now.AddMonths(-1);
            dtpCardStatsGraphEnd.Value = DateTime.Now;
        }

        private void nudRigLastXHours_ValueChanged(object sender, EventArgs e)
        {
            dtpRigStatsGraphStartTime.Value = DateTime.Now.AddHours(-(int)nudRigLastXHours.Value);
            dtpRigStatsGraphsEndTime.Value = DateTime.Now;

        }

        private void nudCardLastXHours_ValueChanged(object sender, EventArgs e)
        {
            dtpCardStatsGraphStart.Value = DateTime.Now.AddHours(-(int)nudCardLastXHours.Value);
            dtpCardStatsGraphEnd.Value = DateTime.Now;
        }

        private void timerCardStatsGraphs_Tick(object sender, EventArgs e)
        {
			DateTime newEnd = DateTime.Now;
			dtpCardStatsGraphStart.Value = dtpCardStatsGraphStart.Value.Add(newEnd - dtpCardStatsGraphEnd.Value);
			dtpCardStatsGraphEnd.Value = newEnd;
			timerCardStatsGraphs.Interval = GetCardResolution() * 1000;
            RunCardStatReport(GetCardResolution());
        }

        private void lblReleaseNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!String.IsNullOrEmpty(DataHelper.UpdateChecker.NewReleaseURL))
            { 
                Process.Start(DataHelper.UpdateChecker.NewReleaseURL);
            }
        }

        private void timerNewReleaseCheck_Tick(object sender, EventArgs e)
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
        private void lblNewRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.WriteAllText("RunningApp.txt", "Viewer.exe");
            Process.Start("Updater.exe");
            this.Close();
        }

		private void dtpRigStatsGraphStartTime_ValueChanged(object sender, EventArgs e)
		{
			checkStartTimeSeparation(dtpRigStatsGraphStartTime, dtpRigStatsGraphsEndTime);
		}

		private void dtpRigStatsGraphsEndTime_ValueChanged(object sender, EventArgs e)
		{
			checkEndTimeSeparation(dtpRigStatsGraphStartTime, dtpRigStatsGraphsEndTime);
		}
		private void checkStartTimeSeparation(DateTimePicker start, DateTimePicker end)
		{
			if(start.Value.AddMinutes(5) > end.Value)
			{
				end.Value = start.Value.AddMinutes(5);
			}
		}
		private void checkEndTimeSeparation(DateTimePicker start, DateTimePicker end)
		{
			if (end.Value.AddMinutes(-5) < start.Value)
			{
				start.Value = end.Value.AddMinutes(-5);
			}
		}

		private void dtpCardStatsGraphStart_ValueChanged(object sender, EventArgs e)
		{
			checkStartTimeSeparation(dtpCardStatsGraphStart, dtpCardStatsGraphEnd);
		}

		private void dtpCardStatsGraphEnd_ValueChanged(object sender, EventArgs e)
		{
			checkEndTimeSeparation(dtpCardStatsGraphStart, dtpCardStatsGraphEnd);
		}

		private void lblRigPendingWalletBalance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(string.Format("https://www.nicehash.com/miner/{0}", tbLiveRigWalletAddr.Text));
		}

		private void tcRigStats_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(tcRigStats.SelectedIndex == 1)
			{
				timerLiveStatsRefresh.Start();
				UpdateRigLiveStatsDashboard();
			}
			else
			{
				timerLiveStatsRefresh.Stop();
			}
		}

		private void timerLiveStatsRefresh_Tick(object sender, EventArgs e)
		{
			UpdateRigLiveStatsDashboard();
		}
		private void UpdateRigLiveStatsDashboard()
		{
			lblRigPendingWalletBalance.Text = DataHelper.NiceHashAPI.GetBalance(tbLiveRigWalletAddr.Text).ToString();
			dgvLiveRigStats.DataSource = null;
			DataTable DTable = Reports.RigReports.GetRigLiveStats(tbLiveRigWalletAddr.Text);
			BindingSource SBind = new BindingSource();
			SBind.DataSource = DTable;
			dgvLiveRigStats.Rows.Clear();
			dgvLiveRigStats.AutoGenerateColumns = true;
			dgvLiveRigStats.DataSource = DTable;

			dgvLiveRigStats.DataSource = SBind;
			dgvLiveRigStats.Refresh();
		}

		private void lblCardLiveSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(string.Format("https://www.nicehash.com/miner/{0}", tbCardLiveWalletAddress.Text));
		}

		private void timerLiveCardStatsRefresh_Tick(object sender, EventArgs e)
		{
			UpdateCardLiveStatsDashboard();
		}
		private void UpdateCardLiveStatsDashboard()
		{
			lblCardLiveSite.Text = DataHelper.NiceHashAPI.GetBalance(tbCardLiveWalletAddress.Text).ToString();
			dgvLiveCardStats.DataSource = null;
			DataTable DTable = Reports.RigReports.GetCardLiveStats(tbCardLiveWalletAddress.Text, cbCardLiveStatFriendlyName.Checked);
			BindingSource SBind = new BindingSource();
			SBind.DataSource = DTable;
			dgvLiveCardStats.Rows.Clear();
			dgvLiveCardStats.AutoGenerateColumns = true;
			dgvLiveCardStats.DataSource = DTable;

			dgvLiveCardStats.DataSource = SBind;
			dgvLiveCardStats.Refresh();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedIndex == 1)
			{
				timerLiveCardStatsRefresh.Start();
				UpdateCardLiveStatsDashboard();
			}
			else
			{
				timerLiveCardStatsRefresh.Stop();
			}
		}
	}
}
