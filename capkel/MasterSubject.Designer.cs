namespace capkel
{
    partial class MasterSubject
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.IdTXB = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.InsertBTN = new System.Windows.Forms.Button();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sMKScoreDataSet = new capkel.SMKScoreDataSet();
            this.NameTXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherTableAdapter = new capkel.SMKScoreDataSetTableAdapters.TeacherTableAdapter();
            this.CriteriaNum = new System.Windows.Forms.NumericUpDown();
            this.isPracticeCHK = new System.Windows.Forms.CheckBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMKScoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dataStudent
            // 
            this.dataStudent.AllowUserToAddRows = false;
            this.dataStudent.AllowUserToDeleteRows = false;
            this.dataStudent.AllowUserToOrderColumns = true;
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Location = new System.Drawing.Point(32, 65);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.ReadOnly = true;
            this.dataStudent.RowHeadersWidth = 46;
            this.dataStudent.Size = new System.Drawing.Size(681, 293);
            this.dataStudent.TabIndex = 67;
            // 
            // IdTXB
            // 
            this.IdTXB.Location = new System.Drawing.Point(131, 390);
            this.IdTXB.Name = "IdTXB";
            this.IdTXB.Size = new System.Drawing.Size(168, 20);
            this.IdTXB.TabIndex = 66;
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.LightCoral;
            this.CancelBTN.Location = new System.Drawing.Point(542, 438);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(111, 39);
            this.CancelBTN.TabIndex = 65;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveBTN.Location = new System.Drawing.Point(425, 438);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(111, 39);
            this.SaveBTN.TabIndex = 64;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = false;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteBTN.Location = new System.Drawing.Point(602, 393);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(111, 39);
            this.DeleteBTN.TabIndex = 63;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpdateBTN.Location = new System.Drawing.Point(485, 393);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(111, 39);
            this.UpdateBTN.TabIndex = 62;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = false;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // InsertBTN
            // 
            this.InsertBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertBTN.Location = new System.Drawing.Point(368, 391);
            this.InsertBTN.Name = "InsertBTN";
            this.InsertBTN.Size = new System.Drawing.Size(111, 39);
            this.InsertBTN.TabIndex = 61;
            this.InsertBTN.Text = "Insert";
            this.InsertBTN.UseVisualStyleBackColor = false;
            this.InsertBTN.Click += new System.EventHandler(this.InsertBTN_Click);
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
            // NameTXB
            // 
            this.NameTXB.Location = new System.Drawing.Point(131, 424);
            this.NameTXB.Name = "NameTXB";
            this.NameTXB.Size = new System.Drawing.Size(168, 20);
            this.NameTXB.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Minimum Criteria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Subject ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.333333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Master Subject";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // CriteriaNum
            // 
            this.CriteriaNum.Location = new System.Drawing.Point(135, 457);
            this.CriteriaNum.Name = "CriteriaNum";
            this.CriteriaNum.Size = new System.Drawing.Size(164, 20);
            this.CriteriaNum.TabIndex = 68;
            // 
            // isPracticeCHK
            // 
            this.isPracticeCHK.AutoSize = true;
            this.isPracticeCHK.Location = new System.Drawing.Point(135, 487);
            this.isPracticeCHK.Name = "isPracticeCHK";
            this.isPracticeCHK.Size = new System.Drawing.Size(74, 17);
            this.isPracticeCHK.TabIndex = 69;
            this.isPracticeCHK.Text = "is practice";
            this.isPracticeCHK.UseVisualStyleBackColor = true;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(467, 21);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(246, 20);
            this.SearchBar.TabIndex = 70;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // MasterSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 516);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.isPracticeCHK);
            this.Controls.Add(this.CriteriaNum);
            this.Controls.Add(this.dataStudent);
            this.Controls.Add(this.IdTXB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.InsertBTN);
            this.Controls.Add(this.NameTXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MasterSubject";
            this.Text = "MasterSubject";
            this.Load += new System.EventHandler(this.MasterSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMKScoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.TextBox IdTXB;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button InsertBTN;
        private System.Windows.Forms.TextBox NameTXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private SMKScoreDataSet sMKScoreDataSet;
        private SMKScoreDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.NumericUpDown CriteriaNum;
        private System.Windows.Forms.CheckBox isPracticeCHK;
        private System.Windows.Forms.TextBox SearchBar;
    }
}