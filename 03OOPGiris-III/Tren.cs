using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03OOPGiris_III
{
    public class Tren
    {
        private int hiz;
        public const int HIZ_LIMITI = 250;


        public void Calistir()
        {
            Console.WriteLine("Tren Calisiyor");
        }


        public int Hiz()
        {
            return hiz;
        }
        public void Hizlan(int hedefHiz)
        {
            while (hiz < Math.Min(hedefHiz, HIZ_LIMITI))
            {
                hiz++;
                Console.Write("{0:000}", hiz);
                Thread.Sleep(21);
                Console.Write("\b\b\b");
            }
            Console.WriteLine();

        }
        public void Yavasla(int hedefHiz)
        {
            while (hiz > Math.Max(0,hedefHiz))
            {
                hiz--;
                Console.Write("{0:000}", hiz);
                Thread.Sleep(21);
                Console.Write("\b\b\b");
            }
            Console.WriteLine();
        }
        public void Durdur()
        {
            Console.WriteLine("Tren Durduruluyor");
            Yavasla(0);


        }
    }
}
