using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AbstractionNeGiyeyim
{
    public class WheatherCom : IHavaDurumu
    {
        public double SicaklikVer(string sehirAd) //Sehre göre hava sıcaklığı yollar. görevi tek bu
        {
            sehirAd = sehirAd.ToLower();
            switch (sehirAd)
            {
                case "ankara":
                    return 23;
                case "istanbul":
                    return 15;
                case "kars":
                    return 19;
                case "yakutistan":
                    return -9;
                case "kahire":
                    return 36;
                default:
                    return new Random().Next(-10, 35);
            }
        }
    }
}
