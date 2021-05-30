using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49
{
    public partial class Form1 : Form
    { private int xPos = 0, yPos = 0;

        public string mode = "SoSa";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xPos = label1.Location.X;
            yPos = label1.Location.Y;
            mode = "SoSa";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mode == "SoSa")
            {
                if (this.Width == xPos)
                {
                    this.label1.Location = new System.Drawing.Point(0, yPos);
                    xPos = 0;
                }
                else
                {
                    this.label1.Location = new System.Drawing.Point(xPos, yPos);
                    xPos += 5;
                }
            } 
            else if(mode=="SaSo")
            {
                if(xPos==0)
                {
                    this.label1.Location = new System.Drawing.Point(this.Width, yPos);
                    xPos = this.Width;
                }
                else
                {
                    this.label1.Location = new System.Drawing.Point(xPos, yPos);
                    xPos -= 5;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xPos = label1.Location.X;
            yPos = label1.Location.Y;
            mode = "SaSo";
            timer1.Start();
        }
    }
}
