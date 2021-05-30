using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k1, k2, k3;
            k1 = Convert.ToInt32(textBox1.Text);
            k2 = Convert.ToInt32(textBox2.Text);
            k3 = Convert.ToInt32(textBox3.Text);
            ucgenbul(k1, k2, k3);

        }
        void ucgenbul(int a, int b, int c)
        {
            if (a == b && a == c)
                label5.Text = "EŞKENAR ÜÇGEN";
            else if (a != b && a != c)
                label5.Text = "ÇEŞİTKENAR ÜÇGEN";
            else
                label5.Text = "İKİZKENAR ÜÇGEN";


        }
    }

}
