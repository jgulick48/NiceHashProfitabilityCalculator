namespace NiceHash_Profitability_Tracker
{
    partial class Tracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tracker));
            this.lblWalletAddr = new System.Windows.Forms.Label();
            this.tbWalletAddr = new System.Windows.Forms.TextBox();
            this.btnScanAction = new System.Windows.Forms.Button();
            this.lblRefreshTime = new System.Windows.Forms.Label();
            this.nudRefreshTimer = new System.Windows.Forms.NumericUpDown();
            this.lblLastRefreshTimelbl = new System.Windows.Forms.Label();
            this.lblPendingBalancelbl = new System.Windows.Forms.Label();
            this.lblPrftMinlbl = new System.Windows.Forms.Label();
            this.lblPrftHourlbl = new System.Windows.Forms.Label();
            this.lblPrftDaylbl = new System.Windows.Forms.Label();
            this.lblPrftWeeklbl = new System.Windows.Forms.Label();
            this.lblPrftMonthlbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPMHA = new System.Windows.Forms.Label();
            this.lblPHHA = new System.Windows.Forms.Label();
            this.lblPDHA = new System.Windows.Forms.Label();
            this.lblPWHA = new System.Windows.Forms.Label();
            this.lblPMthHA = new System.Windows.Forms.Label();
            this.lblPMDA = new System.Windows.Forms.Label();
            this.lblPHDA = new System.Windows.Forms.Label();
            this.lblPDDA = new System.Windows.Forms.Label();
            this.lblPWDA = new System.Windows.Forms.Label();
            this.lblPMthDA = new System.Windows.Forms.Label();
            this.lblPMWA = new System.Windows.Forms.Label();
            this.lblPHWA = new System.Windows.Forms.Label();
            this.lblPDWA = new System.Windows.Forms.Label();
            this.lblPWWA = new System.Windows.Forms.Label();
            this.lblPMthWA = new System.Windows.Forms.Label();
            this.lblLRT = new System.Windows.Forms.Label();
            this.lblPB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.nudBTCValue = new System.Windows.Forms.NumericUpDown();
            this.cbCnvtBTC = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFIAT = new System.Windows.Forms.Label();
            this.cbDebug = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRefreshTimer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBTCValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWalletAddr
            // 
            this.lblWalletAddr.AutoSize = true;
            this.lblWalletAddr.Location = new System.Drawing.Point(12, 15);
            this.lblWalletAddr.Name = "lblWalletAddr";
            this.lblWalletAddr.Size = new System.Drawing.Size(81, 13);
            this.lblWalletAddr.TabIndex = 0;
            this.lblWalletAddr.Text = "Wallet Address:";
            // 
            // tbWalletAddr
            // 
            this.tbWalletAddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWalletAddr.Location = new System.Drawing.Point(99, 12);
            this.tbWalletAddr.Name = "tbWalletAddr";
            this.tbWalletAddr.Size = new System.Drawing.Size(488, 20);
            this.tbWalletAddr.TabIndex = 1;
            this.tbWalletAddr.Text = "37s2ZBNJ64sa1bkYh3HWAkncJSxcXoBzvn";
            this.tbWalletAddr.TextChanged += new System.EventHandler(this.tbWalletAddr_TextChanged);
            // 
            // btnScanAction
            // 
            this.btnScanAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanAction.Location = new System.Drawing.Point(512, 377);
            this.btnScanAction.Name = "btnScanAction";
            this.btnScanAction.Size = new System.Drawing.Size(75, 23);
            this.btnScanAction.TabIndex = 2;
            this.btnScanAction.Text = "Start";
            this.btnScanAction.UseVisualStyleBackColor = true;
            this.btnScanAction.Click += new System.EventHandler(this.btnScanAction_Click);
            // 
            // lblRefreshTime
            // 
            this.lblRefreshTime.AutoSize = true;
            this.lblRefreshTime.Location = new System.Drawing.Point(10, 382);
            this.lblRefreshTime.Name = "lblRefreshTime";
            this.lblRefreshTime.Size = new System.Drawing.Size(122, 13);
            this.lblRefreshTime.TabIndex = 3;
            this.lblRefreshTime.Text = "Refresh Time (seconds):";
            // 
            // nudRefreshTimer
            // 
            this.nudRefreshTimer.Location = new System.Drawing.Point(138, 380);
            this.nudRefreshTimer.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudRefreshTimer.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudRefreshTimer.Name = "nudRefreshTimer";
            this.nudRefreshTimer.Size = new System.Drawing.Size(120, 20);
            this.nudRefreshTimer.TabIndex = 4;
            this.nudRefreshTimer.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudRefreshTimer.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblLastRefreshTimelbl
            // 
            this.lblLastRefreshTimelbl.AutoSize = true;
            this.lblLastRefreshTimelbl.Location = new System.Drawing.Point(12, 40);
            this.lblLastRefreshTimelbl.Name = "lblLastRefreshTimelbl";
            this.lblLastRefreshTimelbl.Size = new System.Drawing.Size(96, 13);
            this.lblLastRefreshTimelbl.TabIndex = 5;
            this.lblLastRefreshTimelbl.Text = "Last Refresh Time:";
            // 
            // lblPendingBalancelbl
            // 
            this.lblPendingBalancelbl.AutoSize = true;
            this.lblPendingBalancelbl.Location = new System.Drawing.Point(12, 53);
            this.lblPendingBalancelbl.Name = "lblPendingBalancelbl";
            this.lblPendingBalancelbl.Size = new System.Drawing.Size(91, 13);
            this.lblPendingBalancelbl.TabIndex = 6;
            this.lblPendingBalancelbl.Text = "Pending Balance:";
            // 
            // lblPrftMinlbl
            // 
            this.lblPrftMinlbl.AutoSize = true;
            this.lblPrftMinlbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrftMinlbl.Location = new System.Drawing.Point(3, 49);
            this.lblPrftMinlbl.Name = "lblPrftMinlbl";
            this.lblPrftMinlbl.Size = new System.Drawing.Size(75, 13);
            this.lblPrftMinlbl.TabIndex = 7;
            this.lblPrftMinlbl.Text = "Profit (Minute):";
            this.lblPrftMinlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrftHourlbl
            // 
            this.lblPrftHourlbl.AutoSize = true;
            this.lblPrftHourlbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrftHourlbl.Location = new System.Drawing.Point(3, 98);
            this.lblPrftHourlbl.Name = "lblPrftHourlbl";
            this.lblPrftHourlbl.Size = new System.Drawing.Size(66, 13);
            this.lblPrftHourlbl.TabIndex = 8;
            this.lblPrftHourlbl.Text = "Profit (Hour):";
            this.lblPrftHourlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrftDaylbl
            // 
            this.lblPrftDaylbl.AutoSize = true;
            this.lblPrftDaylbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrftDaylbl.Location = new System.Drawing.Point(3, 147);
            this.lblPrftDaylbl.Name = "lblPrftDaylbl";
            this.lblPrftDaylbl.Size = new System.Drawing.Size(62, 13);
            this.lblPrftDaylbl.TabIndex = 9;
            this.lblPrftDaylbl.Text = "Profit (Day):";
            this.lblPrftDaylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrftWeeklbl
            // 
            this.lblPrftWeeklbl.AutoSize = true;
            this.lblPrftWeeklbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrftWeeklbl.Location = new System.Drawing.Point(3, 196);
            this.lblPrftWeeklbl.Name = "lblPrftWeeklbl";
            this.lblPrftWeeklbl.Size = new System.Drawing.Size(72, 13);
            this.lblPrftWeeklbl.TabIndex = 10;
            this.lblPrftWeeklbl.Text = "Profit (Week):";
            this.lblPrftWeeklbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrftMonthlbl
            // 
            this.lblPrftMonthlbl.AutoSize = true;
            this.lblPrftMonthlbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrftMonthlbl.Location = new System.Drawing.Point(3, 245);
            this.lblPrftMonthlbl.Name = "lblPrftMonthlbl";
            this.lblPrftMonthlbl.Size = new System.Drawing.Size(73, 13);
            this.lblPrftMonthlbl.TabIndex = 11;
            this.lblPrftMonthlbl.Text = "Profit (Month):";
            this.lblPrftMonthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Controls.Add(this.lblPrftMonthlbl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPrftWeeklbl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPrftDaylbl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPrftHourlbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPrftMinlbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPMHA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPHHA, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPDHA, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPWHA, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPMthHA, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPMDA, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPHDA, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPDDA, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPWDA, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPMthDA, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPMWA, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPHWA, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPDWA, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPWWA, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPMthWA, 3, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 300);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hour Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Day Average";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Week Average";
            // 
            // lblPMHA
            // 
            this.lblPMHA.AutoSize = true;
            this.lblPMHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMHA.Location = new System.Drawing.Point(146, 49);
            this.lblPMHA.Name = "lblPMHA";
            this.lblPMHA.Size = new System.Drawing.Size(49, 24);
            this.lblPMHA.TabIndex = 15;
            this.lblPMHA.Text = "0.00";
            // 
            // lblPHHA
            // 
            this.lblPHHA.AutoSize = true;
            this.lblPHHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPHHA.Location = new System.Drawing.Point(146, 98);
            this.lblPHHA.Name = "lblPHHA";
            this.lblPHHA.Size = new System.Drawing.Size(49, 24);
            this.lblPHHA.TabIndex = 16;
            this.lblPHHA.Text = "0.00";
            // 
            // lblPDHA
            // 
            this.lblPDHA.AutoSize = true;
            this.lblPDHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDHA.Location = new System.Drawing.Point(146, 147);
            this.lblPDHA.Name = "lblPDHA";
            this.lblPDHA.Size = new System.Drawing.Size(49, 24);
            this.lblPDHA.TabIndex = 17;
            this.lblPDHA.Text = "0.00";
            // 
            // lblPWHA
            // 
            this.lblPWHA.AutoSize = true;
            this.lblPWHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWHA.Location = new System.Drawing.Point(146, 196);
            this.lblPWHA.Name = "lblPWHA";
            this.lblPWHA.Size = new System.Drawing.Size(49, 24);
            this.lblPWHA.TabIndex = 18;
            this.lblPWHA.Text = "0.00";
            // 
            // lblPMthHA
            // 
            this.lblPMthHA.AutoSize = true;
            this.lblPMthHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMthHA.Location = new System.Drawing.Point(146, 245);
            this.lblPMthHA.Name = "lblPMthHA";
            this.lblPMthHA.Size = new System.Drawing.Size(49, 24);
            this.lblPMthHA.TabIndex = 19;
            this.lblPMthHA.Text = "0.00";
            // 
            // lblPMDA
            // 
            this.lblPMDA.AutoSize = true;
            this.lblPMDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMDA.Location = new System.Drawing.Point(289, 49);
            this.lblPMDA.Name = "lblPMDA";
            this.lblPMDA.Size = new System.Drawing.Size(49, 24);
            this.lblPMDA.TabIndex = 20;
            this.lblPMDA.Text = "0.00";
            // 
            // lblPHDA
            // 
            this.lblPHDA.AutoSize = true;
            this.lblPHDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPHDA.Location = new System.Drawing.Point(289, 98);
            this.lblPHDA.Name = "lblPHDA";
            this.lblPHDA.Size = new System.Drawing.Size(49, 24);
            this.lblPHDA.TabIndex = 21;
            this.lblPHDA.Text = "0.00";
            // 
            // lblPDDA
            // 
            this.lblPDDA.AutoSize = true;
            this.lblPDDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDDA.Location = new System.Drawing.Point(289, 147);
            this.lblPDDA.Name = "lblPDDA";
            this.lblPDDA.Size = new System.Drawing.Size(49, 24);
            this.lblPDDA.TabIndex = 22;
            this.lblPDDA.Text = "0.00";
            // 
            // lblPWDA
            // 
            this.lblPWDA.AutoSize = true;
            this.lblPWDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWDA.Location = new System.Drawing.Point(289, 196);
            this.lblPWDA.Name = "lblPWDA";
            this.lblPWDA.Size = new System.Drawing.Size(49, 24);
            this.lblPWDA.TabIndex = 23;
            this.lblPWDA.Text = "0.00";
            // 
            // lblPMthDA
            // 
            this.lblPMthDA.AutoSize = true;
            this.lblPMthDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMthDA.Location = new System.Drawing.Point(289, 245);
            this.lblPMthDA.Name = "lblPMthDA";
            this.lblPMthDA.Size = new System.Drawing.Size(49, 24);
            this.lblPMthDA.TabIndex = 24;
            this.lblPMthDA.Text = "0.00";
            // 
            // lblPMWA
            // 
            this.lblPMWA.AutoSize = true;
            this.lblPMWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMWA.Location = new System.Drawing.Point(432, 49);
            this.lblPMWA.Name = "lblPMWA";
            this.lblPMWA.Size = new System.Drawing.Size(49, 24);
            this.lblPMWA.TabIndex = 25;
            this.lblPMWA.Text = "0.00";
            // 
            // lblPHWA
            // 
            this.lblPHWA.AutoSize = true;
            this.lblPHWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPHWA.Location = new System.Drawing.Point(432, 98);
            this.lblPHWA.Name = "lblPHWA";
            this.lblPHWA.Size = new System.Drawing.Size(49, 24);
            this.lblPHWA.TabIndex = 26;
            this.lblPHWA.Text = "0.00";
            // 
            // lblPDWA
            // 
            this.lblPDWA.AutoSize = true;
            this.lblPDWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDWA.Location = new System.Drawing.Point(432, 147);
            this.lblPDWA.Name = "lblPDWA";
            this.lblPDWA.Size = new System.Drawing.Size(49, 24);
            this.lblPDWA.TabIndex = 27;
            this.lblPDWA.Text = "0.00";
            // 
            // lblPWWA
            // 
            this.lblPWWA.AutoSize = true;
            this.lblPWWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWWA.Location = new System.Drawing.Point(432, 196);
            this.lblPWWA.Name = "lblPWWA";
            this.lblPWWA.Size = new System.Drawing.Size(49, 24);
            this.lblPWWA.TabIndex = 28;
            this.lblPWWA.Text = "0.00";
            // 
            // lblPMthWA
            // 
            this.lblPMthWA.AutoSize = true;
            this.lblPMthWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMthWA.Location = new System.Drawing.Point(432, 245);
            this.lblPMthWA.Name = "lblPMthWA";
            this.lblPMthWA.Size = new System.Drawing.Size(49, 24);
            this.lblPMthWA.TabIndex = 29;
            this.lblPMthWA.Text = "0.00";
            // 
            // lblLRT
            // 
            this.lblLRT.AutoSize = true;
            this.lblLRT.Location = new System.Drawing.Point(114, 40);
            this.lblLRT.Name = "lblLRT";
            this.lblLRT.Size = new System.Drawing.Size(0, 13);
            this.lblLRT.TabIndex = 13;
            // 
            // lblPB
            // 
            this.lblPB.AutoSize = true;
            this.lblPB.Location = new System.Drawing.Point(114, 53);
            this.lblPB.Name = "lblPB";
            this.lblPB.Size = new System.Drawing.Size(0, 13);
            this.lblPB.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "BTC Value:";
            // 
            // nudBTCValue
            // 
            this.nudBTCValue.Location = new System.Drawing.Point(467, 38);
            this.nudBTCValue.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudBTCValue.Name = "nudBTCValue";
            this.nudBTCValue.Size = new System.Drawing.Size(120, 20);
            this.nudBTCValue.TabIndex = 16;
            this.nudBTCValue.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudBTCValue.ValueChanged += new System.EventHandler(this.nudBTCValue_ValueChanged);
            // 
            // cbCnvtBTC
            // 
            this.cbCnvtBTC.AutoSize = true;
            this.cbCnvtBTC.Location = new System.Drawing.Point(287, 39);
            this.cbCnvtBTC.Name = "cbCnvtBTC";
            this.cbCnvtBTC.Size = new System.Drawing.Size(107, 17);
            this.cbCnvtBTC.TabIndex = 17;
            this.cbCnvtBTC.Text = "Convert Earnings";
            this.cbCnvtBTC.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "FIAT:";
            // 
            // lblFIAT
            // 
            this.lblFIAT.AutoSize = true;
            this.lblFIAT.Location = new System.Drawing.Point(240, 53);
            this.lblFIAT.Name = "lblFIAT";
            this.lblFIAT.Size = new System.Drawing.Size(0, 13);
            this.lblFIAT.TabIndex = 19;
            // 
            // cbDebug
            // 
            this.cbDebug.AutoSize = true;
            this.cbDebug.Location = new System.Drawing.Point(426, 383);
            this.cbDebug.Name = "cbDebug";
            this.cbDebug.Size = new System.Drawing.Size(58, 17);
            this.cbDebug.TabIndex = 20;
            this.cbDebug.Text = "Debug";
            this.cbDebug.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 412);
            this.Controls.Add(this.cbDebug);
            this.Controls.Add(this.lblFIAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCnvtBTC);
            this.Controls.Add(this.nudBTCValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPB);
            this.Controls.Add(this.lblLRT);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblPendingBalancelbl);
            this.Controls.Add(this.lblLastRefreshTimelbl);
            this.Controls.Add(this.nudRefreshTimer);
            this.Controls.Add(this.lblRefreshTime);
            this.Controls.Add(this.btnScanAction);
            this.Controls.Add(this.tbWalletAddr);
            this.Controls.Add(this.lblWalletAddr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NiceHash Profitability Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRefreshTimer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBTCValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWalletAddr;
        private System.Windows.Forms.TextBox tbWalletAddr;
        private System.Windows.Forms.Button btnScanAction;
        private System.Windows.Forms.Label lblRefreshTime;
        private System.Windows.Forms.NumericUpDown nudRefreshTimer;
        private System.Windows.Forms.Label lblLastRefreshTimelbl;
        private System.Windows.Forms.Label lblPendingBalancelbl;
        private System.Windows.Forms.Label lblPrftMinlbl;
        private System.Windows.Forms.Label lblPrftHourlbl;
        private System.Windows.Forms.Label lblPrftDaylbl;
        private System.Windows.Forms.Label lblPrftWeeklbl;
        private System.Windows.Forms.Label lblPrftMonthlbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPMHA;
        private System.Windows.Forms.Label lblPHHA;
        private System.Windows.Forms.Label lblPDHA;
        private System.Windows.Forms.Label lblPWHA;
        private System.Windows.Forms.Label lblPMthHA;
        private System.Windows.Forms.Label lblPMDA;
        private System.Windows.Forms.Label lblPHDA;
        private System.Windows.Forms.Label lblPDDA;
        private System.Windows.Forms.Label lblPWDA;
        private System.Windows.Forms.Label lblPMthDA;
        private System.Windows.Forms.Label lblPMWA;
        private System.Windows.Forms.Label lblPHWA;
        private System.Windows.Forms.Label lblPDWA;
        private System.Windows.Forms.Label lblPWWA;
        private System.Windows.Forms.Label lblPMthWA;
        private System.Windows.Forms.Label lblLRT;
        private System.Windows.Forms.Label lblPB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudBTCValue;
        private System.Windows.Forms.CheckBox cbCnvtBTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFIAT;
		private System.Windows.Forms.CheckBox cbDebug;
    }
}

