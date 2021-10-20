using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TryCatchh
{
    class Program
    {
        static void Main(string[] args)
        {
        soru:
            Console.WriteLine("Sayi : ");
            int sayi;

            try
            {
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                goto soru;
            }
            string sonuc = sayi % 2 == 0 ? "çift" : "tek";
            Console.WriteLine($"Girdiğiniz sayı {sonuc}tir.");
            Console.ReadKey();
        }
    }
}
