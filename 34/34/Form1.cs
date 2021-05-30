using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saat = 0, gun=0, ucret = 0;
            string[] dizi1 = new string[30];
            string[] dizi2 = new string[30];
            dizi1 = comboBox2.Text.Split(' ');
            gun = dizi1[0].Length;
            dizi2 = comboBox1.Text.Split(' ');
            saat = dizi2[0].Length;
            if (radioButton1.Checked)
            {
                ucret = gun * 30 + saat * 5;
            }
            if (radioButton2.Checked)
            {
                ucret = gun * 80 + saat * 7;
            }
            label5.Text = ucret.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 23; i++)
                comboBox2.Items.Add(i + "saat");
            for (int i = 0; i <= 30; i++)
                comboBox1.Items.Add(i + "gün");
        }
    }
}
