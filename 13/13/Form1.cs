using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int c = 0;
        List<TextBox> textboxlar = new List<TextBox>();

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox yenitext = new TextBox();
            c++;
            yenitext.Location = new System.Drawing.Point(20, 22 + (20 * c));
            yenitext.Size = new System.Drawing.Size(125, 25);
            this.Controls.Add(yenitext);
            textboxlar.Add(yenitext);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(TextBox textBox in textboxlar)
            {
                string value = textBox.Text;
                listBox1.Items.Add(value);
            }
        }
    }
}
