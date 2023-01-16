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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dolgu dolgu = new Dolgu();
            this.Hide();
            dolgu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         Tel  tel = new Tel();
            this.Hide();
            tel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kaplama kaplama = new Kaplama();
            this.Hide();
            kaplama.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Kanal kanal = new Kanal();
            this.Hide();
            kanal.Show();
        }
    }
}
