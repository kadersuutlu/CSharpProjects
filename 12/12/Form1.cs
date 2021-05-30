using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad_ilk_harf = textBox1.Text.Trim().ToLower().Substring(0, 1);
            string soyad = textBox2.Text.Replace(" ", " ").ToLower();
            string universite = textBox3.Text.ToLower().Replace("Üniversite", " ");
            universite = universite.Replace("üniversite", " ");
            universite = universite.Replace("üniv", " ");
            universite = universite.Replace("üni", " ");
            universite = universite.Replace(".", " ");
            universite = universite.Replace(" ", " ");
            string e_posta = ad_ilk_harf + "." + soyad + "@" + universite + ".edu.tr";
            e_posta = e_posta.Replace("ü", "u");
            e_posta = e_posta.Replace("ğ", "g");
            e_posta = e_posta.Replace("ı", "i");
            e_posta = e_posta.Replace("ş", "s");
            e_posta = e_posta.Replace("ç", "c");
            e_posta = e_posta.Replace("ö", "o");
            e_posta = e_posta.Replace(" ", " ");
            label5.Text = e_posta;
        }
    }
}
