namespace WinFormsApp
{
    partial class ctrlPlayerForOrder
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblListType = new System.Windows.Forms.Label();
            this.lblOccurences = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(107, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "IMEIPREZIMEIGRACA";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(108, 21);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(19, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "99";
            // 
            // lblListType
            // 
            this.lblListType.AutoSize = true;
            this.lblListType.Location = new System.Drawing.Point(108, 43);
            this.lblListType.Name = "lblListType";
            this.lblListType.Size = new System.Drawing.Size(139, 13);
            this.lblListType.TabIndex = 3;
            this.lblListType.Text = "BROJ KARTONA/GOLOVA";
            // 
            // lblOccurences
            // 
            this.lblOccurences.AutoSize = true;
            this.lblOccurences.Location = new System.Drawing.Point(111, 60);
            this.lblOccurences.Name = "lblOccurences";
            this.lblOccurences.Size = new System.Drawing.Size(19, 13);
            this.lblOccurences.TabIndex = 4;
            this.lblOccurences.Text = "99";
            // 
            // ctrlPlayerForOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOccurences);
            this.Controls.Add(this.lblListType);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlPlayerForOrder";
            this.Size = new System.Drawing.Size(249, 91);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblListType;
        private System.Windows.Forms.Label lblOccurences;
    }
}
