using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi();
            k1.Ad = "Tuğba";
            k1.Yas = 18;

            Kisi k2 = new Kisi() { Ad = "Arzu", Yas = 26 };
            Kisi k3 = new Kisi() { Ad = "Serkan", Yas = 25 };
            Kisi k4 = new Kisi() { Ad = "YIGIT", Yas = 34 };
            Kisi k5 = new Kisi() { Ad = "Kudret", Yas = 32 };

            List<Kisi> kisiler = new List<Kisi>() { k1, k2, k3, k4, k5 };

            foreach (Kisi kisi in kisiler.OrderByDescending(x => x.Yas))
            {
                Console.WriteLine($"Adı : {kisi.Ad,-8} Yası : {kisi.Yas}");
            }

            foreach (Kisi kisi1 in kisiler)
            {
                Console.WriteLine(kisi1.Kunye());
            }

            Console.ReadLine();


        }
    }
    public class Kisi
    {
        public string Ad; // Field          //ÖNEMLİ NOT: Giriş yapma nedeniyle field'lar public yapıldı. İleride property dediğimiz
        public int Yas; // Field            // yapıyı gördüğümüz zaman bunlar private olacak ve dışardan erişim kısıtlanacak:

        public string Kunye() // Method
        {
            return $"{Ad} ({Yas})";
        }

    }
}


