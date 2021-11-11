using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComperableTakim
{
    public partial class Form1 : Form
    {
        List<Takim> puanDurumu = new List<Takim>();
        bool adBuyuktenKucugeMi = true, puanBuyuktenKucugeMi = true, averajBuyuktenKucugeMi = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            puanDurumu.Add(new Takim() { TakimAdi = "Beşiktaş", Average = 13, Puani = 30 });
            puanDurumu.Add(new Takim() { TakimAdi = "Galatasaray", Average = 11, Puani = 27 });
            puanDurumu.Add(new Takim() { TakimAdi = "Z Fenerbahçe", Average = 10, Puani = 25 });
            puanDurumu.Add(new Takim() { TakimAdi = "Trabzonspor", Average = 14, Puani = 23 });
            puanDurumu.Add(new Takim() { TakimAdi = "Sivasspor", Average = 13, Puani = 22 });
            puanDurumu.Add(new Takim() { TakimAdi = "AnkaraGücü", Average = 20, Puani = 40 });

            puanDurumu.Sort();
            ListeDoldur();
        }

        private void ListeDoldur()
        {
            lstPuanDurumu.Items.Clear();
            int siralama = 1;
            foreach (var item in puanDurumu)
            {
                ListViewItem lvi = new ListViewItem(siralama.ToString());
                lvi.SubItems.Add(item.TakimAdi);
                lvi.SubItems.Add(item.Average.ToString());
                lvi.SubItems.Add(item.Puani.ToString());
                siralama++;
                lstPuanDurumu.Items.Add(lvi);

            }
            lstPuanDurumu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);


        }

        private void lstPuanDurumu_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 1:
                    if (adBuyuktenKucugeMi)
                    {
                        puanDurumu.Sort(new AdaGoreSirala());
                        adBuyuktenKucugeMi = false;
                    }
                    else
                    {
                        puanDurumu.Sort(new AdaGoreSiralaKucuktenBuyuge());
                        adBuyuktenKucugeMi = true;
                    }
                    break;


                case 2:
                    if (averajBuyuktenKucugeMi)
                    {
                        puanDurumu.Sort(new AverajaGoreBuyuktenKucuge());
                        averajBuyuktenKucugeMi = false;
                    }
                    else
                    {
                        puanDurumu.Sort(new AverajaGoreKucuktenBuyuge());
                        averajBuyuktenKucugeMi = true;
                    }

                    break;

                case 3:
                    if (puanBuyuktenKucugeMi)
                    {
                        puanDurumu.Sort();
                        puanBuyuktenKucugeMi = false;
                    }
                    else
                    {
                        puanDurumu.Sort(new PuanaGoreKucuktenBuyuge());
                        puanBuyuktenKucugeMi = true;
                    }
                    break;
            }
            ListeDoldur();
        }
    }
}
