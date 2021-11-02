using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04RecursiveExcercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            IcIceKareCiz(e.Graphics, 20, 20, 350);
        }
        void IcIceKareCiz(Graphics g, int x, int y, int kenarUzunluk)
        {
            if (kenarUzunluk <= 0) return;
            g.DrawRectangle(Pens.Black, x, y, kenarUzunluk, kenarUzunluk);
            IcIceKareCiz(g, x + 4, y + 4, kenarUzunluk - 8);
        }
    }
}
