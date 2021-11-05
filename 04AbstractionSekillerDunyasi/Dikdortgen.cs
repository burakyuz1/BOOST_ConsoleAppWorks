using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AbstractionSekillerDunyasi
{
    public class Dikdortgen : Sekil
    {
        public override string Ad => "Dikdörtgen";
        //public override string Ad { get {return "Dikdörtgen" } } -> KLASIK YONTEM, YUKARIDAKIYLE AYNI GOREVDE

        public override double Alan()
        {
            return Genislik * Yukseklik;
        }

        public override double Cevre()
        {
            return 2 * (Genislik + Yukseklik);
        }

        public override void Ciz(Graphics g)
        {
            if (IciBoyaliMi)
            {
                Brush brush = new SolidBrush(Renk);
                g.FillRectangle(brush, X, Y, Genislik, Yukseklik);
            }
            else
            {
                Pen pen = new Pen(Renk);
                g.DrawRectangle(pen, X, Y, Genislik, Yukseklik);
            }
        }
    }
}
