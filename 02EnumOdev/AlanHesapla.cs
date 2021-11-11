using _02EnumOdev.Enums;
using System;

namespace _02EnumOdev
{
    public static class AlanHesapla
    {

        public static double Hesapla(this Tip tip, int kareKenar = 1, int dikdortgenKenar1 = 1, int diktortgenKenar2 = 1, int taban = 1, int yukseklik = 1, int yariCap = 1)
        {
            switch (tip)
            {
                case Tip.Kare:
                    return kareKenar * kareKenar;

                case Tip.Dikdortgen:
                    return dikdortgenKenar1 * diktortgenKenar2;

                case Tip.Ucgen:
                    return (taban * yukseklik) / 2;
                case Tip.Daire:
                    return (Math.PI) * yariCap * yariCap;
                default:
                    return 0;
            }

        }
    }
}
