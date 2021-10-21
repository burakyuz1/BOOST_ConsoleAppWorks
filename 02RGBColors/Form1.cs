using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02RGBColors
{
    public partial class frmColor : Form
    {
        int R = 255, G = 0, B = 0;
        public frmColor()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(R, G, B);
            lblColor.Text = $"R : {R} G : {G} B : {B}";
        }
        private void tmrColorChange_Tick(object sender, EventArgs e)
        {
            if (R == 255 && G == 0 && B < 255)
                B++;
            if (R == 255 && G < 255 && B == 255)
                G++;
            if (G == 255 && B == 255 && R <= 255)
                R--;
            if (R == 0 && G <= 255 && B == 255)
                G--;
            if (G == 0 && B == 0 && R < 255)
                R++;
            if (R == 0 && G == 0 && B <= 255)
                B--;
            this.BackColor = Color.FromArgb(R, G, B);
            lblColor.Text = $"R : {R} G : {G} B : {B}";
        }

    }
}
