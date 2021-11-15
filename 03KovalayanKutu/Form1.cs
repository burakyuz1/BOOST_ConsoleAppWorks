using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03KovalayanKutu
{
    public partial class Form1 : Form
    {
        Point hedef;
        Point ball;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            hedef = e.Location;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillEllipse(Brushes.Black, ball.X, ball.Y, 50, 50);
        }

        private void tmrKovala_Tick(object sender, EventArgs e)
        {
            ball.X  = (ball.X + hedef.X) / 2;
            ball.Y = (ball.Y + hedef.Y) / 2;
            Refresh();

        }
    }
}
