using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglantii = new SqlConnection("Data Source=LAPTOP-E0AAA6PN;Initial Catalog=kullanicislem;Integrated Security=True");
        private void button6_Click(object sender, EventArgs e)
        {
            bool aramadurumu = false;
            if (textBox1.Text.Length != 11)
            {
                MessageBox.Show("Lütfen TC alanına 11 rakam giriniz");
            }
            else
            {
                baglantii.Open();
                SqlCommand sorgum = new SqlCommand("select * from islem where tc_no='" + textBox1.Text + "'", baglantii);
                SqlDataReader okumam = sorgum.ExecuteReader();

                while (okumam.Read())
                {
                    aramadurumu = true;

                    textBox2.Text = okumam.GetValue(1).ToString();
                    textBox3.Text = okumam.GetValue(2).ToString();
                    if (okumam.GetValue(3).ToString() == "Kadın")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    comboBox1.Text = okumam.GetValue(4).ToString();
                    comboBox2.Text = okumam.GetValue(5).ToString();
                    dateTimePicker1.Text = okumam.GetValue(6).ToString();
                    comboBox3.Text = okumam.GetValue(7).ToString();
                    break;
                }
                if (aramadurumu == false)
                {
                    MessageBox.Show("Aranan Kayıt bulunamadı");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    comboBox1.SelectedItem = "";
                    comboBox2.SelectedItem = "";
                    comboBox3.SelectedItem = "";
                }
                baglantii.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Text = "RANDEVU AL";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
            }
            else if (textBox1.Text.Length != 11)
            {
                MessageBox.Show("Lütfen TC alanına 11 rakam giriniz");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
            }
            else if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
            }
            else
            {
                string yol = ("Data Source=LAPTOP-E0AAA6PN;Initial Catalog=kullanicislem;Integrated Security=True");
                SqlConnection baglanti = new SqlConnection(yol);
                baglanti.Open();
                String ekleme = "INSERT INTO islem(tc_no,ad,soyad,cinsiyet,bölüm,doktor,saat,tarih) VALUES (@tc_no,@ad,@soyad,@cinsiyet,@bölüm,@doktor,@saat,@tarih)";
                SqlCommand komut = new SqlCommand(ekleme, baglanti);
                komut.Parameters.AddWithValue("@tc_no", textBox1.Text);
                komut.Parameters.AddWithValue("@ad", textBox2.Text);
                komut.Parameters.AddWithValue("@soyad", textBox3.Text);

                string cinsiyet = "";
                if (radioButton1.Checked == true)
                {
                    cinsiyet = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    cinsiyet = radioButton2.Text;
                }
                komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);

                string bölüm = "";
                if (comboBox1.SelectedItem.ToString() == "Dolgu")
                {
                    comboBox2.Items.Add("Leyla Pakman");
                    comboBox2.Items.Add("Ali Gürsoy");
                    bölüm = comboBox1.SelectedItem.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Kanal Tedavi")
                {
                    comboBox2.Items.Add("Kerem Bülbül");
                    comboBox2.Items.Add("Fadime Sevgül");
                    bölüm = comboBox1.SelectedItem.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Diş Teli")
                {
                    comboBox2.Items.Add("Osman Şıpsevdi");
                    comboBox2.Items.Add("Aylin Usta");
                    bölüm = comboBox1.SelectedItem.ToString();
                }
                komut.Parameters.AddWithValue("@bölüm", bölüm);

                string doktor = "";
                if (comboBox2.SelectedItem.ToString() == "Leyla Pakman")
                {
                    comboBox1.Items.Add("Kaplama");
                    doktor = comboBox2.SelectedItem.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Ali Gürsoy")
                {
                    comboBox1.Items.Add("Dolgu");
                    doktor = comboBox2.SelectedItem.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Kerem Bülbül")
                {
                    comboBox1.Items.Add("Dolgu");
                    doktor = comboBox2.SelectedItem.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Osman Şıpsevdi")
                {
                    comboBox1.Items.Add("Dolgu");
                    doktor = comboBox2.SelectedItem.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Aylin Usta")
                {
                    comboBox1.Items.Add("Kanal Tedavi");
                    doktor = comboBox2.SelectedItem.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Fadime Sevgül")
                {
                    comboBox1.Items.Add("Kaplama");
                    doktor = comboBox2.SelectedItem.ToString();
                }
                komut.Parameters.AddWithValue("@doktor", doktor);

                string saat = "";
                saat = comboBox3.SelectedItem.ToString();
                komut.Parameters.AddWithValue("@saat", saat);
                comboBox3.Items.RemoveAt(comboBox3.SelectedIndex);

                DateTime tarih = DateTime.Now;
                tarih = dateTimePicker1.Value;
                komut.Parameters.AddWithValue("@tarih", tarih);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Randevu Oluşturuldu");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
              
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool aramadurumu = false;
            if (textBox1.Text.Length != 11)
            {
                MessageBox.Show("Lütfen TC alanına 11 rakam giriniz");
            }
            else
            {
                baglantii.Open();
                SqlCommand sorgum = new SqlCommand("select * from islem where tc_no='" + textBox1.Text + "'", baglantii);
                SqlDataReader okumam = sorgum.ExecuteReader();

                while (okumam.Read())
                {
                    aramadurumu = true;

                    SqlCommand silme = new SqlCommand("delete from islem where tc_no='" + textBox1.Text + "'", baglantii);
                    silme.ExecuteNonQuery();
                    MessageBox.Show("Randevunuz iptal edilmiştir");
                }
                if (aramadurumu == false)
                {
                    MessageBox.Show("Aranan Kayıt bulunamadı");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    comboBox1.SelectedItem = "";
                    comboBox2.SelectedItem = "";
                    comboBox3.SelectedItem = "";
                }
                baglantii.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




