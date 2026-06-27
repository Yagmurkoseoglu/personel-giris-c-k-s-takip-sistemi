using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            MySqlConnection baglanti = new MySqlConnection("server=localhost;Database=personel_takip;Uid=root;Pwd=;");
            baglanti.Open();
            string sorgu = "SELECT ad_soyad FROM tbl_personeller";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            { 
                    comboBox1.Items.Add(oku["ad_soyad"].ToString());
                }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("lütfen bir personel secinizzz!!");
                return;
            }
            string personel=comboBox1.SelectedItem.ToString();
            string zaman = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            listBox1.Items.Add(personel + "Giriş yaptı-" + zaman);
            MySqlConnection baglanti = new MySqlConnection("server=localhost;Database=personel_takip;Uid=root;Pwd=;");
            baglanti.Open();
            string sorgu=$"INSERT INTO tbl_mesai(ad_soyad),'islem-turu', tarih_saat) VALUES ('{personel}','{zaman}')";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("lütfen bir personel secinizzz!!");
                return;
            }

            string personel = comboBox1.SelectedItem.ToString();
            string zaman = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            listBox1.Items.Add(personel + "çikiş yaptı-" + zaman);
            MySqlConnection baglanti = new MySqlConnection("server=localhost;Database=personel_takip;Uid=root;Pwd=;");
            baglanti.Open();
            string sorgu = $"INSERT INTO tbl_mesai(ad_soyad),'islem-turu', tarih_saat) VALUES ('{personel}', 'çıkış', {zaman}')";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
