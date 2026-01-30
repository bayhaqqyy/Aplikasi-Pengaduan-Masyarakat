using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tampilan_Pelapor
{
    public partial class LoginForm : Form
    {
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxUsername.Text == "")
            {
                MessageBox.Show("Username atau Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "123")
            {
                MessageBox.Show("Login Berhasil! Selamat datang.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Membuka form utama dan menutup form login
                Form1 frmUtama = new Form1();
                frmUtama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
