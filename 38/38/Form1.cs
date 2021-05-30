using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tutulansayi, sayac;

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                label3.Text = "Sayı giriniz:";
            }
            else
            {
                int girilensayi = int.Parse(textBox1.Text);
                if(girilensayi<tutulansayi)
                {
                    label3.Text = "Yukarı";
                    sayac--;
                }
                else if(girilensayi>tutulansayi)
                {
                    label3.Text = "Aşağı";
                    sayac--;
                }
                else
                {
                    label3.Text = "Tebrikler Kazandınız.";
                    button2.Enabled = false;
                }
            }
            label1.Text = sayac.ToString();
            if(sayac==0)
            {
                button2.Enabled = false;
                label3.Text = "Oyun Bitti Kaybettiniz...\n Sayı" + tutulansayi + "dı.";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            tutulansayi = rastgele.Next(0, 1000);
            sayac = 10;
            label1.Text = sayac.ToString();
            label3.Text = "";
            textBox1.Text = "";
            button2.Enabled = true;
        }
    }
}
