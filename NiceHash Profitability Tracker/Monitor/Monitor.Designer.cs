namespace Monitor
{
	partial class Monitor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
			this.nudRefresh = new System.Windows.Forms.NumericUpDown();
			this.gbSettings = new System.Windows.Forms.GroupBox();
			this.lblRefreshTime = new System.Windows.Forms.Label();
			this.timerCardStatsRefresh = new System.Windows.Forms.Timer(this.components);
			this.bgwCardStatsRefresh = new System.ComponentModel.BackgroundWorker();
			this.bgwDataBaseSave = new System.ComponentModel.BackgroundWorker();
			this.btnStartStop = new System.Windows.Forms.Button();
			this.gbCardDetails = new System.Windows.Forms.GroupBox();
			this.tbCardUUID = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbGCFriendlyName = new System.Windows.Forms.TextBox();
			this.btnSaveCard = new System.Windows.Forms.Button();
			this.tbAlogName = new System.Windows.Forms.TextBox();
			this.tbGCEarnings = new System.Windows.Forms.TextBox();
			this.tbGCTemp = new System.Windows.Forms.TextBox();
			this.tbGCPower = new System.Windows.Forms.TextBox();
			this.tbGPUPercent = new System.Windows.Forms.TextBox();
			this.tbFanPercent = new System.Windows.Forms.TextBox();
			this.tbFanRPM = new System.Windows.Forms.TextBox();
			this.tbGCName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbCardSelect = new System.Windows.Forms.ComboBox();
			this.btnEditRig = new System.Windows.Forms.Button();
			this.lblNewRelease = new System.Windows.Forms.LinkLabel();
			this.lblReleaseNotes = new System.Windows.Forms.LinkLabel();
			this.timerUpdateCheck = new System.Windows.Forms.Timer(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lblPerKWH = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnEditRigPowerCur = new System.Windows.Forms.Button();
			this.lblCurShort = new System.Windows.Forms.Label();
			this.lblBasePower = new System.Windows.Forms.Label();
			this.lblPricePerKWH = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudRefresh)).BeginInit();
			this.gbSettings.SuspendLayout();
			this.gbCardDetails.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// nudRefresh
			// 
			this.nudRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudRefresh.Location = new System.Drawing.Point(136, 19);
			this.nudRefresh.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
			this.nudRefresh.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudRefresh.Name = "nudRefresh";
			this.nudRefresh.Size = new System.Drawing.Size(218, 20);
			this.nudRefresh.TabIndex = 0;
			this.nudRefresh.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudRefresh.ValueChanged += new System.EventHandler(this.nudRefresh_ValueChanged);
			// 
			// gbSettings
			// 
			this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbSettings.Controls.Add(this.btnEditRigPowerCur);
			this.gbSettings.Controls.Add(this.tableLayoutPanel1);
			this.gbSettings.Controls.Add(this.lblRefreshTime);
			this.gbSettings.Controls.Add(this.nudRefresh);
			this.gbSettings.Location = new System.Drawing.Point(12, 12);
			this.gbSettings.Name = "gbSettings";
			this.gbSettings.Size = new System.Drawing.Size(360, 91);
			this.gbSettings.TabIndex = 1;
			this.gbSettings.TabStop = false;
			this.gbSettings.Text = "Settings";
			// 
			// lblRefreshTime
			// 
			this.lblRefreshTime.AutoSize = true;
			this.lblRefreshTime.Location = new System.Drawing.Point(6, 21);
			this.lblRefreshTime.Name = "lblRefreshTime";
			this.lblRefreshTime.Size = new System.Drawing.Size(124, 13);
			this.lblRefreshTime.TabIndex = 0;
			this.lblRefreshTime.Text = "Refresh Time (Seconds):";
			// 
			// timerCardStatsRefresh
			// 
			this.timerCardStatsRefresh.Interval = 10000;
			this.timerCardStatsRefresh.Tick += new System.EventHandler(this.timerCardStatsRefresh_Tick);
			// 
			// bgwCardStatsRefresh
			// 
			this.bgwCardStatsRefresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCardStatsRefresh_DoWork);
			this.bgwCardStatsRefresh.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCardStatsRefresh_RunWorkerCompleted);
			// 
			// bgwDataBaseSave
			// 
			this.bgwDataBaseSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDataBaseSave_DoWork);
			// 
			// btnStartStop
			// 
			this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStartStop.Location = new System.Drawing.Point(291, 448);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(75, 23);
			this.btnStartStop.TabIndex = 2;
			this.btnStartStop.Text = "Start";
			this.btnStartStop.UseVisualStyleBackColor = true;
			this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
			// 
			// gbCardDetails
			// 
			this.gbCardDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbCardDetails.Controls.Add(this.tbCardUUID);
			this.gbCardDetails.Controls.Add(this.label11);
			this.gbCardDetails.Controls.Add(this.tbGCFriendlyName);
			this.gbCardDetails.Controls.Add(this.btnSaveCard);
			this.gbCardDetails.Controls.Add(this.tbAlogName);
			this.gbCardDetails.Controls.Add(this.tbGCEarnings);
			this.gbCardDetails.Controls.Add(this.tbGCTemp);
			this.gbCardDetails.Controls.Add(this.tbGCPower);
			this.gbCardDetails.Controls.Add(this.tbGPUPercent);
			this.gbCardDetails.Controls.Add(this.tbFanPercent);
			this.gbCardDetails.Controls.Add(this.tbFanRPM);
			this.gbCardDetails.Controls.Add(this.tbGCName);
			this.gbCardDetails.Controls.Add(this.label10);
			this.gbCardDetails.Controls.Add(this.label9);
			this.gbCardDetails.Controls.Add(this.label8);
			this.gbCardDetails.Controls.Add(this.label7);
			this.gbCardDetails.Controls.Add(this.label6);
			this.gbCardDetails.Controls.Add(this.label5);
			this.gbCardDetails.Controls.Add(this.label4);
			this.gbCardDetails.Controls.Add(this.label12);
			this.gbCardDetails.Controls.Add(this.label2);
			this.gbCardDetails.Controls.Add(this.label1);
			this.gbCardDetails.Controls.Add(this.cbCardSelect);
			this.gbCardDetails.Location = new System.Drawing.Point(12, 109);
			this.gbCardDetails.Name = "gbCardDetails";
			this.gbCardDetails.Size = new System.Drawing.Size(360, 333);
			this.gbCardDetails.TabIndex = 3;
			this.gbCardDetails.TabStop = false;
			this.gbCardDetails.Text = "Card Details";
			// 
			// tbCardUUID
			// 
			this.tbCardUUID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCardUUID.Location = new System.Drawing.Point(124, 280);
			this.tbCardUUID.Name = "tbCardUUID";
			this.tbCardUUID.ReadOnly = true;
			this.tbCardUUID.Size = new System.Drawing.Size(230, 20);
			this.tbCardUUID.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 283);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 13);
			this.label11.TabIndex = 20;
			this.label11.Text = "Card UUID:";
			// 
			// tbGCFriendlyName
			// 
			this.tbGCFriendlyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbGCFriendlyName.Location = new System.Drawing.Point(124, 72);
			this.tbGCFriendlyName.Name = "tbGCFriendlyName";
			this.tbGCFriendlyName.Size = new System.Drawing.Size(230, 20);
			this.tbGCFriendlyName.TabIndex = 19;
			// 
			// btnSaveCard
			// 
			this.btnSaveCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveCard.Enabled = false;
			this.btnSaveCard.Location = new System.Drawing.Point(279, 304);
			this.btnSaveCard.Name = "btnSaveCard";
			this.btnSaveCard.Size = new System.Drawing.Size(75, 23);
			this.btnSaveCard.TabIndex = 5;
			this.btnSaveCard.Text = "Save Card";
			this.btnSaveCard.UseVisualStyleBackColor = true;
			this.btnSaveCard.Click += new System.EventHandler(this.btnSaveCard_Click);
			// 
			// tbAlogName
			// 
			this.tbAlogName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAlogName.Location = new System.Drawing.Point(124, 98);
			this.tbAlogName.Name = "tbAlogName";
			this.tbAlogName.ReadOnly = true;
			this.tbAlogName.Size = new System.Drawing.Size(230, 20);
			this.tbAlogName.TabIndex = 18;
			// 
			// tbGCEarnings
			// 
			this.tbGCEarnings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbGCEarnings.Location = new System.Drawing.Point(124, 124);
			this.tbGCEarnings.Name = "tbGCEarnings";
			this.tbGCEarnings.ReadOnly = true;
			this.tbGCEarnings.Size = new System.Drawing.Size(230, 20);
			this.tbGCEarnings.TabIndex = 17;
			// 
			// tbGCTemp
			// 
			this.tbGCTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbGCTemp.Location = new System.Drawing.Point(124, 150);
			this.tbGCTemp.Name = "tbGCTemp";
			this.tbGCTemp.ReadOnly = true;
			this.tbGCTemp.Size = new System.Drawing.Size(230, 20);
			this.tbGCTemp.TabIndex = 16;
			// 
			// tbGCPower
			// 
			this.tbGCPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbGCPower.Location = new System.Drawing.Point(124, 176);
			this.tbGCPower.Name = "tbGCPower";
			this.tbGCPower.ReadOnly = true;
			this.tbGCPower.Size = new System.Drawing.Size(230, 20);
			this.tbGCPower.TabIndex = 15;
			// 
			// tbGPUPercent
			// 
			this.tbGPUPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbGPUPercent.Location = new System.Drawing.Point(124, 202);
			this.tbGPUPercent.Name = "tbGPUPercent";
			this.tbGPUPercent.ReadOnly = true;
			this.tbGPUPercent.Size = new System.Drawing.Size(230, 20);
			this.tbGPUPercent.TabIndex = 14;
			// 
			// tbFanPercent
			// 
			this.tbFanPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFanPercent.Location = new System.Drawing.Point(124, 228);
			this.tbFanPercent.Name = "tbFanPercent";
			this.tbFanPercent.ReadOnly = true;
			this.tbFanPercent.Size = new System.Drawing.Size(230, 20);
			this.tbFanPercent.TabIndex = 13;
			// 
			// tbFanRPM
			// 
			this.tbFanRPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFanRPM.Location = new System.Drawing.Point(124, 254);
			this.tbFanRPM.Name = "tbFanRPM";
			this.tbFanRPM.ReadOnly = true;
			this.tbFanRPM.Size = new System.Drawing.Size(230, 20);
			this.tbFanRPM.TabIndex = 12;
			// 
			// tbGCName
			// 
			this.tbGCName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbGCName.Location = new System.Drawing.Point(124, 46);
			this.tbGCName.Name = "tbGCName";
			this.tbGCName.ReadOnly = true;
			this.tbGCName.Size = new System.Drawing.Size(230, 20);
			this.tbGCName.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 101);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(31, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "Algo:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 257);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Fan RPM:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 231);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Fan%:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 205);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "GPU%:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Power (Watts):";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 156);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Temp:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Current Earnings/Day:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 75);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 13);
			this.label12.TabIndex = 3;
			this.label12.Text = "Friendly Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Card:";
			// 
			// cbCardSelect
			// 
			this.cbCardSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCardSelect.FormattingEnabled = true;
			this.cbCardSelect.Location = new System.Drawing.Point(124, 19);
			this.cbCardSelect.Name = "cbCardSelect";
			this.cbCardSelect.Size = new System.Drawing.Size(230, 21);
			this.cbCardSelect.TabIndex = 0;
			this.cbCardSelect.SelectedIndexChanged += new System.EventHandler(this.cbCardSelect_SelectedIndexChanged);
			// 
			// btnEditRig
			// 
			this.btnEditRig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditRig.Location = new System.Drawing.Point(210, 448);
			this.btnEditRig.Name = "btnEditRig";
			this.btnEditRig.Size = new System.Drawing.Size(75, 23);
			this.btnEditRig.TabIndex = 6;
			this.btnEditRig.Text = "Edit Rig";
			this.btnEditRig.UseVisualStyleBackColor = true;
			this.btnEditRig.Click += new System.EventHandler(this.btnEditRig_Click);
			// 
			// lblNewRelease
			// 
			this.lblNewRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblNewRelease.AutoSize = true;
			this.lblNewRelease.Enabled = false;
			this.lblNewRelease.Location = new System.Drawing.Point(12, 445);
			this.lblNewRelease.Name = "lblNewRelease";
			this.lblNewRelease.Size = new System.Drawing.Size(196, 13);
			this.lblNewRelease.TabIndex = 7;
			this.lblNewRelease.TabStop = true;
			this.lblNewRelease.Text = "A new release is avaialble for download.";
			this.lblNewRelease.Visible = false;
			this.lblNewRelease.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNewRelease_LinkClicked);
			// 
			// lblReleaseNotes
			// 
			this.lblReleaseNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblReleaseNotes.AutoSize = true;
			this.lblReleaseNotes.Enabled = false;
			this.lblReleaseNotes.Location = new System.Drawing.Point(12, 461);
			this.lblReleaseNotes.Name = "lblReleaseNotes";
			this.lblReleaseNotes.Size = new System.Drawing.Size(77, 13);
			this.lblReleaseNotes.TabIndex = 8;
			this.lblReleaseNotes.TabStop = true;
			this.lblReleaseNotes.Text = "Release Notes";
			this.lblReleaseNotes.Visible = false;
			this.lblReleaseNotes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReleaseNotes_LinkClicked);
			// 
			// timerUpdateCheck
			// 
			this.timerUpdateCheck.Interval = 3600000;
			this.timerUpdateCheck.Tick += new System.EventHandler(this.timerUpdateCheck_Tick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "Currency:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(108, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(87, 12);
			this.label13.TabIndex = 2;
			this.label13.Text = "Base Power (W):";
			// 
			// lblPerKWH
			// 
			this.lblPerKWH.AutoSize = true;
			this.lblPerKWH.Location = new System.Drawing.Point(248, 0);
			this.lblPerKWH.Name = "lblPerKWH";
			this.lblPerKWH.Size = new System.Drawing.Size(45, 12);
			this.lblPerKWH.TabIndex = 3;
			this.lblPerKWH.Text = "x/kWH:";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.lblPerKWH, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblCurShort, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblBasePower, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblPricePerKWH, 5, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 45);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 12);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// btnEditRigPowerCur
			// 
			this.btnEditRigPowerCur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditRigPowerCur.Location = new System.Drawing.Point(6, 60);
			this.btnEditRigPowerCur.Name = "btnEditRigPowerCur";
			this.btnEditRigPowerCur.Size = new System.Drawing.Size(348, 25);
			this.btnEditRigPowerCur.TabIndex = 2;
			this.btnEditRigPowerCur.Text = "Edit";
			this.btnEditRigPowerCur.UseVisualStyleBackColor = true;
			this.btnEditRigPowerCur.Click += new System.EventHandler(this.btnEditRigPowerCur_Click);
			// 
			// lblCurShort
			// 
			this.lblCurShort.AutoSize = true;
			this.lblCurShort.Location = new System.Drawing.Point(61, 0);
			this.lblCurShort.Name = "lblCurShort";
			this.lblCurShort.Size = new System.Drawing.Size(41, 12);
			this.lblCurShort.TabIndex = 4;
			this.lblCurShort.Text = "label15";
			// 
			// lblBasePower
			// 
			this.lblBasePower.AutoSize = true;
			this.lblBasePower.Location = new System.Drawing.Point(201, 0);
			this.lblBasePower.Name = "lblBasePower";
			this.lblBasePower.Size = new System.Drawing.Size(41, 12);
			this.lblBasePower.TabIndex = 5;
			this.lblBasePower.Text = "label16";
			// 
			// lblPricePerKWH
			// 
			this.lblPricePerKWH.AutoSize = true;
			this.lblPricePerKWH.Location = new System.Drawing.Point(303, 0);
			this.lblPricePerKWH.Name = "lblPricePerKWH";
			this.lblPricePerKWH.Size = new System.Drawing.Size(41, 12);
			this.lblPricePerKWH.TabIndex = 6;
			this.lblPricePerKWH.Text = "label17";
			// 
			// Monitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 483);
			this.Controls.Add(this.lblReleaseNotes);
			this.Controls.Add(this.lblNewRelease);
			this.Controls.Add(this.btnEditRig);
			this.Controls.Add(this.gbCardDetails);
			this.Controls.Add(this.btnStartStop);
			this.Controls.Add(this.gbSettings);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(400, 522);
			this.MinimumSize = new System.Drawing.Size(400, 522);
			this.Name = "Monitor";
			this.Text = "NiceHash Worker Monitor";
			this.Load += new System.EventHandler(this.NiceHashWorkerMonitor_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudRefresh)).EndInit();
			this.gbSettings.ResumeLayout(false);
			this.gbSettings.PerformLayout();
			this.gbCardDetails.ResumeLayout(false);
			this.gbCardDetails.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudRefresh;
		private System.Windows.Forms.GroupBox gbSettings;
		private System.Windows.Forms.Label lblRefreshTime;
		private System.Windows.Forms.Timer timerCardStatsRefresh;
		private System.ComponentModel.BackgroundWorker bgwCardStatsRefresh;
		private System.ComponentModel.BackgroundWorker bgwDataBaseSave;
		private System.Windows.Forms.Button btnStartStop;
		private System.Windows.Forms.GroupBox gbCardDetails;
		private System.Windows.Forms.TextBox tbGCFriendlyName;
		private System.Windows.Forms.Button btnSaveCard;
		private System.Windows.Forms.TextBox tbAlogName;
		private System.Windows.Forms.TextBox tbGCEarnings;
		private System.Windows.Forms.TextBox tbGCTemp;
		private System.Windows.Forms.TextBox tbGCPower;
		private System.Windows.Forms.TextBox tbGPUPercent;
		private System.Windows.Forms.TextBox tbFanPercent;
		private System.Windows.Forms.TextBox tbFanRPM;
		private System.Windows.Forms.TextBox tbGCName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbCardSelect;
		private System.Windows.Forms.Button btnEditRig;
		private System.Windows.Forms.TextBox tbCardUUID;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel lblNewRelease;
        private System.Windows.Forms.LinkLabel lblReleaseNotes;
        private System.Windows.Forms.Timer timerUpdateCheck;
		private System.Windows.Forms.Button btnEditRigPowerCur;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblPerKWH;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblCurShort;
		private System.Windows.Forms.Label lblBasePower;
		private System.Windows.Forms.Label lblPricePerKWH;
	}
}

