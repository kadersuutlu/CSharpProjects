using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad, ders;
            int ogrno, derssaati;
            adsoyad = textBox1.Text;
            ogrno = Convert.ToInt32(textBox2.Text);
            ders = textBox3.Text;
            derssaati = Convert.ToInt32(textBox4.Text);
            listBox1.Items.Add("Ad-Soyad: " + adsoyad + "Öğrenci No: " + ogrno + 
                "Ders: " + ders + "Ders Saati: " + derssaati);
        }
    }
}
