using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Count.ToString();
            listBox2.Items.Count.ToString();
            string metin = textBox1.Text;
            int sayi = metin.Length;
            for (int i = 0; i <= sayi - 1; i++)
            {
                
                char harf = Convert.ToChar(metin.Substring(i, 1));
                if (harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'o' || harf == 'ö' || harf == 'u'
                    || harf == 'ü' || harf == 'A' || harf == 'E' || harf == 'I' || harf == 'İ' || harf == 'O' ||
                    harf == 'Ö' || harf == 'U' || harf == 'Ü')
                    listBox1.Items.Add(harf);
                else
                    listBox2.Items.Add(harf);
                
            }
        }
    }
}
