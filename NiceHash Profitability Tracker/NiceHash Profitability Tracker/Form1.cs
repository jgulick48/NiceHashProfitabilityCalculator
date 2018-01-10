using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Data.SQLite;
using Monitor;

namespace NiceHash_Profitability_Tracker
{
    public partial class Form1 : Form
    {
        SQLiteConnection m_dbConnection;
        private double lastCheck;
        private float lastCheckValue;
        private bool Loading = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!Loading)
            {
                Properties.Settings.Default.RefreshTime = nudRefreshTimer.Value;
                Properties.Settings.Default.Save();
            }
            timer1.Interval = (int)nudRefreshTimer.Value * 1000;
        }
        private void UpdateBalance()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.nicehash.com/api?method=stats.provider&addr=" + tbWalletAddr.Text);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    dynamic returnData = JsonConvert.DeserializeObject(result);
                    if (returnData != null)
                    {
                        if(lastCheck == 0)
                        {
                            lastCheck = Monitor.DataHelper.DateTimeHelper.GetUnixTimeStamp();
                            lastCheckValue = getBalanceFromResults(returnData.result.stats);
                        }
                        else
                        {
                            double elapsedTime = (Monitor.DataHelper.DateTimeHelper.GetUnixTimeStamp() - lastCheck);
                            lastCheck = lastCheck + elapsedTime;
                            float newBal = getBalanceFromResults(returnData.result.stats);
                            float earnings = newBal - lastCheckValue;
                            if(earnings < 0)
                            {
                                earnings = 0;
                            }
                            lastCheckValue = newBal;
                            AddLineToDatabase(tbWalletAddr.Text, elapsedTime, earnings);
                            Metrics();
                        }
                    }
                }
                lblLRT.Text = Monitor.DataHelper.DateTimeHelper.UnixTimeStampToDateTime(lastCheck).ToLongTimeString();
                lblPB.Text = lastCheckValue.ToString();
                lblFIAT.Text = Math.Round((lastCheckValue * (float)nudBTCValue.Value), 2).ToString();
            }
            catch(Exception ex)
            {
				if (cbDebug.Checked)
				{
					MessageBox.Show(ex.ToString());
				}
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loading = true;
            nudBTCValue.Value = Properties.Settings.Default.BTCValue;
            tbWalletAddr.Text = Properties.Settings.Default.WalletAddress;
            nudRefreshTimer.Value = Properties.Settings.Default.RefreshTime;
            Loading = false;
            if(!File.Exists("Nicehash.sqlite"))
            {
                SQLiteConnection.CreateFile("Nicehash.sqlite");
                m_dbConnection = new SQLiteConnection("Data Source=Nicehash.sqlite;");
                m_dbConnection.Open();
                string sql = "create table earnings (daterecorded int, earnings real, secondspassed real, wallet varchar(50))";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                m_dbConnection.Close();
            }
            else
            {
                m_dbConnection = new SQLiteConnection("Data Source=Nicehash.sqlite;");
            }
        }
        private void AddLineToDatabase(string Wallet, double secondsPassed, float Earnings)
        {
            string sql = String.Format("insert into earnings (daterecorded, earnings, secondspassed, wallet)" +
                "values ({0},{1},{2},'{3}')", lastCheck.ToString(CultureInfo.CreateSpecificCulture("en-US")), Earnings.ToString(CultureInfo.CreateSpecificCulture("en-US")), secondsPassed.ToString(CultureInfo.CreateSpecificCulture("en-US")), Wallet);
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            m_dbConnection.Open();
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }
        private float getBalanceFromResults(dynamic stats)
        {
            float total = 0;
            foreach(dynamic stat in stats)
            {
				float balance = 0;
				if (float.TryParse(stat.balance.ToString(),NumberStyles.Any, CultureInfo.InvariantCulture, out balance))
				{
					total += balance;
				}
				else
				{
					if(cbDebug.Checked)
					{
						MessageBox.Show("Error parsing balance. Value: " + stat.balance.ToString() + " is not valid." + Environment.NewLine + stats.ToString());
					}
				}
            }
            return total;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateBalance();
        }

        private void btnScanAction_Click(object sender, EventArgs e)
        {
            if(btnScanAction.Text == "Start")
            {
                timer1.Start();
                btnScanAction.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                btnScanAction.Text = "Start";
            }
        }
        
        private float getSecondAverage(int howFarBack)
        {
            string sql = "select earnings, secondspassed from earnings where daterecorded > '" + (Monitor.DataHelper.DateTimeHelper.GetUnixTimeStamp()-howFarBack) + "'";
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            double recordedSeconds = 0;
            float recordedEarnings = 0;
            while (reader.Read())
            {
                recordedEarnings += float.Parse(reader["earnings"].ToString(), CultureInfo.InvariantCulture);
                recordedSeconds += double.Parse(reader["secondspassed"].ToString(), CultureInfo.InvariantCulture);
            }
            m_dbConnection.Close();
            return (recordedEarnings / (float)recordedSeconds);
        }
        private void Metrics()
        {
            UpdateHourMetrics();
            UpdateDayMetrics();
            UpdateWeekMetrics();
        }
        private void UpdateHourMetrics()
        {
            int howFarBack = 60 * 60;
            float avgEarnings = getSecondAverage(howFarBack);
            int mathRoundValue = 9;
            if(cbCnvtBTC.Checked)
            {
                mathRoundValue = 2;
                avgEarnings = avgEarnings * (float)nudBTCValue.Value;
            }
            lblPMHA.Text = Math.Round(avgEarnings * 60, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPHHA.Text = Math.Round(avgEarnings * 60 * 60, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPDHA.Text = Math.Round(avgEarnings * 60 * 60 * 24, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPWHA.Text = Math.Round(avgEarnings * 60 * 60 * 24 * 7, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPMthHA.Text = Math.Round(avgEarnings * 60 * 60 * 24 * 30, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
        }
        private void UpdateDayMetrics()
        {
            int howFarBack = 60 * 60 * 24;
            float avgEarnings = getSecondAverage(howFarBack);
            int mathRoundValue = 9;
            if (cbCnvtBTC.Checked)
            {
                mathRoundValue = 2;
                avgEarnings = avgEarnings * (float)nudBTCValue.Value;
            }
            lblPMDA.Text = Math.Round(avgEarnings * 60, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPHDA.Text = Math.Round(avgEarnings * 60 * 60, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPDDA.Text = Math.Round(avgEarnings * 60 * 60 * 24, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPWDA.Text = Math.Round(avgEarnings * 60 * 60 * 24 * 7, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPMthDA.Text = Math.Round(avgEarnings * 60 * 60 * 24 * 30, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));

        }
        private void UpdateWeekMetrics()
        {
            int howFarBack = 60 * 60 * 24 * 7;
            float avgEarnings = getSecondAverage(howFarBack);
            int mathRoundValue = 9;
            if (cbCnvtBTC.Checked)
            {
                mathRoundValue = 2;
                avgEarnings = avgEarnings * (float)nudBTCValue.Value;
            }
            lblPMWA.Text = Math.Round(avgEarnings * 60, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPHWA.Text = Math.Round(avgEarnings * 60 * 60, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPDWA.Text = Math.Round(avgEarnings * 60 * 60 * 24, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPWWA.Text = Math.Round(avgEarnings * 60 * 60 * 24 * 7, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
            lblPMthWA.Text = Math.Round(avgEarnings * 60 * 60 * 24 * 30, mathRoundValue).ToString(CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void tbWalletAddr_TextChanged(object sender, EventArgs e)
        {
            if (!Loading)
            {
                Properties.Settings.Default.WalletAddress = tbWalletAddr.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void nudBTCValue_ValueChanged(object sender, EventArgs e)
        {
            if (!Loading)
            {
                Properties.Settings.Default.BTCValue = nudBTCValue.Value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
