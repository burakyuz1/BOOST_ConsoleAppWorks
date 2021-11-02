using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02HashSetCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashsetler List gibi çalışır fakat aynı eleman 2 kere eklenmez.
            HashSet<int> kume1 = new HashSet<int>();
            kume1.Add(1);
            kume1.Add(2);
            kume1.Add(1);


            Console.WriteLine("Öğe sayısı " + kume1.Count); //eklerken hata vermez fakat aynın nesne olduğu için de eklemez.
            foreach (int oge in kume1)
            {
                Console.WriteLine(oge);
            }
            string[] adlar = { "ali", "can", "cem", "can", "ali" };

            Console.WriteLine("Dizinin uzunluğu : " + adlar.Length);

            HashSet<string> kume2 = new HashSet<string>(adlar);

            Console.WriteLine("Küme2 öğe adedi : " + kume2.Count);
            Console.WriteLine(string.Join(", ", kume2));


            //Soru : 1-49 arası 6 farklı sayı üret

            Random rnd = new Random();
            HashSet<int> sayilar = new HashSet<int>();

            while (sayilar.Count < 6) sayilar.Add(rnd.Next(1, 7));
            Console.WriteLine(string.Join(", ", sayilar));






            Console.ReadKey();
        }
    }
}
