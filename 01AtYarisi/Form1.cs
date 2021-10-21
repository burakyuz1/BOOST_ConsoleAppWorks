using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnBasla_Click(object sender, EventArgs e)
        {
            tmrSayac.Start();

        }

        private void tmrYaris_Tick(object sender, EventArgs e)
        {
            pcbAt1.Left += rnd.Next(1, 50);
            pcbAt2.Left += rnd.Next(1, 50);
            pcbAt3.Left += rnd.Next(1, 50);
            if (pcbAt1.Right >= lblBitis.Left)
            {
                tmrYaris.Stop();
                if (MessageBox.Show($"Yarışı {pcbAt1.Tag}. At kazandı. \nYES: Tekrar oyna \nNO: Çıkış yap", "Yarış bitti!", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    AtlariHizayaGetir();
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (pcbAt2.Right >= lblBitis.Left)
            {
                tmrYaris.Stop();
                if (MessageBox.Show($"Yarışı {pcbAt2.Tag}. At kazandı. \nYES: Tekrar oyna \nNO: Çıkış yap", "Yarış bitti!", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    AtlariHizayaGetir();
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (pcbAt3.Right >= lblBitis.Left)
            {
                tmrYaris.Stop();
                if (MessageBox.Show($"Yarışı {pcbAt3.Tag}. At kazandı. \nYES: Tekrar oyna \nNO: Çıkış yap", "Yarış bitti!", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    AtlariHizayaGetir();
                }
                else
                {
                    Application.Exit();
                }


            }
        }

        void AtlariHizayaGetir()
        {
            pcbAt1.Location = new Point(23, 28);
            pcbAt2.Location = new Point(23, 142);
            pcbAt3.Location = new Point(23, 257);
        }
        int sayac = 4;
        private void tmrSayac_Tick(object sender, EventArgs e)
        {
            lblSayac.Visible = true;
            lblSayac.Text = (--sayac).ToString();
            if (sayac == 0)
            {
                sayac = 4;
                lblSayac.Visible = false;
                tmrSayac.Stop();
                tmrYaris.Start();
            }

        }
    }
}
