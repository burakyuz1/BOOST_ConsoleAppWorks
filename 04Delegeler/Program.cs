using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Delegeler
{
    internal class Program
    {
        public delegate void Yaz(string text); //Delege tanımı. (String alıp geriye değer döndürmeyen)
        static void Main(string[] args)
        {
            int a = 3; // A değişkeninde bir tam sayı taşıyoruz.
            string b = "ali";//B değişkenine bir string taşıyoruz

            //c= Console.WriteLine; -> C değişkeninde WriteLine Metodunu nasıl atşırız.
            //Cevap : Ometodu taşıyabilecek özellikte bir delege tanımlayarak.

            //Console sınıflnın WriteLine metodu string alır yazdırır ve geriye bir şey  döndürmez. İşte tam bu özellikte bir delege onu taşıyabilir BKZ: Yukarı

            Yaz y = new Yaz(Console.WriteLine);

            y("Merhaba Dünya");
            Yaz y2 = Console.Write;
            y2("An");
            y2("Ka");
            y2("Ra");

            Console.WriteLine();

            //Bir delege değişkeni birden çok metodu aynı anda temsil edebilir.
            Yaz y3 = Console.Write;
            y3 += Console.Write;
            y3 += Console.WriteLine;
            y3("Oley ");
            y3("VAY ");

            // Delegeler sayesinde metotlar başka metotlara parametre olarak geçirilebilir.

            ToplaVeYav(2, 4, OrtaliYaz);

            //Yaz tipinde bişey vermek için, onun geri dönüş tipiyle parametresinin aynı olması şarttır.


            Console.ReadLine();

        }


        //Bu metot verdiğiniz sayıları toplar ve yazdırma işini sizin istediğiniz şekilde yapar
        static void ToplaVeYav(int sayi1, int sayi2, Yaz yaz)
        {
            int toptlam = sayi1 + sayi2;
            yaz($"{sayi1} + {sayi2} =  {toptlam}");
        }


        static void OrtaliYaz(string metin)
        {
            int boslukAdet = (Console.BufferWidth - metin.Length) / 2;

            Console.WriteLine(new string(' ',boslukAdet) + metin);


        }

    }
}
