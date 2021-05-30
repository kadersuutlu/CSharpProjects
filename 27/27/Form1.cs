using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27
{
    public partial class Form1 : Form
    {
        double yaricap,cap,hacim;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cap = Convert.ToDouble(textBox1.Text);
            yaricap = cap / 2;
            double pi = 3.14;
            hacim = 4 * pi * (Math.Pow(yaricap, 3)) / 3;
            if (radioButton1.Checked)
                label3.Text = hacim.ToString() + "cm3";
            else
                label3.Text = hacim.ToString() + "m3";

        }
    }
}
