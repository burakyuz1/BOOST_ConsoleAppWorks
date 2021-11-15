using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BatikentSuDeposu
{
    internal class Depo
    {
        public event EventHandler<DepoDolduEventArgs> DepoDoldu; //Eventlarda asla parantez aç kapa ya-pıl-maz!
        public Depo(int kapasite)
        {
            Kapasite = kapasite;
        }
        public int Kapasite { get; private set; }
        public int Miktar { get; private set; }
        public decimal DolulukOrani => Miktar / (decimal)Kapasite;


        public void SuEkle(int miktar)
        {
            Miktar += miktar;

            if (Miktar>= Kapasite)
            {
                int tasanMiktar = Miktar - Kapasite;
                Miktar = Kapasite;
                if(DepoDoldu != null)
                {
                    DepoDoldu(this, new DepoDolduEventArgs(tasanMiktar));
                }
            }


        }


    }
}
