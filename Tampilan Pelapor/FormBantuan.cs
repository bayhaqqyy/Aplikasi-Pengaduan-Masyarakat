using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tampilan_Pelapor
{
    public partial class FormBantuan : Form
    {
        public FormBantuan()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void FormBantuan_Load(object sender, EventArgs e)
        {
            listViewPertanyaan.Items.Clear();

            // Menambahkan 6 Pertanyaan ke ListView
            AddFaqItem("1", "Bagaimana cara membuat pengaduan baru?");
            AddFaqItem("2", "Apa saja syarat untuk melapor?");
            AddFaqItem("3", "Berapa lama laporan akan diproses?");
            AddFaqItem("4", "Apakah identitas saya akan dirahasiakan?");
            AddFaqItem("5", "Bagaimana cara mengecek status laporan?");
            AddFaqItem("6", "Mengapa laporan saya ditolak?");
        }
        private void AddFaqItem(string no, string pertanyaan)
        {
            ListViewItem item = new ListViewItem(no);
            item.SubItems.Add(pertanyaan);
            listViewPertanyaan.Items.Add(item);
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPertanyaan.SelectedItems.Count > 0)
            {
                // Mengambil teks dari kolom kedua (Index 1)
                string pertanyaan = listViewPertanyaan.SelectedItems[0].SubItems[1].Text;

                // Logika Jawaban menggunakan Switch agar lebih rapi dari If-Else
                switch (pertanyaan)
                {
                    case "Bagaimana cara membuat pengaduan baru?":
                        richTextBoxJawaban.Text = "Pilih menu 'Buat Pengaduan' di Dashboard, isi formulir dengan lengkap, lampirkan bukti foto jika ada, lalu klik 'Kirim'.";
                        break;

                    case "Apa saja syarat untuk melapor?":
                        richTextBoxJawaban.Text = "Anda harus memiliki akun, memberikan deskripsi kejadian yang jelas (siapa, di mana, kapan), dan menyertakan bukti pendukung yang valid.";
                        break;

                    case "Berapa lama laporan akan diproses?":
                        richTextBoxJawaban.Text = "Tim admin akan memverifikasi laporan dalam waktu 1-3 hari kerja. Anda akan menerima notifikasi jika status berubah.";
                        break;

                    case "Apakah identitas saya akan dirahasiakan?":
                        richTextBoxJawaban.Text = "Ya. Kami menjamin kerahasiaan identitas pelapor. Data Anda hanya dapat diakses oleh petugas yang berwenang.";
                        break;

                    case "Bagaimana cara mengecek status laporan?":
                        richTextBoxJawaban.Text = "Masuk ke menu 'Riwayat Pengaduan'. Di sana akan tertera status apakah laporan sedang 'Diproses', 'Selesai', atau 'Ditolak'.";
                        break;

                    case "Mengapa laporan saya ditolak?":
                        richTextBoxJawaban.Text = "Laporan ditolak jika informasi tidak jelas, mengandung unsur SARA/Hinaan, atau bukti yang diberikan tidak mendukung fakta kejadian.";
                        break;

                    default:
                        richTextBoxJawaban.Text = "Silakan pilih pertanyaan untuk melihat detail jawaban.";
                        break;
                }
            }
            else
            {
                // Kosongkan jika tidak ada yang dipilih
                richTextBoxJawaban.Clear();
            }
        }
    }
}
