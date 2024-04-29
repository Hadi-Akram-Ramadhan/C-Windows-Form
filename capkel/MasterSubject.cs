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
    public partial class MasterSubject : Form
    {
        string connectionString = "Data Source=HADI-PC\\SQLEXPRESS;Initial Catalog=SMKScore;Integrated Security=True;Encrypt=False";
        public MasterSubject()
        {
            InitializeComponent();
            TampilkanData();
        }

        private void MasterSubject_Load(object sender, EventArgs e)
        {

        }

        private void TampilkanData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Subject";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Aktifkan notifikasi perubahan data
                        SqlDependency dependency = new SqlDependency(command);
                        dependency.OnChange += Dependency_OnChange;

                        dataStudent.DataSource = dataTable;
                    }

                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NameTXB.Text))
                {
                    MessageBox.Show("Semua jenis keterangan harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Mengambil ID terakhir dari database
                    SqlCommand getIdCmd = new SqlCommand("SET IDENTITY_INSERT Subject ON; SELECT MAX(SubjectID) FROM Subject", con);
                    object maxId = getIdCmd.ExecuteScalar();
                    int newId;

                    if (maxId != DBNull.Value)
                    {
                        newId = Convert.ToInt32(maxId) + 1;
                    }
                    else
                    {
                        newId = 1;
                    }

                    // Menyiapkan query INSERT dengan parameter
                    SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Subject ON; INSERT INTO Subject (SubjectID, SubjectName, MinimumCriteria, isPractice) VALUES (@SubjectID, @SubjectName, @MinimumCriteria, @isPractice)", con);
                    cmd.Parameters.AddWithValue("@SubjectID", newId);
                    cmd.Parameters.AddWithValue("@SubjectName", NameTXB.Text);
                    cmd.Parameters.AddWithValue("@MinimumCriteria", CriteriaNum.Value);
                    cmd.Parameters.AddWithValue("@isPractice", isPracticeCHK.Checked);
                    int i = cmd.ExecuteNonQuery();

                    con.Close();

                    if (i > 0)
                    {
                        // Menampilkan pesan sukses
                        MessageBox.Show("Data berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mereset formulir
                        NameTXB.Text = "";
                        CriteriaNum.Value = 0;
                        isPracticeCHK.Checked = false;
                        

                        TampilkanData();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal ditambahkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Menghandle eksepsi
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IdTXB.Text))
                {
                    MessageBox.Show("Masukkan ID Subject yang ingin diupdate terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengedit data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Subject SET SubjectName = @SubjectName, MinimumCriteria = @MinimumCriteria, isPractice = @isPractice WHERE SubjectID = @SubjectID", con);
                        cmd.Parameters.AddWithValue("@SubjectName", NameTXB.Text);
                        cmd.Parameters.AddWithValue("@SubjectID", IdTXB.Text);
                        cmd.Parameters.AddWithValue("@MinimumCriteria", CriteriaNum.Value);
                        cmd.Parameters.AddWithValue("@isPractice", isPracticeCHK.Checked);
  
                        int i = cmd.ExecuteNonQuery();

                        con.Close();

                        if (i > 0)
                        {
                            MessageBox.Show("Data berhasil diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh data grid view or call method to display data
                            
                            NameTXB.Text = "";
                            CriteriaNum.Value = 0;
                            isPracticeCHK.Checked = false;
                            TampilkanData();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IdTXB.Text))
                {
                    MessageBox.Show("Masukkan ID yang ingin dihapus terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Subject WHERE SubjectID = @SubjectID", con);
                        cmd.Parameters.AddWithValue("@SubjectID", IdTXB.Text);
                        int i = cmd.ExecuteNonQuery();

                        con.Close();

                        if (i > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear form
                            NameTXB.Text = "";
                            CriteriaNum.Value = 0;
                            isPracticeCHK.Checked = false;

                            // Refresh data grid view or call method to display data
                            TampilkanData();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Subject WHERE SubjectName LIKE @searchTerm";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + SearchBar.Text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataStudent.DataSource = dataTable;

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
