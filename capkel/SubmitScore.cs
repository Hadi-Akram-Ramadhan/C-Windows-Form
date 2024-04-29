using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capkel
{
    public partial class SubmitScore : Form
    {
        string connectionString = "Data Source=HADI-PC\\SQLEXPRESS;Initial Catalog=SMKScore;Integrated Security=True;Encrypt=False";
        public SubmitScore()
        {
            InitializeComponent();
            TampilkanData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TampilkanData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT StudentID, StudentName, StudentClass FROM Student"; // Ubah sesuai dengan kolom yang ingin ditampilkan

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Aktifkan notifikasi perubahan data
                        SqlDependency dependency = new SqlDependency(command);
                        dependency.OnChange += Dependency_OnChange;

                        // Tambahkan kolom Action
                        DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                        btnColumn.HeaderText = "Action";
                        btnColumn.Text = "Input Score";
                        btnColumn.Name = "btnColumn"; // Beri nama kolom Action
                        btnColumn.UseColumnTextForButtonValue = true;

                        // Tambah kolom Action ke indeks tertentu (misalnya, indeks 0 untuk di sebelah kiri)
                        dataScore.Columns.Insert(0, btnColumn);

                        dataScore.CellContentClick += DataScore_CellContentClick;

                        dataScore.DataSource = dataTable;
                    }

                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DataScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan tombol yang diklik adalah tombol pada kolom "Action"
            if (e.ColumnIndex == dataScore.Columns["btnColumn"].Index && e.RowIndex >= 0)
            {
                // Ambil nilai ID dari baris yang diklik
                int StudentID = Convert.ToInt32(dataScore.Rows[e.RowIndex].Cells["StudentID"].Value);

                // Buat instance form baru
                PopUpcScore pop = new PopUpcScore();
                pop.ShowDialog();
            }
        }



        private void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                // Jika ada perubahan, panggil kembali metode TampilkanData untuk mengambil data terbaru
                TampilkanData();
            }
        }

        private void SubmitScore_Load(object sender, EventArgs e)
        {
            NameTXB.Text = Form1.LoggedInUsername;
        }
    }
}
