namespace capkel
{
    partial class MasterTeacher
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
            this.components = new System.ComponentModel.Container();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMKScoreDataSet = new capkel.SMKScoreDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTXB = new System.Windows.Forms.TextBox();
            this.PhoneTXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BirthDT = new System.Windows.Forms.DateTimePicker();
            this.EmailTXB = new System.Windows.Forms.TextBox();
            this.PassTXB = new System.Windows.Forms.TextBox();
            this.RoleCMB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FemaleRB = new System.Windows.Forms.RadioButton();
            this.MaleRB = new System.Windows.Forms.RadioButton();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.IdTXB = new System.Windows.Forms.TextBox();
            this.teacherTableAdapter = new capkel.SMKScoreDataSetTableAdapters.TeacherTableAdapter();
            this.dataTeacher = new System.Windows.Forms.DataGridView();
            this.SearchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMKScoreDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.sMKScoreDataSet;
            // 
            // sMKScoreDataSet
            // 
            this.sMKScoreDataSet.DataSetName = "SMKScoreDataSet";
            this.sMKScoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Master Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teacher ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Birth Date";
            // 
            // NameTXB
            // 
            this.NameTXB.Location = new System.Drawing.Point(140, 431);
            this.NameTXB.Name = "NameTXB";
            this.NameTXB.Size = new System.Drawing.Size(168, 20);
            this.NameTXB.TabIndex = 7;
            // 
            // PhoneTXB
            // 
            this.PhoneTXB.Location = new System.Drawing.Point(140, 464);
            this.PhoneTXB.Name = "PhoneTXB";
            this.PhoneTXB.Size = new System.Drawing.Size(168, 20);
            this.PhoneTXB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Role";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(348, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(348, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Gender";
            // 
            // BirthDT
            // 
            this.BirthDT.Location = new System.Drawing.Point(140, 503);
            this.BirthDT.Name = "BirthDT";
            this.BirthDT.Size = new System.Drawing.Size(167, 20);
            this.BirthDT.TabIndex = 14;
            // 
            // EmailTXB
            // 
            this.EmailTXB.Location = new System.Drawing.Point(413, 434);
            this.EmailTXB.Name = "EmailTXB";
            this.EmailTXB.Size = new System.Drawing.Size(168, 20);
            this.EmailTXB.TabIndex = 15;
            // 
            // PassTXB
            // 
            this.PassTXB.Location = new System.Drawing.Point(413, 467);
            this.PassTXB.Name = "PassTXB";
            this.PassTXB.Size = new System.Drawing.Size(168, 20);
            this.PassTXB.TabIndex = 16;
            // 
            // RoleCMB
            // 
            this.RoleCMB.FormattingEnabled = true;
            this.RoleCMB.Items.AddRange(new object[] {
            "Admin",
            "Evaluator"});
            this.RoleCMB.Location = new System.Drawing.Point(413, 503);
            this.RoleCMB.Name = "RoleCMB";
            this.RoleCMB.Size = new System.Drawing.Size(168, 21);
            this.RoleCMB.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FemaleRB);
            this.groupBox1.Controls.Add(this.MaleRB);
            this.groupBox1.Location = new System.Drawing.Point(413, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 42);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // FemaleRB
            // 
            this.FemaleRB.AutoSize = true;
            this.FemaleRB.Location = new System.Drawing.Point(99, 19);
            this.FemaleRB.Name = "FemaleRB";
            this.FemaleRB.Size = new System.Drawing.Size(59, 17);
            this.FemaleRB.TabIndex = 20;
            this.FemaleRB.TabStop = true;
            this.FemaleRB.Text = "Female";
            this.FemaleRB.UseVisualStyleBackColor = true;
            // 
            // MaleRB
            // 
            this.MaleRB.AutoSize = true;
            this.MaleRB.Location = new System.Drawing.Point(8, 19);
            this.MaleRB.Name = "MaleRB";
            this.MaleRB.Size = new System.Drawing.Size(48, 17);
            this.MaleRB.TabIndex = 19;
            this.MaleRB.TabStop = true;
            this.MaleRB.Text = "Male";
            this.MaleRB.UseVisualStyleBackColor = true;
            // 
            // InsertBTN
            // 
            this.InsertBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertBTN.Location = new System.Drawing.Point(647, 410);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(111, 39);
            this.InsertBTN.TabIndex = 19;
            this.InsertBTN.Text = "Insert";
            this.InsertBTN.UseVisualStyleBackColor = false;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpdateBTN.Location = new System.Drawing.Point(764, 412);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(111, 39);
            this.UpdateBTN.TabIndex = 20;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = false;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteBTN.Location = new System.Drawing.Point(881, 412);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(111, 39);
            this.DeleteBTN.TabIndex = 21;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.LightCoral;
            this.CancelBTN.Location = new System.Drawing.Point(821, 457);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(111, 39);
            this.CancelBTN.TabIndex = 23;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.button4_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveBTN.Location = new System.Drawing.Point(704, 457);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(111, 39);
            this.SaveBTN.TabIndex = 22;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // IdTXB
            // 
            this.IdTXB.HideSelection = false;
            this.IdTXB.Location = new System.Drawing.Point(140, 397);
            this.IdTXB.Name = "IdTXB";
            this.IdTXB.Size = new System.Drawing.Size(168, 20);
            this.IdTXB.TabIndex = 24;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // dataTeacher
            // 
            this.dataTeacher.AllowUserToAddRows = false;
            this.dataTeacher.AllowUserToDeleteRows = false;
            this.dataTeacher.AllowUserToOrderColumns = true;
            this.dataTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTeacher.Location = new System.Drawing.Point(41, 72);
            this.dataTeacher.Name = "dataTeacher";
            this.dataTeacher.ReadOnly = true;
            this.dataTeacher.RowHeadersWidth = 46;
            this.dataTeacher.Size = new System.Drawing.Size(912, 293);
            this.dataTeacher.TabIndex = 25;
            this.dataTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTeacher_CellContentClick_1);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(707, 28);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(246, 20);
            this.SearchBar.TabIndex = 71;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // MasterTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 564);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.dataTeacher);
            this.Controls.Add(this.IdTXB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.InsertBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoleCMB);
            this.Controls.Add(this.PassTXB);
            this.Controls.Add(this.EmailTXB);
            this.Controls.Add(this.BirthDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PhoneTXB);
            this.Controls.Add(this.NameTXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MasterTeacher";
            this.Text = "MasterTeacher";
            this.Load += new System.EventHandler(this.MasterTeacher_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMKScoreDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        
        private System.Windows.Forms.TextBox NameTXB;
        private System.Windows.Forms.TextBox PhoneTXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker BirthDT;
        private System.Windows.Forms.TextBox EmailTXB;
        private System.Windows.Forms.TextBox PassTXB;
        private System.Windows.Forms.ComboBox RoleCMB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MaleRB;
        private System.Windows.Forms.RadioButton FemaleRB;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.TextBox IdTXB;
        private SMKScoreDataSet sMKScoreDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private SMKScoreDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridView dataTeacher;
        private System.Windows.Forms.TextBox SearchBar;
    }
}