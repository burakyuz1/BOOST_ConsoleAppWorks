using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03StaticNonStatic
{
    internal class Kisi
    {

        public static int KisiAdet { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }


        public string TamAd()
        {
            return $"{Ad} {Soyad}";
        }

        public static string SoyadOner() //Burada nonstatic üyelere erişim yapamayız.
        {
            Random rnd = new Random();
            string unluler = "AEIİOÖUÜ";
            string unsuzler = "BCÇDFGHJKLMNPRSŞTYZ";

            return unluler[rnd.Next(unluler.Length - 1)] + "" + unsuzler[rnd.Next(unsuzler.Length - 1)].ToString().ToLower();

        }
    }
}
