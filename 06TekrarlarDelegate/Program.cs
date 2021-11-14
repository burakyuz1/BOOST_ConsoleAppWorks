using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06TekrarlarDelegate
{
    internal class Program
    {
        public delegate bool Kosul(int sayi);
        public delegate void Eylem();
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            Kosul ciftMi = x => x % 2 == 0;
            Kosul tekMi = x => x % 2 == 1;
            Yazdir(sayilar, ciftMi);
            Yazdir(sayilar, tekMi);

            Yazdir(sayilar, delegate (int sayi) { return sayi % 4 == 0; });

            Yazdir(sayilar, x => x % 3 == 0);


            Console.WriteLine("****");
            //Öyle bir metot yaz ki, verilen sayı kadar, bir iş yapsın.

            KereYap(3, () => Console.WriteLine("Burak"));
            KereYap(4, () => Console.WriteLine("Akyüz"));

            //bir list olsun içinde a harfi geçen kelimeleri bulsun.

            List<string> kelimeler = new List<string>() { "ayşe", "mehmet", "ahmet", "berke", "murat", "halil" };


            kelimeler.VirgulleYazdir();

            int[] sayiDizisi = { 1, 2, 3, 4, 5, 6, 7 };
            sayiDizisi.KosulluYazdir(x => x % 2 == 0);

            Console.WriteLine(  "*****++++");
            sayiDizisi.KosulluYazdir(sayi => sayi > 3);


            Console.ReadLine();
        }

        private static void Yazdir(int[] sayilar, Kosul ciftMi)
        {
            foreach (int sayi in sayilar)
            {
                if (ciftMi(sayi))
                {
                    Console.WriteLine(sayi + " ");
                }

            }
        }

        private static void KereYap(int sayi, Eylem eylem)
        {
            for (int i = 0; i < sayi; i++)
            {
                eylem();
            }

        }
    }
}
