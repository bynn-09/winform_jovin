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
    
    public partial class Form2 : Form
    {
        string tanggal_pesan;
        public Form2()
        {
            InitializeComponent();
        }


        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 7; i++)
                cmbJumlah.Items.Add(i);

            cmbTujuan.Items.AddRange(new string[] { "Bekasi", "Solo", "Yogyakarta", "Bogor", "Bandung", "Surabaya" });

            cmbJam.Items.AddRange(new string[] { "06.00", "09.00", "12.00", "15.00", "18.00", "21.00" });

            cmbAsal.Items.AddRange(new string[] { "Jakarta" });
        }
        private void BtnKonfirmasi(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtTelp.Text == "" || cmbJumlah.Text == "" || cmbTujuan.Text == "" || cmbJam.Text == "")
            {
                MessageBox.Show("Lengkapi semua data!");
                return;
            }

            DataPemesan.NamaPemesan = txtNama.Text;
            DataPemesan.NomorTelp = txtTelp.Text;
            DataPemesan.JumlahPenumpang = int.Parse(cmbJumlah.Text);
            tanggal_pesan = DateTime.Now.ToString("d");
            DataPemesan.KotaTujuan = cmbTujuan.Text;
            DataPemesan.JamKeberangkatan = cmbJam.Text;

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

       
    }
}
