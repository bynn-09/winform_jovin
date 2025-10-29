namespace Tugas_Pak_Selamet
{
    public partial class Form1 : Form
    {
        string username, password;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            username = tb_username.Text;
            password = tb_password.Text;
            if (username == "admin" && password == "admin123")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah");
            }

        }
    }
}
