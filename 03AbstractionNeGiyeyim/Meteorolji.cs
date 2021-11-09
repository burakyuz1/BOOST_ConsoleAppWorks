using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AbstractionNeGiyeyim
{
    public class Meteorolji  : IHavaDurumu  //Her Meteoroloji aynı zamanda HavaDurumudur. POLIMORPHISM Farklı bir tür daha kazandı..!
    {
        public double SicaklikVer(string sehirAd)
        {
            sehirAd = sehirAd.ToLower();
            switch (sehirAd)
            {
                case "ankara":
                    return 21;
                case "istanbul":
                    return 17;
                case "kars":
                    return 13;
                case "yakutistan":
                    return -3;
                case "kahire":
                    return 30;
                default:
                    return new Random().Next(-5, 40);
            }
        }
    }
}
