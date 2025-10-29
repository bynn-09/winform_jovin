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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            l_nama.Text = DataPemesan.NamaPemesan;
            l_nomor_telp.Text = DataPemesan.NomorTelp;
            l_jml_pnp.Text = DataPemesan.JumlahPenumpang.ToString();
            l_kota_asal.Text = DataPemesan.KotaAsal;
            l_kota_tujuan.Text = DataPemesan.JamKeberangkatan;
            l_nomor_kursi.Text = DataPemesan.KodeKursi;
            l_total_harga.Text = "Rp " + DataPemesan.TotalHarga.ToString();
            l_method_pembayaran.Text = DataPemesan.MetodePembayaran;
            l_tgl_keberangkatan.Text = DataPemesan.Tanggal;
            l_jam_keberangkatan.Text = DataPemesan.JamKeberangkatan;
        }

        private void l_kota_asal_Click(object sender, EventArgs e)
        {

        }
    }
}
