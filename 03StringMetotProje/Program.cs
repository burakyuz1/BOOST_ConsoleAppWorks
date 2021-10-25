using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03StringMetotProje
{
    class Program
    {
        static void Main(string[] args)
        {

            //1-49 arası 6 benzersiz sayı üret, Aralarına - koyarak yazdır.

            //Enter'a bastıkca yeni üretsin çıkmak için herhangi bir tuş + enter

            Random rnd = new Random();
            int[] sayilar = new int[6];

            Console.WriteLine("Benzersiz 6 sayı üretmek için ENTER bas, Çıkış için CTRL+C");
            string devamMi = Console.ReadLine();
            while (devamMi == "")
            {

                int sayac = 0;
                do
                {
                    int randomSayi = rnd.Next(1, 49);
                    if (Array.IndexOf(sayilar, randomSayi, 0, sayac) == -1) //0. İndexten sayaca kadar bakar.
                    {
                        sayilar[sayac] = randomSayi;
                        sayac++;
                    }
                } while (sayac < 6);


                Array.Sort(sayilar);
                string beraber = string.Join(" - ", sayilar);

                Console.WriteLine(beraber);
                devamMi = Console.ReadLine();


            }



        }
    }
}











//while (sayac < 6)
//{
//    int randomSayi = rnd.Next(1, 50);
//    if (Array.IndexOf(sayilar, randomSayi) == -1)
//    {
//        sayilar[sayac] = randomSayi;
//        sayac++;
//    }
//}