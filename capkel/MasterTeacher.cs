using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace capkel
{
    public partial class MasterTeacher : Form
    {
        string connectionString = "Data Source=Hadi-PC\\SQLEXPRESS;Initial Catalog=SMKScore;Integrated Security=True";

        public MasterTeacher()
        {
            InitializeComponent();
            TampilkanData();
        }

        private void TampilkanData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Teacher";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        
                        adapter.Fill(dataTable);

                        // Aktifkan notifikasi perubahan data
                        SqlDependency dependency = new SqlDependency(command);
                        dependency.OnChange += Dependency_OnChange;

                        dataTeacher.DataSource = dataTable;
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


        private void MasterTeacher_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NameTXB.Text) || string.IsNullOrEmpty(PhoneTXB.Text) ||
                    string.IsNullOrEmpty(EmailTXB.Text) || string.IsNullOrEmpty(PassTXB.Text) || RoleCMB.SelectedItem == null)
                {
                    MessageBox.Show("Semua jenis keterangan harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Mengambil ID terakhir dari database
                    SqlCommand getIdCmd = new SqlCommand("SET IDENTITY_INSERT Teacher ON; SELECT MAX(TeacherID) FROM Teacher", con);
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
                    SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Teacher ON; INSERT INTO Teacher (TeacherID, TeacherName, BirthDate, Gender, PhoneNumber, Email, Password, Role) VALUES (@TeacherID, @TeacherName, @BirthDate, @Gender, @PhoneNumber, @Email, @Password, @Role)", con);
                    cmd.Parameters.AddWithValue("@TeacherID", newId);
                    cmd.Parameters.AddWithValue("@TeacherName", NameTXB.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", BirthDT.Value);
                    cmd.Parameters.AddWithValue("@Gender", MaleRB.Checked ? "M" : "F");
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneTXB.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTXB.Text);
                    cmd.Parameters.AddWithValue("@Password", PassTXB.Text);
                    cmd.Parameters.AddWithValue("@Role", RoleCMB.SelectedItem == null ? "Evaluator" : RoleCMB.SelectedItem.ToString());
                    int i = cmd.ExecuteNonQuery();

                    con.Close();

                    if (i > 0)
                    {
                        // Menampilkan pesan sukses
                        MessageBox.Show("Data berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mereset formulir
                        NameTXB.Text = "";
                        BirthDT.Value = DateTime.Now;
                        MaleRB.Checked = true;
                        PhoneTXB.Text = "";
                        EmailTXB.Text = "";
                        PassTXB.Text = "";
                        RoleCMB.SelectedIndex = -1;

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






        private void MasterTeacher_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMKScoreDataSet.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.sMKScoreDataSet.Teacher);

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IdTXB.Text))
                {
                    MessageBox.Show("Masukkan ID Teacher yang ingin dihapus terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Teacher WHERE TeacherID = @TeacherID", con);
                        cmd.Parameters.AddWithValue("@TeacherID", IdTXB.Text);
                        int i = cmd.ExecuteNonQuery();


                        con.Close();

                        if (i > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear form
                            IdTXB.Text = "";
                            NameTXB.Text = "";
                            BirthDT.Value = DateTime.Now;
                            MaleRB.Checked = true;
                            PhoneTXB.Text = "";
                            EmailTXB.Text = "";
                            PassTXB.Text = "";
                            RoleCMB.SelectedIndex = -1;

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

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IdTXB.Text))
                {
                    MessageBox.Show("Masukkan ID Teacher yang ingin diupdate terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengedit data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Teacher SET TeacherName = @TeacherName, BirthDate = @BirthDate, Gender = @Gender, PhoneNumber = @PhoneNumber, Email = @Email, Password = @Password, Role = @Role WHERE TeacherID = @TeacherID", con);
                        cmd.Parameters.AddWithValue("@TeacherID", IdTXB.Text);
                        cmd.Parameters.AddWithValue("@TeacherName", NameTXB.Text);
                        cmd.Parameters.AddWithValue("@BirthDate", BirthDT.Value);
                        cmd.Parameters.AddWithValue("@Gender", MaleRB.Checked ? "M" : "F");
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneTXB.Text);
                        cmd.Parameters.AddWithValue("@Email", EmailTXB.Text);
                        cmd.Parameters.AddWithValue("@Password", PassTXB.Text);
                        cmd.Parameters.AddWithValue("@Role", RoleCMB.SelectedItem == null ? "Evaluator" : RoleCMB.SelectedItem.ToString());
                        int i = cmd.ExecuteNonQuery();

                        con.Close();

                        if (i > 0)
                        {
                            MessageBox.Show("Data berhasil diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Refresh data grid view or call method to display data
                            TampilkanData();
                            IdTXB.Text = "";
                            NameTXB.Text = "";
                            BirthDT.Value = DateTime.Now;
                            MaleRB.Checked = true;
                            PhoneTXB.Text = "";
                            EmailTXB.Text = "";
                            PassTXB.Text = "";
                            RoleCMB.SelectedIndex = -1;
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

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menyimpan perubahan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Teacher WHERE TeacherName LIKE @searchTerm";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + SearchBar.Text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataTeacher.DataSource = dataTable;

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataTeacher_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
