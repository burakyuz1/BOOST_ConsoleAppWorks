using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01YasHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //        [10:42]
        //        Galip Yıldız(BilgeAdam Boost)
        //19 Şubat 20 Mart BALIK

        //[10:42] Galip Yıldız(BilgeAdam Boost)
        //21 Mart 20 Nisan KOÇ

        //[10:42] Galip Yıldız(BilgeAdam Boost)
        //21 Nisan 20 Mayıs BOĞA

        //[10:43] Galip Yıldız(BilgeAdam Boost)
        //21 Mayıs 21 Haziran İkizler

        //[10:43] Galip Yıldız(BilgeAdam Boost)
        //22 Haziran 22 Temmuz Yengeç

        //[10:43] Galip Yıldız(BilgeAdam Boost)
        //23 Temmuz 22 Ağustos Aslan

        //[10:43] Galip Yıldız(BilgeAdam Boost)
        //23 Ağustos 22 Eylül Başak

        //[10:43] Galip Yıldız(BilgeAdam Boost)
        //23 Eylül 23 Ekim Terazi

        //[10:43] Galip Yıldız(BilgeAdam Boost)
        //24 Ekim 22 Kasım Akrep

        //[10:43] Galip Yıldız(BilgeAdam Boost)
        //23 Kasım 21 Aralık Yay


        private void btnHesapla_Click(object sender, EventArgs e)
        {
         
            DateTime dt = new DateTime();
            int yas = DateTime.Now.Year - dtpTarih.Value.Year;
            lblYas.Text = yas.ToString(); //Yaş hesaplama

            dt = dtpTarih.Value;
            TimeSpan ts = DateTime.Now - dt;


            int yasanilanGun = (int)ts.TotalDays; //yaşanılan gün hesaplama
            lblGun.Text = yasanilanGun.ToString();

            int ay = dtpTarih.Value.Month;
            int gun = dtpTarih.Value.Day;

            #region Burc Sorgulama
            if ((ay == 1 && gun >= 21) || (ay == 2 && gun <= 18))
                lblBurc.Text = "KOVA";
            if ((ay == 2 && gun >= 19) || (ay == 3 && gun <= 20))
                lblBurc.Text = "BALIK";
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
                lblBurc.Text = "KOÇ";
            if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 20))
                lblBurc.Text = "BOĞA";
            if ((ay == 5 && gun >= 21) || (ay == 6 && gun <= 21))
                lblBurc.Text = "İKİZLER";
            if ((ay == 6 && gun >= 22) || (ay == 7 && gun <= 22))
                lblBurc.Text = "YENGEÇ";
            if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
                lblBurc.Text = "ASLAN";
            if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22))
                lblBurc.Text = "BAŞAK";
            if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22))
                lblBurc.Text = "TERAZİ";
            if ((ay == 10 && gun >= 24) || (ay == 11 && gun <= 22))
                lblBurc.Text = "AKREP";
            if ((ay == 11 && gun >= 23) || (ay == 12 && gun <= 21))
                lblBurc.Text = "YAY";


            if ((ay == 12 && gun >= 22) || (ay == 01 && gun <= 20))
                lblBurc.Text = "OĞLAK";

            #endregion

            //Form Renkleri değşitirme
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;

            double kacCuma = yasanilanGun / 7.0;
            lblCuma.Text = (Math.Round(kacCuma)).ToString();
            tmrShow.Start();

        }

        private void btnHesapla_MouseHover(object sender, EventArgs e)
        {

            if (btnHesapla.BackColor == Color.White)
            {
                btnHesapla.BackColor = Color.Red;
                btnHesapla.ForeColor = Color.White;
            }
            else
            {
                btnHesapla.BackColor = Color.White;
                btnHesapla.ForeColor = Color.Red;
            }

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            int yas = DateTime.Now.Year - dtpTarih.Value.Year;
            lblYas.Text = yas.ToString(); //Yaş hesaplama

            dt = dtpTarih.Value;
            TimeSpan ts = DateTime.Now - dt;


            int yasanilanGun = (int)ts.TotalDays; //yaşanılan gün hesaplama
            lblGun.Text = yasanilanGun.ToString();

            int ay = dtpTarih.Value.Month;
            int gun = dtpTarih.Value.Day;

            #region Burc Sorgulama
            if ((ay == 1 && gun >= 21) || (ay == 2 && gun <= 18))
                lblBurc.Text = "KOVA";
            if ((ay == 2 && gun >= 19) || (ay == 3 && gun <= 20))
                lblBurc.Text = "BALIK";
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
                lblBurc.Text = "KOÇ";
            if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 20))
                lblBurc.Text = "BOĞA";
            if ((ay == 5 && gun >= 21) || (ay == 6 && gun <= 21))
                lblBurc.Text = "İKİZLER";
            if ((ay == 6 && gun >= 22) || (ay == 7 && gun <= 22))
                lblBurc.Text = "YENGEÇ";
            if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
                lblBurc.Text = "ASLAN";
            if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22))
                lblBurc.Text = "BAŞAK";
            if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22))
                lblBurc.Text = "TERAZİ";
            if ((ay == 10 && gun >= 24) || (ay == 11 && gun <= 22))
                lblBurc.Text = "AKREP";
            if ((ay == 11 && gun >= 23) || (ay == 12 && gun <= 21))
                lblBurc.Text = "YAY";


            if ((ay == 12 && gun >= 22) || (ay == 01 && gun <= 20))
                lblBurc.Text = "OĞLAK";

            #endregion
        }

    
    }
}
