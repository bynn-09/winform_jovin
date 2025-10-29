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
            total_harga = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 2;
            label1.Text = "Forum Bayar";
            // 
            // l_method_pembayaran
            // 
            l_method_pembayaran.AutoSize = true;
            l_method_pembayaran.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_method_pembayaran.Location = new Point(9, 100);
            l_method_pembayaran.Margin = new Padding(2, 0, 2, 0);
            l_method_pembayaran.Name = "l_method_pembayaran";
            l_method_pembayaran.Size = new Size(220, 21);
            l_method_pembayaran.TabIndex = 10;
            l_method_pembayaran.Text = "Pilih Metode Pembayaran :";
            // 
            // cmbMetode
            // 
            cmbMetode.FormattingEnabled = true;
            cmbMetode.Items.AddRange(new object[] { "Kartu Kredit", "E-Wallet" });
            cmbMetode.Location = new Point(243, 103);
            cmbMetode.Margin = new Padding(2);
            cmbMetode.Name = "cmbMetode";
            cmbMetode.Size = new Size(128, 23);
            cmbMetode.TabIndex = 11;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(9, 66);
            lblHarga.Margin = new Padding(2, 0, 2, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(156, 21);
            lblHarga.TabIndex = 12;
            lblHarga.Text = "Total Harga Tiket :";
            // 
            // button43
            // 
            button43.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button43.Location = new Point(154, 202);
            button43.Margin = new Padding(2);
            button43.Name = "button43";
            button43.Size = new Size(75, 20);
            button43.TabIndex = 59;
            button43.Text = "Konfirmasi";
            button43.UseVisualStyleBackColor = true;
            button43.Click += BtnKonfirmasi;
            // 
            // total_harga
            // 
            total_harga.AutoSize = true;
            total_harga.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_harga.Location = new Point(178, 66);
            total_harga.Margin = new Padding(2, 0, 2, 0);
            total_harga.Name = "total_harga";
            total_harga.Size = new Size(156, 21);
            total_harga.TabIndex = 60;
            total_harga.Text = "Total Harga Tiket :";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 230);
            Controls.Add(total_harga);
            Controls.Add(button43);
            Controls.Add(lblHarga);
            Controls.Add(cmbMetode);
            Controls.Add(l_method_pembayaran);
            Controls.Add(label1);
            Margin = new Padding(2);
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
        private Label total_harga;
    }
}