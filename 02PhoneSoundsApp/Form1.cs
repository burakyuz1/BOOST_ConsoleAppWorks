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
            }
            else
            {
                phone.StopSound();
                tiklanmadi = true;
            }
        }
    }
}
