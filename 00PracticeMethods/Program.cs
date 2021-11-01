using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00PracticeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extension Metot içinde
            //TCKNO Üretme
            //TC nin ilk 9 hanesinin tek sayılarının 7 katıyla , çift sayılarının farkının 10'a bölümünden kalan sonuç 10. haneyi vermeli
            //TC nin ilk 10 basamağının toplamının 10'a bölümünden kalan sonuç 11. haneyi vermeli.

            Console.Write("Yapmak İstediğiniz işlemi girin (1: TC SORGULA 2: TC ÜRET) ");

            string sonuc = Console.ReadLine();
            if (sonuc == "1")
            {
                Console.WriteLine("SORGULAMAK İÇİN BİR TC GİRİN");
                string sorgu = Console.ReadLine();

                if (sorgu.TcNoDogrula())
                {
                    Console.WriteLine("GEÇERLİ BİR TC");
                }
                else
                {
                    Console.WriteLine("GEÇERLİ BİR TC DEĞİL");
                }
            }
            if (sonuc == "2")
            {
                Console.WriteLine(ExtensionMethod.TcNoUret());
            }
            Console.ReadKey();
        }


       
    }
}
