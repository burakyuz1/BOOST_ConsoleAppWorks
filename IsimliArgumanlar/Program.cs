using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsimliArgumanlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Selamla(soyad: "akyüz", ad: "burak");

            Console.ReadKey();
        }
        static void Selamla(string ad, string soyad)
        {
            Console.WriteLine($"Merhaba {ad} {soyad}");
        }
    }
}
