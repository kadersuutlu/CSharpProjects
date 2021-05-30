using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = Convert.ToString(textBox1.Text);
            int madeti = Convert.ToInt32(textBox2.Text);
            for (int i = 1; i <= madeti; i++)
                listBox1.Items.Add(+i + "--" + mesaj);
        }
    }
}
