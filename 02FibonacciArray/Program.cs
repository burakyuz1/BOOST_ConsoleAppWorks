using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FibonacciArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibSayilar = new int[20]; //20 odalı bir dizi(0'larla dolu default olarak)
            fibSayilar[0] = 0;
            fibSayilar[1] = 1;
            int toplam = 0;

            for (int i = 2; i < fibSayilar.Length; i++)
            {
                fibSayilar[i] = fibSayilar[i - 1] + fibSayilar[i - 2];
                Console.Write(fibSayilar[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
