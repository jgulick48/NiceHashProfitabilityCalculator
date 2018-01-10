using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts; //Core of the library
using LiveCharts.WinForms;

namespace NiceHashStatsViewer
{
	public partial class NicehashStatsViewer : Form
	{
		private bool loading = false;
		public NicehashStatsViewer()
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
				switch (cbRigStatsGraphReport.SelectedIndex)
			{
				case 0:
					Reports.RigReports.RunRigStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart1, "Power", "Power(Watts)", "WorkerName", true,"F");
					break;
				case 1:
					Reports.RigReports.RunRigStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart1, "Temp", "Temp(C)", "WorkerName", false, "F");
					break;
				case 2:
					Reports.RigReports.RunRigWorkStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart1, "Efficiency", "Efficiency %", "WorkerName", false, "P");
					break;
				case 3:
					Reports.RigReports.RunRigWorkStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart1, "CalculatedEarnings", "CalculatedEarnings (BTC/Day)", "WorkerName", true, "F9");
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
				switch (cbCardStatsGraphReport.SelectedIndex)
				{
					case 0:
						Reports.RigReports.RunCardStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpCardStatsGraphStart.Value, dtpCardStatsGraphEnd.Value, resolution, cartesianChart2, "Power", "Power(Watts)", legend, true, "F");
						break;
					case 1:
						Reports.RigReports.RunCardStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpCardStatsGraphStart.Value, dtpCardStatsGraphEnd.Value, resolution, cartesianChart2, "Temp", "Temp(C)", legend, false, "F");
						break;
					case 2:
						Reports.RigReports.RunCardWorkStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpCardStatsGraphStart.Value, dtpCardStatsGraphEnd.Value, resolution, cartesianChart2, "Efficiency", "Efficiency %", legend, false, "P");
						break;
					case 3:
						Reports.RigReports.RunCardWorkStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpCardStatsGraphStart.Value, dtpCardStatsGraphEnd.Value, resolution, cartesianChart2, "CalculatedEarnings", "CalculatedEarnings (BTC/Day)", legend, true, "F9");
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
			dtpRigStatsGraphsEndTime.Value = DateTime.Now;
			RunRigStatReport(GetRigResolution());
		}
		private int GetRigResolution()
		{
			double SecondsContained = (dtpRigStatsGraphsEndTime.Value - dtpRigStatsGraphStartTime.Value).TotalSeconds;
			int resolution = (60 * 60);
			if (SecondsContained >= (60 * 60 * 24 * 5))
			{
				resolution = (60 * 60 * 12);
			}
			else if (SecondsContained >= (60 * 60 * 2))
			{
				resolution = (60 * 60);
			}
			else if (SecondsContained >= (60 * 30))
			{
				resolution = (60);
			}
			else
			{
				resolution = (10);
			}
			return resolution;
		}
		private int GetCardResolution()
		{
			double SecondsContained = (dtpCardStatsGraphEnd.Value - dtpCardStatsGraphStart.Value).TotalSeconds;
			int resolution = (60 * 60);
			if (SecondsContained >= (60 * 60 * 24*5))
			{
				resolution = (60 * 60 * 12);
			}
			else if (SecondsContained >= (60 * 60 * 2))
			{
				resolution = (60 * 60);
			}
			else if (SecondsContained >= (60 * 30))
			{
				resolution = (60);
			}
			else
			{
				resolution = (10);
			}
			return resolution;
		}

		private void btnRunCardStatsGraphReport_Click(object sender, EventArgs e)
		{
			RunCardStatReport(GetCardResolution());
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
				if (itemChanged != tbCardStatsGraphWallet)
				{
					loading = true;
					tbCardStatsGraphWallet.Text = itemChanged.Text;
					loading = false;
				}
				else if (itemChanged != tbRigStatsGraphWallet)
				{
					loading = true;
					tbRigStatsGraphWallet.Text = itemChanged.Text;
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
	}
}
