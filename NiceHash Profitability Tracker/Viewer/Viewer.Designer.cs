namespace Viewer
{
	partial class Viewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
			this.tcMain = new System.Windows.Forms.TabControl();
			this.tpRigStats = new System.Windows.Forms.TabPage();
			this.tcRigStats = new System.Windows.Forms.TabControl();
			this.tpRigGraphs = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.nudRigLastXHours = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.btnRigLast3Hours = new System.Windows.Forms.Button();
			this.btnRigLast12Hours = new System.Windows.Forms.Button();
			this.btnRigLastDay = new System.Windows.Forms.Button();
			this.btnRigLastWeek = new System.Windows.Forms.Button();
			this.btnRigLastMonth = new System.Windows.Forms.Button();
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
			this.tpLiveRigStats = new System.Windows.Forms.TabPage();
			this.dgvLiveRigStats = new System.Windows.Forms.DataGridView();
			this.lblRigPendingWalletBalance = new System.Windows.Forms.LinkLabel();
			this.label14 = new System.Windows.Forms.Label();
			this.tbLiveRigWalletAddr = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tpRigStatsExports = new System.Windows.Forms.TabPage();
			this.dgvRigExport = new System.Windows.Forms.DataGridView();
			this.cbRigExportResolution = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.btnRigExportSave = new System.Windows.Forms.Button();
			this.btnRigExportRunReport = new System.Windows.Forms.Button();
			this.btnRigExportReportRefresh = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnRigExportYTD = new System.Windows.Forms.Button();
			this.btnRigExportMTD = new System.Windows.Forms.Button();
			this.btnRigExportWTD = new System.Windows.Forms.Button();
			this.btnRigExportLY = new System.Windows.Forms.Button();
			this.btnRigExportLM = new System.Windows.Forms.Button();
			this.btnRigExportLW = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.dtpRigExportEnd = new System.Windows.Forms.DateTimePicker();
			this.dtpRigExportStart = new System.Windows.Forms.DateTimePicker();
			this.tbRigExportWallet = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.cbRigExportReport = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.tpCardStats = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCardLast3Hours = new System.Windows.Forms.Button();
			this.btnCardLast12Hours = new System.Windows.Forms.Button();
			this.btnCardLastDay = new System.Windows.Forms.Button();
			this.btnCardLastWeek = new System.Windows.Forms.Button();
			this.btnCardLastMonth = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.nudCardLastXHours = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.cbCardUseFriendlyName = new System.Windows.Forms.CheckBox();
			this.cbGardStatsGraphLive = new System.Windows.Forms.CheckBox();
			this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
			this.btnRunCardStatsGraphReport = new System.Windows.Forms.Button();
			this.tbCardStatsGraphWallet = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpCardStatsGraphEnd = new System.Windows.Forms.DateTimePicker();
			this.dtpCardStatsGraphStart = new System.Windows.Forms.DateTimePicker();
			this.cbCardStatsGraphReport = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tpCardLiveStats = new System.Windows.Forms.TabPage();
			this.cbCardLiveStatFriendlyName = new System.Windows.Forms.CheckBox();
			this.dgvLiveCardStats = new System.Windows.Forms.DataGridView();
			this.lblCardLiveSite = new System.Windows.Forms.LinkLabel();
			this.label15 = new System.Windows.Forms.Label();
			this.tbCardLiveWalletAddress = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dgvCardExport = new System.Windows.Forms.DataGridView();
			this.cbCardExportResolution = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.btnCardExportSave = new System.Windows.Forms.Button();
			this.btnCardExportRunReport = new System.Windows.Forms.Button();
			this.btnCardExportReportRefresh = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCardExportYTD = new System.Windows.Forms.Button();
			this.btnCardExportMTD = new System.Windows.Forms.Button();
			this.btnCardExportWTD = new System.Windows.Forms.Button();
			this.btnCardExportLY = new System.Windows.Forms.Button();
			this.btnCardExportLM = new System.Windows.Forms.Button();
			this.btnCardExportLW = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.dtpCardExportEnd = new System.Windows.Forms.DateTimePicker();
			this.dtpCardExportStart = new System.Windows.Forms.DateTimePicker();
			this.tbCardExportWallet = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.cbCardExportReportSelect = new System.Windows.Forms.ComboBox();
			this.label26 = new System.Windows.Forms.Label();
			this.timerRigStatsGraphs = new System.Windows.Forms.Timer(this.components);
			this.bgwRigStatsReport = new System.ComponentModel.BackgroundWorker();
			this.bgwCardStatsReport = new System.ComponentModel.BackgroundWorker();
			this.timerCardStatsGraphs = new System.Windows.Forms.Timer(this.components);
			this.lblReleaseNotes = new System.Windows.Forms.LinkLabel();
			this.lblNewRelease = new System.Windows.Forms.LinkLabel();
			this.timerNewReleaseCheck = new System.Windows.Forms.Timer(this.components);
			this.timerLiveStatsRefresh = new System.Windows.Forms.Timer(this.components);
			this.timerLiveCardStatsRefresh = new System.Windows.Forms.Timer(this.components);
			this.tcMain.SuspendLayout();
			this.tpRigStats.SuspendLayout();
			this.tcRigStats.SuspendLayout();
			this.tpRigGraphs.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRigLastXHours)).BeginInit();
			this.tpLiveRigStats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLiveRigStats)).BeginInit();
			this.tpRigStatsExports.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRigExport)).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.tpCardStats.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCardLastXHours)).BeginInit();
			this.tpCardLiveStats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLiveCardStats)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCardExport)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
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
			this.tcMain.Size = new System.Drawing.Size(712, 537);
			this.tcMain.TabIndex = 0;
			this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
			// 
			// tpRigStats
			// 
			this.tpRigStats.Controls.Add(this.tcRigStats);
			this.tpRigStats.Location = new System.Drawing.Point(4, 22);
			this.tpRigStats.Name = "tpRigStats";
			this.tpRigStats.Padding = new System.Windows.Forms.Padding(3);
			this.tpRigStats.Size = new System.Drawing.Size(704, 511);
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
			this.tcRigStats.Controls.Add(this.tpLiveRigStats);
			this.tcRigStats.Controls.Add(this.tpRigStatsExports);
			this.tcRigStats.Location = new System.Drawing.Point(6, 6);
			this.tcRigStats.Name = "tcRigStats";
			this.tcRigStats.SelectedIndex = 0;
			this.tcRigStats.Size = new System.Drawing.Size(692, 499);
			this.tcRigStats.TabIndex = 0;
			this.tcRigStats.SelectedIndexChanged += new System.EventHandler(this.tcRigStats_SelectedIndexChanged);
			// 
			// tpRigGraphs
			// 
			this.tpRigGraphs.Controls.Add(this.tableLayoutPanel1);
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
			this.tpRigGraphs.Size = new System.Drawing.Size(684, 473);
			this.tpRigGraphs.TabIndex = 0;
			this.tpRigGraphs.Text = "Graphs";
			this.tpRigGraphs.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Controls.Add(this.panel2, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRigLast3Hours, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRigLast12Hours, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRigLastDay, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRigLastWeek, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRigLastMonth, 4, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 59);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 29);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.nudRigLastXHours);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(558, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(111, 23);
			this.panel2.TabIndex = 6;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(73, 5);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 13);
			this.label11.TabIndex = 2;
			this.label11.Text = "Hours";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nudRigLastXHours
			// 
			this.nudRigLastXHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudRigLastXHours.Location = new System.Drawing.Point(36, 3);
			this.nudRigLastXHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.nudRigLastXHours.Name = "nudRigLastXHours";
			this.nudRigLastXHours.Size = new System.Drawing.Size(31, 20);
			this.nudRigLastXHours.TabIndex = 1;
			this.nudRigLastXHours.ValueChanged += new System.EventHandler(this.nudRigLastXHours_ValueChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 5);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(27, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "Last";
			// 
			// btnRigLast3Hours
			// 
			this.btnRigLast3Hours.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigLast3Hours.Location = new System.Drawing.Point(3, 3);
			this.btnRigLast3Hours.Name = "btnRigLast3Hours";
			this.btnRigLast3Hours.Size = new System.Drawing.Size(105, 23);
			this.btnRigLast3Hours.TabIndex = 0;
			this.btnRigLast3Hours.Text = "Last 3 Hours";
			this.btnRigLast3Hours.UseVisualStyleBackColor = true;
			this.btnRigLast3Hours.Click += new System.EventHandler(this.btnLast3Hours_Click);
			// 
			// btnRigLast12Hours
			// 
			this.btnRigLast12Hours.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigLast12Hours.Location = new System.Drawing.Point(114, 3);
			this.btnRigLast12Hours.Name = "btnRigLast12Hours";
			this.btnRigLast12Hours.Size = new System.Drawing.Size(105, 23);
			this.btnRigLast12Hours.TabIndex = 1;
			this.btnRigLast12Hours.Text = "Last 12 Hours";
			this.btnRigLast12Hours.UseVisualStyleBackColor = true;
			this.btnRigLast12Hours.Click += new System.EventHandler(this.btnLast12Hours_Click);
			// 
			// btnRigLastDay
			// 
			this.btnRigLastDay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigLastDay.Location = new System.Drawing.Point(225, 3);
			this.btnRigLastDay.Name = "btnRigLastDay";
			this.btnRigLastDay.Size = new System.Drawing.Size(105, 23);
			this.btnRigLastDay.TabIndex = 2;
			this.btnRigLastDay.Text = "Last Day";
			this.btnRigLastDay.UseVisualStyleBackColor = true;
			this.btnRigLastDay.Click += new System.EventHandler(this.btnLastDay_Click);
			// 
			// btnRigLastWeek
			// 
			this.btnRigLastWeek.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigLastWeek.Location = new System.Drawing.Point(336, 3);
			this.btnRigLastWeek.Name = "btnRigLastWeek";
			this.btnRigLastWeek.Size = new System.Drawing.Size(105, 23);
			this.btnRigLastWeek.TabIndex = 3;
			this.btnRigLastWeek.Text = "Last Week";
			this.btnRigLastWeek.UseVisualStyleBackColor = true;
			this.btnRigLastWeek.Click += new System.EventHandler(this.btnLastWeek_Click);
			// 
			// btnRigLastMonth
			// 
			this.btnRigLastMonth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigLastMonth.Location = new System.Drawing.Point(447, 3);
			this.btnRigLastMonth.Name = "btnRigLastMonth";
			this.btnRigLastMonth.Size = new System.Drawing.Size(105, 23);
			this.btnRigLastMonth.TabIndex = 4;
			this.btnRigLastMonth.Text = "Last Month";
			this.btnRigLastMonth.UseVisualStyleBackColor = true;
			this.btnRigLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
			// 
			// cbLive
			// 
			this.cbLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbLive.AutoSize = true;
			this.cbLive.Location = new System.Drawing.Point(9, 444);
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
			this.cartesianChart1.Location = new System.Drawing.Point(9, 94);
			this.cartesianChart1.Name = "cartesianChart1";
			this.cartesianChart1.Size = new System.Drawing.Size(669, 344);
			this.cartesianChart1.TabIndex = 9;
			this.cartesianChart1.Text = "cartesianChart1";
			// 
			// btnPlotData
			// 
			this.btnPlotData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlotData.Location = new System.Drawing.Point(603, 444);
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
			this.tbRigStatsGraphWallet.Size = new System.Drawing.Size(360, 20);
			this.tbRigStatsGraphWallet.TabIndex = 7;
			this.tbRigStatsGraphWallet.Text = "37s2ZBNJ64sa1bkYh3HWAkncJSxcXoBzvn";
			this.tbRigStatsGraphWallet.TextChanged += new System.EventHandler(this.tbRigStatsGraphWallet_TextChanged);
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
			this.label3.Location = new System.Drawing.Point(459, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "End Time:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(456, 9);
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
			this.dtpRigStatsGraphsEndTime.Location = new System.Drawing.Point(520, 32);
			this.dtpRigStatsGraphsEndTime.Name = "dtpRigStatsGraphsEndTime";
			this.dtpRigStatsGraphsEndTime.Size = new System.Drawing.Size(158, 20);
			this.dtpRigStatsGraphsEndTime.TabIndex = 3;
			this.dtpRigStatsGraphsEndTime.ValueChanged += new System.EventHandler(this.dtpRigStatsGraphsEndTime_ValueChanged);
			// 
			// dtpRigStatsGraphStartTime
			// 
			this.dtpRigStatsGraphStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpRigStatsGraphStartTime.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.dtpRigStatsGraphStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRigStatsGraphStartTime.Location = new System.Drawing.Point(520, 6);
			this.dtpRigStatsGraphStartTime.Name = "dtpRigStatsGraphStartTime";
			this.dtpRigStatsGraphStartTime.Size = new System.Drawing.Size(158, 20);
			this.dtpRigStatsGraphStartTime.TabIndex = 2;
			this.dtpRigStatsGraphStartTime.Value = new System.DateTime(2018, 1, 4, 16, 17, 0, 0);
			this.dtpRigStatsGraphStartTime.ValueChanged += new System.EventHandler(this.dtpRigStatsGraphStartTime_ValueChanged);
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
			this.cbRigStatsGraphReport.Size = new System.Drawing.Size(399, 21);
			this.cbRigStatsGraphReport.TabIndex = 1;
			this.cbRigStatsGraphReport.SelectedIndexChanged += new System.EventHandler(this.cbRigStatsGraphReport_SelectedIndexChanged);
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
			// tpLiveRigStats
			// 
			this.tpLiveRigStats.Controls.Add(this.dgvLiveRigStats);
			this.tpLiveRigStats.Controls.Add(this.lblRigPendingWalletBalance);
			this.tpLiveRigStats.Controls.Add(this.label14);
			this.tpLiveRigStats.Controls.Add(this.tbLiveRigWalletAddr);
			this.tpLiveRigStats.Controls.Add(this.label13);
			this.tpLiveRigStats.Location = new System.Drawing.Point(4, 22);
			this.tpLiveRigStats.Name = "tpLiveRigStats";
			this.tpLiveRigStats.Padding = new System.Windows.Forms.Padding(3);
			this.tpLiveRigStats.Size = new System.Drawing.Size(684, 473);
			this.tpLiveRigStats.TabIndex = 2;
			this.tpLiveRigStats.Text = "Live";
			this.tpLiveRigStats.UseVisualStyleBackColor = true;
			// 
			// dgvLiveRigStats
			// 
			this.dgvLiveRigStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvLiveRigStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvLiveRigStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLiveRigStats.Location = new System.Drawing.Point(9, 32);
			this.dgvLiveRigStats.Name = "dgvLiveRigStats";
			this.dgvLiveRigStats.Size = new System.Drawing.Size(669, 422);
			this.dgvLiveRigStats.TabIndex = 12;
			// 
			// lblRigPendingWalletBalance
			// 
			this.lblRigPendingWalletBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblRigPendingWalletBalance.AutoSize = true;
			this.lblRigPendingWalletBalance.Location = new System.Drawing.Point(136, 457);
			this.lblRigPendingWalletBalance.Name = "lblRigPendingWalletBalance";
			this.lblRigPendingWalletBalance.Size = new System.Drawing.Size(55, 13);
			this.lblRigPendingWalletBalance.TabIndex = 11;
			this.lblRigPendingWalletBalance.TabStop = true;
			this.lblRigPendingWalletBalance.Text = "linkLabel1";
			this.lblRigPendingWalletBalance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRigPendingWalletBalance_LinkClicked);
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 457);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(124, 13);
			this.label14.TabIndex = 10;
			this.label14.Text = "Pending Wallet Balance:";
			// 
			// tbLiveRigWalletAddr
			// 
			this.tbLiveRigWalletAddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLiveRigWalletAddr.Location = new System.Drawing.Point(92, 6);
			this.tbLiveRigWalletAddr.Name = "tbLiveRigWalletAddr";
			this.tbLiveRigWalletAddr.Size = new System.Drawing.Size(586, 20);
			this.tbLiveRigWalletAddr.TabIndex = 9;
			this.tbLiveRigWalletAddr.Text = "37s2ZBNJ64sa1bkYh3HWAkncJSxcXoBzvn";
			this.tbLiveRigWalletAddr.TextChanged += new System.EventHandler(this.tbRigStatsGraphWallet_TextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(5, 9);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(81, 13);
			this.label13.TabIndex = 8;
			this.label13.Text = "Wallet Address:";
			// 
			// tpRigStatsExports
			// 
			this.tpRigStatsExports.Controls.Add(this.dgvRigExport);
			this.tpRigStatsExports.Controls.Add(this.cbRigExportResolution);
			this.tpRigStatsExports.Controls.Add(this.label23);
			this.tpRigStatsExports.Controls.Add(this.btnRigExportSave);
			this.tpRigStatsExports.Controls.Add(this.btnRigExportRunReport);
			this.tpRigStatsExports.Controls.Add(this.btnRigExportReportRefresh);
			this.tpRigStatsExports.Controls.Add(this.tableLayoutPanel3);
			this.tpRigStatsExports.Controls.Add(this.label19);
			this.tpRigStatsExports.Controls.Add(this.dtpRigExportEnd);
			this.tpRigStatsExports.Controls.Add(this.dtpRigExportStart);
			this.tpRigStatsExports.Controls.Add(this.tbRigExportWallet);
			this.tpRigStatsExports.Controls.Add(this.label20);
			this.tpRigStatsExports.Controls.Add(this.label21);
			this.tpRigStatsExports.Controls.Add(this.cbRigExportReport);
			this.tpRigStatsExports.Controls.Add(this.label22);
			this.tpRigStatsExports.Location = new System.Drawing.Point(4, 22);
			this.tpRigStatsExports.Name = "tpRigStatsExports";
			this.tpRigStatsExports.Padding = new System.Windows.Forms.Padding(3);
			this.tpRigStatsExports.Size = new System.Drawing.Size(684, 473);
			this.tpRigStatsExports.TabIndex = 1;
			this.tpRigStatsExports.Text = "Exports";
			this.tpRigStatsExports.UseVisualStyleBackColor = true;
			this.tpRigStatsExports.Click += new System.EventHandler(this.tpRigStatsExports_Click);
			// 
			// dgvRigExport
			// 
			this.dgvRigExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvRigExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRigExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRigExport.Location = new System.Drawing.Point(6, 94);
			this.dgvRigExport.Name = "dgvRigExport";
			this.dgvRigExport.Size = new System.Drawing.Size(672, 344);
			this.dgvRigExport.TabIndex = 26;
			// 
			// cbRigExportResolution
			// 
			this.cbRigExportResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbRigExportResolution.FormattingEnabled = true;
			this.cbRigExportResolution.Items.AddRange(new object[] {
            "Monthly",
            "Weekly",
            "Daily"});
			this.cbRigExportResolution.Location = new System.Drawing.Point(408, 33);
			this.cbRigExportResolution.Name = "cbRigExportResolution";
			this.cbRigExportResolution.Size = new System.Drawing.Size(92, 21);
			this.cbRigExportResolution.TabIndex = 25;
			// 
			// label23
			// 
			this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(342, 36);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(60, 13);
			this.label23.TabIndex = 24;
			this.label23.Text = "Resolution:";
			// 
			// btnRigExportSave
			// 
			this.btnRigExportSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRigExportSave.Location = new System.Drawing.Point(522, 444);
			this.btnRigExportSave.Name = "btnRigExportSave";
			this.btnRigExportSave.Size = new System.Drawing.Size(75, 23);
			this.btnRigExportSave.TabIndex = 23;
			this.btnRigExportSave.Text = "Save";
			this.btnRigExportSave.UseVisualStyleBackColor = true;
			this.btnRigExportSave.Click += new System.EventHandler(this.btnRigExportSave_Click);
			// 
			// btnRigExportRunReport
			// 
			this.btnRigExportRunReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRigExportRunReport.Location = new System.Drawing.Point(603, 444);
			this.btnRigExportRunReport.Name = "btnRigExportRunReport";
			this.btnRigExportRunReport.Size = new System.Drawing.Size(75, 23);
			this.btnRigExportRunReport.TabIndex = 22;
			this.btnRigExportRunReport.Text = "Run Report";
			this.btnRigExportRunReport.UseVisualStyleBackColor = true;
			this.btnRigExportRunReport.Click += new System.EventHandler(this.btnRigExportRunReport_Click);
			// 
			// btnRigExportReportRefresh
			// 
			this.btnRigExportReportRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRigExportReportRefresh.Location = new System.Drawing.Point(425, 5);
			this.btnRigExportReportRefresh.Name = "btnRigExportReportRefresh";
			this.btnRigExportReportRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRigExportReportRefresh.TabIndex = 21;
			this.btnRigExportReportRefresh.Text = "Refresh";
			this.btnRigExportReportRefresh.UseVisualStyleBackColor = true;
			this.btnRigExportReportRefresh.Click += new System.EventHandler(this.btnRigExportReportRefresh_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 6;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel3.Controls.Add(this.btnRigExportYTD, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnRigExportMTD, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnRigExportWTD, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnRigExportLY, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnRigExportLM, 4, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnRigExportLW, 5, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 59);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(672, 29);
			this.tableLayoutPanel3.TabIndex = 20;
			// 
			// btnRigExportYTD
			// 
			this.btnRigExportYTD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigExportYTD.Location = new System.Drawing.Point(3, 3);
			this.btnRigExportYTD.Name = "btnRigExportYTD";
			this.btnRigExportYTD.Size = new System.Drawing.Size(105, 23);
			this.btnRigExportYTD.TabIndex = 0;
			this.btnRigExportYTD.Text = "Year to Date";
			this.btnRigExportYTD.UseVisualStyleBackColor = true;
			this.btnRigExportYTD.Click += new System.EventHandler(this.btnRigExportYTD_Click);
			// 
			// btnRigExportMTD
			// 
			this.btnRigExportMTD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigExportMTD.Location = new System.Drawing.Point(114, 3);
			this.btnRigExportMTD.Name = "btnRigExportMTD";
			this.btnRigExportMTD.Size = new System.Drawing.Size(105, 23);
			this.btnRigExportMTD.TabIndex = 1;
			this.btnRigExportMTD.Text = "Month to Date";
			this.btnRigExportMTD.UseVisualStyleBackColor = true;
			this.btnRigExportMTD.Click += new System.EventHandler(this.btnRigExportMTD_Click);
			// 
			// btnRigExportWTD
			// 
			this.btnRigExportWTD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigExportWTD.Location = new System.Drawing.Point(225, 3);
			this.btnRigExportWTD.Name = "btnRigExportWTD";
			this.btnRigExportWTD.Size = new System.Drawing.Size(105, 23);
			this.btnRigExportWTD.TabIndex = 2;
			this.btnRigExportWTD.Text = "Week to Date";
			this.btnRigExportWTD.UseVisualStyleBackColor = true;
			this.btnRigExportWTD.Click += new System.EventHandler(this.btnRigExportWTD_Click);
			// 
			// btnRigExportLY
			// 
			this.btnRigExportLY.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigExportLY.Location = new System.Drawing.Point(336, 3);
			this.btnRigExportLY.Name = "btnRigExportLY";
			this.btnRigExportLY.Size = new System.Drawing.Size(105, 23);
			this.btnRigExportLY.TabIndex = 3;
			this.btnRigExportLY.Text = "Last Year";
			this.btnRigExportLY.UseVisualStyleBackColor = true;
			this.btnRigExportLY.Click += new System.EventHandler(this.btnRigExportLY_Click);
			// 
			// btnRigExportLM
			// 
			this.btnRigExportLM.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigExportLM.Location = new System.Drawing.Point(447, 3);
			this.btnRigExportLM.Name = "btnRigExportLM";
			this.btnRigExportLM.Size = new System.Drawing.Size(105, 23);
			this.btnRigExportLM.TabIndex = 4;
			this.btnRigExportLM.Text = "Last Month";
			this.btnRigExportLM.UseVisualStyleBackColor = true;
			this.btnRigExportLM.Click += new System.EventHandler(this.btnRigExportLM_Click);
			// 
			// btnRigExportLW
			// 
			this.btnRigExportLW.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRigExportLW.Location = new System.Drawing.Point(558, 3);
			this.btnRigExportLW.Name = "btnRigExportLW";
			this.btnRigExportLW.Size = new System.Drawing.Size(111, 23);
			this.btnRigExportLW.TabIndex = 5;
			this.btnRigExportLW.Text = "Last Week";
			this.btnRigExportLW.UseVisualStyleBackColor = true;
			this.btnRigExportLW.Click += new System.EventHandler(this.btnRigExportLW_Click);
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(509, 36);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(55, 13);
			this.label19.TabIndex = 17;
			this.label19.Text = "End Time:";
			// 
			// dtpRigExportEnd
			// 
			this.dtpRigExportEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpRigExportEnd.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.dtpRigExportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpRigExportEnd.Location = new System.Drawing.Point(570, 32);
			this.dtpRigExportEnd.Name = "dtpRigExportEnd";
			this.dtpRigExportEnd.Size = new System.Drawing.Size(108, 20);
			this.dtpRigExportEnd.TabIndex = 15;
			// 
			// dtpRigExportStart
			// 
			this.dtpRigExportStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpRigExportStart.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.dtpRigExportStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpRigExportStart.Location = new System.Drawing.Point(570, 6);
			this.dtpRigExportStart.Name = "dtpRigExportStart";
			this.dtpRigExportStart.Size = new System.Drawing.Size(108, 20);
			this.dtpRigExportStart.TabIndex = 14;
			this.dtpRigExportStart.Value = new System.DateTime(2018, 1, 4, 16, 17, 0, 0);
			// 
			// tbRigExportWallet
			// 
			this.tbRigExportWallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRigExportWallet.Location = new System.Drawing.Point(93, 33);
			this.tbRigExportWallet.Name = "tbRigExportWallet";
			this.tbRigExportWallet.Size = new System.Drawing.Size(243, 20);
			this.tbRigExportWallet.TabIndex = 19;
			this.tbRigExportWallet.Text = "37s2ZBNJ64sa1bkYh3HWAkncJSxcXoBzvn";
			this.tbRigExportWallet.TextChanged += new System.EventHandler(this.tbRigStatsGraphWallet_TextChanged);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(6, 36);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(81, 13);
			this.label20.TabIndex = 18;
			this.label20.Text = "Wallet Address:";
			// 
			// label21
			// 
			this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(506, 9);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(58, 13);
			this.label21.TabIndex = 16;
			this.label21.Text = "Start Time:";
			// 
			// cbRigExportReport
			// 
			this.cbRigExportReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbRigExportReport.FormattingEnabled = true;
			this.cbRigExportReport.Items.AddRange(new object[] {
            "Power Usage (Watts)",
            "Average Card Temp",
            "Rig Efficiency",
            "Calculated Earnings (Average Per Day)"});
			this.cbRigExportReport.Location = new System.Drawing.Point(54, 6);
			this.cbRigExportReport.Name = "cbRigExportReport";
			this.cbRigExportReport.Size = new System.Drawing.Size(365, 21);
			this.cbRigExportReport.TabIndex = 13;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(6, 9);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(42, 13);
			this.label22.TabIndex = 12;
			this.label22.Text = "Report:";
			// 
			// tpCardStats
			// 
			this.tpCardStats.Controls.Add(this.tabControl1);
			this.tpCardStats.Location = new System.Drawing.Point(4, 22);
			this.tpCardStats.Name = "tpCardStats";
			this.tpCardStats.Padding = new System.Windows.Forms.Padding(3);
			this.tpCardStats.Size = new System.Drawing.Size(704, 511);
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
			this.tabControl1.Controls.Add(this.tpCardLiveStats);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(6, 6);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(692, 499);
			this.tabControl1.TabIndex = 1;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tableLayoutPanel2);
			this.tabPage1.Controls.Add(this.cbCardUseFriendlyName);
			this.tabPage1.Controls.Add(this.cbGardStatsGraphLive);
			this.tabPage1.Controls.Add(this.cartesianChart2);
			this.tabPage1.Controls.Add(this.btnRunCardStatsGraphReport);
			this.tabPage1.Controls.Add(this.tbCardStatsGraphWallet);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.dtpCardStatsGraphEnd);
			this.tabPage1.Controls.Add(this.dtpCardStatsGraphStart);
			this.tabPage1.Controls.Add(this.cbCardStatsGraphReport);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(684, 473);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Graphs";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 6;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66945F));
			this.tableLayoutPanel2.Controls.Add(this.btnCardLast3Hours, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnCardLast12Hours, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnCardLastDay, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnCardLastWeek, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnCardLastMonth, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel1, 5, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 59);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(672, 29);
			this.tableLayoutPanel2.TabIndex = 12;
			// 
			// btnCardLast3Hours
			// 
			this.btnCardLast3Hours.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardLast3Hours.Location = new System.Drawing.Point(3, 3);
			this.btnCardLast3Hours.Name = "btnCardLast3Hours";
			this.btnCardLast3Hours.Size = new System.Drawing.Size(105, 23);
			this.btnCardLast3Hours.TabIndex = 0;
			this.btnCardLast3Hours.Text = "Last 3 Hours";
			this.btnCardLast3Hours.UseVisualStyleBackColor = true;
			this.btnCardLast3Hours.Click += new System.EventHandler(this.btnCardLast3Hours_Click);
			// 
			// btnCardLast12Hours
			// 
			this.btnCardLast12Hours.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardLast12Hours.Location = new System.Drawing.Point(114, 3);
			this.btnCardLast12Hours.Name = "btnCardLast12Hours";
			this.btnCardLast12Hours.Size = new System.Drawing.Size(105, 23);
			this.btnCardLast12Hours.TabIndex = 1;
			this.btnCardLast12Hours.Text = "Last 12 Hours";
			this.btnCardLast12Hours.UseVisualStyleBackColor = true;
			this.btnCardLast12Hours.Click += new System.EventHandler(this.btnCardLast12Hours_Click);
			// 
			// btnCardLastDay
			// 
			this.btnCardLastDay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardLastDay.Location = new System.Drawing.Point(225, 3);
			this.btnCardLastDay.Name = "btnCardLastDay";
			this.btnCardLastDay.Size = new System.Drawing.Size(105, 23);
			this.btnCardLastDay.TabIndex = 2;
			this.btnCardLastDay.Text = "Last Day";
			this.btnCardLastDay.UseVisualStyleBackColor = true;
			this.btnCardLastDay.Click += new System.EventHandler(this.btnCardLastDay_Click);
			// 
			// btnCardLastWeek
			// 
			this.btnCardLastWeek.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardLastWeek.Location = new System.Drawing.Point(336, 3);
			this.btnCardLastWeek.Name = "btnCardLastWeek";
			this.btnCardLastWeek.Size = new System.Drawing.Size(105, 23);
			this.btnCardLastWeek.TabIndex = 3;
			this.btnCardLastWeek.Text = "Last Week";
			this.btnCardLastWeek.UseVisualStyleBackColor = true;
			this.btnCardLastWeek.Click += new System.EventHandler(this.btnCardLastWeek_Click);
			// 
			// btnCardLastMonth
			// 
			this.btnCardLastMonth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardLastMonth.Location = new System.Drawing.Point(447, 3);
			this.btnCardLastMonth.Name = "btnCardLastMonth";
			this.btnCardLastMonth.Size = new System.Drawing.Size(105, 23);
			this.btnCardLastMonth.TabIndex = 4;
			this.btnCardLastMonth.Text = "Last Month";
			this.btnCardLastMonth.UseVisualStyleBackColor = true;
			this.btnCardLastMonth.Click += new System.EventHandler(this.btnCardLastMonth_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.nudCardLastXHours);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(558, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(111, 23);
			this.panel1.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(73, 5);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 2;
			this.label10.Text = "Hours";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nudCardLastXHours
			// 
			this.nudCardLastXHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudCardLastXHours.Location = new System.Drawing.Point(36, 3);
			this.nudCardLastXHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.nudCardLastXHours.Name = "nudCardLastXHours";
			this.nudCardLastXHours.Size = new System.Drawing.Size(31, 20);
			this.nudCardLastXHours.TabIndex = 1;
			this.nudCardLastXHours.ValueChanged += new System.EventHandler(this.nudCardLastXHours_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 5);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(27, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Last";
			// 
			// cbCardUseFriendlyName
			// 
			this.cbCardUseFriendlyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbCardUseFriendlyName.AutoSize = true;
			this.cbCardUseFriendlyName.Location = new System.Drawing.Point(9, 448);
			this.cbCardUseFriendlyName.Name = "cbCardUseFriendlyName";
			this.cbCardUseFriendlyName.Size = new System.Drawing.Size(115, 17);
			this.cbCardUseFriendlyName.TabIndex = 11;
			this.cbCardUseFriendlyName.Text = "Use Friendly Name";
			this.cbCardUseFriendlyName.UseVisualStyleBackColor = true;
			// 
			// cbGardStatsGraphLive
			// 
			this.cbGardStatsGraphLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbGardStatsGraphLive.AutoSize = true;
			this.cbGardStatsGraphLive.Location = new System.Drawing.Point(130, 448);
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
			this.cartesianChart2.Location = new System.Drawing.Point(9, 94);
			this.cartesianChart2.Name = "cartesianChart2";
			this.cartesianChart2.Size = new System.Drawing.Size(669, 344);
			this.cartesianChart2.TabIndex = 9;
			this.cartesianChart2.Text = "cartesianChart2";
			// 
			// btnRunCardStatsGraphReport
			// 
			this.btnRunCardStatsGraphReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRunCardStatsGraphReport.Location = new System.Drawing.Point(603, 444);
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
			this.tbCardStatsGraphWallet.Size = new System.Drawing.Size(360, 20);
			this.tbCardStatsGraphWallet.TabIndex = 7;
			this.tbCardStatsGraphWallet.Text = "37s2ZBNJ64sa1bkYh3HWAkncJSxcXoBzvn";
			this.tbCardStatsGraphWallet.TextChanged += new System.EventHandler(this.tbRigStatsGraphWallet_TextChanged);
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
			this.label6.Location = new System.Drawing.Point(459, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "End Time:";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(456, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Start Time:";
			// 
			// dtpCardStatsGraphEnd
			// 
			this.dtpCardStatsGraphEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpCardStatsGraphEnd.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.dtpCardStatsGraphEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCardStatsGraphEnd.Location = new System.Drawing.Point(520, 32);
			this.dtpCardStatsGraphEnd.Name = "dtpCardStatsGraphEnd";
			this.dtpCardStatsGraphEnd.Size = new System.Drawing.Size(158, 20);
			this.dtpCardStatsGraphEnd.TabIndex = 3;
			this.dtpCardStatsGraphEnd.ValueChanged += new System.EventHandler(this.dtpCardStatsGraphEnd_ValueChanged);
			// 
			// dtpCardStatsGraphStart
			// 
			this.dtpCardStatsGraphStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpCardStatsGraphStart.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.dtpCardStatsGraphStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCardStatsGraphStart.Location = new System.Drawing.Point(520, 6);
			this.dtpCardStatsGraphStart.Name = "dtpCardStatsGraphStart";
			this.dtpCardStatsGraphStart.Size = new System.Drawing.Size(158, 20);
			this.dtpCardStatsGraphStart.TabIndex = 2;
			this.dtpCardStatsGraphStart.Value = new System.DateTime(2018, 1, 4, 16, 17, 0, 0);
			this.dtpCardStatsGraphStart.ValueChanged += new System.EventHandler(this.dtpCardStatsGraphStart_ValueChanged);
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
			this.cbCardStatsGraphReport.Size = new System.Drawing.Size(396, 21);
			this.cbCardStatsGraphReport.TabIndex = 1;
			this.cbCardStatsGraphReport.SelectedIndexChanged += new System.EventHandler(this.cbCardStatsGraphReport_SelectedIndexChanged);
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
			// tpCardLiveStats
			// 
			this.tpCardLiveStats.Controls.Add(this.cbCardLiveStatFriendlyName);
			this.tpCardLiveStats.Controls.Add(this.dgvLiveCardStats);
			this.tpCardLiveStats.Controls.Add(this.lblCardLiveSite);
			this.tpCardLiveStats.Controls.Add(this.label15);
			this.tpCardLiveStats.Controls.Add(this.tbCardLiveWalletAddress);
			this.tpCardLiveStats.Controls.Add(this.label16);
			this.tpCardLiveStats.Location = new System.Drawing.Point(4, 22);
			this.tpCardLiveStats.Name = "tpCardLiveStats";
			this.tpCardLiveStats.Size = new System.Drawing.Size(684, 473);
			this.tpCardLiveStats.TabIndex = 2;
			this.tpCardLiveStats.Text = "Live";
			this.tpCardLiveStats.UseVisualStyleBackColor = true;
			// 
			// cbCardLiveStatFriendlyName
			// 
			this.cbCardLiveStatFriendlyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCardLiveStatFriendlyName.AutoSize = true;
			this.cbCardLiveStatFriendlyName.Location = new System.Drawing.Point(563, 8);
			this.cbCardLiveStatFriendlyName.Name = "cbCardLiveStatFriendlyName";
			this.cbCardLiveStatFriendlyName.Size = new System.Drawing.Size(115, 17);
			this.cbCardLiveStatFriendlyName.TabIndex = 18;
			this.cbCardLiveStatFriendlyName.Text = "Use Friendly Name";
			this.cbCardLiveStatFriendlyName.UseVisualStyleBackColor = true;
			// 
			// dgvLiveCardStats
			// 
			this.dgvLiveCardStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvLiveCardStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvLiveCardStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLiveCardStats.Location = new System.Drawing.Point(9, 32);
			this.dgvLiveCardStats.Name = "dgvLiveCardStats";
			this.dgvLiveCardStats.Size = new System.Drawing.Size(669, 422);
			this.dgvLiveCardStats.TabIndex = 17;
			// 
			// lblCardLiveSite
			// 
			this.lblCardLiveSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCardLiveSite.AutoSize = true;
			this.lblCardLiveSite.Location = new System.Drawing.Point(136, 457);
			this.lblCardLiveSite.Name = "lblCardLiveSite";
			this.lblCardLiveSite.Size = new System.Drawing.Size(55, 13);
			this.lblCardLiveSite.TabIndex = 16;
			this.lblCardLiveSite.TabStop = true;
			this.lblCardLiveSite.Text = "linkLabel1";
			this.lblCardLiveSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCardLiveSite_LinkClicked);
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 457);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(124, 13);
			this.label15.TabIndex = 15;
			this.label15.Text = "Pending Wallet Balance:";
			// 
			// tbCardLiveWalletAddress
			// 
			this.tbCardLiveWalletAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCardLiveWalletAddress.Location = new System.Drawing.Point(92, 6);
			this.tbCardLiveWalletAddress.Name = "tbCardLiveWalletAddress";
			this.tbCardLiveWalletAddress.Size = new System.Drawing.Size(465, 20);
			this.tbCardLiveWalletAddress.TabIndex = 14;
			this.tbCardLiveWalletAddress.Text = "37s2ZBNJ64sa1bkYh3HWAkncJSxcXoBzvn";
			this.tbCardLiveWalletAddress.TextChanged += new System.EventHandler(this.tbRigStatsGraphWallet_TextChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(5, 9);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(81, 13);
			this.label16.TabIndex = 13;
			this.label16.Text = "Wallet Address:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dgvCardExport);
			this.tabPage2.Controls.Add(this.cbCardExportResolution);
			this.tabPage2.Controls.Add(this.label17);
			this.tabPage2.Controls.Add(this.btnCardExportSave);
			this.tabPage2.Controls.Add(this.btnCardExportRunReport);
			this.tabPage2.Controls.Add(this.btnCardExportReportRefresh);
			this.tabPage2.Controls.Add(this.tableLayoutPanel4);
			this.tabPage2.Controls.Add(this.label18);
			this.tabPage2.Controls.Add(this.dtpCardExportEnd);
			this.tabPage2.Controls.Add(this.dtpCardExportStart);
			this.tabPage2.Controls.Add(this.tbCardExportWallet);
			this.tabPage2.Controls.Add(this.label24);
			this.tabPage2.Controls.Add(this.label25);
			this.tabPage2.Controls.Add(this.cbCardExportReportSelect);
			this.tabPage2.Controls.Add(this.label26);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(684, 473);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Exports";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dgvCardExport
			// 
			this.dgvCardExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCardExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCardExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCardExport.Location = new System.Drawing.Point(6, 94);
			this.dgvCardExport.Name = "dgvCardExport";
			this.dgvCardExport.Size = new System.Drawing.Size(672, 344);
			this.dgvCardExport.TabIndex = 41;
			// 
			// cbCardExportResolution
			// 
			this.cbCardExportResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCardExportResolution.FormattingEnabled = true;
			this.cbCardExportResolution.Items.AddRange(new object[] {
            "Monthly",
            "Weekly",
            "Daily"});
			this.cbCardExportResolution.Location = new System.Drawing.Point(408, 33);
			this.cbCardExportResolution.Name = "cbCardExportResolution";
			this.cbCardExportResolution.Size = new System.Drawing.Size(92, 21);
			this.cbCardExportResolution.TabIndex = 40;
			this.cbCardExportResolution.SelectedIndexChanged += new System.EventHandler(this.cbCardExportResolution_SelectedIndexChanged);
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(342, 36);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(60, 13);
			this.label17.TabIndex = 39;
			this.label17.Text = "Resolution:";
			// 
			// btnCardExportSave
			// 
			this.btnCardExportSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCardExportSave.Location = new System.Drawing.Point(522, 444);
			this.btnCardExportSave.Name = "btnCardExportSave";
			this.btnCardExportSave.Size = new System.Drawing.Size(75, 23);
			this.btnCardExportSave.TabIndex = 38;
			this.btnCardExportSave.Text = "Save";
			this.btnCardExportSave.UseVisualStyleBackColor = true;
			this.btnCardExportSave.Click += new System.EventHandler(this.btnCardExportSave_Click);
			// 
			// btnCardExportRunReport
			// 
			this.btnCardExportRunReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCardExportRunReport.Location = new System.Drawing.Point(603, 444);
			this.btnCardExportRunReport.Name = "btnCardExportRunReport";
			this.btnCardExportRunReport.Size = new System.Drawing.Size(75, 23);
			this.btnCardExportRunReport.TabIndex = 37;
			this.btnCardExportRunReport.Text = "Run Report";
			this.btnCardExportRunReport.UseVisualStyleBackColor = true;
			this.btnCardExportRunReport.Click += new System.EventHandler(this.btnCardExportRunReport_Click);
			// 
			// btnCardExportReportRefresh
			// 
			this.btnCardExportReportRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCardExportReportRefresh.Location = new System.Drawing.Point(425, 5);
			this.btnCardExportReportRefresh.Name = "btnCardExportReportRefresh";
			this.btnCardExportReportRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnCardExportReportRefresh.TabIndex = 36;
			this.btnCardExportReportRefresh.Text = "Refresh";
			this.btnCardExportReportRefresh.UseVisualStyleBackColor = true;
			this.btnCardExportReportRefresh.Click += new System.EventHandler(this.btnCardExportReportRefresh_Click);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.ColumnCount = 6;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel4.Controls.Add(this.btnCardExportYTD, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnCardExportMTD, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnCardExportWTD, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnCardExportLY, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnCardExportLM, 4, 0);
			this.tableLayoutPanel4.Controls.Add(this.btnCardExportLW, 5, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 59);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(672, 29);
			this.tableLayoutPanel4.TabIndex = 35;
			// 
			// btnCardExportYTD
			// 
			this.btnCardExportYTD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardExportYTD.Location = new System.Drawing.Point(3, 3);
			this.btnCardExportYTD.Name = "btnCardExportYTD";
			this.btnCardExportYTD.Size = new System.Drawing.Size(105, 23);
			this.btnCardExportYTD.TabIndex = 0;
			this.btnCardExportYTD.Text = "Year to Date";
			this.btnCardExportYTD.UseVisualStyleBackColor = true;
			this.btnCardExportYTD.Click += new System.EventHandler(this.btnCardExportYTD_Click);
			// 
			// btnCardExportMTD
			// 
			this.btnCardExportMTD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardExportMTD.Location = new System.Drawing.Point(114, 3);
			this.btnCardExportMTD.Name = "btnCardExportMTD";
			this.btnCardExportMTD.Size = new System.Drawing.Size(105, 23);
			this.btnCardExportMTD.TabIndex = 1;
			this.btnCardExportMTD.Text = "Month to Date";
			this.btnCardExportMTD.UseVisualStyleBackColor = true;
			this.btnCardExportMTD.Click += new System.EventHandler(this.btnCardExportMTD_Click);
			// 
			// btnCardExportWTD
			// 
			this.btnCardExportWTD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardExportWTD.Location = new System.Drawing.Point(225, 3);
			this.btnCardExportWTD.Name = "btnCardExportWTD";
			this.btnCardExportWTD.Size = new System.Drawing.Size(105, 23);
			this.btnCardExportWTD.TabIndex = 2;
			this.btnCardExportWTD.Text = "Week to Date";
			this.btnCardExportWTD.UseVisualStyleBackColor = true;
			this.btnCardExportWTD.Click += new System.EventHandler(this.btnCardExportWTD_Click);
			// 
			// btnCardExportLY
			// 
			this.btnCardExportLY.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardExportLY.Location = new System.Drawing.Point(336, 3);
			this.btnCardExportLY.Name = "btnCardExportLY";
			this.btnCardExportLY.Size = new System.Drawing.Size(105, 23);
			this.btnCardExportLY.TabIndex = 3;
			this.btnCardExportLY.Text = "Last Year";
			this.btnCardExportLY.UseVisualStyleBackColor = true;
			this.btnCardExportLY.Click += new System.EventHandler(this.btnCardExportLY_Click);
			// 
			// btnCardExportLM
			// 
			this.btnCardExportLM.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardExportLM.Location = new System.Drawing.Point(447, 3);
			this.btnCardExportLM.Name = "btnCardExportLM";
			this.btnCardExportLM.Size = new System.Drawing.Size(105, 23);
			this.btnCardExportLM.TabIndex = 4;
			this.btnCardExportLM.Text = "Last Month";
			this.btnCardExportLM.UseVisualStyleBackColor = true;
			this.btnCardExportLM.Click += new System.EventHandler(this.btnCardExportLM_Click);
			// 
			// btnCardExportLW
			// 
			this.btnCardExportLW.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCardExportLW.Location = new System.Drawing.Point(558, 3);
			this.btnCardExportLW.Name = "btnCardExportLW";
			this.btnCardExportLW.Size = new System.Drawing.Size(111, 23);
			this.btnCardExportLW.TabIndex = 5;
			this.btnCardExportLW.Text = "Last Week";
			this.btnCardExportLW.UseVisualStyleBackColor = true;
			this.btnCardExportLW.Click += new System.EventHandler(this.btnCardExportLW_Click);
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(509, 36);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(55, 13);
			this.label18.TabIndex = 32;
			this.label18.Text = "End Time:";
			// 
			// dtpCardExportEnd
			// 
			this.dtpCardExportEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpCardExportEnd.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.dtpCardExportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCardExportEnd.Location = new System.Drawing.Point(570, 32);
			this.dtpCardExportEnd.Name = "dtpCardExportEnd";
			this.dtpCardExportEnd.Size = new System.Drawing.Size(108, 20);
			this.dtpCardExportEnd.TabIndex = 30;
			// 
			// dtpCardExportStart
			// 
			this.dtpCardExportStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpCardExportStart.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
			this.dtpCardExportStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCardExportStart.Location = new System.Drawing.Point(570, 6);
			this.dtpCardExportStart.Name = "dtpCardExportStart";
			this.dtpCardExportStart.Size = new System.Drawing.Size(108, 20);
			this.dtpCardExportStart.TabIndex = 29;
			this.dtpCardExportStart.Value = new System.DateTime(2018, 1, 4, 16, 17, 0, 0);
			// 
			// tbCardExportWallet
			// 
			this.tbCardExportWallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCardExportWallet.Location = new System.Drawing.Point(93, 33);
			this.tbCardExportWallet.Name = "tbCardExportWallet";
			this.tbCardExportWallet.Size = new System.Drawing.Size(243, 20);
			this.tbCardExportWallet.TabIndex = 34;
			this.tbCardExportWallet.Text = "37s2ZBNJ64sa1bkYh3HWAkncJSxcXoBzvn";
			this.tbCardExportWallet.TextChanged += new System.EventHandler(this.tbRigStatsGraphWallet_TextChanged);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(6, 36);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(81, 13);
			this.label24.TabIndex = 33;
			this.label24.Text = "Wallet Address:";
			// 
			// label25
			// 
			this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(506, 9);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(58, 13);
			this.label25.TabIndex = 31;
			this.label25.Text = "Start Time:";
			// 
			// cbCardExportReportSelect
			// 
			this.cbCardExportReportSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCardExportReportSelect.FormattingEnabled = true;
			this.cbCardExportReportSelect.Items.AddRange(new object[] {
            "Power Usage (Watts)",
            "Average Card Temp",
            "Rig Efficiency",
            "Calculated Earnings (Average Per Day)"});
			this.cbCardExportReportSelect.Location = new System.Drawing.Point(54, 6);
			this.cbCardExportReportSelect.Name = "cbCardExportReportSelect";
			this.cbCardExportReportSelect.Size = new System.Drawing.Size(365, 21);
			this.cbCardExportReportSelect.TabIndex = 28;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(6, 9);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(42, 13);
			this.label26.TabIndex = 27;
			this.label26.Text = "Report:";
			// 
			// timerRigStatsGraphs
			// 
			this.timerRigStatsGraphs.Interval = 10000;
			this.timerRigStatsGraphs.Tick += new System.EventHandler(this.timerRigStatsGraphs_Tick);
			// 
			// timerCardStatsGraphs
			// 
			this.timerCardStatsGraphs.Interval = 10000;
			this.timerCardStatsGraphs.Tick += new System.EventHandler(this.timerCardStatsGraphs_Tick);
			// 
			// lblReleaseNotes
			// 
			this.lblReleaseNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblReleaseNotes.AutoSize = true;
			this.lblReleaseNotes.Location = new System.Drawing.Point(331, 552);
			this.lblReleaseNotes.Name = "lblReleaseNotes";
			this.lblReleaseNotes.Size = new System.Drawing.Size(77, 13);
			this.lblReleaseNotes.TabIndex = 1;
			this.lblReleaseNotes.TabStop = true;
			this.lblReleaseNotes.Text = "Release Notes";
			this.lblReleaseNotes.Visible = false;
			this.lblReleaseNotes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReleaseNotes_LinkClicked);
			// 
			// lblNewRelease
			// 
			this.lblNewRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblNewRelease.AutoSize = true;
			this.lblNewRelease.Location = new System.Drawing.Point(12, 552);
			this.lblNewRelease.Name = "lblNewRelease";
			this.lblNewRelease.Size = new System.Drawing.Size(313, 13);
			this.lblNewRelease.TabIndex = 2;
			this.lblNewRelease.TabStop = true;
			this.lblNewRelease.Text = "A new release is avaialble for download.  Click here to download.";
			this.lblNewRelease.Visible = false;
			this.lblNewRelease.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNewRelease_LinkClicked);
			// 
			// timerNewReleaseCheck
			// 
			this.timerNewReleaseCheck.Interval = 3600000;
			this.timerNewReleaseCheck.Tick += new System.EventHandler(this.timerNewReleaseCheck_Tick);
			// 
			// timerLiveStatsRefresh
			// 
			this.timerLiveStatsRefresh.Interval = 60000;
			this.timerLiveStatsRefresh.Tick += new System.EventHandler(this.timerLiveStatsRefresh_Tick);
			// 
			// timerLiveCardStatsRefresh
			// 
			this.timerLiveCardStatsRefresh.Interval = 60000;
			this.timerLiveCardStatsRefresh.Tick += new System.EventHandler(this.timerLiveCardStatsRefresh_Tick);
			// 
			// Viewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 574);
			this.Controls.Add(this.lblNewRelease);
			this.Controls.Add(this.lblReleaseNotes);
			this.Controls.Add(this.tcMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Viewer";
			this.Text = "NiceHash Stats Viewer";
			this.Load += new System.EventHandler(this.NicehashStatsViewer_Load);
			this.tcMain.ResumeLayout(false);
			this.tpRigStats.ResumeLayout(false);
			this.tcRigStats.ResumeLayout(false);
			this.tpRigGraphs.ResumeLayout(false);
			this.tpRigGraphs.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudRigLastXHours)).EndInit();
			this.tpLiveRigStats.ResumeLayout(false);
			this.tpLiveRigStats.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLiveRigStats)).EndInit();
			this.tpRigStatsExports.ResumeLayout(false);
			this.tpRigStatsExports.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRigExport)).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tpCardStats.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCardLastXHours)).EndInit();
			this.tpCardLiveStats.ResumeLayout(false);
			this.tpCardLiveStats.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLiveCardStats)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCardExport)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.DateTimePicker dtpCardStatsGraphEnd;
		private System.Windows.Forms.DateTimePicker dtpCardStatsGraphStart;
		private System.Windows.Forms.ComboBox cbCardStatsGraphReport;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabPage2;
		private System.ComponentModel.BackgroundWorker bgwCardStatsReport;
		private System.Windows.Forms.Timer timerCardStatsGraphs;
		private System.Windows.Forms.CheckBox cbCardUseFriendlyName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRigLast3Hours;
        private System.Windows.Forms.Button btnRigLast12Hours;
        private System.Windows.Forms.Button btnRigLastDay;
        private System.Windows.Forms.Button btnRigLastWeek;
        private System.Windows.Forms.Button btnRigLastMonth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCardLast3Hours;
        private System.Windows.Forms.Button btnCardLast12Hours;
        private System.Windows.Forms.Button btnCardLastDay;
        private System.Windows.Forms.Button btnCardLastWeek;
        private System.Windows.Forms.Button btnCardLastMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCardLastXHours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudRigLastXHours;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel lblReleaseNotes;
        private System.Windows.Forms.LinkLabel lblNewRelease;
        private System.Windows.Forms.Timer timerNewReleaseCheck;
		private System.Windows.Forms.TabPage tpLiveRigStats;
		private System.Windows.Forms.TextBox tbLiveRigWalletAddr;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.LinkLabel lblRigPendingWalletBalance;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Timer timerLiveStatsRefresh;
		private System.Windows.Forms.DataGridView dgvLiveRigStats;
		private System.Windows.Forms.TabPage tpCardLiveStats;
		private System.Windows.Forms.DataGridView dgvLiveCardStats;
		private System.Windows.Forms.LinkLabel lblCardLiveSite;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox tbCardLiveWalletAddress;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.CheckBox cbCardLiveStatFriendlyName;
		private System.Windows.Forms.Timer timerLiveCardStatsRefresh;
		private System.Windows.Forms.Button btnRigExportReportRefresh;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button btnRigExportYTD;
		private System.Windows.Forms.Button btnRigExportMTD;
		private System.Windows.Forms.Button btnRigExportWTD;
		private System.Windows.Forms.Button btnRigExportLY;
		private System.Windows.Forms.Button btnRigExportLM;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DateTimePicker dtpRigExportEnd;
		private System.Windows.Forms.DateTimePicker dtpRigExportStart;
		private System.Windows.Forms.TextBox tbRigExportWallet;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.ComboBox cbRigExportReport;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Button btnRigExportSave;
		private System.Windows.Forms.Button btnRigExportRunReport;
		private System.Windows.Forms.ComboBox cbRigExportResolution;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Button btnRigExportLW;
		private System.Windows.Forms.DataGridView dgvRigExport;
		private System.Windows.Forms.DataGridView dgvCardExport;
		private System.Windows.Forms.ComboBox cbCardExportResolution;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button btnCardExportSave;
		private System.Windows.Forms.Button btnCardExportRunReport;
		private System.Windows.Forms.Button btnCardExportReportRefresh;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button btnCardExportYTD;
		private System.Windows.Forms.Button btnCardExportMTD;
		private System.Windows.Forms.Button btnCardExportWTD;
		private System.Windows.Forms.Button btnCardExportLY;
		private System.Windows.Forms.Button btnCardExportLM;
		private System.Windows.Forms.Button btnCardExportLW;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.DateTimePicker dtpCardExportEnd;
		private System.Windows.Forms.DateTimePicker dtpCardExportStart;
		private System.Windows.Forms.TextBox tbCardExportWallet;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.ComboBox cbCardExportReportSelect;
		private System.Windows.Forms.Label label26;
	}
}

