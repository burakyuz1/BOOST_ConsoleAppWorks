using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Loopss
{
    class Program
    {
        static void Main(string[] args)
        {
            //Belli işlemleri belli bir şarta bağlı olarak
            //Tekrar tekrar yapan yapılardır.

            //1'den 10'a kadar olan sayılar
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //body'si olmayan döngü olur mu ?
            //-> Aslında olmaz ama boş statement koyulabilir.
            /*   while (true) ; */ // ßoş statement.. _> Sonsuz kere döner --> SONSUZ DONGU'DEN CTRL+C ILE CIKILABILIR.

            //foktoriyel hesaplama

            //Console.Write("Bir sayı girin faktoriyel: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int faktoriyel = 2;
            //for (int i = 3; i <= sayi; i++)
            //{
            //    faktoriyel *= i;
            //}
            //Console.WriteLine($"{sayi}! = {faktoriyel}");

            ////Fibonacci sayı dizisi
            //int a = 0, b = 1, c = 0;
            //Console.Write($"Fibonacci sayı dizisi : {a} {b} ");
            //for (int i = 0; i < 15; i++)
            //{
            //    c = a + b;
            //    Console.Write($"{c} ");
            //    a = b;
            //    b = c;
            //}


            ////Metni tersine çevirme

            //Console.Write("\nTersine çevirmek için kelime girin: ");
            //string text = Console.ReadLine();

            //for (int i = text.Length - 1; i >= 0 ; i--)
            //{
            //    Console.Write(text[i]);
            //}


            //Çarpım tablosu
            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j < 11; j++)
            //    {
            //        Console.Write($"{j}x{i} = {i*j}               ");
            //    }
            //    Console.WriteLine();

            //}

            //Sayı tahmin oyunu, bilgisayar sayı tutar-> siz tahmin etmeye çalışırsınız, yanlış tahminde program sizi Yukarı/aşağı  diyerek yönlendirir

            int rastgeleSayi = new Random().Next(1, 101);
            Console.Write("1-100 arasında sayı  tahmin et : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool dongu = true;
            while (dongu)
            {

                if (sayi > rastgeleSayi)
                {
                    Console.WriteLine("asagı");
                     sayi = Convert.ToInt32(Console.ReadLine());

                }
                else if (rastgeleSayi > sayi)
                {
                    Console.WriteLine("yukari");
                    sayi = Convert.ToInt32(Console.ReadLine());

                }
               else if (rastgeleSayi == sayi)
                {
                    Console.WriteLine("dogru");
                    dongu = false;
                }
            }




            Console.ReadKey();
        }
    }
}
