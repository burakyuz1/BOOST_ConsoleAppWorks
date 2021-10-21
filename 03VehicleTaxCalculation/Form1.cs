using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03VehicleTaxCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double fiyat = 0;
        private void btnHesapla_Click(object sender, EventArgs e) //////////////BURA
        {
            #region Radio Button Kontrol
            if (rdBinek.Checked == true)
            {
                fiyat += 100;
            }
            if (rdTicari.Checked == true)
            {
                fiyat += 150;
            }

            #endregion

            #region Yas Kontrol
            if (nmuYas.Value <= 3)
            {
                fiyat *= 1.75;
            }
            else if (nmuYas.Value < 7)
            {
                fiyat *= 1.50;
            }
            else
            {
                fiyat *= 1.25;
            }
            #endregion

            #region Motor Hacim Kontrol
            if (nmuMotorHacmi.Value <= 1300)
            {
                fiyat *= 2;
            }
            else if (nmuMotorHacmi.Value <= 1600)
            {
                fiyat *= 3;
            }
            else if (nmuMotorHacmi.Value <= 2000)
            {
                fiyat *= 4;
            }
            else
            {
                fiyat *= 5;
            }
            #endregion

            lblFiyat.Text = fiyat.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nmuMotorHacmi.Maximum = 8000m;
            nmuMotorHacmi.Minimum = 0;
            nmuYas.Maximum = 30m;
            nmuYas.Minimum = 1m;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            fiyat = 0;
            lblFiyat.Text = fiyat.ToString();
            rdBinek.Checked = false;
            rdTicari.Checked = false;
            nmuYas.Value = 1;
            nmuMotorHacmi.Value = 0;
        }
    }
}
