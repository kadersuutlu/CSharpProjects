using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        double hacim, yaricap, yukseklik;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yaricap = Convert.ToDouble(textBox1.Text);
            yukseklik = Convert.ToDouble(textBox2.Text);
            double pi=3.14;
            hacim = pi * Math.Pow(yaricap, 2) * yukseklik;
            if (radioButton1.Checked)
                label4.Text = Math.Round(hacim, 2).ToString() + "santimetreküp";
            else
                label4.Text = Math.Round(hacim, 2).ToString() + "metreküp";
        }
    }
}
