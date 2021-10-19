using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02KararYapilari_IfOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
        bas:
            Console.WriteLine("Sınavdan alınan puan (0-100) : ");
            decimal puan = Convert.ToDecimal(Console.ReadLine());

            if (puan < 0 || puan > 100)
            {
                goto bas;
            }

            char harfNotu;

            if (puan <45 )
            {
                harfNotu = 'F';
            }
            else if (puan < 70)
            {
                harfNotu = 'D';
            }
            else if (puan < 80)
            {
                harfNotu = 'C';
            }
            else if (puan < 90)
            {
                harfNotu = 'B';
            }
            else
            {
                harfNotu = 'A';
            }

            Console.WriteLine($"Harf not : {harfNotu}");


            Console.ReadKey();
        }
    }
}
