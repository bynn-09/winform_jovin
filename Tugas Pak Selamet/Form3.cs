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
    public partial class Form3 : Form
    {
        public int max_memilih;
        List<Button> pilih_kursi = new List<Button>();
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnKonfirmasi(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            { 
                if (c is Button btn)
                {
                    btn.Click += Kursi_Click;
                }
            }
        }
        private void Kursi_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            max_memilih = DataPemesan.JumlahPenumpang;
            string kode_kursi = btn.Text;

            if (pilih_kursi.Contains(btn))
            {
                pilih_kursi.Remove(btn);
                btn.BackColor = DefaultBackColor;
            }
            else
            {
                if (pilih_kursi.Count < max_memilih )
                {
                    pilih_kursi.Add(btn);
                    btn.BackColor = Color.LightGreen;

                }
                else
                {
                    MessageBox.Show("Jumlah kursi melebihi jumlah penumpang");
                }
            }
        }
    }
}
