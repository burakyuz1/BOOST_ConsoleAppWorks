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
    public partial class NokiaForm : Form
    {
            Nokia nokia = new Nokia();
        public NokiaForm()
        {
            InitializeComponent();
            nokia.Id = 1;
            nokia.Brand = "Nokia";
            nokia.Model = "3310";
            nokia.UnitPrice = 22.33m;
            lblNokia.Text = nokia.ToString();
            nokia.PlaySound();
        }

        private void NokiaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            nokia.StopSound();
        }
    }
}
