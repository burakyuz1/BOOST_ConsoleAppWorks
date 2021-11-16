using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Kişi Class'ı -> Ad - Soyad - Yaş props.
//Yeni kişi butonuna basıldığında yeni bir form açılacak ve form1'de oluşturulan listeye yeni bir kişi eklenecek
//DGW'nin dataSource'na liste verilecek ve her ekleme yapıldıktan sonra dgw'ye yansıyacak.
//cmb'da Ada göre sırala, ada göre tersten sırala, soyada göre ve soyada göre tersten, yaşa göre ve yaşa göre tersten sırala seçenekleri olacak ve her seçim değiştiğinde dgw'de değişecek.


namespace _01KisiRehberi
{
    public partial class Form1 : Form
    {
        List<Kisi> kisiler = new List<Kisi>() 
        {
            new Kisi(){ Ad="Ali",Soyad ="Yıldız",Yas = 20},
            new Kisi(){ Ad="Zehra",Soyad ="Duman",Yas = 22},
            new Kisi(){ Ad="Mustafa",Soyad ="Akın",Yas = 23},
            new Kisi(){ Ad="Süleyman",Soyad ="Doğan",Yas = 15},
            new Kisi(){ Ad="Kemal",Soyad ="Şahin",Yas = 5},
        };
        public Form1()
        {
            InitializeComponent();
            dgwKisiListesi.DataSource = kisiler;
        }

        private void btnYeniKisi_Click(object sender, EventArgs e)
        {

            frmKisiEkle frm = new frmKisiEkle();
            frm.ShowDialog();

            kisiler.Add(frm.KisiBilgileri);
            dgwKisiListesi.DataSource = null;
            dgwKisiListesi.DataSource = kisiler;
        }

        private void cmbKriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = cmbKriter.SelectedIndex;
            dgwKisiListesi.DataSource = null;
            switch (secim)
            {
                case 0:
                    dgwKisiListesi.DataSource = kisiler.OrderBy(x => x.Ad).ToList();
                    break;
                case 1:
                    dgwKisiListesi.DataSource = kisiler.OrderByDescending(x => x.Ad).ToList();
                    break;
                case 2:
                    dgwKisiListesi.DataSource = kisiler.OrderBy(x => x.Soyad).ToList();
                    break;
                case 3:
                    dgwKisiListesi.DataSource = kisiler.OrderByDescending(x => x.Soyad).ToList();
                    break;
                case 4:
                    dgwKisiListesi.DataSource = kisiler.OrderBy(x => x.Yas).ToList();
                    break;
                case 5:
                    dgwKisiListesi.DataSource = kisiler.OrderByDescending(x => x.Yas).ToList();
                    break;

                default:
                    MessageBox.Show("Lütfen Seçim yapınız.");
                    break;
            }
        }
    }
}
