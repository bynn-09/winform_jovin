using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Pak_Selamet
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMetode.Items.AddRange(new string[] { "Kartu Kredit", "E-Wallet" });

            int hargaPerPenumpang = 100000;
            int hargaTambahan = 0;
            switch (DataPemesan.KotaTujuan)
            {
                case "Bekasi": hargaTambahan = 50000; break;
                case "Solo": hargaTambahan = 80000; break;
                case "Yogyakarta": hargaTambahan = 100000; break;
                case "Bogor": hargaTambahan = 50000; break;
                case "Bandung": hargaTambahan = 80000; break;
                case "Surabaya": hargaTambahan = 100000; break;
            }

            DataPemesan.TotalHarga = (hargaPerPenumpang + hargaTambahan) * DataPemesan.JumlahPenumpang;
            lblHarga.Text = "Rp " + DataPemesan.TotalHarga.ToString("NO");
        }

        private void BtnKonfirmasi(object sender, EventArgs e)
        {
            if (cmbMetode.Text == "")
            {
                MessageBox.Show("Pilih Metode Pembayaran!");
                return;
            }
            else

            DataPemesan.MetodePembayaran = cmbMetode.Text;

            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
