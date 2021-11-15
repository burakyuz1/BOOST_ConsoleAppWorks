using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05BatikentSuDeposu
{
    public partial class Form1 : Form
    {
        Depo depo = new Depo(100);
        public Form1()
        {
            depo.DepoDoldu += Depo_DepoDoldu;
            InitializeComponent();
            pnlSu.Height = 0;

        }

        private void Depo_DepoDoldu(object sender, DepoDolduEventArgs e)
        {
            MessageBox.Show($"Depo taştı, tasan miktar: {e.TasanMiktar} ");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            depo.SuEkle((int)nmuSuMiktari.Value);
            pnlSu.Height = (int)(pnlDepo.Height * depo.DolulukOrani);

        }
    }
}
