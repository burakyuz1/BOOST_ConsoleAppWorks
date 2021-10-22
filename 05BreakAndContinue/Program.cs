using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Continue -> orayı atlar
            for (int i = 0; i <= 10; i++)
            {
                if (i==7)
                {
                    continue; //buraya girince yani i=7 olunca  alttaki satır çalışmayıp i++ koşula geri dönecek
                }
                Console.WriteLine(i);

                //Sonsuz döngü içinde 1-6 arası zar at ve 6 gelirse döngüden çık..
                Random rnd = new Random();
                for (; ; )
                {
                    Console.WriteLine("Zar atılıyor");
                    int zar = rnd.Next(1, 7);
                    Console.WriteLine(zar);
                    if (zar == 6)
                    {
                        break;//break the cycle
                    }
                }

                Console.ReadKey();  
            }

        }
    }
}
