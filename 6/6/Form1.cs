using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final;
            double ortalama;
            vize = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            ortalama = Convert.ToInt32(vize * 0.4 + final * 0.6);
            textBox3.Text = Convert.ToString(ortalama);
            if (ortalama >= 88)
            {
                MessageBox.Show("AA : Geçti");
            }
            else if(ortalama>=82)
            {
                MessageBox.Show("BA : Geçti");
            }
            else if(ortalama>=76)
            {
                MessageBox.Show("BB : Geçti");
            }
            else if(ortalama>=66)
            {
                MessageBox.Show("CB : Geçti");
            }
            else if(ortalama>=60)
            {
                MessageBox.Show("CC : Geçti");
            }
            else if(ortalama>=55)
            {
                MessageBox.Show("DC : Sorumlu Geçti");
            }
            else if(ortalama>=45)
            {
                MessageBox.Show("DD : Kaldı");
            }
            else if(ortalama>=30)
            {
                MessageBox.Show("FD : Kaldı");
            }
            else if(ortalama>=0)
            {
                MessageBox.Show("FF : Kaldı");
            }
       
        }
    }
}
