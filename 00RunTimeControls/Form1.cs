using _00RunTimeControls.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00RunTimeControls
{
    public partial class Form1 : Form
    {
        Random rnnd = new Random();
        int siraNo;
        Label lbl = new Label();

        public Form1()
        {
            InitializeComponent();

            lbl.AutoSize = true;
            lbl.Font = new Font(FontFamily.GenericSansSerif, 16F);
            lbl.BackColor = Color.Black;
            lbl.ForeColor = Color.White;
            lbl.BorderStyle = BorderStyle.Fixed3D;
            lbl.Left = ClientSize.Width - lbl.Width + 40;
            lbl.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Controls.Add(lbl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pcb = new PictureBox();
            pcb.Image = Resources._63197899;
            pcb.Left = rnnd.Next(0, ClientSize.Width - lbl.Width - pcb.Width);
            pcb.Top = rnnd.Next(0, ClientSize.Height - lbl.Height - pcb.Height);
            pcb.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb.Width = 200;
            pcb.Height = 200;
            this.Controls.Add(pcb);
            this.Icon = Icon.FromHandle(Resources._63197899.GetHicon());
            pcb.Click += Pcb_Click;
            lbl.Text = ButtonVePictureAdetGetir().ToString();
        }

        private void Pcb_Click(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;
            Controls.Remove(pcb);
            lbl.Text = ButtonVePictureAdetGetir().ToString();
        }

        private void btnButonUret_Click(object sender, EventArgs e)
        {
            siraNo++;
            Button btn = new Button();
            btn.Size = new Size(45, 45);
            btn.Left = rnnd.Next(0, ClientSize.Width - btn.Width);
            btn.Top = rnnd.Next(0, ClientSize.Height - btn.Height);
            btn.Text = siraNo.ToString();
            Controls.Add(btn);
            btn.Click += Btn_Click;
            lbl.Text = ButtonVePictureAdetGetir().ToString();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklananButton = (Button)sender;
            tiklananButton.SendToBack();
            MessageBox.Show(tiklananButton.Text);
        }

        private int ButtonVePictureAdetGetir()
        {
            int sayac = 0;
            foreach (var item in this.Controls)
                if (item is Button || item is PictureBox)
                    sayac++;
            return sayac;


        }
    }
}
