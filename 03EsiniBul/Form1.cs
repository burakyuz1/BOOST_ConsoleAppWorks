using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//$₺€¥₾₽₪₦
namespace _03EsiniBul
{
    public partial class Form1 : Form
    {
        List<Button> buttonlar = new List<Button>();
        char[] sembollerKarisik;
        List<Button> aciklar = new List<Button>();
        int kapananAdet = 0;
        public Form1()
        {
            InitializeComponent();
            string semboller = "$₺€¥₾₽₪₦$₺€¥₾₽₪₦";
            char temp;
            sembollerKarisik = semboller.ToCharArray();

            for (int i = 0; i < 16; i++)
            {
                Random rnd = new Random();
                int talihliIndex = rnd.Next(i, 16);
                temp = sembollerKarisik[i];
                sembollerKarisik[i] = sembollerKarisik[talihliIndex];
                sembollerKarisik[talihliIndex] = temp;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if (aciklar.Contains(tiklanan)) return; // zaten açıksa metottan çık

            if (aciklar.Count == 2) // önceden açık olan 2 adet kart varsa, kapat
                AcikKartlariKapat();

            // tıklanan kartın sembolünü göster
            aciklar.Add(tiklanan);
            int i = buttonlar.IndexOf(tiklanan);
            tiklanan.Text = sembollerKarisik[i].ToString();

            // eğer 2. kart açıldıysa ve aynıysa
            if (aciklar.Count == 2 && aciklar[0].Text == aciklar[1].Text)
            {
                Refresh();
                Thread.Sleep(500);
                AcikKartlariKapatVeGizle();
                kapananAdet += 2;
            }

            // hiç görünen kart kalmadıysa
            if (kapananAdet == 16)
            {
                btnTekrarOyna.Visible = true;
            }

        }

        private void AcikKartlariKapatVeGizle()
        {
            foreach (Button button in aciklar)
            {
                button.Text = "";
                button.Hide();
            }
            aciklar.Clear();
        }

        private void AcikKartlariKapat()
        {
            foreach (Button button in aciklar)
            {
                button.Text = "";
            }
            aciklar.Clear();
        }

        private void btnTekrarOyna_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            ButonlariOlustur();
            btnTekrarOyna.Visible= false;

        }

        private void ButonlariOlustur()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(45, 45);
                    btn.Left = j * 50;
                    btn.Top = i * 50;
                    buttonlar.Add(btn);
                    Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }
    }
}
