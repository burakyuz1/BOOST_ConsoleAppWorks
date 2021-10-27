using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04RefKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //REF veya VALUE Type farketmez. her türlü değişkenin kendisini gönderir metotun içine
            int a = 3;
            Arttir(a);
            Console.WriteLine(a);//3

            Arttir(ref a);
            Console.WriteLine(a);//4 -> DEĞİŞKENE BİZZAT GÖNDERİR.

            Console.ReadKey();
        }

        private static void Arttir(int a)
        {
            a++;
        }
        private static void Arttir(ref int a)
        {
            a++;
        }
    }
}
