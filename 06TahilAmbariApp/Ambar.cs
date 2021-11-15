using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06TahilAmbariApp
{
    internal class Ambar
    {
        public event DepoDolmaOlayIsleyici DepoDoldu; //Event tanımlanırken parantez aç/kapa yapılmaz.
        public Ambar(int kapasite)
        {
            Kapasite = kapasite;
        }

        public int Kapasite { get; set; }
        public int Miktar { get; set; }
        public double DolulukOrani => Miktar / Kapasite;

        public void TahilEkle(int tahilMiktar)
        {
            Miktar += tahilMiktar;
            if (Miktar>= Kapasite)
            {
                int tasanMiktar = Miktar - Kapasite;
                DepoDoldu(tasanMiktar);
            }
        }

    }
}
