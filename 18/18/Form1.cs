using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18
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
            int adet = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if ((i % 3 == 0) && (i % 7 == 0))
                {
                    listBox1.Items.Add(i);
                    toplam += i;
                    adet++;
                }
            }
            textBox1.Text = ("Sayıların toplamı=" + toplam+"\n\r" + "Sayıların adedi=" + adet);
        }
    }
}
