namespace NiceHashStatsViewer
{
	partial class NicehashStatsViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NicehashStatsViewer));
			this.tcMain = new System.Windows.Forms.TabControl();
			this.tpRigStats = new System.Windows.Forms.TabPage();
			this.tcRigStats = new System.Windows.Forms.TabControl();
			this.tpRigGraphs = new System.Windows.Forms.TabPage();
			this.cbLive = new System.Windows.Forms.CheckBox();
			this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
			this.btnPlotData = new System.Windows.Forms.Button();
			this.tbRigStatsGraphWallet = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpRigStatsGraphsEndTime = new System.Windows.Forms.DateTimePicker();
			this.dtpRigStatsGraphStartTime = new System.Windows.Forms.DateTimePicker();
			this.cbRigStatsGraphReport = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tpRigStatsExports = new System.Windows.Forms.TabPage();
			this.tpCardStats = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.cbGardStatsGraphLive = new System.Windows.Forms.CheckBox();
			this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
			this.btnRunCardStatsGraphReport = new System.Windows.Forms.Button();
			this.tbCardStatsGraphWallet = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.nudCardStatsGraphEnd = new System.Windows.Forms.DateTimePicker();
			this.dtpCardStatsGraphStart = new System.Windows.Forms.DateTimePicker();
			this.cbCardStatsGraphReport = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.timerRigStatsGraphs = new System.Windows.Forms.Timer(this.components);
			this.bgwRigStatsReport = new System.ComponentModel.BackgroundWorker();
			this.bgwCardStatsReport = new System.ComponentModel.BackgroundWorker();
			this.timerCardStatsGraphs = new System.Windows.Forms.Timer(this.components);
			this.tcMain.SuspendLayout();
			this.tpRigStats.SuspendLayout();
			this.tcRigStats.SuspendLayout();
			this.tpRigGraphs.SuspendLayout();
			this.tpCardStats.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcMain
			// 
			this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tcMain.Controls.Add(this.tpRigStats);
			this.tcMain.Controls.Add(this.tpCardStats);
			this.tcMain.Location = new System.Drawing.Point(12, 12);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(756, 534);
			this.tcMain.TabIndex = 0;
			// 
			// tpRigStats
			// 
			this.tpRigStats.Controls.Add(this.tcRigStats);
			this.tpRigStats.Location = new System.Drawing.Point(4, 22);
			this.tpRigStats.Name = "tpRigStats";
			this.tpRigStats.Padding = new System.Windows.Forms.Padding(3);
			this.tpRigStats.Size = new System.Drawing.Size(748, 508);
			this.tpRigStats.TabIndex = 0;
			this.tpRigStats.Text = "Rig Stats";
			this.tpRigStats.UseVisualStyleBackColor = true;
			// 
			// tcRigStats
			// 
			this.tcRigStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tcRigStats.Controls.Add(this.tpRigGraphs);
			this.tcRigStats.Controls.Add(this.tpRigStatsExports);
			this.tcRigStats.Location = new System.Drawing.Point(6, 6);
			this.tcRigStats.Name = "tcRigStats";
			this.tcRigStats.SelectedIndex = 0;
			this.tcRigStats.Size = new System.Drawing.Size(736, 496);
			this.tcRigStats.TabIndex = 0;
			// 
			// tpRigGraphs
			// 
			this.tpRigGraphs.Controls.Add(this.cbLive);
			this.tpRigGraphs.Controls.Add(this.cartesianChart1);
			this.tpRigGraphs.Controls.Add(this.btnPlotData);
			this.tpRigGraphs.Controls.Add(this.tbRigStatsGraphWallet);
			this.tpRigGraphs.Controls.Add(this.label4);
			this.tpRigGraphs.Controls.Add(this.label3);
			this.tpRigGraphs.Controls.Add(this.label2);
			this.tpRigGraphs.Controls.Add(this.dtpRigStatsGraphsEndTime);
			this.tpRigGraphs.Controls.Add(this.dtpRigStatsGraphStartTime);
			this.tpRigGraphs.Controls.Add(this.cbRigStatsGraphReport);
			this.tpRigGraphs.Controls.Add(this.label1);
			this.tpRigGraphs.Location = new System.Drawing.Point(4, 22);
			this.tpRigGraphs.Name = "tpRigGraphs";
			this.tpRigGraphs.Padding = new System.Windows.Forms.Padding(3);
			this.tpRigGraphs.Size = new System.Drawing.Size(728, 470);
			this.tpRigGraphs.TabIndex = 0;
			this.tpRigGraphs.Text = "Graphs";
			this.tpRigGraphs.UseVisualStyleBackColor = true;
			// 
			// cbLive
			// 
			this.cbLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbLive.AutoSize = true;
			this.cbLive.Location = new System.Drawing.Point(9, 441);
			this.cbLive.Name = "cbLive";
			this.cbLive.Size = new System.Drawing.Size(46, 17);
			this.cbLive.TabIndex = 10;
			this.cbLive.Text = "Live";
			this.cbLive.UseVisualStyleBackColor = true;
			// 
			// cartesianChart1
			// 
			this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cartesianChart1.Location = new System.Drawing.Point(9, 59);
			this.cartesianChart1.Name = "cartesianChart1";
			this.cartesianChart1.Size = new System.Drawing.Size(713, 376);
			this.cartesianChart1.TabIndex = 9;
			this.cartesianChart1.Text = "cartesianChart1";
			// 
			// btnPlotData
			// 
			this.btnPlotData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlotData.Location = new System.Drawing.Point(647, 441);
			this.btnPlotData.Name = "btnPlotData";
			this.btnPlotData.Size = new System.Drawing.Size(75, 23);
			this.btnPlotData.TabIndex = 8;
			this.btnPlotData.Text = "Run Report";
			this.btnPlotData.UseVisualStyleBackColor = true;
			this.btnPlotData.Click += new System.EventHandler(this.btnPlotData_Click);
			// 
			// tbRigStatsGraphWallet
			// 
			this.tbRigStatsGraphWallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRigStatsGraphWallet.Location = new System.Drawing.Point(93, 33);
			this.tbRigStatsGraphWallet.Name = "tbRigStatsGraphWallet";
			this.tbRigStatsGraphWallet.Size = new System.Drawing.Size(404, 20);
			this.tbRigStatsGraphWallet.TabIndex = 7;
			this.tbRigStatsGraphWallet.Text = "37s2ZBNJ64sa1bkYh3HWAkncJSxcXoBzvn";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Wallet Address:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(503, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "End Time:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(500, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Start Time:";
			// 
			// dtpRigStatsGraphsEndTime
			// 
			this.dtpRigStatsGraphsEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpRigStatsGraphsEndTime.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.dtpRigStatsGraphsEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRigStatsGraphsEndTime.Location = new System.Drawing.Point(564, 32);
			this.dtpRigStatsGraphsEndTime.Name = "dtpRigStatsGraphsEndTime";
			this.dtpRigStatsGraphsEndTime.Size = new System.Drawing.Size(158, 20);
			this.dtpRigStatsGraphsEndTime.TabIndex = 3;
			// 
			// dtpRigStatsGraphStartTime
			// 
			this.dtpRigStatsGraphStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpRigStatsGraphStartTime.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.dtpRigStatsGraphStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRigStatsGraphStartTime.Location = new System.Drawing.Point(564, 6);
			this.dtpRigStatsGraphStartTime.Name = "dtpRigStatsGraphStartTime";
			this.dtpRigStatsGraphStartTime.Size = new System.Drawing.Size(158, 20);
			this.dtpRigStatsGraphStartTime.TabIndex = 2;
			this.dtpRigStatsGraphStartTime.Value = new System.DateTime(2018, 1, 4, 16, 17, 0, 0);
			// 
			// cbRigStatsGraphReport
			// 
			this.cbRigStatsGraphReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbRigStatsGraphReport.FormattingEnabled = true;
			this.cbRigStatsGraphReport.Items.AddRange(new object[] {
            "Power Usage (Watts)",
            "Average Card Temp",
            "Rig Efficiency",
            "Calculated Earnings (Average Per Day)"});
			this.cbRigStatsGraphReport.Location = new System.Drawing.Point(54, 6);
			this.cbRigStatsGraphReport.Name = "cbRigStatsGraphReport";
			this.cbRigStatsGraphReport.Size = new System.Drawing.Size(443, 21);
			this.cbRigStatsGraphReport.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Report:";
			// 
			// tpRigStatsExports
			// 
			this.tpRigStatsExports.Location = new System.Drawing.Point(4, 22);
			this.tpRigStatsExports.Name = "tpRigStatsExports";
			this.tpRigStatsExports.Padding = new System.Windows.Forms.Padding(3);
			this.tpRigStatsExports.Size = new System.Drawing.Size(728, 470);
			this.tpRigStatsExports.TabIndex = 1;
			this.tpRigStatsExports.Text = "Exports";
			this.tpRigStatsExports.UseVisualStyleBackColor = true;
			// 
			// tpCardStats
			// 
			this.tpCardStats.Controls.Add(this.tabControl1);
			this.tpCardStats.Location = new System.Drawing.Point(4, 22);
			this.tpCardStats.Name = "tpCardStats";
			this.tpCardStats.Padding = new System.Windows.Forms.Padding(3);
			this.tpCardStats.Size = new System.Drawing.Size(748, 508);
			this.tpCardStats.TabIndex = 1;
			this.tpCardStats.Text = "Card Stats";
			this.tpCardStats.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(6, 6);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(736, 496);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.cbGardStatsGraphLive);
			this.tabPage1.Controls.Add(this.cartesianChart2);
			this.tabPage1.Controls.Add(this.btnRunCardStatsGraphReport);
			this.tabPage1.Controls.Add(this.tbCardStatsGraphWallet);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.nudCardStatsGraphEnd);
			this.tabPage1.Controls.Add(this.dtpCardStatsGraphStart);
			this.tabPage1.Controls.Add(this.cbCardStatsGraphReport);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(728, 470);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Graphs";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// cbGardStatsGraphLive
			// 
			this.cbGardStatsGraphLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbGardStatsGraphLive.AutoSize = true;
			this.cbGardStatsGraphLive.Location = new System.Drawing.Point(9, 441);
			this.cbGardStatsGraphLive.Name = "cbGardStatsGraphLive";
			this.cbGardStatsGraphLive.Size = new System.Drawing.Size(46, 17);
			this.cbGardStatsGraphLive.TabIndex = 10;
			this.cbGardStatsGraphLive.Text = "Live";
			this.cbGardStatsGraphLive.UseVisualStyleBackColor = true;
			// 
			// cartesianChart2
			// 
			this.cartesianChart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cartesianChart2.Location = new System.Drawing.Point(9, 59);
			this.cartesianChart2.Name = "cartesianChart2";
			this.cartesianChart2.Size = new System.Drawing.Size(713, 376);
			this.cartesianChart2.TabIndex = 9;
			this.cartesianChart2.Text = "cartesianChart2";
			// 
			// btnRunCardStatsGraphReport
			// 
			this.btnRunCardStatsGraphReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRunCardStatsGraphReport.Location = new System.Drawing.Point(647, 441);
			this.btnRunCardStatsGraphReport.Name = "btnRunCardStatsGraphReport";
			this.btnRunCardStatsGraphReport.Size = new System.Drawing.Size(75, 23);
			this.btnRunCardStatsGraphReport.TabIndex = 8;
			this.btnRunCardStatsGraphReport.Text = "Run Report";
			this.btnRunCardStatsGraphReport.UseVisualStyleBackColor = true;
			this.btnRunCardStatsGraphReport.Click += new System.EventHandler(this.btnRunCardStatsGraphReport_Click);
			// 
			// tbCardStatsGraphWallet
			// 
			this.tbCardStatsGraphWallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCardStatsGraphWallet.Location = new System.Drawing.Point(93, 33);
			this.tbCardStatsGraphWallet.Name = "tbCardStatsGraphWallet";
			this.tbCardStatsGraphWallet.Size = new System.Drawing.Size(404, 20);
			this.tbCardStatsGraphWallet.TabIndex = 7;
			this.tbCardStatsGraphWallet.Text = "37s2ZBNJ64sa1bkYh3HWAkncJSxcXoBzvn";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Wallet Address:";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(503, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "End Time:";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(500, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Start Time:";
			// 
			// nudCardStatsGraphEnd
			// 
			this.nudCardStatsGraphEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nudCardStatsGraphEnd.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.nudCardStatsGraphEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.nudCardStatsGraphEnd.Location = new System.Drawing.Point(564, 32);
			this.nudCardStatsGraphEnd.Name = "nudCardStatsGraphEnd";
			this.nudCardStatsGraphEnd.Size = new System.Drawing.Size(158, 20);
			this.nudCardStatsGraphEnd.TabIndex = 3;
			// 
			// dtpCardStatsGraphStart
			// 
			this.dtpCardStatsGraphStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpCardStatsGraphStart.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.dtpCardStatsGraphStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCardStatsGraphStart.Location = new System.Drawing.Point(564, 6);
			this.dtpCardStatsGraphStart.Name = "dtpCardStatsGraphStart";
			this.dtpCardStatsGraphStart.Size = new System.Drawing.Size(158, 20);
			this.dtpCardStatsGraphStart.TabIndex = 2;
			this.dtpCardStatsGraphStart.Value = new System.DateTime(2018, 1, 4, 16, 17, 0, 0);
			// 
			// cbCardStatsGraphReport
			// 
			this.cbCardStatsGraphReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCardStatsGraphReport.FormattingEnabled = true;
			this.cbCardStatsGraphReport.Items.AddRange(new object[] {
            "Power Usage (Watts)",
            "Average Card Temp",
            "Rig Efficiency",
            "Calculated Earnings (Average Per Day)"});
			this.cbCardStatsGraphReport.Location = new System.Drawing.Point(54, 6);
			this.cbCardStatsGraphReport.Name = "cbCardStatsGraphReport";
			this.cbCardStatsGraphReport.Size = new System.Drawing.Size(443, 21);
			this.cbCardStatsGraphReport.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Report:";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(728, 470);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Exports";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// timerRigStatsGraphs
			// 
			this.timerRigStatsGraphs.Interval = 10000;
			this.timerRigStatsGraphs.Tick += new System.EventHandler(this.timerRigStatsGraphs_Tick);
			// 
			// timerCardStatsGraphs
			// 
			this.timerCardStatsGraphs.Interval = 10000;
			// 
			// NicehashStatsViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 558);
			this.Controls.Add(this.tcMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NicehashStatsViewer";
			this.Text = "NiceHash Stats Viewer";
			this.tcMain.ResumeLayout(false);
			this.tpRigStats.ResumeLayout(false);
			this.tcRigStats.ResumeLayout(false);
			this.tpRigGraphs.ResumeLayout(false);
			this.tpRigGraphs.PerformLayout();
			this.tpCardStats.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tcMain;
		private System.Windows.Forms.TabPage tpRigStats;
		private System.Windows.Forms.TabControl tcRigStats;
		private System.Windows.Forms.TabPage tpRigGraphs;
		private System.Windows.Forms.DateTimePicker dtpRigStatsGraphsEndTime;
		private System.Windows.Forms.DateTimePicker dtpRigStatsGraphStartTime;
		private System.Windows.Forms.ComboBox cbRigStatsGraphReport;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tpRigStatsExports;
		private System.Windows.Forms.TabPage tpCardStats;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbRigStatsGraphWallet;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnPlotData;
		private LiveCharts.WinForms.CartesianChart cartesianChart1;
		private System.Windows.Forms.Timer timerRigStatsGraphs;
		private System.Windows.Forms.CheckBox cbLive;
		private System.ComponentModel.BackgroundWorker bgwRigStatsReport;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.CheckBox cbGardStatsGraphLive;
		private LiveCharts.WinForms.CartesianChart cartesianChart2;
		private System.Windows.Forms.Button btnRunCardStatsGraphReport;
		private System.Windows.Forms.TextBox tbCardStatsGraphWallet;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker nudCardStatsGraphEnd;
		private System.Windows.Forms.DateTimePicker dtpCardStatsGraphStart;
		private System.Windows.Forms.ComboBox cbCardStatsGraphReport;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabPage2;
		private System.ComponentModel.BackgroundWorker bgwCardStatsReport;
		private System.Windows.Forms.Timer timerCardStatsGraphs;
	}
}

