using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class sayilar
        {
            private int sayi1;
            public int Sayi1
            {
                get { return sayi1; }
                set { sayi1 = value; }
            }
            private int sayi2;
        public int Sayi2
        {
            get { return sayi2; }
            set { sayi2 = value; }
        }
        private int sayi3;
        public int Sayi3
        {
            get { return sayi3; }
            set { sayi3 = value; }
        }
        
        }
        class toplama : sayilar
        {
            private int sonuc;
            public int Sonuc
            {
                get { return sonuc; }
                set { sonuc = value; }
            }
            public int topla()
            {
                sonuc = Sayi1 + Sayi2 + Sayi3;
                return sonuc;

            }
        }
        class ortalama : sayilar
        {
            private double sonuc;
            public double Sonuc
            {
                get { return sonuc; }
                set { sonuc = value; }
            }
            public double ortala()
            {
                sonuc = (Sayi1 + Sayi2 + Sayi3) / 3;
                return sonuc;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            toplama Toplama = new toplama();
            ortalama Ortalama = new ortalama();
            Toplama.Sayi1 = Int16.Parse(textBox1.Text);
            Toplama.Sayi2 = Int16.Parse(textBox2.Text);
            Toplama.Sayi3 = Int16.Parse(textBox3.Text);
            Ortalama.Sayi1 = Int16.Parse(textBox1.Text);
            Ortalama.Sayi2 = Int16.Parse(textBox2.Text);
            Ortalama.Sayi3 = Int16.Parse(textBox3.Text);
            label6.Text = Convert.ToString(Toplama.topla());
            label7.Text = Convert.ToString(Ortalama.ortala());
        }
    }
}
