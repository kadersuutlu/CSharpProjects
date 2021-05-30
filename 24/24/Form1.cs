using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox yeni = new ListBox();
            for (int i = 0; i <= listView1.Items.Count - 1; i++)
                yeni.Items.Add(listView1.Items[i].Text);
            if (yeni.Items.Contains(textBox1.Text) == false)
                listView1.Items.Add(textBox1.Text);
            else
                MessageBox.Show("Daha Önceden Eklenmiş Bilgi");
        }
    }
}
