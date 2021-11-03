using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05TelefonRehberi
{
    //Arama özelliği
    public partial class Form1 : Form
    {
        BindingList<Kisi> kisiler = new BindingList<Kisi>()
        {
            new Kisi("Burak","Akyüz","(506) 844-2874"),
            new Kisi("Ali","Yıldız","(505) 655-6521")
        };

        public Form1()
        {
            InitializeComponent();
            dgvKisiListesi.DataSource = kisiler;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = mtxTelNo.Text;
            if (ad=="")
            {
                MessageBox.Show("Kisi alani zorunludur");
                return;
            }

            Kisi kisi = new Kisi()
            {
                Ad = ad,
                Soyad = soyad,
                Telefon = telefon
            };
            kisiler.Add(kisi);

            txtAd.Clear();
            txtSoyad.Clear();
            mtxTelNo.Clear();
        }
    }
}
