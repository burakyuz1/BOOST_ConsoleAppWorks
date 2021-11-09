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
    public partial class DenemeForm : Form
    {
        public string OkunanDeger { get; set; }
        public DenemeForm()  //ctor1 -> non parameter
        {
            InitializeComponent();

        }
        public DenemeForm(string okunanDeger) //ctor2 -> Parameter  _can be extended or ctor either parameter
        {
            InitializeComponent();
            this.OkunanDeger = okunanDeger;
            lblOkunanDeger.Text = OkunanDeger;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            // this ile var olduğum sınıf içerisindeki prop lara erişebiliyorum
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void lblOkunanDeger_Click(object sender, EventArgs e)
        {
            lblOkunanDeger.Text = OkunanDeger;
        }
    }
}
