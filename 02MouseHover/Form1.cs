using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02MouseHover
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int sansliSayi;
        bool oyunBittiMi;
        public Form1()
        {
            InitializeComponent();
            sansliSayi = rnd.Next(1, 101);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Text = (++sayac).ToString();
                    btn.Size = new Size(45, 45);
                    btn.Left = j * 50;
                    btn.Top = i * 50;
                    btn.BackColor = Color.White;
                    btn.MouseEnter += Btn_MouseEnter;
                    Controls.Add(btn);
                }
            }
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            if (oyunBittiMi) return;
            Button btn = (Button)sender;
            int butonSayi = Convert.ToInt32(btn.Text);
            if (sansliSayi == butonSayi)
            {
                oyunBittiMi = true;
                btn.BackColor = Color.Purple;
            }
            else
            {
                btn.Hide();
            }


        }
    }
}
