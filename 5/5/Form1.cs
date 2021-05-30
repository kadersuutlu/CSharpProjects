using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            cmbAylar.Items.Clear();
            cmbSayilar.Items.Clear();

            string[] Aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", 
                "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

            cmbAylar.Items.AddRange(Aylar);

            int[] AyNo = new int[12];
            for(int i=0;i<AyNo.Length;i++)
            {
                AyNo[i] = i + 1;
                cmbSayilar.Items.Add(AyNo[i]);
            }
        }
    }
}
