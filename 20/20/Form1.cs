using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
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
            int kackarakter = int.Parse(textBox1.Text);
            int kactane = int.Parse(textBox2.Text);
            char[] harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz".ToCharArray();
            Random rand = new Random();
            for(int i=1;i<=kactane;i++)
            {
                string kelime = "";
                for(int j=1;j<=kackarakter;j++)
                {
                    int harfnumarasi = rand.Next(0, harfler.Length - 1);
                    kelime += harfler[harfnumarasi];
                }
                listBox1.Items.Add(kelime);
            }
        }
    }
}
