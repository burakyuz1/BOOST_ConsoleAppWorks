using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00AracCezaApp
{
    public class Arac
    {
        public event EventHandler<HizGectiEventArgs> HizGecti;

        public int Hiz { get; set; }
        public string Plaka { get; set; }
        public decimal ToplamCeza { get; private set; }

        public void Hizlan(int hiz)
        {
            Hiz = hiz;

            if (Hiz >= 130)
            {
                ToplamCeza = 175;
                if (HizGecti != null) HizGecti(this, new HizGectiEventArgs(DateTime.Now));
            }
            else if (Hiz >= 110)
            {
                ToplamCeza = 150;
                if (HizGecti != null) HizGecti(this, new HizGectiEventArgs(DateTime.Now));
            }
            else if (Hiz >= 80)
            {
                ToplamCeza = 100;
                if (HizGecti != null) HizGecti(this, new HizGectiEventArgs(DateTime.Now));
            }


        }
    }
}
