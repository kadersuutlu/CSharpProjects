using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50
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

        private void button1_Click(object sender, EventArgs e)
        {
            string tcno, adsoyad, cinsiyet="", egitim="", diller="", uzmanlık="";
            tcno = textBox1.Text;
            adsoyad = textBox2.Text;
            if(radioButton1.Checked==true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if(radioButton2.Checked==true)
            {
                cinsiyet = radioButton2.Text;
            }
            if(radioButton3.Checked)
            {
                egitim = radioButton3.Text;
            }
            else if(radioButton4.Checked)
            {
                egitim = radioButton4.Text;
            }
            else if(radioButton5.Checked)
            {
                egitim = radioButton5.Text;
            }
            else if(radioButton6.Checked)
            {
                egitim = radioButton6.Text;
            }
            if(checkBox5.Checked==true)
            
                diller = diller + "" + checkBox5.Text;
            
            if(checkBox5.Checked==true)
            
                diller = diller + "" + checkBox6.Text;
            
            if(checkBox7.Checked==true)
            
                diller = diller + "" + checkBox7.Text;
            
            if(checkBox8.Checked==true)
            
                diller = diller + "" + checkBox8.Text;
            
            if(checkBox9.Checked==true)
            
                diller = diller + "" + checkBox9.Text;
            
            if(checkBox10.Checked==true)
            
                diller = diller + "" + checkBox10.Text;
            
            diller = diller.Substring(1);
            if (checkBox11.Checked == true)
                uzmanlık = uzmanlık + "" + checkBox11.Text;
            if (checkBox12.Checked == true)
                uzmanlık = uzmanlık + "" + checkBox12.Text;
            if (checkBox13.Checked == true)
                uzmanlık = uzmanlık + "" + checkBox13.Text;
            if (checkBox14.Checked == true)
                uzmanlık = uzmanlık + "" + checkBox14.Text;
            if (checkBox15.Checked == true)
                uzmanlık = uzmanlık + "" + checkBox15.Text;
            if (checkBox16.Checked == true)
                uzmanlık = uzmanlık + "" + checkBox16.Text;
            uzmanlık = uzmanlık.Substring(1);
            listBox1.Items.Add("TC NO:" + tcno + "\tAD-SOYAD:" + adsoyad + "\tCİNSİYET:" + cinsiyet +"\tMEZUNİYET:"+egitim+ "\tDİLLER:" + diller + "\tUZMANLIK:" + uzmanlık);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}