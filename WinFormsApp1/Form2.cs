using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.Field;
namespace WinFormsApp1
{
    public partial class Form2 : Form
    { MySqlConnection baglanti = new MySqlConnection("server = localhost;Database=personel_takip;Uid=root;Pwd=;");
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad = textBox1.Text;
            string tcNo = textBox2.Text;
            string telefon = textBox3.Text;
            string adres = textBox4.Text;
            string departman = textBox5.Text;
            string baslamaTarihi = dateTimePicker1.Value.ToShortDateString();

            string Cinsiyet = "";
            if (radioButton1.Checked) Cinsiyet = "Kadın";
            else if (radioButton2.Checked) Cinsiyet = "Erkek";

            if (adSoyad != "" && tcNo != "")
            {
                baglanti.Open();
                string sorgu = $"INSERT INTO tbl_personeller (ad_soyad, tc_no, telefon, adres, departman, baslama_tarihi, cinsiyet)VALUES ('{adSoyad}', '{tcNo}', '{telefon}', '{adres}', '{departman}', '{baslamaTarihi}', '{Cinsiyet}')";
                MySqlCommand komut = new MySqlCommand(sorgu,baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                MessageBox.Show(adSoyad+ "isimli personel başarıyla kaydedildi!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
           


        }
    }
}
