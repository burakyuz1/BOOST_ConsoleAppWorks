using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05GenericMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5 };
            Console.WriteLine("ÖNCE : " + string.Join("-", sayilar));
            Karistir(sayilar);
            Console.WriteLine("Sonra : " + string.Join("-", sayilar));


            string[] adlar = new string[] { "ali", "veli", "mustafa" };
            Karistir<string>(adlar);
            Console.WriteLine("Sonra : " + string.Join("-", adlar));


            Console.WriteLine("****");

            char[] charArrayi = "Istanbul".ToCharArray();

            Karistir<char>(charArrayi);
            Console.WriteLine("Sonra : " + string.Join("-", charArrayi));




            Console.ReadLine();
        }

        private static void Karistir<T>(T[] sayilar)
        {
            Random rnd = new Random();
            int talihliIndex;
            T temp;
            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                talihliIndex = rnd.Next(i, sayilar.Length);
                temp = sayilar[i];
                sayilar[i] = sayilar[talihliIndex];
                sayilar[talihliIndex] = temp;

            }

        }
    }
}
//Öyle bir metot yazın ki list olsun dizi olsun int listesi olsun char listesi olsun 
//Her türlü foreach 'e girebilen yapıların öğelerini ekrana satır satır yazdırabilsin.









