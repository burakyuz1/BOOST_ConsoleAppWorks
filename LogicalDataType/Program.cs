using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantiksalVeriTuru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hava kapalı mı ? true/false?");
            bool havaKapaliMi = Convert.ToBoolean(Console.ReadLine());
            if (havaKapaliMi)
            {
                Console.WriteLine("Şemsiye al");
            }
            else
            {
                Console.WriteLine("Gözlük al ");
            }

            Console.WriteLine("ehliyet alabilir mi ?");
            Console.WriteLine("Yaşı 18 den büyük mü ? true/false");
            bool yas = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("erkek mi?");
            bool cinsiyet = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("bir engeli var mı ?");
            bool engelDurumu = Convert.ToBoolean(Console.ReadLine());
            bool uygunMu = yas && (cinsiyet && engelDurumu);
            Console.WriteLine(uygunMu ? "uygun" : "değil");

            // !  işaretiyle bir boolean değğişkeni tersine döndürebiliriz

            Console.ReadKey();
        }
    }
}
