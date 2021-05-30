using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double maas = 0;
        double yıllıkartismiktarı = 0;
        double yıllıkartis = 0;
        int yil = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            maas = Convert.ToDouble(textBox1.Text);
            yıllıkartismiktarı = Convert.ToDouble(textBox2.Text);
            yil = Convert.ToInt32(textBox3.Text);
            for(int i=0;i<=yil;i++)
            {
                yıllıkartis = (maas / 100) * yıllıkartismiktarı;
                maas = maas + yıllıkartis;
            }
            label4.Text = Convert.ToString(yil) + " yıl sonunda" + " yıllık " + Convert.ToString(yıllıkartismiktarı) 
                + " % " + " artış ile "+ Convert.ToString(Math.Round(maas, 2)) + " TL alacaksınız.";
        }
    }
}
