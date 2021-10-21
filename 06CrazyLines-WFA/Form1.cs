using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06CrazyLines_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Random rnd = new Random();


        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red, rnd.Next(1, 4));
            int x1, y1, ilkX, ilkY;
            int x2 = rnd.Next(0, pnlCizim.Width);
            int y2 = rnd.Next(0, pnlCizim.Height);

            ilkX = x2;
            ilkY = y2;
            for (int i = 0; i < 7; i++)
            {
                x1 = rnd.Next(0, pnlCizim.Width);
                y1 = rnd.Next(0, pnlCizim.Height);

                e.Graphics.DrawLine(myPen, x2, y2, x1, y1);
                x2 = x1;
                y2 = y1;
            }
            e.Graphics.DrawLine(myPen, x2, y2, ilkX, ilkY);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            pnlCizim.Refresh();
        }

        private void btnAnimasyonBaslat_Click(object sender, EventArgs e)
        {
            if (tmrDraw.Enabled)
            {
                tmrDraw.Stop();
                btnAnimasyonBaslat.Text = "STOP ! ";
            }
            else
            {
                tmrDraw.Start();
                btnAnimasyonBaslat.Text = "START ANIMATION ! ";
            }
        }
        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            pnlCizim.Refresh();
        }
    }
}
