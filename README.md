# PROYEK TUGAS AKHIR: APLIKASI E-GOVERNMENT

**Mata Kuliah:** Pemrograman Visual
**Semester:** 1
**Anggota Kelompok:**

| Nama                  | NIM          |
| :-------------------- | :----------- |
| RAFLI ABDUL BAY HAQQY | 250401010113 |
| BINTANG TRIADMAJA     | 250401010075 |
| NEVADA PRIDHO         | 250401010223 |
| RENI YUNIARTI PUTRI   | 250401070202 |
| PRIMUANDY LEOKOY      | 250401010209 |

---

## SOAL UJIAN & PEMENUHAN

Tugas ini bertujuan untuk membangun sebuah aplikasi yang memenuhi persyaratan fungsional dan teknis yang ditetapkan dalam soal ujian, dengan studi kasus terfokus pada layanan publik berbasis digital (E-Government).

### 1. Pembuatan Aplikasi dengan Visual Studio

| Konsep                             | Implementasi dalam Proyek |
| :--------------------------------- | :------------------------ |
| Watch Window (simulasi)            | Tampilan Daftar Pengaduan + Detail Pengaduan (ListView + RichTextBox) |
| Breakpoints (simulasi)             | Menu Debug → Simulasi Breakpoint (Debugger.Break) |
| Handling Exceptions / Error        | try/catch + MessageBox error |
| String & String Methods            | IsNullOrWhiteSpace, Trim, PadRight, ToString |
| Date, Time, TimeSpan               | DateTime.Now, DateTimePicker, TimeSpan |
| Array & Collection                 | string[,] userArray, List<string> loginHistory |
| If Statements                      | Validasi input dan logika gender |
| Select Case Statements             | switch pada gender dan FAQ |
| For-Loop / For Each / While / Do   | for (ringkas daftar), foreach (cek kredensial), while, do-while |
| Function & Methods                 | Method pada Form1/LoginForm/FormBantuan |
| ByVal (default)                    | Parameter biasa pada method |
| ByRef (ref/out)                    | NormalizeTitle(ref), TryBuildReportPath(out) |
| Passing Arrays                     | CreateFixedWidthRow(string[] columns, int[] widths) |
| Parameter                          | CekKredensial, AddFaqItem, dsb. |
| Files                              | Simpan laporan ke file .txt |
| File Dates and Times               | File.GetCreationTime / GetLastWriteTime |
| Direktori                          | Directory.CreateDirectory, Directory.GetFiles |
| Namespace                          | namespace Tampilan_Pelapor |
| Control Printing / Report Printing | PrintDocument + PrintDialog + PrintPreviewDialog |
| Alignment Printed Text             | StringFormat Alignment + MeasureString |
| Calculate Text                     | MeasureString untuk tinggi teks |

---

### 2. Studi Kasus: E-Government

#### Tema: Aplikasi Pengaduan Masyarakat

**Deskripsi Proyek:**
Aplikasi desktop berbasis WinForms untuk layanan publik yang memungkinkan warga membuat pengaduan, melampirkan bukti foto, melihat daftar pengaduan, serta membaca detail laporan. Aplikasi juga menyediakan menu bantuan/FAQ dan fitur laporan (simpan ke file dan cetak). Untuk kebutuhan pembelajaran debugging, tampilan Daftar/Detail berperan sebagai watch window dan tersedia simulasi breakpoint melalui menu Debug.
