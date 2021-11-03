using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05TelefonRehberi
{
    public class Kisi
    {
        public Kisi()
        {

        }
        public Kisi(string ad, string soyad, string telefon)
        {
            Ad = ad;
            Soyad = soyad;
            Telefon = telefon;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }


    }
}
