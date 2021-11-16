using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Araç sınıfı tanımlayınız ve aracın hızı 82 değerini geçtiğinde


namespace _00AracCezaApp
{
    public partial class Form1 : Form
    {
        Arac arac = new Arac();
        public Form1()
        {
            arac.Plaka = "06 AA 123";
            arac.HizGecti += Arac_HizGecti;
            InitializeComponent();
        }
        private void Arac_HizGecti(object sender, HizGectiEventArgs e)
        {
            Arac aracGelen = (Arac)sender;
            txtAracToplamCeza.Text = $"HIZ LİMİTİNİ AŞTINIZ. \r\nPlakanız: {aracGelen.Plaka} \r\nBorcunuz: {aracGelen.ToplamCeza} \r\nCeza Yediğin Tarih: {e.Tarih.ToShortDateString()}" ;
        }

        private void nmuAracAnlikHiz_ValueChanged(object sender, EventArgs e)
        {
            arac.Hizlan((int)nmuAracAnlikHiz.Value);
        }
    }
}
