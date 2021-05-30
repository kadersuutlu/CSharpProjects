using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                listBox2.Items.Add(listBox1.Items[i]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                listBox3.Items.Add(Int16.Parse(listBox1.Items[i].ToString()) * Int16.Parse(listBox2.Items[i].ToString()));
        }
    }
}
