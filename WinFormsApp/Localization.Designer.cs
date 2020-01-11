namespace WinFormsApp
{
    partial class Localization
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCroatian = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, choose your locales";
            // 
            // btnCroatian
            // 
            this.btnCroatian.Location = new System.Drawing.Point(260, 104);
            this.btnCroatian.Name = "btnCroatian";
            this.btnCroatian.Size = new System.Drawing.Size(245, 61);
            this.btnCroatian.TabIndex = 1;
            this.btnCroatian.Text = "Hrvatski";
            this.btnCroatian.UseVisualStyleBackColor = true;
            this.btnCroatian.Click += new System.EventHandler(this.btnCroatian_ClickAsync);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Location = new System.Drawing.Point(260, 171);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(245, 61);
            this.btnEnglish.TabIndex = 2;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_ClickAsync);
            // 
            // Localization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnCroatian);
            this.Controls.Add(this.label1);
            this.Name = "Localization";
            this.Text = "Localization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCroatian;
        private System.Windows.Forms.Button btnEnglish;
    }
}