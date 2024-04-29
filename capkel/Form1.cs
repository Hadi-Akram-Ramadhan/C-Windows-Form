using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace capkel
{
    public partial class Form1 : Form
    {
        public static string LoggedInUsername = "";
        private string connectionString = "Data Source=Hadi-PC\\SQLEXPRESS;Initial Catalog=SMKScore;Integrated Security=True";
        // Ganti Your_Connection_String dengan connection string database Anda

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmailTXB.Text = ""; // Kosongkan textbox Email saat form dimuat
            PassTXB.Text = ""; // Kosongkan textbox Password saat form dimuat

            // Tambahkan event handler untuk button LoginBTN
            LoginBTN.Click += LoginBTN_Click;
        }
        
        public void nama()
        {

        }


        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string email = EmailTXB.Text;
            string password = PassTXB.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email dan password harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM Teacher WHERE Email = @Email AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string roleString = reader["Role"].ToString(); // Ambil nilai Role dari database sebagai string
                    string name = reader["TeacherName"].ToString();

                    char roleChar;

                    if (!string.IsNullOrEmpty(roleString) && roleString.Length > 0)
                    {
                        roleChar = Convert.ToChar(roleString[0]); // Ambil karakter pertama dari string Role
                    }
                    else
                    {
                        // Atur default jika nilai Role kosong atau tidak valid
                        roleChar = ' ';
                    }

                    if (roleChar == 'A')
                    {
                        MessageBox.Show("Selamat datang Admin!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Lakukan aksi yang sesuai untuk role Admin
                        LoggedInUsername = name;
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Selamat datang Guru!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Lakukan aksi yang sesuai untuk role Guru
                        LoggedInUsername = name;
                        Form3 f3 = new Form3();
                        f3.Show();
                        this.Hide();
                    }
                }


                connection.Close();
            }
        }
    }
}
