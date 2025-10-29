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
            lblNama.Text = DataPemesan.NamaPemesan;
            lblTelp.Text = DataPemesan.NomorTelp;
            lblJumlah.Text = DataPemesan.JumlahPenumpang.ToString();
            lblAsal.Text = DataPemesan.KotaAsal;
            lblJam.Text = DataPemesan.JamKeberangkatan;
            lblKursi.Text = DataPemesan.Kursi;
            lblTotal.Text = "Rp " + DataPemesan.TotalHarga.ToString();
            lblMetode.Text = DataPemesan.MetodePembayaran;
        }
    }
}
