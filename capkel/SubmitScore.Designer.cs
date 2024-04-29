namespace capkel
{
    partial class SubmitScore
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
            this.dataScore = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameTXB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataScore
            // 
            this.dataScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataScore.Location = new System.Drawing.Point(30, 86);
            this.dataScore.Name = "dataScore";
            this.dataScore.RowHeadersWidth = 46;
            this.dataScore.Size = new System.Drawing.Size(688, 351);
            this.dataScore.TabIndex = 0;
            this.dataScore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Evaluator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 3;
            // 
            // NameTXB
            // 
            this.NameTXB.Location = new System.Drawing.Point(112, 50);
            this.NameTXB.Name = "NameTXB";
            this.NameTXB.Size = new System.Drawing.Size(177, 20);
            this.NameTXB.TabIndex = 4;
            // 
            // SubmitScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameTXB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataScore);
            this.Name = "SubmitScore";
            this.Text = "SubmitScore";
            this.Load += new System.EventHandler(this.SubmitScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NameTXB;
    }
}