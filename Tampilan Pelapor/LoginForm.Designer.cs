namespace Tampilan_Pelapor
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelLogin = new Label();
            groupLogin = new GroupBox();
            buttonLogin = new Button();
            comboKategori = new ComboBox();
            checkBoxPassword = new CheckBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            labelKategori = new Label();
            labelUsername = new Label();
            pictureBox1 = new PictureBox();
            labelUmum = new Label();
            buttonPengaduan = new Button();
            buttonTentang = new Button();
            buttonBantuan = new Button();
            groupLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(117, 353);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(236, 37);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "LOGIN ADMIN";
            labelLogin.Click += label1_Click;
            // 
            // groupLogin
            // 
            groupLogin.Controls.Add(buttonLogin);
            groupLogin.Controls.Add(comboKategori);
            groupLogin.Controls.Add(checkBoxPassword);
            groupLogin.Controls.Add(textBoxPassword);
            groupLogin.Controls.Add(textBoxUsername);
            groupLogin.Controls.Add(labelPassword);
            groupLogin.Controls.Add(labelKategori);
            groupLogin.Controls.Add(labelUsername);
            groupLogin.Location = new Point(12, 393);
            groupLogin.Name = "groupLogin";
            groupLogin.Size = new Size(517, 317);
            groupLogin.TabIndex = 1;
            groupLogin.TabStop = false;
            groupLogin.Enter += groupBox1_Enter;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.Highlight;
            buttonLogin.Font = new Font("Times New Roman", 14F);
            buttonLogin.Location = new Point(142, 242);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(279, 40);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // comboKategori
            // 
            comboKategori.Font = new Font("Times New Roman", 14F);
            comboKategori.FormattingEnabled = true;
            comboKategori.Items.AddRange(new object[] { "Kebersihan", "Ketertiban dan Keamanan", "Infrastruktur dan Fasilitas Umum", "Layanan Publik", "Lainnya" });
            comboKategori.Location = new Point(142, 101);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(279, 41);
            comboKategori.TabIndex = 6;
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.AutoSize = true;
            checkBoxPassword.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxPassword.Location = new Point(437, 176);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(22, 21);
            checkBoxPassword.TabIndex = 5;
            checkBoxPassword.UseVisualStyleBackColor = true;
            checkBoxPassword.CheckedChanged += checkBoxPassword_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Times New Roman", 14F);
            textBoxPassword.Location = new Point(142, 166);
            textBoxPassword.MaxLength = 20;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Masukkan Password";
            textBoxPassword.Size = new Size(279, 40);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Times New Roman", 14F);
            textBoxUsername.Location = new Point(142, 44);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username Admin";
            textBoxUsername.Size = new Size(279, 40);
            textBoxUsername.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Times New Roman", 14F);
            labelPassword.Location = new Point(17, 169);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(121, 33);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Font = new Font("Times New Roman", 14F);
            labelKategori.Location = new Point(17, 105);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(110, 33);
            labelKategori.TabIndex = 1;
            labelKategori.Text = "Kategori";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Times New Roman", 14F);
            labelUsername.Location = new Point(17, 47);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(124, 33);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            labelUsername.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gambarfixs;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1090, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelUmum
            // 
            labelUmum.AutoSize = true;
            labelUmum.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUmum.Location = new Point(746, 357);
            labelUmum.Name = "labelUmum";
            labelUmum.Size = new Size(216, 37);
            labelUmum.TabIndex = 3;
            labelUmum.Text = "USER UMUM";
            // 
            // buttonPengaduan
            // 
            buttonPengaduan.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPengaduan.Location = new Point(660, 406);
            buttonPengaduan.Name = "buttonPengaduan";
            buttonPengaduan.Size = new Size(396, 71);
            buttonPengaduan.TabIndex = 4;
            buttonPengaduan.Text = "BUAT PENGADUAN BARU";
            buttonPengaduan.UseVisualStyleBackColor = true;
            buttonPengaduan.Click += buttonPengaduan_Click;
            // 
            // buttonTentang
            // 
            buttonTentang.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTentang.Location = new Point(660, 498);
            buttonTentang.Name = "buttonTentang";
            buttonTentang.Size = new Size(396, 71);
            buttonTentang.TabIndex = 5;
            buttonTentang.Text = "TENTANG";
            buttonTentang.UseVisualStyleBackColor = true;
            buttonTentang.Click += buttonTentang_Click;
            // 
            // buttonBantuan
            // 
            buttonBantuan.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBantuan.Location = new Point(660, 595);
            buttonBantuan.Name = "buttonBantuan";
            buttonBantuan.Size = new Size(396, 71);
            buttonBantuan.TabIndex = 6;
            buttonBantuan.Text = "BANTUAN DAN FAQ";
            buttonBantuan.UseVisualStyleBackColor = true;
            buttonBantuan.Click += buttonBantuan_Click;
            // 
            // LoginForm
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1114, 722);
            Controls.Add(buttonBantuan);
            Controls.Add(buttonTentang);
            Controls.Add(buttonPengaduan);
            Controls.Add(labelUmum);
            Controls.Add(pictureBox1);
            Controls.Add(groupLogin);
            Controls.Add(labelLogin);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "APLIKASI PENGADUAN MASYARAKAT";
            Load += LoginForm_Load;
            groupLogin.ResumeLayout(false);
            groupLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private GroupBox groupLogin;
        private Label labelUsername;
        private Label labelKategori;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private CheckBox checkBoxPassword;
        private ComboBox comboKategori;
        private PictureBox pictureBox1;
        private Button buttonLogin;
        private Label labelUmum;
        private Button buttonPengaduan;
        private Button buttonTentang;
        private Button buttonBantuan;
    }
}