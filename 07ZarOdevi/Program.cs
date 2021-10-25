using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ZarOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            byte turPuan,  totalPuan = 0;
            int deneme = 0;
            while (totalPuan <= 15)
            {
                turPuan = 0;
                Console.WriteLine("******Zar atılıyor******");
                byte zar1 = (byte)rnd.Next(1, 7);
                byte zar2 = (byte)rnd.Next(1, 7);
                byte zar3 = (byte)rnd.Next(1, 7);

                Console.Write($"1. ZAR: {zar1}\n2. ZAR: {zar2}\n3. ZAR: {zar3}\n");
                if (zar1 == zar2)
                {
                    if (zar2 == zar3)
                    {
                        turPuan += 6;
                    }
                }
                else if (zar1 == zar2 || zar2 == zar3 || zar1 == zar3)
                {
                    turPuan += 2;
                }
                totalPuan += turPuan;
                deneme++;
                Console.WriteLine($"Bu turda kazandığın puan: {turPuan}");
                if (15 - totalPuan < 0)
                {
                    break;
                }
                Console.WriteLine($"Oyunu bitirmek için kalan puan: {15 - totalPuan}");
                Console.WriteLine();
                System.Threading.Thread.Sleep(500);
            }
            Console.WriteLine("OYUN BİTTİ");
            Console.WriteLine($"{deneme} adet deneme sonrası, kazandığın puan: {totalPuan}");

            Console.ReadKey();

        }
    }
}
