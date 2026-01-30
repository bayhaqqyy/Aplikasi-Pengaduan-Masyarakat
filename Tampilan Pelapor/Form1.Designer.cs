namespace Tampilan_Pelapor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            buatPengaduanToolStripMenuItem = new ToolStripMenuItem();
            tentangToolStripMenuItem = new ToolStripMenuItem();
            pengaduanToolStripMenuItem = new ToolStripMenuItem();
            groupForm = new GroupBox();
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            genderLabel = new Label();
            buttonReset = new Button();
            buttonKirim = new Button();
            pictureBoxFoto = new PictureBox();
            buttonFoto = new Button();
            rtbDeskripsi = new RichTextBox();
            textJudul = new TextBox();
            textLokasi = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboKategori = new ComboBox();
            textNik = new TextBox();
            textNama = new TextBox();
            labelDeskripsi = new Label();
            labelJudul = new Label();
            labelLokasi = new Label();
            labelTanggal = new Label();
            labelKategori = new Label();
            labelNik = new Label();
            labelNama = new Label();
            groupDetail = new GroupBox();
            pictureBoxDetailFoto = new PictureBox();
            detailFotoAduanLabel = new Label();
            rtbDetail = new RichTextBox();
            labelTotalAduan = new Label();
            groupDaftar = new GroupBox();
            listDaftar = new ListView();
            columnNO = new ColumnHeader();
            columnTanggal = new ColumnHeader();
            columnKategori = new ColumnHeader();
            columnJudul = new ColumnHeader();
            timerPengaduan = new System.Windows.Forms.Timer(components);
            labelTimer = new Label();
            menuStrip1.SuspendLayout();
            groupForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            groupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetailFoto).BeginInit();
            groupDaftar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, buatPengaduanToolStripMenuItem, tentangToolStripMenuItem, pengaduanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1178, 38);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(109, 34);
            homeToolStripMenuItem.Text = "Beranda";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // buatPengaduanToolStripMenuItem
            // 
            buatPengaduanToolStripMenuItem.Name = "buatPengaduanToolStripMenuItem";
            buatPengaduanToolStripMenuItem.Size = new Size(185, 34);
            buatPengaduanToolStripMenuItem.Text = "Buat Pengaduan";
            buatPengaduanToolStripMenuItem.Click += buatPengaduanToolStripMenuItem_Click;
            // 
            // tentangToolStripMenuItem
            // 
            tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            tentangToolStripMenuItem.Size = new Size(106, 34);
            tentangToolStripMenuItem.Text = "Tentang";
            tentangToolStripMenuItem.Click += tentangToolStripMenuItem_Click;
            // 
            // pengaduanToolStripMenuItem
            // 
            pengaduanToolStripMenuItem.Name = "pengaduanToolStripMenuItem";
            pengaduanToolStripMenuItem.Size = new Size(107, 34);
            pengaduanToolStripMenuItem.Text = "Bantuan";
            pengaduanToolStripMenuItem.Click += pengaduanToolStripMenuItem_Click;
            // 
            // groupForm
            // 
            groupForm.Controls.Add(femaleRadioButton);
            groupForm.Controls.Add(maleRadioButton);
            groupForm.Controls.Add(genderLabel);
            groupForm.Controls.Add(buttonReset);
            groupForm.Controls.Add(buttonKirim);
            groupForm.Controls.Add(pictureBoxFoto);
            groupForm.Controls.Add(buttonFoto);
            groupForm.Controls.Add(rtbDeskripsi);
            groupForm.Controls.Add(textJudul);
            groupForm.Controls.Add(textLokasi);
            groupForm.Controls.Add(dateTimePicker1);
            groupForm.Controls.Add(comboKategori);
            groupForm.Controls.Add(textNik);
            groupForm.Controls.Add(textNama);
            groupForm.Controls.Add(labelDeskripsi);
            groupForm.Controls.Add(labelJudul);
            groupForm.Controls.Add(labelLokasi);
            groupForm.Controls.Add(labelTanggal);
            groupForm.Controls.Add(labelKategori);
            groupForm.Controls.Add(labelNik);
            groupForm.Controls.Add(labelNama);
            groupForm.Font = new Font("Segoe UI", 10F);
            groupForm.Location = new Point(20, 80);
            groupForm.Margin = new Padding(2);
            groupForm.Name = "groupForm";
            groupForm.Padding = new Padding(2);
            groupForm.Size = new Size(508, 714);
            groupForm.TabIndex = 0;
            groupForm.TabStop = false;
            groupForm.Text = "Buat Pengaduan";
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(315, 84);
            femaleRadioButton.Margin = new Padding(4);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(135, 32);
            femaleRadioButton.TabIndex = 22;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Perempuan";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(135, 84);
            maleRadioButton.Margin = new Padding(4);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(109, 32);
            maleRadioButton.TabIndex = 21;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Laki-laki";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(24, 84);
            genderLabel.Margin = new Padding(2, 0, 2, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(76, 28);
            genderLabel.TabIndex = 18;
            genderLabel.Text = "Gender";
            genderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.LightGray;
            buttonReset.Location = new Point(162, 578);
            buttonReset.Margin = new Padding(2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(112, 34);
            buttonReset.TabIndex = 17;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonKirim
            // 
            buttonKirim.BackColor = Color.DodgerBlue;
            buttonKirim.Location = new Point(24, 578);
            buttonKirim.Margin = new Padding(2);
            buttonKirim.Name = "buttonKirim";
            buttonKirim.Size = new Size(112, 34);
            buttonKirim.TabIndex = 16;
            buttonKirim.Text = "Kirim";
            buttonKirim.UseVisualStyleBackColor = false;
            buttonKirim.Click += buttonKirim_Click;
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.BackColor = SystemColors.ButtonHighlight;
            pictureBoxFoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFoto.Location = new Point(315, 492);
            pictureBoxFoto.Margin = new Padding(2);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(160, 114);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto.TabIndex = 15;
            pictureBoxFoto.TabStop = false;
            pictureBoxFoto.Click += pictureBoxFoto_Click;
            // 
            // buttonFoto
            // 
            buttonFoto.BackColor = Color.LightGray;
            buttonFoto.Location = new Point(135, 494);
            buttonFoto.Margin = new Padding(2);
            buttonFoto.Name = "buttonFoto";
            buttonFoto.Size = new Size(166, 34);
            buttonFoto.TabIndex = 14;
            buttonFoto.Text = "Lampirkan Foto";
            buttonFoto.UseVisualStyleBackColor = false;
            buttonFoto.Click += buttonFoto_Click;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(135, 384);
            rtbDeskripsi.Margin = new Padding(2);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(340, 84);
            rtbDeskripsi.TabIndex = 13;
            rtbDeskripsi.Text = "";
            // 
            // textJudul
            // 
            textJudul.Location = new Point(136, 332);
            textJudul.Margin = new Padding(2);
            textJudul.Name = "textJudul";
            textJudul.Size = new Size(339, 34);
            textJudul.TabIndex = 12;
            // 
            // textLokasi
            // 
            textLokasi.Location = new Point(136, 282);
            textLokasi.Margin = new Padding(2);
            textLokasi.Name = "textLokasi";
            textLokasi.Size = new Size(339, 34);
            textLokasi.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(136, 230);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(339, 34);
            dateTimePicker1.TabIndex = 10;
            // 
            // comboKategori
            // 
            comboKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            comboKategori.FormattingEnabled = true;
            comboKategori.Items.AddRange(new object[] { "Kebersihan", "Ketertiban dan Keamanan", "Infrastruktur dan Fasilitas Umum", "Layanan Publik", "Lainnya" });
            comboKategori.Location = new Point(136, 176);
            comboKategori.Margin = new Padding(2);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(339, 36);
            comboKategori.TabIndex = 9;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // textNik
            // 
            textNik.Location = new Point(136, 124);
            textNik.Margin = new Padding(2);
            textNik.Name = "textNik";
            textNik.Size = new Size(339, 34);
            textNik.TabIndex = 8;
            // 
            // textNama
            // 
            textNama.Location = new Point(136, 32);
            textNama.Margin = new Padding(2);
            textNama.Name = "textNama";
            textNama.Size = new Size(339, 34);
            textNama.TabIndex = 7;
            // 
            // labelDeskripsi
            // 
            labelDeskripsi.AutoSize = true;
            labelDeskripsi.Location = new Point(24, 384);
            labelDeskripsi.Margin = new Padding(2, 0, 2, 0);
            labelDeskripsi.Name = "labelDeskripsi";
            labelDeskripsi.Size = new Size(91, 28);
            labelDeskripsi.TabIndex = 6;
            labelDeskripsi.Text = "Deskripsi";
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Location = new Point(24, 332);
            labelJudul.Margin = new Padding(2, 0, 2, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(58, 28);
            labelJudul.TabIndex = 5;
            labelJudul.Text = "Judul";
            // 
            // labelLokasi
            // 
            labelLokasi.AutoSize = true;
            labelLokasi.Location = new Point(24, 282);
            labelLokasi.Margin = new Padding(2, 0, 2, 0);
            labelLokasi.Name = "labelLokasi";
            labelLokasi.Size = new Size(66, 28);
            labelLokasi.TabIndex = 4;
            labelLokasi.Text = "Lokasi";
            // 
            // labelTanggal
            // 
            labelTanggal.AutoSize = true;
            labelTanggal.Location = new Point(24, 230);
            labelTanggal.Margin = new Padding(2, 0, 2, 0);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new Size(80, 28);
            labelTanggal.TabIndex = 3;
            labelTanggal.Text = "Tanggal";
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Location = new Point(24, 176);
            labelKategori.Margin = new Padding(2, 0, 2, 0);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(87, 28);
            labelKategori.TabIndex = 2;
            labelKategori.Text = "Kategori";
            // 
            // labelNik
            // 
            labelNik.AutoSize = true;
            labelNik.Location = new Point(24, 124);
            labelNik.Margin = new Padding(2, 0, 2, 0);
            labelNik.Name = "labelNik";
            labelNik.Size = new Size(44, 28);
            labelNik.TabIndex = 1;
            labelNik.Text = "NIK";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(24, 39);
            labelNama.Margin = new Padding(2, 0, 2, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(64, 28);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama";
            labelNama.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupDetail
            // 
            groupDetail.Controls.Add(pictureBoxDetailFoto);
            groupDetail.Controls.Add(detailFotoAduanLabel);
            groupDetail.Controls.Add(rtbDetail);
            groupDetail.Location = new Point(541, 392);
            groupDetail.Margin = new Padding(2);
            groupDetail.Name = "groupDetail";
            groupDetail.Padding = new Padding(2);
            groupDetail.Size = new Size(625, 401);
            groupDetail.TabIndex = 13;
            groupDetail.TabStop = false;
            groupDetail.Text = "Detail Pengaduan";
            // 
            // pictureBoxDetailFoto
            // 
            pictureBoxDetailFoto.BackColor = SystemColors.ButtonHighlight;
            pictureBoxDetailFoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxDetailFoto.Location = new Point(122, 271);
            pictureBoxDetailFoto.Margin = new Padding(2);
            pictureBoxDetailFoto.Name = "pictureBoxDetailFoto";
            pictureBoxDetailFoto.Size = new Size(160, 114);
            pictureBoxDetailFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDetailFoto.TabIndex = 18;
            pictureBoxDetailFoto.TabStop = false;
            // 
            // detailFotoAduanLabel
            // 
            detailFotoAduanLabel.AutoSize = true;
            detailFotoAduanLabel.Location = new Point(12, 271);
            detailFotoAduanLabel.Margin = new Padding(2, 0, 2, 0);
            detailFotoAduanLabel.Name = "detailFotoAduanLabel";
            detailFotoAduanLabel.Size = new Size(106, 25);
            detailFotoAduanLabel.TabIndex = 18;
            detailFotoAduanLabel.Text = "Foto Aduan";
            // 
            // rtbDetail
            // 
            rtbDetail.Location = new Point(12, 31);
            rtbDetail.Margin = new Padding(4);
            rtbDetail.Name = "rtbDetail";
            rtbDetail.Size = new Size(596, 234);
            rtbDetail.TabIndex = 0;
            rtbDetail.Text = "";
            // 
            // labelTotalAduan
            // 
            labelTotalAduan.AutoSize = true;
            labelTotalAduan.Location = new Point(12, 270);
            labelTotalAduan.Margin = new Padding(4, 0, 4, 0);
            labelTotalAduan.Name = "labelTotalAduan";
            labelTotalAduan.Size = new Size(125, 25);
            labelTotalAduan.TabIndex = 15;
            labelTotalAduan.Text = "Total Aduan: 0";
            // 
            // groupDaftar
            // 
            groupDaftar.Controls.Add(listDaftar);
            groupDaftar.Controls.Add(labelTotalAduan);
            groupDaftar.Location = new Point(541, 80);
            groupDaftar.Margin = new Padding(2);
            groupDaftar.Name = "groupDaftar";
            groupDaftar.Padding = new Padding(2);
            groupDaftar.Size = new Size(625, 309);
            groupDaftar.TabIndex = 14;
            groupDaftar.TabStop = false;
            groupDaftar.Text = "Daftar Pengaduan";
            // 
            // listDaftar
            // 
            listDaftar.Columns.AddRange(new ColumnHeader[] { columnNO, columnTanggal, columnKategori, columnJudul });
            listDaftar.Location = new Point(12, 32);
            listDaftar.Margin = new Padding(2);
            listDaftar.Name = "listDaftar";
            listDaftar.Size = new Size(596, 218);
            listDaftar.TabIndex = 0;
            listDaftar.UseCompatibleStateImageBehavior = false;
            listDaftar.View = View.Details;
            listDaftar.SelectedIndexChanged += listDaftar_SelectedIndexChanged;
            // 
            // columnNO
            // 
            columnNO.Text = "NO";
            columnNO.Width = 50;
            // 
            // columnTanggal
            // 
            columnTanggal.Text = "Tanggal";
            columnTanggal.TextAlign = HorizontalAlignment.Center;
            columnTanggal.Width = 180;
            // 
            // columnKategori
            // 
            columnKategori.Text = "Kategori";
            columnKategori.TextAlign = HorizontalAlignment.Center;
            columnKategori.Width = 180;
            // 
            // columnJudul
            // 
            columnJudul.Text = "Judul";
            columnJudul.TextAlign = HorizontalAlignment.Center;
            columnJudul.Width = 180;
            // 
            // timerPengaduan
            // 
            timerPengaduan.Enabled = true;
            timerPengaduan.Interval = 1000;
            timerPengaduan.Tick += timerPengaduan_Tick;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimer.Location = new Point(819, 50);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(22, 30);
            labelTimer.TabIndex = 15;
            labelTimer.Text = "-";
            // 
            // Form1
            // 
            AcceptButton = buttonKirim;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1178, 808);
            Controls.Add(labelTimer);
            Controls.Add(groupDaftar);
            Controls.Add(groupDetail);
            Controls.Add(groupForm);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APLIKASI PENGADUAN MASYARAKAT";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupForm.ResumeLayout(false);
            groupForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            groupDetail.ResumeLayout(false);
            groupDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetailFoto).EndInit();
            groupDaftar.ResumeLayout(false);
            groupDaftar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem buatPengaduanToolStripMenuItem;
        private ToolStripMenuItem tentangToolStripMenuItem;
        private ToolStripMenuItem pengaduanToolStripMenuItem;
        private GroupBox groupForm;
        private Label labelNama;
        private Label labelNik;
        private Label labelDeskripsi;
        private Label labelJudul;
        private Label labelLokasi;
        private Label labelTanggal;
        private Label labelKategori;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboKategori;
        private TextBox textNik;
        private TextBox textNama;
        private RichTextBox rtbDeskripsi;
        private TextBox textJudul;
        private TextBox textLokasi;
        private PictureBox pictureBoxFoto;
        private Button buttonFoto;
        private Button buttonReset;
        private Button buttonKirim;
        private GroupBox groupDetail;
        private GroupBox groupDaftar;
        private ListView listDaftar;
        private ColumnHeader columnNO;
        private ColumnHeader columnTanggal;
        private ColumnHeader columnKategori;
        private ColumnHeader columnJudul;
        private RichTextBox rtbDetail;
        private Label detailFotoAduanLabel;
        private PictureBox pictureBoxDetailFoto;
        private Label labelTotalAduan;
        private Label genderLabel;
        private RadioButton femaleRadioButton;
        private RadioButton maleRadioButton;
        private System.Windows.Forms.Timer timerPengaduan;
        private Label labelTimer;
    }
}
