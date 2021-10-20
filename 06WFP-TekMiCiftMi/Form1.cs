using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06WFP_TekMiCiftMi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nmSayi_ValueChanged(object sender, EventArgs e)
        {
            int sayi = (int)nmSayi.Value;
            if (sayi % 2 == 0 )
            {
                lblSonuc.Text = "Çift";
                lblSonuc.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblSonuc.Text = "Tek";
                lblSonuc.ForeColor = Color.Red;

            }
        }
    }
}
