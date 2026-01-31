using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// #fitur-namespace
namespace Tampilan_Pelapor
{
    public partial class Form1 : Form
    {
        // #fitur-variables
        private int totalAduan = 0;
        private readonly string reportDirectory;
        private string[] cachedReportLines = Array.Empty<string>();

        public const string HELPDESK_PHONE_NUMBER = "+628123456789";
        Gender selectedGender;

        // #fitur-enum
        public enum Gender
        {
            male,
            female
        }

        // #fitur-function-method
        public string GetGenderString(Gender gender)
        {
            // Konsep 12 Select Case Statement: mendapatkan gender
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
        // #fitur-constructor
        public Form1()
        {
            InitializeComponent();
            reportDirectory = Path.Combine(Application.StartupPath, "Laporan");
        }

        // Konsep 19: Method (Sub). Tidak ada "return", hanya menjalankan tugas.
        // #fitur-method
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textNama.Clear();
            textNik.Clear();
            comboKategori.SelectedIndex = -1;
            textLokasi.Clear();
            textJudul.Clear();
            rtbDeskripsi.Clear();
            pictureBoxFoto.Image = null;
            pictureBoxFoto.Tag = null;

        }

        // #fitur-if-string-file-exception
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

        // #fitur-method
        private void Form1_Load(object sender, EventArgs e)
        {
            rtbDetail.ReadOnly = true;
            totalAduan = listDaftar.Items.Count;
            labelTotalAduan.Text = "Total Aduan: " + totalAduan;
        }

        // #fitur-if-string-date-parameter
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

            // #fitur-passing-arrays
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

        // #fitur-file
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

        // #fitur-date-time
        private void timerPengaduan_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        // #fitur-file-directory-dates-times
        private void simpanLaporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryBuildReportPath(out string reportPath))
                {
                    MessageBox.Show("Folder laporan tidak tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string reportText = BuildReportText();
                File.WriteAllText(reportPath, reportText);

                DateTime created = File.GetCreationTime(reportPath);
                DateTime modified = File.GetLastWriteTime(reportPath);
                int fileCount = Directory.GetFiles(reportDirectory, "*.txt").Length;

                MessageBox.Show(
                    "Laporan tersimpan.\n" +
                    $"Lokasi: {reportPath}\n" +
                    $"Dibuat: {created}\n" +
                    $"Diubah: {modified}\n" +
                    $"Jumlah file laporan: {fileCount}",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan laporan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // #fitur-directory
        private void bukaFolderLaporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(reportDirectory);
                Process.Start("explorer.exe", reportDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal membuka folder laporan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // #fitur-printing-report
        private void cetakLaporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cachedReportLines = BuildReportLines();
            if (cachedReportLines.Length == 0)
            {
                MessageBox.Show("Belum ada data untuk dicetak.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using PrintDocument doc = new PrintDocument();
            doc.DocumentName = "Laporan Pengaduan";
            doc.PrintPage += ReportPrintDocument_PrintPage;

            using PrintDialog printDialog = new PrintDialog();
            printDialog.Document = doc;
            printDialog.UseEXDialog = true;

            if (printDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;
            preview.Width = 900;
            preview.Height = 700;
            preview.ShowDialog();
        }

        // #fitur-debug-watch
        private void infoDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string status = Debugger.IsAttached ? "Debugger terpasang" : "Debugger tidak terpasang";
            string summary = $"Status debug: {status}\nTotal aduan: {totalAduan}\nLast report path: {GetLastReportPath()}";

            Debug.WriteLine($"[WATCH] totalAduan = {totalAduan}");
            Debug.WriteLine($"[WATCH] listDaftar.Count = {listDaftar.Items.Count}");

            MessageBox.Show(summary, "Info Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // #fitur-printing-alignment-calc-text
        private void ReportPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (cachedReportLines.Length == 0)
            {
                e.HasMorePages = false;
                return;
            }

            using Font titleFont = new Font("Consolas", 13, FontStyle.Bold);
            using Font bodyFont = new Font("Consolas", 10);

            float y = e.MarginBounds.Top;
            for (int i = 0; i < cachedReportLines.Length; i++)
            {
                string line = cachedReportLines[i];
                Font font = i == 0 ? titleFont : bodyFont;
                StringAlignment alignment = StringAlignment.Near;

                if (i == 0)
                {
                    alignment = StringAlignment.Center;
                }
                else if (line.StartsWith("Total Aduan:", StringComparison.OrdinalIgnoreCase))
                {
                    alignment = StringAlignment.Far;
                }

                using StringFormat format = new StringFormat { Alignment = alignment, LineAlignment = StringAlignment.Near };
                SizeF size = e.Graphics.MeasureString(line, font, e.MarginBounds.Width);
                RectangleF rect = new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width, size.Height);
                e.Graphics.DrawString(line, font, Brushes.Black, rect, format);
                y += size.Height + 2;

                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = false;
                    break;
                }
            }
        }

        // #fitur-string-methods
        private string BuildReportText()
        {
            string[] lines = BuildReportLines();
            return string.Join(Environment.NewLine, lines);
        }

        // #fitur-timespan-for-loop-array-collection
        private string[] BuildReportLines()
        {
            if (listDaftar.Items.Count == 0)
            {
                return Array.Empty<string>();
            }

            if (listDaftar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pilih satu data di daftar pengaduan terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return Array.Empty<string>();
            }

            ListViewItem selectedItem = listDaftar.SelectedItems[0];

            List<string> lines = new List<string>();
            lines.Add("LAPORAN PENGADUAN MASYARAKAT");
            lines.Add(new string('-', 44));

            string judul = selectedItem.SubItems.Count > 3 ? selectedItem.SubItems[3].Text : string.Empty;
            NormalizeTitle(ref judul);

            string deskripsi = selectedItem.SubItems.Count > 7 ? selectedItem.SubItems[7].Text : string.Empty;
            deskripsi = deskripsi.Trim();
            int deskripsiLength = deskripsi.Length;

            DateTime laporanDate;
            string tanggalText = selectedItem.SubItems.Count > 1 ? selectedItem.SubItems[1].Text : string.Empty;
            if (!DateTime.TryParse(tanggalText, out laporanDate))
            {
                laporanDate = DateTime.Now.Date;
            }
            TimeSpan usiaLaporan = DateTime.Now - laporanDate;

            lines.Add($"Judul        : {judul}");
            lines.Add($"Nama         : {(selectedItem.SubItems.Count > 5 ? selectedItem.SubItems[5].Text : string.Empty)}");
            lines.Add($"NIK          : {(selectedItem.SubItems.Count > 4 ? selectedItem.SubItems[4].Text : string.Empty)}");
            lines.Add($"Kategori     : {(selectedItem.SubItems.Count > 2 ? selectedItem.SubItems[2].Text : string.Empty)}");
            lines.Add($"Tanggal      : {laporanDate:dd MMMM yyyy}");
            lines.Add($"Usia Laporan : {usiaLaporan.Days} hari {usiaLaporan.Hours} jam");
            lines.Add($"Panjang Judul: {judul.Length} karakter");
            lines.Add($"Panjang Desc : {deskripsiLength} karakter");
            lines.Add($"Total Aduan: {listDaftar.Items.Count}");

            lines.Add(string.Empty);
            lines.Add("Ringkas Daftar (No | Tanggal | Kategori | Judul)");
            lines.Add(new string('-', 60));

            for (int i = 0; i < listDaftar.Items.Count; i++)
            {
                ListViewItem item = listDaftar.Items[i];
                string row = CreateFixedWidthRow(new[]
                {
                    (i + 1).ToString(),
                    item.SubItems[1].Text,
                    item.SubItems[2].Text,
                    item.SubItems[3].Text
                }, new[] { 3, 12, 20, 30 });
                lines.Add(row);
            }

            lines.Add(string.Empty);
            lines.Add("Detail Lampiran Foto:");
            lines.Add(new string('-', 30));
            lines.AddRange(GetFotoFileInfoLines());

            return lines.ToArray();
        }

        // #fitur-passing-arrays
        private string CreateFixedWidthRow(string[] columns, int[] widths)
        {
            int columnCount = Math.Min(columns.Length, widths.Length);
            List<string> parts = new List<string>();
            for (int i = 0; i < columnCount; i++)
            {
                string value = columns[i] ?? string.Empty;
                parts.Add(value.PadRight(widths[i]));
            }
            return string.Join(" | ", parts);
        }

        // #fitur-byref
        private void NormalizeTitle(ref string title)
        {
            if (title == null)
            {
                title = "(Tanpa Judul)";
                return;
            }

            title = title.Trim();
            if (title.Length == 0)
            {
                title = "(Tanpa Judul)";
            }
        }

        // #fitur-byref-out
        private bool TryBuildReportPath(out string reportPath)
        {
            reportPath = string.Empty;
            try
            {
                Directory.CreateDirectory(reportDirectory);
                string fileName = $"Laporan_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                reportPath = Path.Combine(reportDirectory, fileName);
                return true;
            }
            catch
            {
                reportPath = string.Empty;
                return false;
            }
        }

        // #fitur-directory-file
        private string GetLastReportPath()
        {
            try
            {
                if (!Directory.Exists(reportDirectory))
                {
                    return "-";
                }

                string last = Directory.GetFiles(reportDirectory, "*.txt")
                    .OrderByDescending(File.GetLastWriteTime)
                    .FirstOrDefault();

                return string.IsNullOrWhiteSpace(last) ? "-" : last;
            }
            catch
            {
                return "-";
            }
        }

        // #fitur-fileinfo
        private string[] GetFotoFileInfoLines()
        {
            string imagePath = pictureBoxFoto.Tag as string;
            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
            {
                return new[] { "Tidak ada lampiran foto." };
            }

            FileInfo info = new FileInfo(imagePath);
            return new[]
            {
                $"Nama File   : {info.Name}",
                $"Ukuran      : {info.Length} bytes",
                $"Dibuat      : {info.CreationTime}",
                $"Diubah      : {info.LastWriteTime}"
            };
        }
    }
}
