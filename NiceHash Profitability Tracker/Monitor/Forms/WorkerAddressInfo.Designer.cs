namespace Monitor.Forms
{
	partial class WorkerAddressInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerAddressInfo));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbWalletAddress = new System.Windows.Forms.TextBox();
			this.tbWorkerName = new System.Windows.Forms.TextBox();
			this.btnOkay = new System.Windows.Forms.Button();
			this.cbStorageType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Wallet Address:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Worker Name:";
			// 
			// tbWalletAddress
			// 
			this.tbWalletAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbWalletAddress.Location = new System.Drawing.Point(99, 12);
			this.tbWalletAddress.Name = "tbWalletAddress";
			this.tbWalletAddress.Size = new System.Drawing.Size(491, 20);
			this.tbWalletAddress.TabIndex = 2;
			// 
			// tbWorkerName
			// 
			this.tbWorkerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbWorkerName.Location = new System.Drawing.Point(99, 38);
			this.tbWorkerName.Name = "tbWorkerName";
			this.tbWorkerName.Size = new System.Drawing.Size(491, 20);
			this.tbWorkerName.TabIndex = 3;
			// 
			// btnOkay
			// 
			this.btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOkay.Location = new System.Drawing.Point(515, 92);
			this.btnOkay.Name = "btnOkay";
			this.btnOkay.Size = new System.Drawing.Size(75, 23);
			this.btnOkay.TabIndex = 4;
			this.btnOkay.Text = "Okay";
			this.btnOkay.UseVisualStyleBackColor = true;
			// 
			// cbStorageType
			// 
			this.cbStorageType.Enabled = false;
			this.cbStorageType.FormattingEnabled = true;
			this.cbStorageType.Items.AddRange(new object[] {
            "MySQL",
            "sqlite"});
			this.cbStorageType.Location = new System.Drawing.Point(99, 64);
			this.cbStorageType.Name = "cbStorageType";
			this.cbStorageType.Size = new System.Drawing.Size(491, 21);
			this.cbStorageType.TabIndex = 5;
			this.cbStorageType.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Enabled = false;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Storage Type:";
			this.label3.Visible = false;
			// 
			// WorkerAddressInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 127);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbStorageType);
			this.Controls.Add(this.btnOkay);
			this.Controls.Add(this.tbWorkerName);
			this.Controls.Add(this.tbWalletAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(618, 139);
			this.Name = "WorkerAddressInfo";
			this.Text = "Worker Address Info";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox tbWalletAddress;
		public System.Windows.Forms.TextBox tbWorkerName;
		private System.Windows.Forms.Button btnOkay;
		private System.Windows.Forms.ComboBox cbStorageType;
		private System.Windows.Forms.Label label3;
	}
}