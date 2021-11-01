using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02ListPractice
{
    public partial class Form1 : Form
    {
        List<string> kisiler;
        public Form1()
        {
            InitializeComponent();
            VerilerOku();
            KisileriListele();
        }

        private void VerilerOku()
        {
            try
            {
                string[] dizi = File.ReadAllLines("veri.txt");
                kisiler = dizi.ToList();
            }
            catch (Exception)
            {

                kisiler = new List<string>();
            }
        }

        Random rnd = new Random();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kisiler.Add(txtIsim.Text.Trim().ToUpper());
            txtIsim.Text = "";
            KisileriListele();
            this.ActiveControl = txtIsim; //-> Eklendikten sonra imlecin txt de kalmasını sağlar
            //txtIsim.Focus();  // OPSİYONEL

        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            int rastgeleKisi = rnd.Next(0, kisiler.Count);
            lblSansliKisi.Text = kisiler[rastgeleKisi];
        }

        private void btnKaristir_Click(object sender, EventArgs e)
        {
            List<string> yeniList = new List<string>();
            int adet = kisiler.Count;

            #region YONTEM I
            //string mevcut;
            //int talihliIndeks;

            //for (int i = 0; i < kisiler.Count - 1; i++)
            //{
            //    talihliIndeks = rnd.Next(0, kisiler.Count);
            //    mevcut = kisiler[i];
            //    kisiler[i] = kisiler[talihliIndeks];
            //    kisiler[talihliIndeks] = mevcut;
            //}

            //KisileriListele(); 
            #endregion

            for (int i = 0; i < adet; i++)
            {
                int rastgeleSayi2 = rnd.Next(0, kisiler.Count);
                yeniList.Add(kisiler[rastgeleSayi2]); //yeni listeye (rasgele indexli) asıl listeden eleman ekleme
                kisiler.Remove(kisiler[rastgeleSayi2]); //rastgele bulunan elemanı asıl listeden silme
            }

            lsbIsimler.Items.Clear(); //basmadan önce temizlik

            foreach (var item in yeniList)
            {
                lsbIsimler.Items.Add(item); //yeni listedeki elemanları listBox içine basma
                kisiler.Add(item); //tekrar basıldığında list boş kalmasın diye
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            KisileriListele();
        }

        private void txtIsim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEkle_Click(this, new EventArgs());  //ENTER tuşuna btnEkle_Click Eventi atama.
            }
        }
        private void KisileriListele()
        {
            lsbIsimler.Items.Clear();

            foreach (string kisi in kisiler)
            {
                lsbIsimler.Items.Add(kisi);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllLines("veri.txt", kisiler);
        }

        private void lsbIsimler_KeyDown(object sender, KeyEventArgs e)
        {
            int sid = lsbIsimler.SelectedIndex;
            if (e.KeyCode == Keys.Delete && sid != -1)
            {
                kisiler.RemoveAt(sid);
                KisileriListele();
                if (sid == 0)
                {
                    if (lsbIsimler.Items.Count > 0)
                        lsbIsimler.SelectedIndex = 0;
                }
                else
                {
                    if (sid == lsbIsimler.Items.Count)
                        lsbIsimler.SelectedIndex = sid - 1;
                    else
                        lsbIsimler.SelectedIndex = sid;
                }

            }
        }

        private void txtIsim_Click(object sender, EventArgs e)
        {
            txtIsim.Text = "";
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            int sid = lsbIsimler.SelectedIndex;

            if (sid > 0)
                Tasi(sid, 0);              
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            int sid = lsbIsimler.SelectedIndex;
            if (sid != kisiler.Count - 1 && sid > -1)
                Tasi(sid, kisiler.Count - 1);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int sid = lsbIsimler.SelectedIndex;
            if (sid > 0)
                Tasi(sid, sid - 1);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int sid = lsbIsimler.SelectedIndex;
            if (sid != kisiler.Count - 1 && sid > -1)
                Tasi(sid, sid + 1);
        }

        void Tasi(int secilenIndex, int hedefIndex)
        {
            string temp = kisiler[secilenIndex];
            kisiler.RemoveAt(secilenIndex);
            kisiler.Insert(hedefIndex, temp);
            KisileriListele();
            lsbIsimler.SelectedIndex = hedefIndex;
            lsbIsimler.Focus();
        }
    }
}
