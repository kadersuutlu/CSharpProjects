using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label15.Text = textBox1.Text;
            label11.Text = textBox2.Text;
            label14.Text = textBox3.Text;
            comboBox1.Items.Add(label13.Text);
            label12.Text = textBox4.Text;
        }
    }
}
     