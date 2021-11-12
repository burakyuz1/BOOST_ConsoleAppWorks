using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00IEnumerableOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblOrtalama.ForeColor = Color.Green;
            lblToplam.ForeColor = Color.Red;
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {

            Futbolcu[] futbolcular = new Futbolcu[]
            {
                new Futbolcu() {AdSoyad="Burak",FormaNo = 10 , Mevkii = Mevkii.Kaleci },
                new Futbolcu() {AdSoyad="Ali",FormaNo = 11 , Mevkii = Mevkii.Forvet },
                new Futbolcu() {AdSoyad="Veli",FormaNo = 1 , Mevkii = Mevkii.Defans },
                new Futbolcu() {AdSoyad="Can",FormaNo = 5 , Mevkii = Mevkii.OrtaSaha }
            };


            Takim takim = new Takim(futbolcular);

            foreach (var futbolcu in takim) //takım sınıfınıın içinde futbolcu dizisi olduğu için her döndüğümde bana futbolcu yolladı.
                                            //futbolcunun ToString() 'i override ettiğim için de içindekileri listeye yazdırabildim.
            {
                lstFutbolcular.Items.Add(futbolcu.ToString()); 
            }

            lblToplam.Text = takim.FutbolcuSayisi.ToString(); // futbolcu sayısı yazdırma.
            lblOrtalama.Text = takim.OrtalamaHesapla().ToString();

        }
    }
}
