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
        public Form1()
        {
            InitializeComponent();
        }
    }
}
