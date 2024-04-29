namespace capkel
{
    partial class MasterStudent
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
            this.teacherTableAdapter = new capkel.SMKScoreDataSetTableAdapters.TeacherTableAdapter();
            this.FemaleRB = new System.Windows.Forms.RadioButton();
            this.sMKScoreDataSet = new capkel.SMKScoreDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaleRB = new System.Windows.Forms.RadioButton();
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.IdTXB = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BirthDT = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameTXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AddressTXB = new System.Windows.Forms.TextBox();
            this.KelasTXB = new System.Windows.Forms.TextBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sMKScoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
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
            // sMKScoreDataSet
            // 
            this.sMKScoreDataSet.DataSetName = "SMKScoreDataSet";
            this.sMKScoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.sMKScoreDataSet;
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
            // dataStudent
            // 
            this.dataStudent.AllowUserToAddRows = false;
            this.dataStudent.AllowUserToDeleteRows = false;
            this.dataStudent.AllowUserToOrderColumns = true;
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Location = new System.Drawing.Point(27, 67);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.ReadOnly = true;
            this.dataStudent.RowHeadersWidth = 46;
            this.dataStudent.Size = new System.Drawing.Size(912, 293);
            this.dataStudent.TabIndex = 48;
            this.dataStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudent_CellContentClick);
            // 
            // IdTXB
            // 
            this.IdTXB.Location = new System.Drawing.Point(126, 392);
            this.IdTXB.Name = "IdTXB";
            this.IdTXB.Size = new System.Drawing.Size(168, 20);
            this.IdTXB.TabIndex = 47;
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.LightCoral;
            this.CancelBTN.Location = new System.Drawing.Point(807, 452);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(111, 39);
            this.CancelBTN.TabIndex = 46;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveBTN.Location = new System.Drawing.Point(690, 452);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(111, 39);
            this.SaveBTN.TabIndex = 45;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteBTN.Location = new System.Drawing.Point(867, 407);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(111, 39);
            this.DeleteBTN.TabIndex = 44;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpdateBTN.Location = new System.Drawing.Point(750, 407);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(111, 39);
            this.UpdateBTN.TabIndex = 43;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = false;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // InsertBTN
            // 
            this.InsertBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertBTN.Location = new System.Drawing.Point(633, 405);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(111, 39);
            this.InsertBTN.TabIndex = 42;
            this.InsertBTN.Text = "Insert";
            this.InsertBTN.UseVisualStyleBackColor = false;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FemaleRB);
            this.groupBox1.Controls.Add(this.MaleRB);
            this.groupBox1.Location = new System.Drawing.Point(399, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 42);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // BirthDT
            // 
            this.BirthDT.Location = new System.Drawing.Point(126, 462);
            this.BirthDT.Name = "BirthDT";
            this.BirthDT.Size = new System.Drawing.Size(167, 20);
            this.BirthDT.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Gender";
            // 
            // NameTXB
            // 
            this.NameTXB.Location = new System.Drawing.Point(126, 426);
            this.NameTXB.Name = "NameTXB";
            this.NameTXB.Size = new System.Drawing.Size(168, 20);
            this.NameTXB.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Master Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Address";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AddressTXB
            // 
            this.AddressTXB.Location = new System.Drawing.Point(402, 439);
            this.AddressTXB.Name = "AddressTXB";
            this.AddressTXB.Size = new System.Drawing.Size(189, 20);
            this.AddressTXB.TabIndex = 50;
            // 
            // KelasTXB
            // 
            this.KelasTXB.Location = new System.Drawing.Point(402, 469);
            this.KelasTXB.Name = "KelasTXB";
            this.KelasTXB.Size = new System.Drawing.Size(189, 20);
            this.KelasTXB.TabIndex = 51;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(693, 23);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(246, 20);
            this.SearchBar.TabIndex = 71;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // MasterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 542);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.KelasTXB);
            this.Controls.Add(this.AddressTXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataStudent);
            this.Controls.Add(this.IdTXB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.InsertBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BirthDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NameTXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MasterStudent";
            this.Text = "MasterStudent";
            this.Load += new System.EventHandler(this.MasterStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sMKScoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SMKScoreDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.RadioButton FemaleRB;
        private SMKScoreDataSet sMKScoreDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.RadioButton MaleRB;
        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.TextBox IdTXB;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker BirthDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameTXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox AddressTXB;
        private System.Windows.Forms.TextBox KelasTXB;
        private System.Windows.Forms.TextBox SearchBar;
    }
}