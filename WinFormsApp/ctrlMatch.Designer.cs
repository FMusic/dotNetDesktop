namespace WinFormsApp
{
    partial class ctrlMatch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblNumberText = new System.Windows.Forms.Label();
            this.lblNumberOfVisitors = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAway = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(9, 10);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(221, 17);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "LOKACIJA/LOCATION/LOCATION";
            // 
            // lblNumberText
            // 
            this.lblNumberText.AutoSize = true;
            this.lblNumberText.Location = new System.Drawing.Point(9, 26);
            this.lblNumberText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberText.Name = "lblNumberText";
            this.lblNumberText.Size = new System.Drawing.Size(130, 17);
            this.lblNumberText.TabIndex = 1;
            this.lblNumberText.Text = "Number of visitors: ";
            // 
            // lblNumberOfVisitors
            // 
            this.lblNumberOfVisitors.AutoSize = true;
            this.lblNumberOfVisitors.Location = new System.Drawing.Point(147, 26);
            this.lblNumberOfVisitors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfVisitors.Name = "lblNumberOfVisitors";
            this.lblNumberOfVisitors.Size = new System.Drawing.Size(84, 17);
            this.lblNumberOfVisitors.TabIndex = 2;
            this.lblNumberOfVisitors.Text = "9999 99999";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(9, 64);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(130, 17);
            this.lblHome.TabIndex = 3;
            this.lblHome.Text = "HomeTeamCountry";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "VS";
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Location = new System.Drawing.Point(183, 64);
            this.lblAway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(126, 17);
            this.lblAway.TabIndex = 5;
            this.lblAway.Text = "AwayTeamCountry";
            // 
            // ctrlMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lblAway);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblNumberOfVisitors);
            this.Controls.Add(this.lblNumberText);
            this.Controls.Add(this.lblLocation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ctrlMatch";
            this.Size = new System.Drawing.Size(313, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblNumberText;
        private System.Windows.Forms.Label lblNumberOfVisitors;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAway;
    }
}
