namespace Tugas_Pak_Selamet
{
    partial class Form5
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
            lblJumlah = new Label();
            lblJam = new Label();
            lblTujuan = new Label();
            lblAsal = new Label();
            lblTanggal = new Label();
            lblTelp = new Label();
            lblNama = new Label();
            lblKursi = new Label();
            lblTotal = new Label();
            lblMetode = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 45);
            label1.TabIndex = 3;
            label1.Text = "Forum Cetak";
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlah.Location = new Point(12, 226);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(261, 32);
            lblJumlah.TabIndex = 21;
            lblJumlah.Text = "Jumlah Penumpang :";
            // 
            // lblJam
            // 
            lblJam.AutoSize = true;
            lblJam.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJam.Location = new Point(12, 525);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(260, 32);
            lblJam.TabIndex = 20;
            lblJam.Text = "Jam Keberangkatan :";
            // 
            // lblTujuan
            // 
            lblTujuan.AutoSize = true;
            lblTujuan.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTujuan.Location = new Point(12, 448);
            lblTujuan.Name = "lblTujuan";
            lblTujuan.Size = new Size(171, 32);
            lblTujuan.TabIndex = 19;
            lblTujuan.Text = "Kota Tujuan :";
            // 
            // lblAsal
            // 
            lblAsal.AutoSize = true;
            lblAsal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsal.Location = new Point(12, 371);
            lblAsal.Name = "lblAsal";
            lblAsal.Size = new Size(141, 32);
            lblAsal.TabIndex = 18;
            lblAsal.Text = "Kota Asal :";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggal.Location = new Point(12, 296);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(305, 32);
            lblTanggal.TabIndex = 17;
            lblTanggal.Text = "Tanggal Keberangkatan :";
            // 
            // lblTelp
            // 
            lblTelp.AutoSize = true;
            lblTelp.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelp.Location = new Point(12, 151);
            lblTelp.Name = "lblTelp";
            lblTelp.Size = new Size(168, 32);
            lblTelp.TabIndex = 16;
            lblTelp.Text = "Nomor Telp :";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(12, 80);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(209, 32);
            lblNama.TabIndex = 15;
            lblNama.Text = "Nama Pemesan :";
            // 
            // lblKursi
            // 
            lblKursi.AutoSize = true;
            lblKursi.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKursi.Location = new Point(400, 80);
            lblKursi.Name = "lblKursi";
            lblKursi.Size = new Size(179, 32);
            lblKursi.TabIndex = 22;
            lblKursi.Text = "Nomor Kursi :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(400, 151);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(232, 32);
            lblTotal.TabIndex = 24;
            lblTotal.Text = "Total Harga Tiket :";
            // 
            // lblMetode
            // 
            lblMetode.AutoSize = true;
            lblMetode.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetode.Location = new Point(400, 226);
            lblMetode.Name = "lblMetode";
            lblMetode.Size = new Size(271, 32);
            lblMetode.TabIndex = 23;
            lblMetode.Text = "Metode Pembayaran :";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 678);
            Controls.Add(lblTotal);
            Controls.Add(lblMetode);
            Controls.Add(lblKursi);
            Controls.Add(lblJumlah);
            Controls.Add(lblJam);
            Controls.Add(lblTujuan);
            Controls.Add(lblAsal);
            Controls.Add(lblTanggal);
            Controls.Add(lblTelp);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblJumlah;
        private Label lblJam;
        private Label lblTujuan;
        private Label lblAsal;
        private Label lblTanggal;
        private Label lblTelp;
        private Label lblNama;
        private Label lblKursi;
        private Label lblTotal;
        private Label lblMetode;
    }
}