using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] { 3, 4, 5, 6, 7, 1, 2, 3, 4 };
            Console.WriteLine(Topla(dizi));
            Console.WriteLine(Topla(3, 4, 5, 6));
            Console.ReadKey();
        }
        static int Topla(params int[] dizi)
        {
            int toplam = 0;
            foreach (var sayi in dizi)
                toplam += sayi;
            return toplam;
        }
    }
}
