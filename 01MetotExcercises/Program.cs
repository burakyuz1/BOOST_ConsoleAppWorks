using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01MetotExcercises
{
    class Program
    {

        static void Main(string[] args)
        {
            //4 adet metot vardır
            //***************************************
            //1. Parametre alan geriye değer döndüren
            //2. Parametre alan geriye değer döndürmeyen
            //3. Parametre almayan geriye değer döndüren
            //4. Parametre almayan geriye değer döndürmeyen

            //2 adet int parametre alan değer döndürmeyen Toplam metodunu yazın.
            Console.Write("1. sayıyı girin : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı girin : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Toplam(a, b);



            Console.Write("1. sayıyı girin : ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayıyı girin : ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("3. sayıyı girin : ");
            double sayi3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sayıların çarpımı: "+Carp(sayi1, sayi2, sayi3));

            //Başlangıc ve bitiş değerleri girilen sayı aralığını ekrana yazdıran metodu yazın.

            Console.WriteLine("Başlangıç sayısı girin");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş sayısı girin");
            int bitis = Convert.ToInt32(Console.ReadLine());

            SayiAralik(baslangic, bitis);
            Console.ReadLine();

        }

        /// <summary>
        /// Verilen 3 sayıyı çarpan metot
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static double Carp(double a, double b, double c)
        {
            return a * b * c;
        }
        /// <summary>
        /// Verilen 2 sayıyı toplayan metot
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Toplam(int a, int b)
        {
            int toplam = a + b;
            Console.WriteLine("Girdiğin ilk sayı: {0}, ikinci sayı: {1}, sayıların toplamı: {2}", a, b, toplam);
        }
        /// <summary>
        /// Verilen 2 sayının aralığındaki tüm sayıları ekrana yazdıran metot
        /// </summary>
        /// <param name="baslangic"> int degerinde baslangic degeri gir</param>
        /// <param name="bitis">int degerinde bitis degeri gir</param>
        static void SayiAralik(int baslangic , int bitis)
        {
            for (int i = baslangic ; i <= bitis; i++)
                Console.Write(i + " ");
        }
    }
}
