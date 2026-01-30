using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tampilan_Pelapor
{
    public partial class Form1 : Form
    {
        private int totalAduan = 0;

        public const string HELPDESK_PHONE_NUMBER = "+628123456789";
        Gender selectedGender;

        public enum Gender
        {
            male,
            female
        }

        public string GetGenderString(Gender gender)
        {
            switch (gender)
            {
                case Gender.male:
                    return "Laki-laki";

                case Gender.female:
                    return "Perempuan";

                default:
                    return "Tidak Diketahui";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textNama.Clear();
            textNik.Clear();
            comboKategori.SelectedIndex = -1;
            textLokasi.Clear();
            textJudul.Clear();
            rtbDeskripsi.Clear();
            pictureBoxFoto.Image = null;

        }

        private void listDaftar_SelectedIndexChanged(object sender, EventArgs e)
        {
            RichTextBox rtbDetailPengaduan = this.rtbDetail;

            if (listDaftar.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listDaftar.SelectedItems[0];

                string no = selectedItem.Text;
                string tanggal = selectedItem.SubItems.Count > 1 ? selectedItem.SubItems[1].Text : "N/A";
                string kategori = selectedItem.SubItems.Count > 2 ? selectedItem.SubItems[2].Text : "N/A";
                string judul = selectedItem.SubItems.Count > 3 ? selectedItem.SubItems[3].Text : "N/A";
                string nik = selectedItem.SubItems.Count > 4 ? selectedItem.SubItems[4].Text : "N/A";
                string nama = selectedItem.SubItems.Count > 5 ? selectedItem.SubItems[5].Text : "N/A";
                string lokasi = selectedItem.SubItems.Count > 6 ? selectedItem.SubItems[6].Text : "N/A";
                string deskripsi = selectedItem.SubItems.Count > 7 ? selectedItem.SubItems[7].Text : "N/A";

                string genderString = GetGenderString(selectedGender);

                string detailText = $"--- DETAIL PENGADUAN ---\n" +
                                    $"No. Pengaduan: {no}\n" +
                                    $"Tanggal: {tanggal}\n" +
                                    $"Nama Pengadu: {nama}\n" +
                                    $"NIK: {nik}\n" +
                                    $"Gender: {genderString}\n" +
                                    $"Kategori: {kategori}\n" +
                                    $"Judul: {judul}\n" +
                                    $"Deskripsi: {deskripsi}\n" +
                                    $"------------------------\n";

                string imagePath = selectedItem.Tag as string;

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        pictureBoxDetailFoto.Image = Image.FromFile(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal memuat gambar: {ex.Message}");
                        pictureBoxDetailFoto.Image = null;
                    }
                }
                else
                {
                    pictureBoxDetailFoto.Image = null;
                }

                rtbDetailPengaduan.Text = detailText;
            }
            else
            {
                rtbDetailPengaduan.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtbDetail.ReadOnly = true;
            totalAduan = listDaftar.Items.Count;
            labelTotalAduan.Text = "Total Aduan: " + totalAduan;
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNama.Text) ||
                string.IsNullOrWhiteSpace(textJudul.Text) ||
                string.IsNullOrWhiteSpace(textNik.Text))
            {
                MessageBox.Show("NIK, Nama, dan Judul wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textNik.Text, "^[0-9]+$"))
            {
                MessageBox.Show("NIK hanya boleh berisi angka (0-9).", "Format Salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (textNik.Text.Length != 16)
            {
                MessageBox.Show("NIK harus berjumlah 16 digit.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maleRadioButton.Checked)
            {
                selectedGender = Gender.male;
            }
            else if (femaleRadioButton.Checked)
            {
                selectedGender = Gender.female;
            }
            else
            {
                MessageBox.Show("Gender harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = listDaftar.Items.Count + 1;

            var item = new ListViewItem(new[] {
                idx.ToString(),
                dateTimePicker1.Value.ToShortDateString(),
                comboKategori.Text,
                textJudul.Text,
                textNik.Text,
                textNama.Text,
                textLokasi.Text,
                rtbDeskripsi.Text,
            });

            if (pictureBoxFoto.Tag != null)
            {
                item.Tag = pictureBoxFoto.Tag.ToString();
            }

            listDaftar.Items.Add(item);
            totalAduan = totalAduan + 1;
            labelTotalAduan.Text = "Total Aduan: " + totalAduan;
            MessageBox.Show("Pengaduan ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonReset.PerformClick();
        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image|*.jpg;*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(dlg.FileName);
                pictureBoxFoto.Tag = dlg.FileName;
            }

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah Anda yakin ingin kembali ke halaman Login?", "Konfirmasi");
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void buatPengaduanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda Saat ini Sedang Berada Di Buat Pengaduan");
        }

        private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void pengaduanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hubungi Helpdesk:\n" +
                HELPDESK_PHONE_NUMBER);
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timerPengaduan_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
    }
}
