namespace capkel
{
    partial class Form2
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
            this.NamaLBL = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubjectBTN = new System.Windows.Forms.Button();
            this.StudentBTN = new System.Windows.Forms.Button();
            this.TeacherBTN = new System.Windows.Forms.Button();
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NamaLBL
            // 
            this.NamaLBL.AutoSize = true;
            this.NamaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaLBL.Location = new System.Drawing.Point(162, 23);
            this.NamaLBL.Name = "NamaLBL";
            this.NamaLBL.Size = new System.Drawing.Size(19, 13);
            this.NamaLBL.TabIndex = 1;
            this.NamaLBL.Text = "...";
            this.NamaLBL.Click += new System.EventHandler(this.NamaLBL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SubjectBTN);
            this.groupBox1.Controls.Add(this.StudentBTN);
            this.groupBox1.Controls.Add(this.TeacherBTN);
            this.groupBox1.Location = new System.Drawing.Point(63, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master Data";
            // 
            // SubjectBTN
            // 
            this.SubjectBTN.Location = new System.Drawing.Point(17, 128);
            this.SubjectBTN.Name = "SubjectBTN";
            this.SubjectBTN.Size = new System.Drawing.Size(280, 40);
            this.SubjectBTN.TabIndex = 2;
            this.SubjectBTN.Text = "Manage Subject";
            this.SubjectBTN.UseVisualStyleBackColor = true;
            this.SubjectBTN.Click += new System.EventHandler(this.SubjectBTN_Click);
            // 
            // StudentBTN
            // 
            this.StudentBTN.Location = new System.Drawing.Point(17, 82);
            this.StudentBTN.Name = "StudentBTN";
            this.StudentBTN.Size = new System.Drawing.Size(280, 40);
            this.StudentBTN.TabIndex = 1;
            this.StudentBTN.Text = "Manage Student";
            this.StudentBTN.UseVisualStyleBackColor = true;
            this.StudentBTN.Click += new System.EventHandler(this.StudentBTN_Click);
            // 
            // TeacherBTN
            // 
            this.TeacherBTN.Location = new System.Drawing.Point(17, 36);
            this.TeacherBTN.Name = "TeacherBTN";
            this.TeacherBTN.Size = new System.Drawing.Size(280, 40);
            this.TeacherBTN.TabIndex = 0;
            this.TeacherBTN.Text = "Manage Teacher";
            this.TeacherBTN.UseVisualStyleBackColor = true;
            this.TeacherBTN.Click += new System.EventHandler(this.TeacherBTN_Click);
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.Location = new System.Drawing.Point(143, 267);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(148, 40);
            this.LogoutBTN.TabIndex = 3;
            this.LogoutBTN.Text = "Log Out";
            this.LogoutBTN.UseVisualStyleBackColor = true;
            this.LogoutBTN.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 319);
            this.Controls.Add(this.LogoutBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NamaLBL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NamaLBL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SubjectBTN;
        private System.Windows.Forms.Button StudentBTN;
        private System.Windows.Forms.Button TeacherBTN;
        private System.Windows.Forms.Button LogoutBTN;
    }
}