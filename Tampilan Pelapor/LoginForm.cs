using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// #fitur-namespace
namespace Tampilan_Pelapor
{
    public partial class LoginForm : Form
    {

        // #fitur-array
        // Konsep 10: Array untuk menyimpan username dan password (sebagai database lokal sederhana)
        // Format: {username, password}
        string[,] userArray = {
            { "admin", "123" },
            { "bintang", "p@ssword" },
            { "pelapor1", "rahasia" }
        };

        // #fitur-collection
        // Konsep 11: Collection (List) untuk mencatat riwayat login (Log)
        List<string> loginHistory = new List<string>();

        int loginAttempts = 0;


        // #fitur-parameter
        // Konsep 23 & 18: Parameter (menerima inputUser dan inputPass)
        private bool CekKredensial(string inputUser, string inputPass)
        {
            // #fitur-foreach-loop
            foreach (var i in Enumerable.Range(0, userArray.GetLength(0)))
            {
                string usernameDiArray = userArray[i, 0];
                string passwordDiArray = userArray[i, 1];
                // #fitur-if
                // Konsep 12, If statement untuk pengecekan username & password
                if (inputUser == usernameDiArray && inputPass == passwordDiArray)
                {
                    return true; // Login cocok
                }
            }
            return false; // Tidak ditemukan yang cocok
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        // #fitur-if
        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        // #fitur-do-loop-string-methods-date-time
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;

            // --- Konsep 17: Do Loop (Validasi input tidak boleh kosong) ---
            do
            {
                // Konsep 6: String Methods, memanipulasi string input user dan passwowrd.

                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Input tidak boleh kosong!");
                    return;
                }
            } while (false);

            // --- Pemanggilan Fungsi dengan Parameter (Konsep 23) ---
            if (CekKredensial(user, pass))
            {
                // Konsep 6: Penggunaan date & time
                loginHistory.Add($"Sukses: {user} pada {DateTime.Now}");

                MessageBox.Show("Login Berhasil!", "Sukses");
                Form1 frmUtama = new Form1();
                frmUtama.Show();
                this.Hide();
            }
            else
            {
                loginAttempts++;
                loginHistory.Add($"Gagal: {user} pada {DateTime.Now}");

                // --- Konsep 16: While Loop (Contoh simulasi jika salah 3 kali) ---
                int i = 0;
                // #fitur-while-loop
                while (i < 1)
                {
                    MessageBox.Show($"Login Gagal! Percobaan ke-{loginAttempts}", "Gagal");
                    i++;
                }

                textBoxPassword.Clear();
                textBoxUsername.Focus();
            }
        }

        private void buttonBantuan_Click(object sender, EventArgs e)
        {
            FormBantuan frmAduan = new FormBantuan();
            frmAduan.Show();
            this.Hide();
        }

        private void buttonPengaduan_Click(object sender, EventArgs e)
        {
            Form1 frmAduan = new Form1();
            frmAduan.Show();
            this.Hide();
        }

        private void buttonTentang_Click(object sender, EventArgs e)
        {
            AboutBox1 frmAduan = new AboutBox1();
            frmAduan.Show();
        }
    }
}
