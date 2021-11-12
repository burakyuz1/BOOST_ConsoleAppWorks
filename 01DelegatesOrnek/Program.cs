using System;

// 1) Bir tane geriye değer döndürmeyen ve 2 adet integer param alan deletage'i tanımlayınız.
// 2) Parametre alan geriye değer döndürmeyen Topla,  Çıkar, Böl Çarp metodlarını tanımlayınız.
// 3) Bu metodları delegate içine atın, Invoke edin.
// 4) Çarp metodunu delegate'den silip tekrar çalıştırınız.


namespace _01DelegatesOrnek
{
    class Program
    {
        //public delegate void Yazdir(string text);
        public delegate void Islemler(int sayi1, int sayi2);
        static void Main(string[] args)
        {
            //Console.WriteLine("yazi");
            //Yazdir uydurmaIsim = Console.WriteLine;

            //uydurmaIsim += Console.WriteLine;
            //uydurmaIsim += Deneme;
            //uydurmaIsim.Invoke("MERHABALAR");

            Islemler islemler = Topla;
            islemler += Cikar;
            islemler += Bol;
            islemler += Carp;

            islemler.Invoke(9, 3);

            Console.WriteLine("**********");

            islemler -= Carp;
            islemler.Invoke(10, 5);


            Console.ReadLine();

        }

        //static void Deneme(string param)
        //{
        //    Console.WriteLine("TUGBANIN SORUSUU: " + param);
        //}
        static void Topla(int sayi1, int sayi2) => Console.WriteLine("Toplamları : " + (sayi1 + sayi2));
        static void Cikar(int sayi1, int sayi2) => Console.WriteLine("Farkları : " + (sayi1 - sayi2));
        static void Bol(int sayi1, int sayi2) => Console.WriteLine("Bölümleri : " + (sayi1 / sayi2));
        static void Carp(int sayi1, int sayi2) => Console.WriteLine("Çarpımları :" + (sayi1 * sayi2));

    }
}
