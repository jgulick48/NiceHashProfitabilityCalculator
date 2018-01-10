namespace Viewer.Forms
{
	partial class ExceptionPopup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionPopup));
			this.lblErrorMessage = new System.Windows.Forms.Label();
			this.btnOkay = new System.Windows.Forms.Button();
			this.btnReport = new System.Windows.Forms.Button();
			this.tbErrorMessage = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblErrorMessage
			// 
			this.lblErrorMessage.AutoSize = true;
			this.lblErrorMessage.Location = new System.Drawing.Point(12, 9);
			this.lblErrorMessage.Name = "lblErrorMessage";
			this.lblErrorMessage.Size = new System.Drawing.Size(78, 13);
			this.lblErrorMessage.TabIndex = 0;
			this.lblErrorMessage.Text = "Error Message:";
			// 
			// btnOkay
			// 
			this.btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOkay.Location = new System.Drawing.Point(418, 306);
			this.btnOkay.Name = "btnOkay";
			this.btnOkay.Size = new System.Drawing.Size(75, 23);
			this.btnOkay.TabIndex = 1;
			this.btnOkay.Text = "Okay";
			this.btnOkay.UseVisualStyleBackColor = true;
			// 
			// btnReport
			// 
			this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReport.Location = new System.Drawing.Point(337, 306);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(75, 23);
			this.btnReport.TabIndex = 2;
			this.btnReport.Text = "Report";
			this.btnReport.UseVisualStyleBackColor = true;
			this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
			// 
			// tbErrorMessage
			// 
			this.tbErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbErrorMessage.Location = new System.Drawing.Point(12, 25);
			this.tbErrorMessage.Multiline = true;
			this.tbErrorMessage.Name = "tbErrorMessage";
			this.tbErrorMessage.ReadOnly = true;
			this.tbErrorMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbErrorMessage.Size = new System.Drawing.Size(481, 275);
			this.tbErrorMessage.TabIndex = 3;
			// 
			// ExceptionPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 341);
			this.Controls.Add(this.tbErrorMessage);
			this.Controls.Add(this.btnReport);
			this.Controls.Add(this.btnOkay);
			this.Controls.Add(this.lblErrorMessage);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ExceptionPopup";
			this.Text = "Error";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnOkay;
		private System.Windows.Forms.Button btnReport;
		public System.Windows.Forms.Label lblErrorMessage;
		public System.Windows.Forms.TextBox tbErrorMessage;
	}
}