using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01WFAPasswordGenerator
{
    public partial class Form1 : Form

    {
        bool kucukHarfVarMi, buyukHarfVarMi, ozelKarakterVarMi, rakamVarMi;
        int sifreUzunlugu, sifreSayisi;
        string kopyalanmisMetin = "";

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (kopyalanmisMetin == "")
            {
                MessageBox.Show("Bir şifre seçin.");
            }
            else
            {
                Clipboard.SetText(kopyalanmisMetin);
                MessageBox.Show("Kopyalanan sifre: " + kopyalanmisMetin);
            }
        }

        private void rtbSifreAlani_SelectionChanged(object sender, EventArgs e)
        {
            kopyalanmisMetin = rtbSifreAlani.SelectedText;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {

            rtbSifreAlani.Text = "";
            kucukHarfVarMi = cbKucukHarf.Checked;
            buyukHarfVarMi = cbBuyukHarf.Checked;
            rakamVarMi = cbRakam.Checked;
            ozelKarakterVarMi = cbOzelKarakter.Checked;
            sifreUzunlugu = (int)nmuSifreUzunlugu.Value;
            sifreSayisi = (int)nmuSifreAdedi.Value;

            if (!(kucukHarfVarMi || buyukHarfVarMi || rakamVarMi || ozelKarakterVarMi))
            {
                MessageBox.Show("parametre seç");
            }
            string selectedChars = "";

            Uret(ref selectedChars, kucukHarfVarMi, 'a', 'z');
            Uret(ref selectedChars, buyukHarfVarMi, 'A', 'Z');
            Uret(ref selectedChars, rakamVarMi, '0', '9');
            Uret(ref selectedChars, ozelKarakterVarMi, '!', '/');

            rtbSifreAlani.Text = (Yazdir(selectedChars, sifreUzunlugu, sifreSayisi));
        }

        static string Yazdir(string selectedChar, int sifreUzunlugu, int sifreSayisi)
        {
            Random rnd = new Random();
            string tamSifre = "";
            for (int i = 0; i < sifreSayisi; i++) //Üretileni yazdırma
            {
                string sifre = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sifre += selectedChar[rnd.Next(selectedChar.Length)];
                }
                tamSifre += sifre + "\n";
            }
            return tamSifre;
        }
        static void Uret(ref string selectedChar, bool kriterler, char baslangic, char bitis)
        {
            if (kriterler)
            {
                for (char i = baslangic; i <= bitis; i++)
                    selectedChar += i;


            }


        }
    }
}
