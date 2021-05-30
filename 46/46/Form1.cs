using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text.Trim();
            string[] kelimeler, virgul, nokta, soru;
            kelimeler = metin.Split(' ');
            virgul = metin.Split(',');
            nokta = metin.Split('.');
            soru = metin.Split('?');
            label3.Text = Convert.ToString(kelimeler.Length - 1);
            label5.Text = Convert.ToString(kelimeler.Length - 1);
            label7.Text = Convert.ToString(soru.Length - 1);
            label11.Text = Convert.ToString(textBox1.Text.Length);
            label9.Text = Convert.ToString(virgul.Length - 1);

        }
    }
}
