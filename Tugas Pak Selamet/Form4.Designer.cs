namespace Tugas_Pak_Selamet
{
    partial class Form4
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
            l_method_pembayaran = new Label();
            cmbMetode = new ComboBox();
            lblHarga = new Label();
            button43 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 37);
            label1.TabIndex = 2;
            label1.Text = "Forum Bayar";
            // 
            // l_method_pembayaran
            // 
            l_method_pembayaran.AutoSize = true;
            l_method_pembayaran.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_method_pembayaran.Location = new Point(10, 134);
            l_method_pembayaran.Margin = new Padding(2, 0, 2, 0);
            l_method_pembayaran.Name = "l_method_pembayaran";
            l_method_pembayaran.Size = new Size(277, 28);
            l_method_pembayaran.TabIndex = 10;
            l_method_pembayaran.Text = "Pilih Metode Pembayaran :";
            // 
            // cmbMetode
            // 
            cmbMetode.FormattingEnabled = true;
            cmbMetode.Items.AddRange(new object[] { "Kartu Kredit", "E-Wallet" });
            cmbMetode.Location = new Point(278, 137);
            cmbMetode.Margin = new Padding(2, 2, 2, 2);
            cmbMetode.Name = "cmbMetode";
            cmbMetode.Size = new Size(146, 28);
            cmbMetode.TabIndex = 11;
            cmbMetode.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(10, 88);
            lblHarga.Margin = new Padding(2, 0, 2, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(197, 28);
            lblHarga.TabIndex = 12;
            lblHarga.Text = "Total Harga Tiket :";
            // 
            // button43
            // 
            button43.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button43.Location = new Point(176, 270);
            button43.Margin = new Padding(2, 2, 2, 2);
            button43.Name = "button43";
            button43.Size = new Size(86, 27);
            button43.TabIndex = 59;
            button43.Text = "Konfirmasi";
            button43.UseVisualStyleBackColor = true;
            button43.Click += BtnKonfirmasi;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 307);
            Controls.Add(button43);
            Controls.Add(lblHarga);
            Controls.Add(cmbMetode);
            Controls.Add(l_method_pembayaran);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label l_method_pembayaran;
        private ComboBox cmbMetode;
        private Label lblHarga;
        private Button button43;
    }
}