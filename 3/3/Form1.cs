using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, toplam, fark, carpim, bolum;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            toplam = Convert.ToInt32(s1 + s2);
            fark = Convert.ToInt32(s1 - s2);
            carpim = Convert.ToInt32(s1 * s2);
            bolum = Convert.ToInt32(s1 / s2);
            label7.Text = Convert.ToString(toplam);
            label8.Text = Convert.ToString(fark);
            label9.Text = Convert.ToString(carpim);
            label10.Text = Convert.ToString(bolum);
        }
    }
}