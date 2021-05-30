using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad;
            int yas;
            adsoyad = textBox1.Text;
            yas = Convert.ToInt32(textBox2.Text);
            if(yas>=65)
            {
                textBox3.Text = "Yaşlı";
            }
            else if(25<yas && yas<65)
            {
                textBox3.Text = "Yetişkin";
            }
            else if(18<=yas && yas<=25)
            {
                textBox3.Text = "Genç";
            }
            else if(3<yas && yas<18)
            {
                textBox3.Text = "Çocuk";
            }
            else if(0<yas && yas<=3)
            {
                textBox3.Text = "Bebek";
            }


        }
    }
}
