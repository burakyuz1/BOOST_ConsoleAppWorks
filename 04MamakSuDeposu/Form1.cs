using System.Windows.Forms;

namespace _04MamakSuDeposu
{
    public partial class Form1 : Form
    {
        SuDeposu depo = new SuDeposu(100);
        public Form1()
        {
            depo.DepoDoldu += Depo_DepoDoldu;
            InitializeComponent();
            pnlSu.Height = 0;
        }

        private void Depo_DepoDoldu(int tasan)
        {
            SuSeviyesiniGuncelle();
            MessageBox.Show("Depo Doldu, taşan miktar: " + tasan.ToString() + "LT");
        }

        private void btnEkle_Click(object sender, System.EventArgs e)
        {
            depo.SuEkle((int)(nmuSuMiktari.Value));
            SuSeviyesiniGuncelle();
        }

        private void SuSeviyesiniGuncelle()
        {
            pnlSu.Height = (int)(pnlDepo.Height * depo.DolulukOrani);
        }
    }
}
