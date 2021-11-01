using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01TEKRAR
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = int.MaxValue; //IMPLİCİT
            //long sayi2 = sayi;


            //long sayi3 = long.MaxValue;     //Explicit conversion
            //int sayi4 = (int)sayi3;

            //int sayi5 = 300;
            //byte sayi6 = (byte)sayi5;


            //TASK: İSİMLERİ BİRLEŞTİREN, VE O BİRLEŞMİŞ İSMİ TERSTEN YAZDIRAN METOT (REF VE OUT KULLANARAK YAZINIZ.)

            //string name1 = Console.ReadLine();
            //string name2 = Console.ReadLine();
            string birlesmis, tersten;

            int sayi1 = 1, sayi2 = 4, toplam1, toplam2;

            //IsimVeBasHarfBirlestir(name1, name2, ref birlesmis, ref tersten);

            //IsimBirlestirTersCevir(name1, name2, out birlesmis, out tersten);

            SayiVeSayininToplamlariniTopla(sayi1, sayi2, out toplam1, out toplam2);

            Console.WriteLine(toplam1);//5
            Console.WriteLine(toplam2);//14

            int[] dizi = {1,2,3,4,5 };
            Metot1(dizi);
            Console.WriteLine(dizi[0]);

            int sayi31 = 31;
            Metot2(sayi31);
            Console.WriteLine(sayi31);
            Console.ReadLine();

        }

        private static void Metot2(int sayi)
        {
            sayi++;
        }

        private static void Metot1(int[] dizi)
        {
            dizi[0] = 99;
        }

        private static void SayiVeSayininToplamlariniTopla(int sayi1, int sayi2, out int toplam1, out int toplam2)
        {
            toplam1 = sayi1 + sayi2;
            sayi1 = toplam1;
            toplam2 = sayi1 + toplam1 + sayi2; ;


        }

        private static void IsimBirlestirTersCevir(string name1, string name2, out string birlesmis, out string tersten)
        {
            birlesmis = name1 + name2;
            tersten = birlesmis.ToUpper();

        }

        private static void IsimVeBasHarfBirlestir(string name1, string name2, ref string birlesmis, ref string tersten)
        {
            birlesmis = name1 + name2;
            tersten = birlesmis.ToUpper();
        }


    }
}
