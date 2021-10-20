using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03WFA_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            //Math Methodlarını kullanarak -> Perfect Square yap. ÖDEV..
            MessageBox.Show(txtAd.Text.Trim() + " " + txtSoyad.Text.Trim().ToUpper());
        }
    }
}
