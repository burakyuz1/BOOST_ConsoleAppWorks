using _02PersonelKayitApp.Models;
using Newtonsoft.Json;
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

namespace _02PersonelKayitApp
{
    public partial class Form1 : Form
    {
        List<Personel> personels;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool cinsiyet;
            if (rdoErkek.Checked) cinsiyet = true;
            else cinsiyet = false;

            Personel personel = new Personel()
            {
                AdSoyad = txtAdSoyad.Text.Trim().ToUpper(),
                Birim = txtBirim.Text.Trim().ToUpper(),
                DogumTarihi = dtpDogumTarihi.Value,
                TcNO = txtBirim.Text.Trim(),
                Cinsiyet = cinsiyet,
            };

            lblYas.Text = personel.Yas.ToString();
            MessageBox.Show("Personel kayıt başarıyla yapıldı.");
            personels.Add(personel);
            nmuKayitNo.Maximum = personels.Count; //numericUpDown listenin boyutuna göre şekillendi.
            lblKayitSayisi.Text = personels.Count.ToString();
            Temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string jsonOkunan = File.ReadAllText("personels.json");
                personels = JsonConvert.DeserializeObject<List<Personel>>(jsonOkunan);
            }
            catch (Exception)
            {

                personels = new List<Personel>();
            }
            nmuKayitNo.Maximum = personels.Count; // Başlangıçta numericUpDown personel listemin boyutuna göre şekillendi.
            lblKayitSayisi.Text = personels.Count.ToString();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtBirim.Clear();
            txtTc.Clear();
            rdoErkek.Checked = true;
            dtpDogumTarihi.Value = DateTime.Now;
            lblYas.Text = "?";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (nmuKayitNo.Value == 0)
            {
                MessageBox.Show("Lütfen bir kayıt no seçin.");
                lblKayitGoruntule.Text = "";
            }
            else
            {
                int kayitNo = (int)nmuKayitNo.Value;
                lblKayitGoruntule.Text = personels[kayitNo - 1].PersonelBilgileriniGetir();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //JSON Serilization
            string json = JsonConvert.SerializeObject(personels); //json obj başladı.
            File.WriteAllText("personels.json", json);// bin/debug içine kayıt oldu.
        }
    }



}
