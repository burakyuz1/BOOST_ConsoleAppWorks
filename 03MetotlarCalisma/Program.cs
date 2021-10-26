using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MetotlarCalisma
{
    class Program
    {
        static void Main(string[] args)
        {

            //Metotlar classlar içine tanımlanır.
            // Bir metotta olmazsa olmazlar : Geri Dönüş tipi, Metot Adı,
            Console.Write("Kenar 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kenar 2: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hipotenus: {Hipo(a, b)}");
            for (int i = 1; i <= 5; i++)
            {
                KereYaz("*", i);
                YeniSatir();
            }
            Console.ReadKey();
        }

        static double Hipo(double k1, double k2) //Parametre alan Değer döndüren
        {
            return Math.Sqrt(k1 * k1 + k2 * k2);
        }

        static void KereYaz(string metin, int adet)
        {
            for (int i = 0; i < adet; i++)
            {
                Console.Write(metin);

            }
        }
        static void YeniSatir()
        {
            Console.WriteLine();
        }
    }
}
