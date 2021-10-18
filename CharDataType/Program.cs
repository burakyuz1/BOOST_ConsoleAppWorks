using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharVeriTuru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //Özel karakterleri göstermek için
            char c1 = '\n'; //-> Enter
            char c2 = '☺';
            char c3 = '♣';
            char c4 = '•';
            char c5 = '¿';


            Console.WriteLine("{0}{1}{02}{3}{4}", c1, c2, c3, c4, c5);
            int sayi1 = 'A'; //implicit Conversion (Gizli çevirme)
            char harf = (char)66; // explicit conversion

            Console.WriteLine('C' - 'A'); //ASCII Kodlarını birbirinden çıkarıp işlem yapar : 2 : 

            for (int i = 65; i <= 90; i++)
            {
                Console.Write((char)i);
            }

            Console.ReadKey();

        }
    }
}
