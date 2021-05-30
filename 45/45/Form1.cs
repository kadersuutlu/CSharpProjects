using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int degistirmedegiskeni = 0;
            if(sayi2<sayi1)
            {
                degistirmedegiskeni = sayi1;
                sayi1 = sayi2;
                sayi2 = degistirmedegiskeni;
            }
            int sonuc = 1;
            for(int i=sayi1+1;i<sayi2;i++)
            {
                for(int x=1;x<=i; x++)
                {
                    sonuc = sonuc * x;
                }
                listBox1.Items.Add(i.ToString() + " . Sayının faktöriyeli " + sonuc.ToString());
                sonuc = 1;
            }
        }
    }
}
