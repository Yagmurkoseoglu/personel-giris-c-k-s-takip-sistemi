
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server=localhost;Database=personel_takip;Uid=root;Pwd=;");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AdSoyad = textBox1.Text;
            string Sifre = textBox2.Text;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM tbl_kullanicilar WHERE kullanici_adi='" +AdSoyad+ "'AND sifre='" +Sifre+ "'", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("yönetici girişi başarılı.");
                FormAnaMenu menu = new FormAnaMenu();
                menu.Show();
                this.Hide();
            }
          
            else
            {
                MessageBox.Show("kullanıcı adınız ve şifreniz yalnış! lütfen tekrar deneyiniz.");
            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
