using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04OOPProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi()
            {
                DogumTarihi = new DateTime(1994, 1, 1), // Auto property bknz: Kisi.cs
                Soyad = "Akyüz", // Full property bknz: Kisi.cs

            };
            kisi1.SetAd("Burak"); // Java usulü kendim elle get set methodları kullanarak eriştim

            Kisi kisi2 = new Kisi()
            {
                DogumTarihi = new DateTime(1995, 1, 19),
                Soyad = "Çetin"
            };
            kisi2.SetAd("Bihter");

            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(kisi1);
            kisiler.Add(kisi2);

            foreach (Kisi kisi in kisiler)
            {
                Console.WriteLine(kisi1.Kunye());
            }

            Console.ReadLine();
        }
    }
}
