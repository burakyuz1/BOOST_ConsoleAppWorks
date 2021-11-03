using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03OOPGiris_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Tren tren = new Tren();
            tren.Calistir();

            Console.WriteLine("Trenin hizi: "+tren.Hiz());

            Console.WriteLine("Tren Hizlaniyor");
            tren.Hizlan(100);

            Console.WriteLine("Tren Yavaşlıyor");

            tren.Durdur();

            Console.WriteLine("Tren Durdu");
            
            Console.ReadKey();

        }
    }
}
