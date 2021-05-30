using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string metin = textBox1.Text;
            string[] parcalar = metin.Split(' ');
            foreach(string parca in parcalar)
            {
                char[] yeni = parca.ToCharArray();
                Array.Reverse(yeni);
                if (string.Compare(parca, new string(yeni)).ToString() == "0") 
                    listBox1.Items.Add(parca);
            }
        }
    }
}
