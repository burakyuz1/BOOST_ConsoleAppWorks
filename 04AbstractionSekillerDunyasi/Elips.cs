using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AbstractionSekillerDunyasi
{
    public class Elips : Sekil
    {
        public override string Ad => "Elips";
        public double YC1 => Genislik / 2.0;
        public double YC2 => Yukseklik / 2.0;


        public override double Alan()
        {
            return Math.PI * YC1 * YC2;
        }

        public override double Cevre()
        {
            return 2 * Math.PI * Math.Sqrt((YC1 * YC1 + YC2 * YC2) / 2);
        }

        public override void Ciz(Graphics g)
        {
            if (IciBoyaliMi)
            {
                Brush brush = new SolidBrush(Renk);
                g.FillEllipse(brush, X, Y, Genislik, Yukseklik);
            }
            else
            {
                Pen pen = new Pen(Renk);
                g.DrawEllipse(pen, X, Y, Genislik, Yukseklik);
            }
        }
    }
}
