using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capkel
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            NamaLBL.Text = Form1.LoggedInUsername;
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void TeacherBTN_Click(object sender, EventArgs e)
        {
            SubmitScore sc = new SubmitScore();
            sc.Show();
            this.Hide();

        }

        private void ViewScoreBTN_Click(object sender, EventArgs e)
        {
            ViewScore vs = new ViewScore();
            vs.Show();
            this.Hide();
        }

        private void ReportBTN_Click(object sender, EventArgs e)
        {
            ViewReportStudent vr = new ViewReportStudent();
            vr.Show();
            this.Hide();
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            SubmitScore sc = new SubmitScore();
            sc.Show();
            this.Hide();
        }
    }
}
