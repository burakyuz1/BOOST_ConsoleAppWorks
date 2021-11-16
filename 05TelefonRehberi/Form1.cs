//using Newtonsoft.Json;
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

namespace _05TelefonRehberi
{
    //Arama özelliği
    public partial class Form1 : Form
    {
        BindingList<Kisi> kisiler;
        Kisi duzenlenen;

        public Form1()
        {
            VerileriOku();
            InitializeComponent();
            Listele();
        }

        private void VerileriOku()
        {
            try
            {
                string okunanVeri = File.ReadAllText("veri.json"); //Veriyi oku
                //kisiler = JsonConvert.DeserializeObject<BindingList<Kisi>>(okunanVeri); //Okuduğun veriyi listeye ekle
            }
            catch (Exception)
            {
                kisiler = new BindingList<Kisi>()
                {
                    new Kisi("Burak","a","(506) 844-2874"),
                    new Kisi("Mustafa","a","(535) 355-2874"),
                };
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = mtxTelNo.Text;
            if (ad == "")
            {
                MessageBox.Show("Kisi alani zorunludur");
                return;
            }
            if (duzenlenen == null)//ekle
            {
                Kisi kisi = new Kisi()
                {
                    Ad = ad,
                    Soyad = soyad,
                    Telefon = telefon
                };
                kisiler.Add(kisi);

            }
            else // düzenle
            {
                duzenlenen.Ad = ad;
                duzenlenen.Soyad = soyad;
                duzenlenen.Telefon = telefon;
                kisiler.ResetBindings();
                btnIptal.Hide();
                btnKaydet.Text = "Ekle";
                dgvKisiListesi.Enabled = true;
            }

            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKisiListesi.SelectedCells.Count == 0)
            {
                MessageBox.Show("Silinecek kişi bulunamadı.");
                return;
            }
            Kisi kisi = (Kisi)dgvKisiListesi.SelectedRows[0].DataBoundItem;
            kisiler.Remove(kisi);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvKisiListesi.SelectedCells.Count == 0)
            {
                MessageBox.Show("Güncellenecek kişi bulunamadı.");
                return;
            }
            duzenlenen = (Kisi)dgvKisiListesi.SelectedRows[0].DataBoundItem;
            txtAd.Text = duzenlenen.Ad;
            txtSoyad.Text = duzenlenen.Soyad;
            mtxTelNo.Text = duzenlenen.Telefon;
            btnIptal.Visible = true;
            btnKaydet.Text = "Kaydet";
            dgvKisiListesi.Enabled = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Temizle();
            duzenlenen = null;
            dgvKisiListesi.Enabled = true;
            btnIptal.Visible = false;
            btnKaydet.Text = "Ekle";
        }

        public void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            mtxTelNo.Clear();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            string ara = txtAra.Text.ToLower();
            if (string.IsNullOrEmpty(ara))
            {
                dgvKisiListesi.DataSource = kisiler;

            }
            else
            {
                List<Kisi> bulunanKisiler = new List<Kisi>();
                foreach (Kisi kisi in kisiler)
                {
                    if (kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.Telefon.ToLower().Contains(ara))
                    {
                        bulunanKisiler.Add(kisi);
                    }
                }
                dgvKisiListesi.DataSource = bulunanKisiler;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(kisiler); // listeyi json' obj içine aktar
            File.WriteAllText("veri.json", json);// aktardığın json u yazdır (veri.json dosyasının içine)
        }
    }
}
