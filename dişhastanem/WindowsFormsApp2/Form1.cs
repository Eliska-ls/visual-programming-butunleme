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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-E0AAA6PN;Initial Catalog=Dishastanesi;Integrated Security=True");
        SqlConnection baglanti2 = new SqlConnection("Data Source=LAPTOP-E0AAA6PN;Initial Catalog=calisan;Integrated Security=True");

        public static string tc_no, adi, soyadi;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Elis Diş Hastanesi";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 ff = new Form2();
            this.Hide();
            ff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurun");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Lütfen geçerli bir seçenek seçiniz");
            }
            else
            {
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("select * from kullanici", baglanti);
                SqlDataReader okuma = sorgu.ExecuteReader();

              

                while (okuma.Read())
                {
                    if (radioButton1.Checked == true)
                    {
                        if (okuma["kullanici_adi"].ToString() == textBox1.Text && okuma["sifre"].ToString() == textBox2.Text)
                        {
                            tc_no = okuma.GetValue(0).ToString();
                            adi = okuma.GetValue(0).ToString();
                            soyadi = okuma.GetValue(0).ToString();
                            this.Hide();
                            Form3 frm3 = new Form3();
                            frm3.Show();
                            break;
                        }
                    }
                }
                baglanti.Close();
              
            }
        }
    }
}
