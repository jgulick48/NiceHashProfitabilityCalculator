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
            this.tpRigStatsExports = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerRigStatsGraphs = new System.Windows.Forms.Timer(this.components);
            this.bgwRigStatsReport = new System.ComponentModel.BackgroundWorker();
            this.bgwCardStatsReport = new System.ComponentModel.BackgroundWorker();
            this.timerCardStatsGraphs = new System.Windows.Forms.Timer(this.components);
            this.lblReleaseNotes = new System.Windows.Forms.LinkLabel();
            this.lblNewRelease = new System.Windows.Forms.LinkLabel();
            this.timerNewReleaseCheck = new System.Windows.Forms.Timer(this.components);
            this.tcMain.SuspendLayout();
            this.tpRigStats.SuspendLayout();
            this.tcRigStats.SuspendLayout();
            this.tpRigGraphs.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRigLastXHours)).BeginInit();
            this.tpCardStats.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardLastXHours)).BeginInit();
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
            this.tcMain.Size = new System.Drawing.Size(756, 521);
            this.tcMain.TabIndex = 0;
            // 
            // tpRigStats
            // 
            this.tpRigStats.Controls.Add(this.tcRigStats);
            this.tpRigStats.Location = new System.Drawing.Point(4, 22);
            this.tpRigStats.Name = "tpRigStats";
            this.tpRigStats.Padding = new System.Windows.Forms.Padding(3);
            this.tpRigStats.Size = new System.Drawing.Size(748, 495);
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
            this.tcRigStats.Size = new System.Drawing.Size(736, 483);
            this.tcRigStats.TabIndex = 0;
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
            this.tpRigGraphs.Size = new System.Drawing.Size(728, 457);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 29);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.nudRigLastXHours);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(598, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 23);
            this.panel2.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 5);
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
            this.nudRigLastXHours.Size = new System.Drawing.Size(35, 20);
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
            this.btnRigLast3Hours.Size = new System.Drawing.Size(113, 23);
            this.btnRigLast3Hours.TabIndex = 0;
            this.btnRigLast3Hours.Text = "Last 3 Hours";
            this.btnRigLast3Hours.UseVisualStyleBackColor = true;
            this.btnRigLast3Hours.Click += new System.EventHandler(this.btnLast3Hours_Click);
            // 
            // btnRigLast12Hours
            // 
            this.btnRigLast12Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRigLast12Hours.Location = new System.Drawing.Point(122, 3);
            this.btnRigLast12Hours.Name = "btnRigLast12Hours";
            this.btnRigLast12Hours.Size = new System.Drawing.Size(113, 23);
            this.btnRigLast12Hours.TabIndex = 1;
            this.btnRigLast12Hours.Text = "Last 12 Hours";
            this.btnRigLast12Hours.UseVisualStyleBackColor = true;
            this.btnRigLast12Hours.Click += new System.EventHandler(this.btnLast12Hours_Click);
            // 
            // btnRigLastDay
            // 
            this.btnRigLastDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRigLastDay.Location = new System.Drawing.Point(241, 3);
            this.btnRigLastDay.Name = "btnRigLastDay";
            this.btnRigLastDay.Size = new System.Drawing.Size(113, 23);
            this.btnRigLastDay.TabIndex = 2;
            this.btnRigLastDay.Text = "Last Day";
            this.btnRigLastDay.UseVisualStyleBackColor = true;
            this.btnRigLastDay.Click += new System.EventHandler(this.btnLastDay_Click);
            // 
            // btnRigLastWeek
            // 
            this.btnRigLastWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRigLastWeek.Location = new System.Drawing.Point(360, 3);
            this.btnRigLastWeek.Name = "btnRigLastWeek";
            this.btnRigLastWeek.Size = new System.Drawing.Size(113, 23);
            this.btnRigLastWeek.TabIndex = 3;
            this.btnRigLastWeek.Text = "Last Week";
            this.btnRigLastWeek.UseVisualStyleBackColor = true;
            this.btnRigLastWeek.Click += new System.EventHandler(this.btnLastWeek_Click);
            // 
            // btnRigLastMonth
            // 
            this.btnRigLastMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRigLastMonth.Location = new System.Drawing.Point(479, 3);
            this.btnRigLastMonth.Name = "btnRigLastMonth";
            this.btnRigLastMonth.Size = new System.Drawing.Size(113, 23);
            this.btnRigLastMonth.TabIndex = 4;
            this.btnRigLastMonth.Text = "Last Month";
            this.btnRigLastMonth.UseVisualStyleBackColor = true;
            this.btnRigLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // cbLive
            // 
            this.cbLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbLive.AutoSize = true;
            this.cbLive.Location = new System.Drawing.Point(9, 428);
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
            this.cartesianChart1.Size = new System.Drawing.Size(713, 328);
            this.cartesianChart1.TabIndex = 9;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // btnPlotData
            // 
            this.btnPlotData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlotData.Location = new System.Drawing.Point(647, 428);
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
            this.tabPage1.Size = new System.Drawing.Size(728, 470);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(716, 29);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnCardLast3Hours
            // 
            this.btnCardLast3Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCardLast3Hours.Location = new System.Drawing.Point(3, 3);
            this.btnCardLast3Hours.Name = "btnCardLast3Hours";
            this.btnCardLast3Hours.Size = new System.Drawing.Size(113, 23);
            this.btnCardLast3Hours.TabIndex = 0;
            this.btnCardLast3Hours.Text = "Last 3 Hours";
            this.btnCardLast3Hours.UseVisualStyleBackColor = true;
            this.btnCardLast3Hours.Click += new System.EventHandler(this.btnCardLast3Hours_Click);
            // 
            // btnCardLast12Hours
            // 
            this.btnCardLast12Hours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCardLast12Hours.Location = new System.Drawing.Point(122, 3);
            this.btnCardLast12Hours.Name = "btnCardLast12Hours";
            this.btnCardLast12Hours.Size = new System.Drawing.Size(113, 23);
            this.btnCardLast12Hours.TabIndex = 1;
            this.btnCardLast12Hours.Text = "Last 12 Hours";
            this.btnCardLast12Hours.UseVisualStyleBackColor = true;
            this.btnCardLast12Hours.Click += new System.EventHandler(this.btnCardLast12Hours_Click);
            // 
            // btnCardLastDay
            // 
            this.btnCardLastDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCardLastDay.Location = new System.Drawing.Point(241, 3);
            this.btnCardLastDay.Name = "btnCardLastDay";
            this.btnCardLastDay.Size = new System.Drawing.Size(113, 23);
            this.btnCardLastDay.TabIndex = 2;
            this.btnCardLastDay.Text = "Last Day";
            this.btnCardLastDay.UseVisualStyleBackColor = true;
            this.btnCardLastDay.Click += new System.EventHandler(this.btnCardLastDay_Click);
            // 
            // btnCardLastWeek
            // 
            this.btnCardLastWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCardLastWeek.Location = new System.Drawing.Point(360, 3);
            this.btnCardLastWeek.Name = "btnCardLastWeek";
            this.btnCardLastWeek.Size = new System.Drawing.Size(113, 23);
            this.btnCardLastWeek.TabIndex = 3;
            this.btnCardLastWeek.Text = "Last Week";
            this.btnCardLastWeek.UseVisualStyleBackColor = true;
            this.btnCardLastWeek.Click += new System.EventHandler(this.btnCardLastWeek_Click);
            // 
            // btnCardLastMonth
            // 
            this.btnCardLastMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCardLastMonth.Location = new System.Drawing.Point(479, 3);
            this.btnCardLastMonth.Name = "btnCardLastMonth";
            this.btnCardLastMonth.Size = new System.Drawing.Size(113, 23);
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
            this.panel1.Location = new System.Drawing.Point(598, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 23);
            this.panel1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 5);
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
            this.nudCardLastXHours.Size = new System.Drawing.Size(35, 20);
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
            this.cbCardUseFriendlyName.Location = new System.Drawing.Point(9, 445);
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
            this.cbGardStatsGraphLive.Location = new System.Drawing.Point(130, 445);
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
            this.cartesianChart2.Size = new System.Drawing.Size(713, 341);
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
            // dtpCardStatsGraphEnd
            // 
            this.dtpCardStatsGraphEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCardStatsGraphEnd.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
            this.dtpCardStatsGraphEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCardStatsGraphEnd.Location = new System.Drawing.Point(564, 32);
            this.dtpCardStatsGraphEnd.Name = "dtpCardStatsGraphEnd";
            this.dtpCardStatsGraphEnd.Size = new System.Drawing.Size(158, 20);
            this.dtpCardStatsGraphEnd.TabIndex = 3;
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
            this.cbCardStatsGraphReport.Size = new System.Drawing.Size(440, 21);
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
            this.timerCardStatsGraphs.Tick += new System.EventHandler(this.timerCardStatsGraphs_Tick);
            // 
            // lblReleaseNotes
            // 
            this.lblReleaseNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReleaseNotes.AutoSize = true;
            this.lblReleaseNotes.Location = new System.Drawing.Point(331, 536);
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
            this.lblNewRelease.Location = new System.Drawing.Point(12, 536);
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
            // NicehashStatsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 558);
            this.Controls.Add(this.lblNewRelease);
            this.Controls.Add(this.lblReleaseNotes);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NicehashStatsViewer";
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
            this.tpCardStats.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardLastXHours)).EndInit();
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
    }
}

