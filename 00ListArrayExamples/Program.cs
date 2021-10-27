using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00ListArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            //bir sayi listesi tanımlayınız. ve bu sayı listesine 6 adet sayı ekleyiniz ve ekrana yan yana yazdırınız.

            List<int> sayilar = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
                sayilar.Add(rnd.Next(0, 10));
            
            Console.WriteLine(string.Join(", ",sayilar));
            Console.WriteLine("Eleman sayısı: {0}",sayilar.Count);






            Console.ReadKey();

        }
    }
}
