namespace NiceHashWorkerMonitor
{
	partial class NiceHashWorkerMonitor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NiceHashWorkerMonitor));
			this.nudRefresh = new System.Windows.Forms.NumericUpDown();
			this.gbSettings = new System.Windows.Forms.GroupBox();
			this.lblRefreshTime = new System.Windows.Forms.Label();
			this.timerCardStatsRefresh = new System.Windows.Forms.Timer(this.components);
			this.bgwCardStatsRefresh = new System.ComponentModel.BackgroundWorker();
			this.bgwDataBaseSave = new System.ComponentModel.BackgroundWorker();
			this.btnStartStop = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudRefresh)).BeginInit();
			this.gbSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// nudRefresh
			// 
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
			this.nudRefresh.Size = new System.Drawing.Size(139, 20);
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
			this.gbSettings.Controls.Add(this.lblRefreshTime);
			this.gbSettings.Controls.Add(this.nudRefresh);
			this.gbSettings.Location = new System.Drawing.Point(12, 12);
			this.gbSettings.Name = "gbSettings";
			this.gbSettings.Size = new System.Drawing.Size(766, 123);
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
			this.btnStartStop.Location = new System.Drawing.Point(703, 525);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(75, 23);
			this.btnStartStop.TabIndex = 2;
			this.btnStartStop.Text = "Start";
			this.btnStartStop.UseVisualStyleBackColor = true;
			this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
			// 
			// NiceHashWorkerMonitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 560);
			this.Controls.Add(this.btnStartStop);
			this.Controls.Add(this.gbSettings);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NiceHashWorkerMonitor";
			this.Text = "NiceHash Worker Monitor";
			this.Load += new System.EventHandler(this.NiceHashWorkerMonitor_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudRefresh)).EndInit();
			this.gbSettings.ResumeLayout(false);
			this.gbSettings.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudRefresh;
		private System.Windows.Forms.GroupBox gbSettings;
		private System.Windows.Forms.Label lblRefreshTime;
		private System.Windows.Forms.Timer timerCardStatsRefresh;
		private System.ComponentModel.BackgroundWorker bgwCardStatsRefresh;
		private System.ComponentModel.BackgroundWorker bgwDataBaseSave;
		private System.Windows.Forms.Button btnStartStop;
	}
}

