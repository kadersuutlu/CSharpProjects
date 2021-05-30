using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string yeni = "";
            Random r = new Random();
            int randomındex = 0;
            int uzunluk = metin.Length;
            for(int i=uzunluk; i>0;i--)
            {
                randomındex = r.Next(0, uzunluk);
                yeni += metin[randomındex];
                metin = metin.Remove(randomındex, 1);
                uzunluk = metin.Length;
            }
            label1.Text = yeni;
        }
    }
}
