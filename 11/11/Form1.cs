using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if (sayi > 0)
            {
                MessageBox.Show("Girdiğiniz Sayı Pozitiftir.");
            }
            else if (sayi < 0)
            {
                MessageBox.Show("Girdiğiniz Sayı Negatiftir.");
            }
            else
                MessageBox.Show("Girdiğiniz Sayi Sıfırdır.");
                

        }
    }
}
