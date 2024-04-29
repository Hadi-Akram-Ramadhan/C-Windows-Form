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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NamaLBL.Text = Form1.LoggedInUsername;
        }

        private void TeacherBTN_Click(object sender, EventArgs e)
        {
            MasterTeacher mt = new MasterTeacher();
            mt.Show();
            this.Hide();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            MasterStudent ms = new MasterStudent();
            ms.Show();
            this.Hide();
        }

        private void SubjectBTN_Click(object sender, EventArgs e)
        {
            MasterSubject mj = new MasterSubject();
            mj.Show();
            this. Hide();
        }

        private void NamaLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
