using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AbstractionSekillerDunyasi
{
    public class Yazi : ICizilebilir
    {
        public Yazi()
        {

        }
        public Yazi(int x, int y, string metin, Font font, Color color)
        {
            X = x;
            Y = y;
            Metin = metin;
            Font = font;
            Color = color;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public string Metin { get; set; }
        public Color Color { get; set; }
        public Font Font { get; set; }

        public void Ciz(Graphics g)
        {
            Brush firca = new SolidBrush(Color); //fırca oluşturuldu
            g.DrawString(Metin, Font, firca, X, Y); //string yazması için (Boş alana) 

        }
        public override string ToString()
        {
            return $"{Metin} X: {X}  |  Y: {Y}  |  FontFamily:{Font.FontFamily}  | FontSize:{Font.Size}pt  |  Renk: {Color} ";
        }
    }
}
