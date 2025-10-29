using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Tugas_Pak_Selamet
{

    public partial class Form2 : Form
    {
        private readonly Dictionary<(string, string), int> hargaTiket = new Dictionary<(string, string), int>()
        {
            {("Jakarta", "Bandung"), 125000 },
            {("Jakarta", "Surabaya"), 300000 },
            {("Jakarta", "Yogyakarta"), 250000 },
            {("Jakarta", "Semarang"), 275000 },
            {("Bandung", "Jakarta"), 125000 },
            {("Bandung", "Surabaya"), 280000 },
            {("Bandung", "Yogyakarta"), 230000 },
            {("Bandung", "Semarang"), 260000 },
            {("Surabaya", "Jakarta"), 300000 },
            {("Surabaya", "Bandung"), 280000 },
            {("Surabaya", "Yogyakarta"), 200000 },
            {("Surabaya", "Semarang"), 220000 },
            {("Yogyakarta", "Jakarta"), 250000 },
            {("Yogyakarta", "Bandung"), 230000 },
            {("Yogyakarta", "Surabaya"), 200000 },
            {("Yogyakarta", "Semarang"), 150000 },
            {("Semarang", "Jakarta"), 275000 },
            {("Semarang", "Bandung"), 260000 },
            {("Semarang", "Surabaya"), 220000 },
            {("Semarang", "Yogyakarta"), 150000 }
        };

        public Form2()
        {
            InitializeComponent();
            dtpTanggal.MinDate = DateTime.Today.AddDays(1);    // tidak boleh pesan hari ini atau lalu
            dtpTanggal.MaxDate = DateTime.Today.AddMonths(1);  // optional: batasi sampai 1 bulan ke depan
            dtpTanggal.Value = dtpTanggal.MinDate;

            // Populate once (do not repopulate on button clicks)
            PopulateControls();

            // make sure asal cannot be edited
            cmbAsal.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void PopulateControls()
        {
            cmbJumlah.Items.Clear();
            for (int i = 1; i <= 7; i++)                                                                            
                cmbJumlah.Items.Add(i);

            // Use only destinations that exist in the hargaTiket dictionary
            cmbTujuan.Items.Clear();
            cmbTujuan.Items.AddRange(new string[] { "Jakarta", "Bandung", "Surabaya", "Yogyakarta", "Semarang" });

            cmbJam.Items.Clear();
            cmbJam.Items.AddRange(new string[] { "06.00", "09.00", "12.00", "15.00", "18.00", "21.00" });

            cmbAsal.Items.Clear();
            cmbAsal.Items.AddRange(new string[] { "Jakarta", "Bandung", "Surabaya", "Yogyakarta", "Semarang" });

            // select sensible defaults: origin != destination so Hitung_tarif produces a non-zero result
            if (cmbAsal.Items.Count > 0) cmbAsal.SelectedIndex = 0;
            if (cmbTujuan.Items.Count > 1)
            {
                // find a default tujuan that's not the same as asal
                cmbTujuan.SelectedIndex = cmbAsal.SelectedIndex == 0 ? 1 : 0;
            }

            if (cmbJumlah.Items.Count > 0) cmbJumlah.SelectedIndex = 0;
            if (cmbJam.Items.Count > 0) cmbJam.SelectedIndex = 0;
        }

        // keep existing handler if wired in designer but leave empty (we populate in ctor)
        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            // intentionally left empty to avoid duplicate population
        }

        private void BtnKonfirmasi(object sender, EventArgs e)
        {
            // basic validation
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtTelp.Text) ||
                string.IsNullOrWhiteSpace(cmbJumlah.Text) ||
                string.IsNullOrWhiteSpace(cmbTujuan.Text) ||
                string.IsNullOrWhiteSpace(cmbJam.Text))
            {
                MessageBox.Show("Lengkapi semua data!");
                return;
            }

            if (dtpTanggal.Value.Date < DateTime.Today.AddDays(1))
            {
                MessageBox.Show("Pilih tanggal setelah hari ini.");
                return;
            }

            if (!int.TryParse(cmbJumlah.Text, out int jumlah))
            {
                MessageBox.Show("Jumlah penumpang tidak valid.");
                return;
            }

            DataPemesan.NamaPemesan = txtNama.Text.Trim();
            DataPemesan.NomorTelp = txtTelp.Text.Trim();
            DataPemesan.JumlahPenumpang = jumlah;
            DataPemesan.Tanggal = dtpTanggal.Value.Date.ToString("dd-MMMM-yyy");            // gunakan nilai dari DateTimePicker
            DataPemesan.KotaTujuan = cmbTujuan.Text;
            DataPemesan.KotaAsal = cmbAsal.Text;
            DataPemesan.JamKeberangkatan = cmbJam.Text;

            // Hitung tarif sebelum lanjut
            Hitung_tarif();

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Hitung_tarif()
        {
            // prefer Text property (works even if SelectedItem == null)
            string asal = cmbAsal.Text;
            string tujuan = cmbTujuan.Text;

            if (string.IsNullOrWhiteSpace(asal) || string.IsNullOrWhiteSpace(tujuan))
            {
                DataPemesan.TotalHarga = 0;
                tb_tarif_pembayaran.Text = 0.ToString("C0", new CultureInfo("id-ID"));
                return;
            }

            if (asal == tujuan)
            {
                MessageBox.Show("Anda tidak bisa memilih asal dan tujuan yang sama");
                DataPemesan.TotalHarga = 0;
                tb_tarif_pembayaran.Text = 0.ToString("C0", new CultureInfo("id-ID"));
                return;
            }

            if (hargaTiket.TryGetValue((asal, tujuan), out int harga))
            {
                double total = harga * DataPemesan.JumlahPenumpang;
                DataPemesan.TotalHarga = total;
                tb_tarif_pembayaran.Text = total.ToString("C0", new CultureInfo("id-ID")); // "Rp" local formatting
            }
            else
            {
                // route not found -> show clear message/zero
                DataPemesan.TotalHarga = 0;
                tb_tarif_pembayaran.Text = "Rute tidak tersedia";
            }
        }

        private void cmbAsal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hitung_tarif();
        }

        private void cmbTujuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hitung_tarif();
        }

        private void cmbJumlah_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbJumlah.Text, out int j))
                DataPemesan.JumlahPenumpang = j;
            Hitung_tarif();
        }
    }
}
