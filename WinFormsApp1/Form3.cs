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
    public partial class Form3 : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server=localhost;Database=personel_takip;Uid=root;Pwd=;");
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); 
            baglanti.Open();
            string sorgu = "SELECT ad_soyad FROM tbl_personeller";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                comboBox1.Items.Add(oku["ad_soyad"].ToString());
            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("lütfen hesaplamadn önce bir personel seciniz.", "eksik seçim", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }


            string personel=comboBox1.SelectedItem.ToString();
            DateTime baslangic = dateTimePicker1.Value;
            DateTime bitis= dateTimePicker2.Value;

            TimeSpan fark = bitis - baslangic;
            int toplamGun = fark.Days;

            if (toplamGun < 0) toplamGun = 0;
            int toplamMaas = toplamGun * 1500;

            if(dataGridView1.Columns.Count==0)
            {
                dataGridView1.Columns.Add("pers", "personel Adı");
                dataGridView1.Columns.Add("Gun", "çalıştığı gün");
                dataGridView1.Columns.Add("Maas", "hesaplanan Maaş");
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(personel, toplamGun + "gün", toplamMaas + "TL");

            baglanti.Open();
            string donem = bitis.ToString("MMM yyyy");
            string sorgu = $"INSERT INTO tbl_maaslar (personel_id, donem,mesai_saati, toplam, toplam_tutar) VALUES ('1','{donem}','{toplamGun}','{toplamMaas}')";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Close();MessageBox.Show("maaş ve çalışma günü başarıyla başarıyla kaydedildi!");
        }
    }
}
