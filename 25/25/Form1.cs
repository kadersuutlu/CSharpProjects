using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int x=1;x<100;x++)
            {
                for(int y=1;y<100;y++)
                {
                    for(int z=1;z<100;z++)
                    {
                        if ((Math.Pow(z, 2) == Math.Pow(x, 2) + Math.Pow(y, 2)) && (x < y))
                            listBox1.Items.Add(x.ToString() + "-" + y.ToString() + "-" + z.ToString());
                    }
                }
            }
        }
    }
}
