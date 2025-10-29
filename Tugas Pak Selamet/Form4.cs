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
            cmbMetode.Items.AddRange(new object[] { "Kartu Kredit", "E-Wallet" });
            total_harga.Text = "Rp " + DataPemesan.TotalHarga.ToString();
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
