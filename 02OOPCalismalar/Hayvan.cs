using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OOPCalismalar
{
    internal class Hayvan
    {
        public string Tur { get; set; }
        public Hayvan() : this("hayvan31")
        {
            Tur = "Havan";
        }
        public Hayvan(string turAd)
        {
            Tur = turAd;
        }
    }

    internal class Maymun : Hayvan 
    {
        public Maymun() : base("maymun")
        {
           
        }
    }




}
