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
        BindingList<Sekil> sekiller = new BindingList<Sekil>();
        public Form1()
        {
            InitializeComponent();
            lstSekiller.DataSource = sekiller;
            sekiller.ListChanged += Sekiller_ListChanged;
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
            sekiller.Add(s);
            
            
        }

        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            foreach (Sekil sekil in sekiller)
            {
                sekil.Ciz(e.Graphics);
                
            }
        }

        private void pboRenk_Click(object sender, EventArgs e)
        {
            cdiDolgu.ShowDialog();
            pboRenk.BackColor = cdiDolgu.Color;
        }
    }
}
