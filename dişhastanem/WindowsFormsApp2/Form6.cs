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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglantii = new SqlConnection("Data Source=LAPTOP-E0AAA6PN;Initial Catalog=kullanicislem;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand guncelle = new SqlCommand("Update islem Set tc_no=@tc_no,ad=@ad,soyad=@soyad,bölüm=@bölüm,doktor=@doktor,saat=@saat,tarih=@tarih where id=@p1",baglantii);
            guncelle.Parameters.AddWithValue("@tc_no", textBox1.Text);
            guncelle.Parameters.AddWithValue("@ad", textBox2.Text);
            guncelle.Parameters.AddWithValue("@soyad", textBox3.Text);
            guncelle.Parameters.AddWithValue("@bölüm", comboBox1.Text);
            guncelle.Parameters.AddWithValue("@doktor", comboBox2.Text);
            guncelle.Parameters.AddWithValue("@saat", comboBox3.Text);
            guncelle.ExecuteNonQuery();
            baglantii.Close();
            MessageBox.Show("güncelleme başarılı");

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kullanicislemDataSet.islem' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.islemTableAdapter.Fill(this.kullanicislemDataSet.islem);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.islemTableAdapter.Fill(this.kullanicislemDataSet.islem);   
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
