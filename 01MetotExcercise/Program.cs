using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01MetotExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(4, 10));
            Console.ReadLine();
        }
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        public static void Topla(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            Console.WriteLine(sayi1 + sayi2 + sayi3 + sayi4);
        }
    }
}
