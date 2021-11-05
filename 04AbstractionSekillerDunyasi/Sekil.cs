using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AbstractionSekillerDunyasi
{
    public abstract class Sekil
    {
        public abstract string Ad { get; }
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Color Renk { get; set; }
        public bool IciBoyaliMi { get; set; }

        public abstract double Alan();
        //Soyut bi kavram-yani hangi sekli hesaplayacağımızı bilemiyoruz??
        //Abstract yaparak asla newleyerek örnek oluşturamayız. ama değişken olarak oluştarabilirz.
        //Ovverride etmeden bu classı newleyemezsin!!!!!!!!!!!! etsen de newleyemezsin :D

        public abstract double Cevre();
        public abstract void Ciz(Graphics g);


        public override string ToString()
        {
            string dolgu = IciBoyaliMi ? "Var" : "Yok";
            return $"{Ad} X: {X}  |  Y: {Y}  |  Gen:{Genislik}  | Yuk:{Yukseklik}  |  Renk: {Renk}  |  Dolgu: {dolgu}  |  Alan: {Alan():n2}  |  Cevre:{Cevre():n2}";
        }


    }
}
