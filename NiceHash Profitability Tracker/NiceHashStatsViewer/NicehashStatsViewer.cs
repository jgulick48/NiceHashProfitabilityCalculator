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
					
					RunRigStatReport(GetResolution());
					timerRigStatsGraphs.Interval = GetResolution() * 1000;
					timerRigStatsGraphs.Start();
					btnPlotData.Text = "Stop Reports";
				}
				else
				{
					RunRigStatReport(GetResolution());
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
			switch (cbRigStatsGraphReport.SelectedIndex)
			{
				case 0:
					Reports.RigReports.RunRigStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart1, "Power", "Power(Watts)", "WorkerName", true,"F");
					break;
				case 1:
					Reports.RigReports.RunRigStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart1, "Temp", "Temp(C)", "WorkerName", false, "F");
					break;
				case 2:
					Reports.RigReports.RunRigWorkStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart1, "Efficiency", "Efficiency %", "WorkerName", false,"P");
					break;
				case 3:
					Reports.RigReports.RunRigWorkStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart1, "CalculatedEarnings", "CalculatedEarnings (BTC/Day)", "WorkerName", false, "F9");
					break;
			}
		}
		private void RunCardStatReport(int resolution)
		{
			switch (cbCardStatsGraphReport.SelectedIndex)
			{
				case 0:
					Reports.RigReports.RunCardStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart2, "Power", "Power(Watts)", "Name", true, "F");
					break;
				case 1:
					Reports.RigReports.RunCardStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart2, "Temp", "Temp(C)", "Name", false, "F");
					break;
				case 2:
					Reports.RigReports.RunCardWorkStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart2, "Efficiency", "Efficiency %", "Name", false, "P");
					break;
				case 3:
					Reports.RigReports.RunCardWorkStatAndGenerateChart(tbRigStatsGraphWallet.Text, dtpRigStatsGraphStartTime.Value, dtpRigStatsGraphsEndTime.Value, resolution, cartesianChart2, "CalculatedEarnings", "CalculatedEarnings (BTC/Day)", "Name", false, "F9");
					break;
			}
		}

		private void timerRigStatsGraphs_Tick(object sender, EventArgs e)
		{
			timerRigStatsGraphs.Interval = GetResolution() * 1000;
			dtpRigStatsGraphsEndTime.Value = DateTime.Now;
			RunRigStatReport(GetResolution());
		}
		private int GetResolution()
		{
			double SecondsContained = (dtpRigStatsGraphsEndTime.Value - dtpRigStatsGraphStartTime.Value).TotalSeconds;
			int resolution = (60 * 60);
			if (SecondsContained >= (60 * 60 * 2))
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
			RunCardStatReport(GetResolution());
		}
	}
}
