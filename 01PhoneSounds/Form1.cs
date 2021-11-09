using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01PhoneSounds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDenemeAc_Click(object sender, EventArgs e)
        {
            string okunanDeger = txtOkunan.Text;
            //DenemeForm denemeForm = new DenemeForm(okunanDeger);

            //II. yöntem 
            DenemeForm denemeForm = new DenemeForm();
            denemeForm.OkunanDeger = "2. yöntem";
            DialogResult dr = denemeForm.ShowDialog();

            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Kapandı");
            }

        }
    }
}
