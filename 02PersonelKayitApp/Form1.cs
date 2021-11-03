using _02PersonelKayitApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            personel.YasHesapla();
            lblYas.Text = personel.Yas.ToString();
            MessageBox.Show("Personel kayıt başarıyla yapıldı.");

            richTextBox1.Text =  personel.PersonelBilgileriniGetir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personels = new List<Personel>();
        }
    }



}
