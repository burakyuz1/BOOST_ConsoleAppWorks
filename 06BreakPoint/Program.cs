using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06BreakPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("SoyAd");
            string soyad = Console.ReadLine();

            string tamAd = ad + " " + soyad;
            Console.WriteLine($"Merhaba {tamAd}");
            Console.ReadKey();

        }
    }
}
