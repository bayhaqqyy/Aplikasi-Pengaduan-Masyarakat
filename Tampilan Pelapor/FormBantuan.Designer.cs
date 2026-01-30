namespace Tampilan_Pelapor
{
    partial class FormBantuan
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTimer = new Label();
            listViewPertanyaan = new ListView();
            kolom1 = new ColumnHeader();
            kolom2 = new ColumnHeader();
            groupBox1 = new GroupBox();
            richTextBoxJawaban = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 33);
            label1.Name = "label1";
            label1.Size = new Size(398, 37);
            label1.TabIndex = 0;
            label1.Text = "FAQ (Pertanyaan Umum)";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimer.Location = new Point(787, 9);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(22, 30);
            labelTimer.TabIndex = 2;
            labelTimer.Text = "-";
            labelTimer.Click += labelTimer_Click;
            // 
            // listViewPertanyaan
            // 
            listViewPertanyaan.Columns.AddRange(new ColumnHeader[] { kolom1, kolom2 });
            listViewPertanyaan.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewPertanyaan.GridLines = true;
            listViewPertanyaan.Location = new Point(6, 17);
            listViewPertanyaan.Name = "listViewPertanyaan";
            listViewPertanyaan.Size = new Size(615, 323);
            listViewPertanyaan.TabIndex = 0;
            listViewPertanyaan.UseCompatibleStateImageBehavior = false;
            listViewPertanyaan.View = View.Details;
            listViewPertanyaan.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // kolom1
            // 
            kolom1.Text = "NO";
            kolom1.Width = 50;
            // 
            // kolom2
            // 
            kolom2.Text = "Pertanyaan Umum";
            kolom2.TextAlign = HorizontalAlignment.Center;
            kolom2.Width = 600;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxJawaban);
            groupBox1.Controls.Add(listViewPertanyaan);
            groupBox1.Location = new Point(30, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 352);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // richTextBoxJawaban
            // 
            richTextBoxJawaban.BorderStyle = BorderStyle.None;
            richTextBoxJawaban.Location = new Point(59, 87);
            richTextBoxJawaban.Name = "richTextBoxJawaban";
            richTextBoxJawaban.ReadOnly = true;
            richTextBoxJawaban.Size = new Size(549, 85);
            richTextBoxJawaban.TabIndex = 1;
            richTextBoxJawaban.Text = "";
            richTextBoxJawaban.TextChanged += listView1_SelectedIndexChanged;
            // 
            // FormBantuan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1129, 663);
            Controls.Add(groupBox1);
            Controls.Add(labelTimer);
            Controls.Add(label1);
            Name = "FormBantuan";
            Text = "Bantuan / Help";
            Load += FormBantuan_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label labelTimer;
        private ListView listViewPertanyaan;
        private ColumnHeader kolom1;
        private ColumnHeader kolom2;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxJawaban;
    }
}