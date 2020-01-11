namespace WinFormsApp
{
    partial class ctrlPlayerForFav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPlayerForFav));
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.pbFavourite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourite)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(3, 3);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(85, 81);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.Player_Click);
            this.pbPicture.DoubleClick += new System.EventHandler(this.pbPicture_DoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "IMEIGRACA PREZIMEIGRACA";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.Player_Click);
            this.lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlPlayerForFav_MouseDown);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(101, 3);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(34, 25);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "99";
            this.lblNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlPlayerForFav_MouseDown);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(3, 109);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(80, 13);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "ZADNJI VEZNI";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPosition.Click += new System.EventHandler(this.Player_Click);
            this.lblPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlPlayerForFav_MouseDown);
            // 
            // lblCaptain
            // 
            this.lblCaptain.AutoSize = true;
            this.lblCaptain.Location = new System.Drawing.Point(94, 32);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(57, 13);
            this.lblCaptain.TabIndex = 5;
            this.lblCaptain.Text = "KAPETAN";
            this.lblCaptain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlPlayerForFav_MouseDown);
            // 
            // pbFavourite
            // 
            this.pbFavourite.Image = ((System.Drawing.Image)(resources.GetObject("pbFavourite.Image")));
            this.pbFavourite.Location = new System.Drawing.Point(106, 58);
            this.pbFavourite.Name = "pbFavourite";
            this.pbFavourite.Size = new System.Drawing.Size(29, 26);
            this.pbFavourite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFavourite.TabIndex = 6;
            this.pbFavourite.TabStop = false;
            this.pbFavourite.Click += new System.EventHandler(this.Player_Click);
            this.pbFavourite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlPlayerForFav_MouseDown);
            // 
            // ctrlPlayerForFav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.pbFavourite);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbPicture);
            this.Name = "ctrlPlayerForFav";
            this.Size = new System.Drawing.Size(161, 128);
            this.Click += new System.EventHandler(this.Player_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlPlayerForFav_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavourite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.PictureBox pbFavourite;
    }
}
