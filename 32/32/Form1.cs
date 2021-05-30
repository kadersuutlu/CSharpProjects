using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int sayi = Int32.Parse(textBox1.Text);
            int birler = 0, onlar = 0, yuzler = 0, binler = 0;
            if (sayi < 10)
                birler = sayi;
            if(sayi>9&&sayi<100)
            {
                onlar = sayi / 10;
                birler = sayi - (onlar * 10);
            }
            if(sayi>99&&sayi<1000)
            {
                yuzler = sayi / 100;
                onlar = (sayi - (yuzler * 100)) / 10;
                birler = sayi - ((yuzler * 100) + (onlar * 10));
            }
            if(sayi>999&&sayi<10000)
            {
                binler = sayi / 1000;
                yuzler = (sayi - (binler * 1000)) / 100;
                onlar = (sayi - ((binler * 1000) + (yuzler * 100))) / 10;
            }
            string[] dbirler = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] donlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] dyuzler = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }; ;
            string[] dbinler = { "", "M", "MM", "MMM" };
            textBox2.Text += dbinler[binler] + " ";
            textBox2.Text += dyuzler[yuzler] + "";
            textBox2.Text += donlar[onlar] + " ";
            textBox2.Text += " " + dbirler[birler];
        }

       
    }
}
