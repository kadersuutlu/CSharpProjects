using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void notortalamasi(string a,int b, int c, int d)
        {
            double ort;
            ort = (b + c + d) / 3;
            listBox1.Items.Add(a);
            listBox2.Items.Add(ort);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string dersadi = textBox1.Text;
            int yazili1 = Convert.ToInt32(textBox2.Text);
            int yazili2 = Convert.ToInt32(textBox3.Text);
            int yazili3 = Convert.ToInt32(textBox4.Text);
            notortalamasi(dersadi, yazili1, yazili2, yazili3);
        }
    }
}
