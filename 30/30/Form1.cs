using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string metin;
        private void button1_Click(object sender, EventArgs e)
        {
            char[] karakter;
            byte[] numara;
            metin = textBox1.Text;
            karakter = metin.ToCharArray();
            numara = System.Text.Encoding.UTF8.GetBytes(karakter);
            for (int i = 0; i < karakter.Length; i++)
                listBox1.Items.Add(karakter[i] + "=" + numara[i]);
         
        }
    }
}
