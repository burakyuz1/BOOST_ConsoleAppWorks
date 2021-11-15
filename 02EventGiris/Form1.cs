using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02EventGiris
{
    public partial class Form1 : Form
    {
        private readonly Button btn1; // field
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
            btn1 = new Button();
            btn1.Text = sayac.ToString();
            btn1.Font = new Font("Times New Roman", 24f);
            btn1.Width = 100;
            btn1.Height = 50;
            btn1.Top = (ClientSize.Height - btn1.Height) / 2;
            btn1.Left = (ClientSize.Height - btn1.Height) / 2;
            btn1.Click += Tiklandiginda;
            btn1.MouseEnter += FareUzerineGeldi;
            btn1.MouseLeave += FareUzerindenAyrildi;
            Controls.Add(btn1);
        }

        private void FareUzerindenAyrildi(object sender, EventArgs e)
        {
            btn1.BackColor = Button.DefaultBackColor;
            btn1.ForeColor = Button.DefaultForeColor;
        }

        private void FareUzerineGeldi(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Red;
            btn1.ForeColor = Color.Blue;
        }

        void Tiklandiginda(object gonderen, EventArgs args)
        {
            
            btn1.Text = (++sayac).ToString();
        }
    }
}
