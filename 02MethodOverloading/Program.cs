using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            YeniSatir("ÜÇGEN");
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                YeniSatir("*", i);
            }
            Console.WriteLine();
            int k = 5;
            for (int i = 0; i < k; i++)
            {
                YeniSatir("*", k);
            }

            for (int i = 1; i <= n; i++)
            {
                Yazdir(" ", n - i);
                YeniSatir("*", i);
            }

            Console.WriteLine("KÖŞEGEN");

            for (int i = 1; i <= n; i++)
            {
                YeniSatir("* ".PadLeft(i * 2), 1);
            }


            Console.ReadKey();
        }
        //bir methodun adı ve parametreler metot'un imzasını oluşturur
        // Aynı imzaya ait iki metot bulunamaz.
        // Bir sınıfta aynı isimde birden çok metot tanımlamya method overloading denir.
        static void Yazdir(string metin)
        {
            Console.Write(metin);
        }
        static void Yazdir(string metin, int adet) //Void -> İşçi metot
        {
            for (int i = 0; i < adet; i++)
            {
                Yazdir(metin);
            }
        }
        static void YeniSatir(string metin)
        {
            Yazdir(metin + Environment.NewLine);
        }
        static void YeniSatir(string metin, int adet)
        {
            Yazdir(metin, adet);
            Yazdir(Environment.NewLine);
        }
    }
}
