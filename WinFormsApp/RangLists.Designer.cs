namespace WinFormsApp
{
    partial class RangLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangLists));
            this.flpPlayersByGoals = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayersByCards = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMatchesByVisitors = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblGoals = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpPlayersByGoals
            // 
            resources.ApplyResources(this.flpPlayersByGoals, "flpPlayersByGoals");
            this.flpPlayersByGoals.Name = "flpPlayersByGoals";
            // 
            // flpPlayersByCards
            // 
            resources.ApplyResources(this.flpPlayersByCards, "flpPlayersByCards");
            this.flpPlayersByCards.Name = "flpPlayersByCards";
            // 
            // flpMatchesByVisitors
            // 
            resources.ApplyResources(this.flpMatchesByVisitors, "flpMatchesByVisitors");
            this.flpMatchesByVisitors.Name = "flpMatchesByVisitors";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblGoals
            // 
            resources.ApplyResources(this.lblGoals, "lblGoals");
            this.lblGoals.Name = "lblGoals";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RangLists
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGoals);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.flpMatchesByVisitors);
            this.Controls.Add(this.flpPlayersByCards);
            this.Controls.Add(this.flpPlayersByGoals);
            this.Name = "RangLists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlayersByGoals;
        private System.Windows.Forms.FlowLayoutPanel flpPlayersByCards;
        private System.Windows.Forms.FlowLayoutPanel flpMatchesByVisitors;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblGoals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}