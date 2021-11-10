using _02PhoneSoundsApp.Abstract;
using _02PhoneSoundsApp.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02PhoneSoundsApp
{
    public partial class Form1 : Form
    {
        bool tiklanmadi = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            BasePhone phone = new BasePhone();
            if (tiklanmadi)
            {
                phone.PlaySound();
                tiklanmadi = false;
                btnDefault.Text = "Playing...";
            }
            else
            {
                phone.StopSound();
                tiklanmadi = true;
                btnDefault.Text = "Default...";

            }
        }

        private void btnIphone_Click(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone();
            iphone.PlaySound();
            if (tiklanmadi)
            {
                iphone.PlaySound();
                tiklanmadi = false;
                btnIphone.Text = "Playing...";
            }
            else
            {
                iphone.StopSound();
                tiklanmadi = true;
                btnIphone.Text = "Iphone...";

            }
        }

        private void btnNokia_Click(object sender, EventArgs e)
        {
            NokiaForm nokiaForm = new NokiaForm();
            nokiaForm.ShowDialog();
        }

        private void btnSamsung_Click(object sender, EventArgs e)
        {
            //BasePhone samsung = new Samsung();
            IPlaySound samsung = new Samsung();
            Samsung x = (Samsung)samsung;
            samsung.PlaySound();

        }
    }
}
