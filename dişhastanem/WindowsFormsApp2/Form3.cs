using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
       

        public Form3()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm4 = new Form5();
            this.Hide();
            frm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            this.Hide();
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            this.Hide();
            frm6.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            this.Hide();
            frm8.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            this.Hide();
            frm7.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hakkımızda hak = new hakkımızda();
            this.Hide();
            hak.Show();
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
           tedavi frm9 = new tedavi();
            this.Hide();
            frm9.Show();
        }

        private void ilt_Click(object sender, EventArgs e)
        {
            iletisim ilt = new iletisim();
            this.Hide();
            ilt.Show();
        }
    }
}
