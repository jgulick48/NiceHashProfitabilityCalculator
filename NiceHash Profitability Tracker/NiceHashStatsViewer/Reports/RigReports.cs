using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Windows.Media;
using NiceHashWorkerMonitor.DataHelper;
using LiveCharts.WinForms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Globalization;

namespace NiceHashStatsViewer.Reports
{
	public static class RigReports
	{
		public static void RunRigStatAndGenerateChart(ReportParameters Params)
		{
			List<DataTable> Stats = RunRigStatReport(Params);
			CreatChartFromDataSets(Params, Stats);
		}
		public static void RunRigWorkStatAndGenerateChart(ReportParameters Params)
		{
			List<DataTable> Stats = RunRigWorkReport(Params);
			CreatChartFromDataSets(Params, Stats);
		}
		public static void RunCardStatAndGenerateChart(ReportParameters Params)
		{
			List<DataTable> Stats = RunCardStatReport(Params);
			CreatChartFromDataSets(Params, Stats);
		}
		public static void RunCardWorkStatAndGenerateChart(ReportParameters Params)
		{
			List<DataTable> Stats = RunCardWorkReport(Params);
			CreatChartFromDataSets(Params, Stats);
		}
        public static DataTable GetRigsFromWalletAddress(string WalletAddress)
        {
            string sql = string.Format("select WorkerName from MiningRig where WalletAddress = '{0}'", WalletAddress);
            return DataHelper.DataBaseHandler.GetDataTableFromSQL(sql);
        }
		public static List<DataTable> RunRigStatReport(ReportParameters Params)
		{
            DataTable Rigs = GetRigsFromWalletAddress(Params.WalletAddress);
			List<DataTable> RigReports = new List<DataTable>();
			foreach(DataRow rig in Rigs.Rows)
			{
				string sumation = "";
				if(Params.sum)
				{
					sumation = "*Count(Distinct(GC.uuid))";
				}
				string rigPowerSQL = string.Format(
					"select (SUM(cs.Time * cs.{4})/SUM(cs.Time)){5} as {4}, ROUND(cs.TimeRecorded/{0}) as Time, R.WorkerName from MiningRig as R " +
					"inner join GraphicsCard as GC on R.MiningRigID = GC.RigID " +
					"inner join CardStats as cs on GC.uuid = cs.CardUUID " +
					"where R.WorkerName = '{1}' and TimeRecorded > {2} and TimeRecorded <= {3} " +
					"group by R.WorkerName, ROUND(cs.TimeRecorded/{0}) " +
					"order by ROUND(cs.TimeRecorded/{0}) asc", Params.resolution, rig["WorkerName"], DateTimeHelper.GetUnixTimeStamp(Params.start).ToString(CultureInfo.CreateSpecificCulture("en-US")), DateTimeHelper.GetUnixTimeStamp(Params.end).ToString(CultureInfo.CreateSpecificCulture("en-US")), Params.stat, sumation);
				RigReports.Add(DataHelper.DataBaseHandler.GetDataTableFromSQL(rigPowerSQL));
			}
			return RigReports;
		}
		public static List<DataTable> RunRigWorkReport(ReportParameters Params)
        {
            DataTable Rigs = GetRigsFromWalletAddress(Params.WalletAddress);
            List<DataTable> RigReports = new List<DataTable>();
			foreach (DataRow rig in Rigs.Rows)
			{
				string sumation = "";
				if (Params.sum)
				{
					sumation = "*Count(Distinct(GC.uuid))";
				}
				string rigPowerSQL = string.Format(
					"select (SUM(wu.Time * wu.{4})/SUM(wu.Time)){5} as {4}, ROUND(wu.TimeRecorded/{0}) as Time, R.WorkerName from MiningRig as R " +
					"inner join GraphicsCard as GC on R.MiningRigID = GC.RigID " +
					"left join WorkUnit as wu on GC.uuid = wu.CardUUID " +
					"where R.WorkerName = '{1}' and TimeRecorded > {2} and TimeRecorded <= {3} " +
					"group by R.WorkerName, ROUND(wu.TimeRecorded/{0}) " +
					"order by ROUND(wu.TimeRecorded/{0}) asc", Params.resolution, rig["WorkerName"], DateTimeHelper.GetUnixTimeStamp(Params.start).ToString(CultureInfo.CreateSpecificCulture("en-US")), DateTimeHelper.GetUnixTimeStamp(Params.end).ToString(CultureInfo.CreateSpecificCulture("en-US")), Params.stat, sumation);
				RigReports.Add(DataHelper.DataBaseHandler.GetDataTableFromSQL(rigPowerSQL));
			}
			return RigReports;
		}
        public static DataTable GetCardsFromWalletAddress(string WalletAddress)
        {
            string sql = string.Format("select uuid from GraphicsCard as gc" +
                   " inner join MiningRig as r on gc.RigID = r.MiningRigID" +
                   " where WalletAddress = '{0}'", WalletAddress);
            return DataHelper.DataBaseHandler.GetDataTableFromSQL(sql);
        }
		public static List<DataTable> RunCardStatReport(ReportParameters Params)
        {
            DataTable Cards = GetCardsFromWalletAddress(Params.WalletAddress);
            List<DataTable> RigReports = new List<DataTable>();
			foreach (DataRow card in Cards.Rows)
			{
				string sumation = "";
				if (Params.sum)
				{
					sumation = "*Count(Distinct(GC.uuid))";
				}
				string rigPowerSQL = string.Format(
					"select (SUM(cs.Time * cs.{4})/SUM(cs.Time)){5} as {4}, ROUND(cs.TimeRecorded/{0}) as Time, GC.Name, GC.FriendlyName from MiningRig as R " +
					"inner join GraphicsCard as GC on R.MiningRigID = GC.RigID " +
					"inner join CardStats as cs on GC.uuid = cs.CardUUID " +
					"where GC.uuid = '{1}' and TimeRecorded > {2} and TimeRecorded <= {3} " +
					"group by GC.uuid, ROUND(cs.TimeRecorded/{0}) " +
					"order by ROUND(cs.TimeRecorded/{0}) asc", Params.resolution, card["uuid"], DateTimeHelper.GetUnixTimeStamp(Params.start).ToString(CultureInfo.CreateSpecificCulture("en-US")), DateTimeHelper.GetUnixTimeStamp(Params.end).ToString(CultureInfo.CreateSpecificCulture("en-US")), Params.stat, sumation);
				RigReports.Add(DataHelper.DataBaseHandler.GetDataTableFromSQL(rigPowerSQL));
			}
			return RigReports;
		}
		public static List<DataTable> RunCardWorkReport(ReportParameters Params)
		{
            DataTable Cards = GetCardsFromWalletAddress(Params.WalletAddress);
            List<DataTable> RigReports = new List<DataTable>();
			foreach (DataRow card in Cards.Rows)
			{
				string sumation = "";
				if (Params.sum)
				{
					sumation = "*(Count(Distinct(wu.WorkUnitID))/Count(Distinct(wu.TimeRecorded)))";
				}
				string rigPowerSQL = string.Format(
					"select (SUM(wu.Time * wu.{4})/SUM(wu.Time)){5} as {4}, ROUND(wu.TimeRecorded/{0}) as Time, GC.Name, GC.FriendlyName from MiningRig as R " +
					"inner join GraphicsCard as GC on R.MiningRigID = GC.RigID " +
					"left join WorkUnit as wu on GC.uuid = wu.CardUUID " +
					"where GC.uuid = '{1}' and TimeRecorded > {2} and TimeRecorded <= {3} " +
					"group by GC.uuid, ROUND(wu.TimeRecorded/{0}) " +
					"order by ROUND(wu.TimeRecorded/{0}) asc", Params.resolution, card["uuid"], DateTimeHelper.GetUnixTimeStamp(Params.start).ToString(CultureInfo.CreateSpecificCulture("en-US")), DateTimeHelper.GetUnixTimeStamp(Params.end).ToString(CultureInfo.CreateSpecificCulture("en-US")), Params.stat, sumation);
				RigReports.Add(DataHelper.DataBaseHandler.GetDataTableFromSQL(rigPowerSQL));
			}
			return RigReports;
		}
		private static void CreatChartFromDataSets(ReportParameters Params, List<DataTable> data)
		{
            Params.chart.Series = new SeriesCollection();
            Params.chart.AxisX.Clear();
            Params.chart.AxisY.Clear();
			foreach(DataTable rig in data)
			{
				if (rig.Rows.Count != 0)
				{
					Dictionary<int, DataRow> values = new Dictionary<int, DataRow>();
					foreach (DataRow row in rig.Rows)
					{
						if (!string.IsNullOrEmpty(row[Params.stat].ToString()))
						{
							int key = ((int)Math.Round(double.Parse(row["Time"].ToString(), CultureInfo.InvariantCulture) * Params.resolution));
							values.Add(key, row);
						}
					}
					LineSeries series = new LineSeries();
					series.Title = rig.Rows[0][Params.LegendColumn].ToString();
					series.Values = new ChartValues<float>();
					for (int i = ((int)Math.Round(DateTimeHelper.GetUnixTimeStamp(Params.start) / Params.resolution) * Params.resolution); i <= ((int)Math.Round(DateTimeHelper.GetUnixTimeStamp(Params.end) / Params.resolution) * Params.resolution); i += Params.resolution)
					{
						if(values.ContainsKey(i))
						{
							if (!string.IsNullOrEmpty(values[i][Params.stat].ToString()))
							{
								series.Values.Add(float.Parse(values[i][Params.stat].ToString(), CultureInfo.InvariantCulture));
							}
							else
							{
								series.Values.Add(0f);
							}
						}
						else
						{
							series.Values.Add(0f);
						}
					}
                    Params.chart.Series.Add(series);
				}
			}
			Axis xAxis = new Axis();
			xAxis.Title = "Date";
			xAxis.Labels = new List<string>();
			for(int i = ((int)Math.Round(DateTimeHelper.GetUnixTimeStamp(Params.start)/ Params.resolution)* Params.resolution); i <= ((int)Math.Round(DateTimeHelper.GetUnixTimeStamp(Params.end) / Params.resolution) * Params.resolution); i += Params.resolution)
			{
				xAxis.Labels.Add(DateTimeHelper.UnixTimeStampToDateTime(i).ToShortDateString() + " " + DateTimeHelper.UnixTimeStampToDateTime(i).ToShortTimeString());
			}
            Params.chart.AxisX.Add(xAxis);

            Params.chart.AxisY.Add(new Axis
			{
				Title = Params.YKey,
				LabelFormatter = value => value.ToString(Params.numberFormat)
			});

            Params.chart.LegendLocation = LegendLocation.Right;
		}
	}
}
