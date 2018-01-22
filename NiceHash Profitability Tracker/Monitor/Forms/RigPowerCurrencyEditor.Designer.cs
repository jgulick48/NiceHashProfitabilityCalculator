namespace Monitor.Forms
{
	partial class RigPowerCurrencyEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RigPowerCurrencyEditor));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbCurrency = new System.Windows.Forms.ComboBox();
			this.nudBasePower = new System.Windows.Forms.NumericUpDown();
			this.nudPowerPrice = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudBasePower)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPowerPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Currency:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Base Power Usage (Watts):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Price Per kWh";
			// 
			// cbCurrency
			// 
			this.cbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCurrency.FormattingEnabled = true;
			this.cbCurrency.Location = new System.Drawing.Point(167, 12);
			this.cbCurrency.Name = "cbCurrency";
			this.cbCurrency.Size = new System.Drawing.Size(170, 21);
			this.cbCurrency.TabIndex = 3;
			this.cbCurrency.SelectedIndexChanged += new System.EventHandler(this.cbCurrency_SelectedIndexChanged);
			// 
			// nudBasePower
			// 
			this.nudBasePower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudBasePower.Location = new System.Drawing.Point(167, 39);
			this.nudBasePower.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.nudBasePower.Name = "nudBasePower";
			this.nudBasePower.Size = new System.Drawing.Size(170, 20);
			this.nudBasePower.TabIndex = 4;
			// 
			// nudPowerPrice
			// 
			this.nudPowerPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudPowerPrice.DecimalPlaces = 3;
			this.nudPowerPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nudPowerPrice.Location = new System.Drawing.Point(167, 65);
			this.nudPowerPrice.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPowerPrice.Name = "nudPowerPrice";
			this.nudPowerPrice.Size = new System.Drawing.Size(170, 20);
			this.nudPowerPrice.TabIndex = 5;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(262, 93);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(181, 93);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// RigPowerCurrencyEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 128);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.nudPowerPrice);
			this.Controls.Add(this.nudBasePower);
			this.Controls.Add(this.cbCurrency);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(365, 167);
			this.MinimumSize = new System.Drawing.Size(365, 167);
			this.Name = "RigPowerCurrencyEditor";
			this.Text = "Rig Power Currency Editor";
			this.Load += new System.EventHandler(this.RigPowerCurrencyEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudBasePower)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPowerPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbCurrency;
		public System.Windows.Forms.NumericUpDown nudPowerPrice;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		public System.Windows.Forms.NumericUpDown nudBasePower;
	}
}