﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1, r2,rt;
            r1 = Convert.ToDouble(textBox1.Text);
            r2 = Convert.ToDouble(textBox2.Text);
            if(radioButton1.Checked)
            {
                rt = r1 + r2;
            }
            else
            {
                rt = (r1 * r2) / (r1 + r2);
            }
            label4.Text = rt + " ohm";
        }
    }
}
