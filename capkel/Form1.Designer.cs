namespace capkel
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailTXB = new System.Windows.Forms.TextBox();
            this.PassTXB = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMK Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // EmailTXB
            // 
            this.EmailTXB.Location = new System.Drawing.Point(106, 70);
            this.EmailTXB.Name = "EmailTXB";
            this.EmailTXB.Size = new System.Drawing.Size(246, 20);
            this.EmailTXB.TabIndex = 3;
            // 
            // PassTXB
            // 
            this.PassTXB.Location = new System.Drawing.Point(106, 109);
            this.PassTXB.Name = "PassTXB";
            this.PassTXB.Size = new System.Drawing.Size(246, 20);
            this.PassTXB.TabIndex = 4;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(106, 165);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(164, 33);
            this.LoginBTN.TabIndex = 5;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(499, 279);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.PassTXB);
            this.Controls.Add(this.EmailTXB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailTXB;
        private System.Windows.Forms.TextBox PassTXB;
        private System.Windows.Forms.Button LoginBTN;
    }
}

