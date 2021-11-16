using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01KisiRehberi
{
    public partial class frmKisiEkle : Form
    {
        public frmKisiEkle()
        {
            InitializeComponent();

        }
        public Kisi KisiBilgileri { get; set; } = new Kisi();


        private void btnEkle_Click(object sender, EventArgs e)
        {
            KisiBilgileri.Ad = txtAd.Text;
            KisiBilgileri.Soyad = txtSoyad.Text;
            KisiBilgileri.Yas = Convert.ToInt32(txtYas.Text);

            this.Close();
        }

    }
}
