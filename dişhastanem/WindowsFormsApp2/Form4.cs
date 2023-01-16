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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglantii = new SqlConnection("Data Source=LAPTOP-E0AAA6PN;Initial Catalog=calisan;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "YÖNETİCİ İŞLEMLERİ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool aramadurumu = false;
            if (textBox1.Text.Length != 11)
            {
                MessageBox.Show("Lütfen TC alanına 11 rakam giriniz");
            }
            else
            {
                baglantii.Open();
                SqlCommand sorgum = new SqlCommand("select * from doctor where tc_no='" + textBox1.Text + "'", baglantii);
                SqlDataReader okumam = sorgum.ExecuteReader();

               
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
                }
                baglantii.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}

