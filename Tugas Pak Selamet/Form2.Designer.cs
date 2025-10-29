
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
            tb_tarif_pembayaran = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 30);
            label1.TabIndex = 0;
            label1.Text = "Forum Pemesanan";
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nama.Location = new Point(9, 61);
            Nama.Margin = new Padding(2, 0, 2, 0);
            Nama.Name = "Nama";
            Nama.Size = new Size(139, 21);
            Nama.TabIndex = 2;
            Nama.Text = "Nama Pemesan :";
            // 
            // Telp
            // 
            Telp.AutoSize = true;
            Telp.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Telp.Location = new Point(9, 100);
            Telp.Margin = new Padding(2, 0, 2, 0);
            Telp.Name = "Telp";
            Telp.Size = new Size(112, 21);
            Telp.TabIndex = 3;
            Telp.Text = "Nomor Telp :";
            // 
            // Tanggal
            // 
            Tanggal.AutoSize = true;
            Tanggal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tanggal.Location = new Point(9, 188);
            Tanggal.Margin = new Padding(2, 0, 2, 0);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(205, 21);
            Tanggal.TabIndex = 4;
            Tanggal.Text = "Tanggal Keberangkatan :";
            // 
            // cmbAsal
            // 
            cmbAsal.FormattingEnabled = true;
            cmbAsal.Items.AddRange(new object[] { "Jakarta" });
            cmbAsal.Location = new Point(159, 232);
            cmbAsal.Margin = new Padding(2);
            cmbAsal.Name = "cmbAsal";
            cmbAsal.Size = new Size(128, 23);
            cmbAsal.TabIndex = 5;
            cmbAsal.SelectedIndexChanged += cmbAsal_SelectedIndexChanged;
            // 
            // txtNama
            // 
            txtNama.BorderStyle = BorderStyle.FixedSingle;
            txtNama.Location = new Point(159, 62);
            txtNama.Margin = new Padding(2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(105, 23);
            txtNama.TabIndex = 6;
            // 
            // txtTelp
            // 
            txtTelp.BorderStyle = BorderStyle.FixedSingle;
            txtTelp.Location = new Point(159, 101);
            txtTelp.Margin = new Padding(2);
            txtTelp.Name = "txtTelp";
            txtTelp.Size = new Size(105, 23);
            txtTelp.TabIndex = 7;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(226, 188);
            dtpTanggal.Margin = new Padding(2);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(205, 23);
            dtpTanggal.TabIndex = 8;
            // 
            // Asal
            // 
            Asal.AutoSize = true;
            Asal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Asal.Location = new Point(9, 232);
            Asal.Margin = new Padding(2, 0, 2, 0);
            Asal.Name = "Asal";
            Asal.Size = new Size(94, 21);
            Asal.TabIndex = 9;
            Asal.Text = "Kota Asal :";
            // 
            // Tujuan
            // 
            Tujuan.AutoSize = true;
            Tujuan.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tujuan.Location = new Point(9, 279);
            Tujuan.Margin = new Padding(2, 0, 2, 0);
            Tujuan.Name = "Tujuan";
            Tujuan.Size = new Size(114, 21);
            Tujuan.TabIndex = 10;
            Tujuan.Text = "Kota Tujuan :";
            // 
            // cmbTujuan
            // 
            cmbTujuan.FormattingEnabled = true;
            cmbTujuan.Items.AddRange(new object[] { "Bekasi", "Solo", "Yogyakarta", "Bogor", "Bandung", "Surabaya" });
            cmbTujuan.Location = new Point(159, 280);
            cmbTujuan.Margin = new Padding(2);
            cmbTujuan.Name = "cmbTujuan";
            cmbTujuan.Size = new Size(128, 23);
            cmbTujuan.TabIndex = 11;
            cmbTujuan.SelectedIndexChanged += cmbTujuan_SelectedIndexChanged;
            // 
            // Jam
            // 
            Jam.AutoSize = true;
            Jam.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Jam.Location = new Point(9, 326);
            Jam.Margin = new Padding(2, 0, 2, 0);
            Jam.Name = "Jam";
            Jam.Size = new Size(174, 21);
            Jam.TabIndex = 12;
            Jam.Text = "Jam Keberangkatan :";
            // 
            // cmbJam
            // 
            cmbJam.FormattingEnabled = true;
            cmbJam.Items.AddRange(new object[] { "06.00", "09.00", "12.00", "15.00", "18.00", "21.00" });
            cmbJam.Location = new Point(194, 327);
            cmbJam.Margin = new Padding(2);
            cmbJam.Name = "cmbJam";
            cmbJam.Size = new Size(128, 23);
            cmbJam.TabIndex = 13;
            // 
            // Jumlah
            // 
            Jumlah.AutoSize = true;
            Jumlah.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Jumlah.Location = new Point(9, 146);
            Jumlah.Margin = new Padding(2, 0, 2, 0);
            Jumlah.Name = "Jumlah";
            Jumlah.Size = new Size(173, 21);
            Jumlah.TabIndex = 14;
            Jumlah.Text = "Jumlah Penumpang :";
            // 
            // cmbJumlah
            // 
            cmbJumlah.FormattingEnabled = true;
            cmbJumlah.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            cmbJumlah.Location = new Point(195, 148);
            cmbJumlah.Margin = new Padding(2);
            cmbJumlah.Name = "cmbJumlah";
            cmbJumlah.Size = new Size(128, 23);
            cmbJumlah.TabIndex = 15;
            cmbJumlah.SelectedIndexChanged += cmbJumlah_SelectedIndexChanged;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonfirmasi.Location = new Point(306, 372);
            btnKonfirmasi.Margin = new Padding(2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(125, 28);
            btnKonfirmasi.TabIndex = 16;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += BtnKonfirmasi;
            // 
            // tb_tarif_pembayaran
            // 
            tb_tarif_pembayaran.AutoSize = true;
            tb_tarif_pembayaran.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_tarif_pembayaran.Location = new Point(40, 372);
            tb_tarif_pembayaran.Margin = new Padding(2, 0, 2, 0);
            tb_tarif_pembayaran.Name = "tb_tarif_pembayaran";
            tb_tarif_pembayaran.Size = new Size(15, 21);
            tb_tarif_pembayaran.TabIndex = 17;
            tb_tarif_pembayaran.Text = ".";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 411);
            Controls.Add(tb_tarif_pembayaran);
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
            Margin = new Padding(2);
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
        private Label tb_tarif_pembayaran;
    }
}