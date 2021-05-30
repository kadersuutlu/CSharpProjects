using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = Convert.ToInt32(textBox3.Text);
            if(s1>s2&&s1>s3)
            {
                textBox4.Text = "En büyük sayı: " + s1;
            }
            else if(s2>s1&&s2>s3)
            {
                textBox4.Text = "En büyük sayı: " + s2;
            }
            else
            {
                textBox4.Text = "En büyük sayı: " + s3;
            }
        }
    }
}
