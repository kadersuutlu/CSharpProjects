using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28
{
    public partial class Form1 : Form
    {
        double ödenecek = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ürünfiyat = Convert.ToDouble(textBox2.Text);
            double ürünsonfiyat = 0;
            if (radioButton1.Checked == true)
                ürünsonfiyat =Math.Round( ürünfiyat - (ürünfiyat * 0.05),2);
            else if (radioButton2.Checked == true)
                ürünsonfiyat =Math.Round( ürünfiyat - (ürünfiyat * 0.1),2);
            else if (radioButton3.Checked == true)
                ürünsonfiyat = ürünfiyat;
            ödenecek += ürünsonfiyat;
            listBox1.Items.Add(textBox1.Text + " " + ürünsonfiyat + "TL");
            textBox3.Text = ödenecek + " TL";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox3.Clear();
            ödenecek = 0;
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
