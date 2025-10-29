
namespace Tugas_Pak_Selamet
{
    partial class Form2
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
            label1 = new Label();
            Nama = new Label();
            Telp = new Label();
            Tanggal = new Label();
            cmbAsal = new ComboBox();
            txtNama = new TextBox();
            txtTelp = new TextBox();
            dtpTanggal = new DateTimePicker();
            Asal = new Label();
            Tujuan = new Label();
            cmbTujuan = new ComboBox();
            Jam = new Label();
            cmbJam = new ComboBox();
            Jumlah = new Label();
            cmbJumlah = new ComboBox();
            btnKonfirmasi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 0;
            label1.Text = "Forum Pemesanan";
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nama.Location = new Point(10, 81);
            Nama.Margin = new Padding(2, 0, 2, 0);
            Nama.Name = "Nama";
            Nama.Size = new Size(175, 28);
            Nama.TabIndex = 2;
            Nama.Text = "Nama Pemesan :";
            // 
            // Telp
            // 
            Telp.AutoSize = true;
            Telp.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Telp.Location = new Point(10, 134);
            Telp.Margin = new Padding(2, 0, 2, 0);
            Telp.Name = "Telp";
            Telp.Size = new Size(143, 28);
            Telp.TabIndex = 3;
            Telp.Text = "Nomor Telp :";
            // 
            // Tanggal
            // 
            Tanggal.AutoSize = true;
            Tanggal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tanggal.Location = new Point(10, 250);
            Tanggal.Margin = new Padding(2, 0, 2, 0);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(260, 28);
            Tanggal.TabIndex = 4;
            Tanggal.Text = "Tanggal Keberangkatan :";
            // 
            // cmbAsal
            // 
            cmbAsal.FormattingEnabled = true;
            cmbAsal.Items.AddRange(new object[] { "Jakarta" });
            cmbAsal.Location = new Point(182, 310);
            cmbAsal.Margin = new Padding(2, 2, 2, 2);
            cmbAsal.Name = "cmbAsal";
            cmbAsal.Size = new Size(146, 28);
            cmbAsal.TabIndex = 5;
            // 
            // txtNama
            // 
            txtNama.BorderStyle = BorderStyle.FixedSingle;
            txtNama.Location = new Point(182, 82);
            txtNama.Margin = new Padding(2, 2, 2, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(120, 27);
            txtNama.TabIndex = 6;
            // 
            // txtTelp
            // 
            txtTelp.BorderStyle = BorderStyle.FixedSingle;
            txtTelp.Location = new Point(182, 135);
            txtTelp.Margin = new Padding(2, 2, 2, 2);
            txtTelp.Name = "txtTelp";
            txtTelp.Size = new Size(120, 27);
            txtTelp.TabIndex = 7;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(258, 251);
            dtpTanggal.Margin = new Padding(2, 2, 2, 2);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(234, 27);
            dtpTanggal.TabIndex = 8;
            // 
            // Asal
            // 
            Asal.AutoSize = true;
            Asal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Asal.Location = new Point(10, 310);
            Asal.Margin = new Padding(2, 0, 2, 0);
            Asal.Name = "Asal";
            Asal.Size = new Size(118, 28);
            Asal.TabIndex = 9;
            Asal.Text = "Kota Asal :";
            // 
            // Tujuan
            // 
            Tujuan.AutoSize = true;
            Tujuan.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tujuan.Location = new Point(10, 372);
            Tujuan.Margin = new Padding(2, 0, 2, 0);
            Tujuan.Name = "Tujuan";
            Tujuan.Size = new Size(145, 28);
            Tujuan.TabIndex = 10;
            Tujuan.Text = "Kota Tujuan :";
            // 
            // cmbTujuan
            // 
            cmbTujuan.FormattingEnabled = true;
            cmbTujuan.Items.AddRange(new object[] { "Bekasi", "Solo", "Yogyakarta", "Bogor", "Bandung", "Surabaya" });
            cmbTujuan.Location = new Point(182, 374);
            cmbTujuan.Margin = new Padding(2, 2, 2, 2);
            cmbTujuan.Name = "cmbTujuan";
            cmbTujuan.Size = new Size(146, 28);
            cmbTujuan.TabIndex = 11;
            // 
            // Jam
            // 
            Jam.AutoSize = true;
            Jam.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Jam.Location = new Point(10, 434);
            Jam.Margin = new Padding(2, 0, 2, 0);
            Jam.Name = "Jam";
            Jam.Size = new Size(220, 28);
            Jam.TabIndex = 12;
            Jam.Text = "Jam Keberangkatan :";
            // 
            // cmbJam
            // 
            cmbJam.FormattingEnabled = true;
            cmbJam.Items.AddRange(new object[] { "06.00", "09.00", "12.00", "15.00", "18.00", "21.00" });
            cmbJam.Location = new Point(222, 436);
            cmbJam.Margin = new Padding(2, 2, 2, 2);
            cmbJam.Name = "cmbJam";
            cmbJam.Size = new Size(146, 28);
            cmbJam.TabIndex = 13;
            // 
            // Jumlah
            // 
            Jumlah.AutoSize = true;
            Jumlah.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Jumlah.Location = new Point(10, 194);
            Jumlah.Margin = new Padding(2, 0, 2, 0);
            Jumlah.Name = "Jumlah";
            Jumlah.Size = new Size(220, 28);
            Jumlah.TabIndex = 14;
            Jumlah.Text = "Jumlah Penumpang :";
            // 
            // cmbJumlah
            // 
            cmbJumlah.FormattingEnabled = true;
            cmbJumlah.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            cmbJumlah.Location = new Point(223, 197);
            cmbJumlah.Margin = new Padding(2, 2, 2, 2);
            cmbJumlah.Name = "cmbJumlah";
            cmbJumlah.Size = new Size(146, 28);
            cmbJumlah.TabIndex = 15;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonfirmasi.Location = new Point(274, 511);
            btnKonfirmasi.Margin = new Padding(2, 2, 2, 2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(86, 27);
            btnKonfirmasi.TabIndex = 16;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += BtnKonfirmasi;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 548);
            Controls.Add(btnKonfirmasi);
            Controls.Add(cmbJumlah);
            Controls.Add(Jumlah);
            Controls.Add(cmbJam);
            Controls.Add(Jam);
            Controls.Add(cmbTujuan);
            Controls.Add(Tujuan);
            Controls.Add(Asal);
            Controls.Add(dtpTanggal);
            Controls.Add(txtTelp);
            Controls.Add(txtNama);
            Controls.Add(cmbAsal);
            Controls.Add(Tanggal);
            Controls.Add(Telp);
            Controls.Add(Nama);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private Label label1;
        private Label Nama;
        private Label Telp;
        private Label Tanggal;
        private ComboBox cmbAsal;
        private TextBox txtNama;
        private TextBox txtTelp;
        private DateTimePicker dtpTanggal;
        private Label Asal;
        private Label Tujuan;
        private ComboBox cmbTujuan;
        private Label Jam;
        private ComboBox cmbJam;
        private Label Jumlah;
        private ComboBox cmbJumlah;
        private Button btnKonfirmasi;
    }
}