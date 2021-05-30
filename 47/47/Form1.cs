using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, enbuyuk = 0, sayac = 1;
            listBox1.Items.Clear();
            sayi = Int16.Parse(textBox1.Text);
            do
            {
                listBox1.Items.Add(sayi);
                if (sayi % 2 == 0)
                {
                    sayi = sayi / 2;
                }
                else
                {
                    sayi = sayi * 3 + 1;
                }
                if (sayi > enbuyuk) enbuyuk = sayi;
                sayac++;
            }
            while (sayi > 1);
            listBox1.Items.Add("1");
            textBox2.Text = sayac.ToString();
            textBox3.Text = enbuyuk.ToString();
        }
    }
}
