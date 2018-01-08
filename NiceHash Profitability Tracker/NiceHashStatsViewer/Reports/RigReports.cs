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

namespace NiceHashStatsViewer.Reports
{
	public static class RigReports
	{
		public static void RunRigStatAndGenerateChart(string WalletAddress, DateTime start, DateTime end, int resolution, LiveCharts.WinForms.CartesianChart chart, string MetricColumn, string YKey, string LegendColumn, bool sum, string numberFormat)
		{
			List<DataTable> Stats = RunRigStatReport(MetricColumn, WalletAddress, start, end, resolution, sum);
			CreatChartFromDataSets(start, end, chart, resolution, Stats, MetricColumn, YKey, LegendColumn, numberFormat);
		}
		public static void RunRigWorkStatAndGenerateChart(string WalletAddress, DateTime start, DateTime end, int resolution, LiveCharts.WinForms.CartesianChart chart, string MetricColumn, string YKey, string LegendColumn, bool sum, string numberFormat)
		{
			List<DataTable> Stats = RunRigWorkReport(MetricColumn, WalletAddress, start, end, resolution, sum);
			CreatChartFromDataSets(start, end, chart, resolution, Stats, MetricColumn, YKey, LegendColumn, numberFormat);
		}
		public static void RunCardStatAndGenerateChart(string WalletAddress, DateTime start, DateTime end, int resolution, LiveCharts.WinForms.CartesianChart chart, string MetricColumn, string YKey, string LegendColumn, bool sum, string numberFormat)
		{
			List<DataTable> Stats = RunCardStatReport(MetricColumn, WalletAddress, start, end, resolution, sum);
			CreatChartFromDataSets(start, end, chart, resolution, Stats, MetricColumn, YKey, LegendColumn, numberFormat);
		}
		public static void RunCardWorkStatAndGenerateChart(string WalletAddress, DateTime start, DateTime end, int resolution, LiveCharts.WinForms.CartesianChart chart, string MetricColumn, string YKey, string LegendColumn, bool sum, string numberFormat)
		{
			List<DataTable> Stats = RunCardWorkReport(MetricColumn, WalletAddress, start, end, resolution, sum);
			CreatChartFromDataSets(start, end, chart, resolution, Stats, MetricColumn, YKey, LegendColumn, numberFormat);
		}
		public static List<DataTable> RunRigStatReport(string stat, string WalletAddress, DateTime start, DateTime end, int resolution, bool sum)
		{
			string sql = string.Format("select WorkerName from MiningRig where WalletAddress = '{0}'", WalletAddress);
			DataTable Rigs = DataHelper.DataBaseHandler.GetDataTableFromSQL(sql);
			List<DataTable> RigReports = new List<DataTable>();
			foreach(DataRow rig in Rigs.Rows)
			{
				string sumation = "";
				if(sum)
				{
					sumation = "*Count(Distinct(GC.uuid))";
				}
				string rigPowerSQL = string.Format(
					"select (SUM(cs.Time * cs.{4})/SUM(cs.Time)){5} as {4}, ROUND(cs.TimeRecorded/{0}) as Time, R.WorkerName from MiningRig as R " +
					"inner join GraphicsCard as GC on R.MiningRigID = GC.RigID " +
					"inner join CardStats as cs on GC.uuid = cs.CardUUID " +
					"where R.WorkerName = '{1}' and TimeRecorded > {2} and TimeRecorded <= {3} " +
					"group by R.WorkerName, ROUND(cs.TimeRecorded/{0}) " +
					"order by ROUND(cs.TimeRecorded/{0}) asc", resolution, rig["WorkerName"], DateTimeHelper.GetUnixTimeStamp(start), DateTimeHelper.GetUnixTimeStamp(end), stat, sumation);
				RigReports.Add(DataHelper.DataBaseHandler.GetDataTableFromSQL(rigPowerSQL));
			}
			return RigReports;
		}
		public static List<DataTable> RunRigWorkReport(string stat, string WalletAddress, DateTime start, DateTime end, int resolution, bool sum)
		{
			string sql = string.Format("select WorkerName from MiningRig where WalletAddress = '{0}'", WalletAddress);
			DataTable Rigs = DataHelper.DataBaseHandler.GetDataTableFromSQL(sql);
			List<DataTable> RigReports = new List<DataTable>();
			foreach (DataRow rig in Rigs.Rows)
			{
				string sumation = "";
				if (sum)
				{
					sumation = "*Count(Distinct(GC.uuid))";
				}
				string rigPowerSQL = string.Format(
					"select (SUM(wu.Time * wu.{4})/SUM(wu.Time)){5} as {4}, ROUND(wu.TimeRecorded/{0}) as Time, R.WorkerName from MiningRig as R " +
					"inner join GraphicsCard as GC on R.MiningRigID = GC.RigID " +
					"left join WorkUnit as wu on GC.uuid = wu.CardUUID " +
					"where R.WorkerName = '{1}' and TimeRecorded > {2} and TimeRecorded <= {3} " +
					"group by R.WorkerName, ROUND(wu.TimeRecorded/{0}) " +
					"order by ROUND(wu.TimeRecorded/{0}) asc", resolution, rig["WorkerName"], DateTimeHelper.GetUnixTimeStamp(start), DateTimeHelper.GetUnixTimeStamp(end), stat, sumation);
				RigReports.Add(DataHelper.DataBaseHandler.GetDataTableFromSQL(rigPowerSQL));
			}
			return RigReports;
		}

		public static List<DataTable> RunCardStatReport(string stat, string WalletAddress, DateTime start, DateTime end, int resolution, bool sum)
		{
			string sql = string.Format("select uuid from GraphicsCard as gc" +
				   " inner join MiningRig as r on gc.RigID = r.MiningRigID" +
				   " where WalletAddress = '{0}'", WalletAddress);
			DataTable Cards = DataHelper.DataBaseHandler.GetDataTableFromSQL(sql);
			List<DataTable> RigReports = new List<DataTable>();
			foreach (DataRow card in Cards.Rows)
			{
				string sumation = "";
				if (sum)
				{
					sumation = "*Count(Distinct(GC.uuid))";
				}
				string rigPowerSQL = string.Format(
					"select (SUM(cs.Time * cs.{4})/SUM(cs.Time)){5} as {4}, ROUND(cs.TimeRecorded/{0}) as Time, GC.Name, GC.FriendlyName from MiningRig as R " +
					"inner join GraphicsCard as GC on R.MiningRigID = GC.RigID " +
					"inner join CardStats as cs on GC.uuid = cs.CardUUID " +
					"where GC.uuid = '{1}' and TimeRecorded > {2} and TimeRecorded <= {3} " +
					"group by GC.uuid, ROUND(cs.TimeRecorded/{0}) " +
					"order by ROUND(cs.TimeRecorded/{0}) asc", resolution, card["uuid"], DateTimeHelper.GetUnixTimeStamp(start), DateTimeHelper.GetUnixTimeStamp(end), stat, sumation);
				RigReports.Add(DataHelper.DataBaseHandler.GetDataTableFromSQL(rigPowerSQL));
			}
			return RigReports;
		}
		public static List<DataTable> RunCardWorkReport(string stat, string WalletAddress, DateTime start, DateTime end, int resolution, bool sum)
		{
			string sql = string.Format("select uuid from GraphicsCard as gc" +
				   " inner join MiningRig as r on gc.RigID = r.MiningRigID" +
				   " where WalletAddress = '{0}'", WalletAddress);
			DataTable Cards = DataHelper.DataBaseHandler.GetDataTableFromSQL(sql);
			List<DataTable> RigReports = new List<DataTable>();
			foreach (DataRow card in Cards.Rows)
			{
				string sumation = "";
				if (sum)
				{
					sumation = "*(Count(Distinct(wu.WorkUnitID))/Count(Distinct(wu.TimeRecorded)))";
				}
				string rigPowerSQL = string.Format(
					"select (SUM(wu.Time * wu.{4})/SUM(wu.Time)){5} as {4}, ROUND(wu.TimeRecorded/{0}) as Time, GC.Name, GC.FriendlyName from MiningRig as R " +
					"inner join GraphicsCard as GC on R.MiningRigID = GC.RigID " +
					"left join WorkUnit as wu on GC.uuid = wu.CardUUID " +
					"where GC.uuid = '{1}' and TimeRecorded > {2} and TimeRecorded <= {3} " +
					"group by GC.uuid, ROUND(wu.TimeRecorded/{0}) " +
					"order by ROUND(wu.TimeRecorded/{0}) asc", resolution, card["uuid"], DateTimeHelper.GetUnixTimeStamp(start), DateTimeHelper.GetUnixTimeStamp(end), stat, sumation);
				RigReports.Add(DataHelper.DataBaseHandler.GetDataTableFromSQL(rigPowerSQL));
			}
			return RigReports;
		}
		private static void CreatChartFromDataSets(DateTime start, DateTime end, LiveCharts.WinForms.CartesianChart chart, int resolution, List<DataTable> data,string MetricColumn, string YKey, string legendColumn,string numberFormat)
		{
			chart.Series = new SeriesCollection();
			chart.AxisX.Clear();
			chart.AxisY.Clear();
			foreach(DataTable rig in data)
			{
				if (rig.Rows.Count != 0)
				{
					Dictionary<int, DataRow> values = new Dictionary<int, DataRow>();
					foreach (DataRow row in rig.Rows)
					{
						if (!string.IsNullOrEmpty(row[MetricColumn].ToString()))
						{
							int key = ((int)Math.Round(double.Parse(row["Time"].ToString()) * resolution));
							values.Add(key, row);
						}
					}
					LineSeries series = new LineSeries();
					series.Title = rig.Rows[0][legendColumn].ToString();
					series.Values = new ChartValues<float>();
					for (int i = ((int)Math.Round(DateTimeHelper.GetUnixTimeStamp(start) / resolution) * resolution); i <= ((int)Math.Round(DateTimeHelper.GetUnixTimeStamp(end) / resolution) * resolution); i += resolution)
					{
						if(values.ContainsKey(i))
						{
							if (!string.IsNullOrEmpty(values[i][MetricColumn].ToString()))
							{
								series.Values.Add(float.Parse(values[i][MetricColumn].ToString()));
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
					chart.Series.Add(series);
				}
			}
			Axis xAxis = new Axis();
			xAxis.Title = "Date";
			xAxis.Labels = new List<string>();
			for(int i = ((int)Math.Round(DateTimeHelper.GetUnixTimeStamp(start)/resolution)*resolution); i <= ((int)Math.Round(DateTimeHelper.GetUnixTimeStamp(end) / resolution) * resolution); i += resolution)
			{
				xAxis.Labels.Add(DateTimeHelper.UnixTimeStampToDateTime(i).ToShortDateString() + " " + DateTimeHelper.UnixTimeStampToDateTime(i).ToShortTimeString());
			}
			chart.AxisX.Add(xAxis);

			chart.AxisY.Add(new Axis
			{
				Title = YKey,
				LabelFormatter = value => value.ToString(numberFormat)
			});

			chart.LegendLocation = LegendLocation.Right;
		}
	}
}
