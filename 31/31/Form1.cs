using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i <= 100; i++)
                toplam += i;
            textBox1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i <= 100; i += 2)
                toplam += i;
            textBox2.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i <= 100; i += 2)
                toplam += i;
            textBox3.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for(int i=0;i<=100;i++)
            {
                if (i % 3 == 0 & i % 5 == 0)
                    toplam += i;
            }
            textBox4.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i <= 100; i++)
                toplam += i;
            toplam /= 100;
            textBox5.Text = toplam.ToString();
        }
    }
}
