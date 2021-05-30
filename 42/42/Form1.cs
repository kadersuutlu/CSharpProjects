using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class ucgen
        {
            double kenar1, kenar2;
            public double Kenar1
            {
                get { return kenar1; }
                set { kenar1 = value; }
            }
            public double Kenar2
            {
                get { return kenar2; }
                set { kenar2 = value; }
            }
            public double alanhesapla()
            {
                return (kenar1*kenar2)/2;
            }
            public double cevrehesapla()
            {
                double hipotenus=Math.Sqrt(Math.Pow(kenar1,2)+Math.Pow(kenar2,2));
                return (kenar1 + kenar2 + hipotenus);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ucgen dikucgen = new ucgen();
            dikucgen.Kenar1 = Convert.ToInt32(textBox1.Text);
            dikucgen.Kenar2 = Convert.ToInt32(textBox2.Text);
            label4.Text = dikucgen.alanhesapla().ToString();
            label6.Text = dikucgen.cevrehesapla().ToString();
        }
    }
}
