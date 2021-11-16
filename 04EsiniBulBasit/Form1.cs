using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04EsiniBulBasit
{
    public partial class Form1 : Form
    {
        const string SYMBOL_POOL = "$₺€¥₾₽₪₦$₺€¥₾₽₪₦";
        char[] mixedSymbols = SYMBOL_POOL.ToCharArray();
        List<Button> buttons = new List<Button>();
        int clickCount = 0, successMatches = 0;
        List<Button> openedButton = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            CreateButtons();
            MixTheChars(ref mixedSymbols);
        }

        private void MixTheChars(ref char[] mixedSymbols)
        {
            Random rnd = new Random();
            int luckyNumber = 0;
            char temp;
            for (int i = 0; i < (mixedSymbols.Length); i++)
            {
                luckyNumber = rnd.Next(0, mixedSymbols.Length);
                temp = mixedSymbols[i];
                mixedSymbols[i] = mixedSymbols[luckyNumber];
                mixedSymbols[luckyNumber] = temp;
            }
        }

        private void CreateButtons()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(75, 75);
                    button.Left = j * 80;
                    button.Top = i * 80;
                    button.Font = new Font(FontFamily.GenericSerif, 16f);
                        buttons.Add(button);
                    pnlButtons.Controls.Add(button);
                    button.Click += Button_Click;
                }
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            clickCount++;
            Button clickedButton = (Button)sender;

            int index = buttons.IndexOf(clickedButton);
            clickedButton.Text = mixedSymbols[index].ToString();
            openedButton.Add(clickedButton);
            if (clickCount == 2 && openedButton[0] == openedButton[1])
            {
                clickCount = 0;
                HideTheText();
                openedButton.Clear();
                return;
            }

            if (clickCount == 2)
            {
                Refresh();
                Thread.Sleep(500);

                if (openedButton[0].Text == openedButton[1].Text)
                    HideTheButtons();

                if (openedButton[0] != openedButton[1])
                    HideTheText();

                openedButton.Clear();
                clickCount = 0;
            }
            if (successMatches == 16)
            {
                btnYeniden.Visible = true;
            }
        }

        private void HideTheButtons()
        {
            foreach (Button button in openedButton)
            {
                successMatches++;
                button.Text = "";
                button.Hide();
            }
        }


        private void HideTheText()
        {
            foreach (Button button in openedButton)
                button.Text = "";
        }
        private void btnYeniden_Click(object sender, EventArgs e)
        {
            pnlButtons.Controls.Clear();
            mixedSymbols = SYMBOL_POOL.ToCharArray();
            MixTheChars(ref mixedSymbols);
            buttons.Clear();
            CreateButtons();
            btnYeniden.Visible = false;
            successMatches = 0;
            openedButton.Clear();
        }
    }
}
