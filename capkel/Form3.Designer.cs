namespace capkel
{
    partial class Form3
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
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReportBTN = new System.Windows.Forms.Button();
            this.ViewScoreBTN = new System.Windows.Forms.Button();
            this.NamaLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.Location = new System.Drawing.Point(127, 275);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(148, 40);
            this.LogoutBTN.TabIndex = 7;
            this.LogoutBTN.Text = "Log Out";
            this.LogoutBTN.UseVisualStyleBackColor = true;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SubmitBTN);
            this.groupBox1.Controls.Add(this.ReportBTN);
            this.groupBox1.Controls.Add(this.ViewScoreBTN);
            this.groupBox1.Location = new System.Drawing.Point(47, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // ReportBTN
            // 
            this.ReportBTN.Location = new System.Drawing.Point(17, 128);
            this.ReportBTN.Name = "ReportBTN";
            this.ReportBTN.Size = new System.Drawing.Size(280, 40);
            this.ReportBTN.TabIndex = 2;
            this.ReportBTN.Text = "View Report Student";
            this.ReportBTN.UseVisualStyleBackColor = true;
            this.ReportBTN.Click += new System.EventHandler(this.ReportBTN_Click);
            // 
            // ViewScoreBTN
            // 
            this.ViewScoreBTN.Location = new System.Drawing.Point(17, 82);
            this.ViewScoreBTN.Name = "ViewScoreBTN";
            this.ViewScoreBTN.Size = new System.Drawing.Size(280, 40);
            this.ViewScoreBTN.TabIndex = 1;
            this.ViewScoreBTN.Text = "View Score";
            this.ViewScoreBTN.UseVisualStyleBackColor = true;
            this.ViewScoreBTN.Click += new System.EventHandler(this.ViewScoreBTN_Click);
            // 
            // NamaLBL
            // 
            this.NamaLBL.AutoSize = true;
            this.NamaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaLBL.Location = new System.Drawing.Point(146, 31);
            this.NamaLBL.Name = "NamaLBL";
            this.NamaLBL.Size = new System.Drawing.Size(19, 13);
            this.NamaLBL.TabIndex = 5;
            this.NamaLBL.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selamat Datang,";
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.Location = new System.Drawing.Point(17, 36);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(280, 40);
            this.SubmitBTN.TabIndex = 3;
            this.SubmitBTN.Text = "Submit Score";
            this.SubmitBTN.UseVisualStyleBackColor = true;
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 395);
            this.Controls.Add(this.LogoutBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NamaLBL);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ReportBTN;
        private System.Windows.Forms.Button ViewScoreBTN;
        private System.Windows.Forms.Label NamaLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitBTN;
    }
}