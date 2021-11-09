using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04AbstractionSekillerDunyasi
{
    public partial class Form1 : Form
    {
        BindingList<ICizilebilir> cizilebilirler = new BindingList<ICizilebilir>();
        public Form1()
        {
            InitializeComponent();
            lstSekiller.DataSource = cizilebilirler;
            cizilebilirler.ListChanged += Sekiller_ListChanged;
        }

        private void Sekiller_ListChanged(object sender, ListChangedEventArgs e)
        {
            pnlCizim.Refresh();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbTur.SelectedIndex == -1)
            {
                MessageBox.Show("Şeklin türünü seçmenidiniz");
                return;
            }
            string seklinAdi = (string)cmbTur.SelectedItem;

            Sekil s;//Abstract bir tür olduğu için newleyemem ama bu şekilde üretebilirim.

            if (seklinAdi == "Elips")
                s = new Elips();
            else
                s = new Dikdortgen();

            s.X = (int)nmuKonumX.Value;
            s.Y = (int)nmuKonumY.Value;
            s.Genislik = (int)nmuGenislik.Value;
            s.Yukseklik = (int)nmuYukseklik.Value;
            s.Renk = pboRenk.BackColor;
            s.IciBoyaliMi = chkIciBoyali.Checked;
            cizilebilirler.Add(s);


        }

        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            foreach (ICizilebilir cizilebilir in cizilebilirler)
            {
                cizilebilir.Ciz(e.Graphics);

            }
        }

        private void pboRenk_Click(object sender, EventArgs e)
        {
            cdiDolgu.ShowDialog();
            pboRenk.BackColor = cdiDolgu.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fdiYazi.ShowDialog();
        }

        private void pboMetinRenk_Click(object sender, EventArgs e)
        {
            DialogResult dr = cdiYazi.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pboMetinRenk.BackColor = cdiYazi.Color;
            }
        }

        private void btnMetinEkle_Click(object sender, EventArgs e)
        {
            //Yazi yazi = new Yazi((int)nmuMetinx.Value, (int)nmuMetiny.Value, txtMetin.Text, fdiYazi.Font, pboMetinRenk.BackColor);

            ICizilebilir yazi = new Yazi((int)nmuMetinx.Value, (int)nmuMetiny.Value, txtMetin.Text, fdiYazi.Font, pboMetinRenk.BackColor);

            cizilebilirler.Add(yazi);
        }
    }
}
