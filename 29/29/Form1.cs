using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mesafe = Convert.ToInt32(textBox1.Text);
            int sure = Convert.ToInt32(textBox2.Text);
            hesapla(mesafe, sure);
            temizle();
        }
        void hesapla(int a,int b)
        {
            double hız = a / b;
            label4.Text = Convert.ToString(hız);
        }
        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
