using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReferansTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin1 = "Lorem ipsum dolor sit amet, concestetur adipiscing elit.";
            string metin2 = "Ankara";

            Console.WriteLine("Uzunluğu : " + metin2.Length);


            //45 adet * karakterini nasıl yan yana yazabiliriz?
            string cizgiCek = new string('*', 45);
            Console.WriteLine(cizgiCek);

            //özel karakterleri ifade edtmek
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#string-escape-sequences

            //2 satırlık bir şiir

            Console.WriteLine("Bugün 23 Nisan \nNeşeyle doluyor insan");     // \n-> yeni satır

            Console.WriteLine(cizgiCek);

            Console.WriteLine("Ali \t ata \t bak.");     // \p -> tab verir 1 tane
            Console.WriteLine("Emel \t eve \t gel ");

            Console.WriteLine(cizgiCek);

            Console.WriteLine("Makarn\ba");        //   \b -> bir karakter (kendinden önce gelen) siler..

            Console.WriteLine(cizgiCek);

            Console.WriteLine("BABA \x42\x41\x42\x41");  //4*16 = 64 +2 = 66 [66 65 66 65] -> ASCII Kodlarında BABA yazar..

            Console.WriteLine(cizgiCek);

            int birSayi = 0xFA;  //0x 16 lık sayı sisteminde sayı tanımlanacağı belirlenir.::..
                                 //F -> 16lar basamaağı 15 i temsil eder         A-> 1ler basamağı 10 u temsil eder ..... -> 16*15=240   10   -> 240+10=250;;;;;
            Console.WriteLine(birSayi);

            Console.WriteLine(cizgiCek);

            Console.WriteLine("Türkiyenin Başkenti \"AnkaraDır\"   ");

            Console.WriteLine(cizgiCek);


            string alinti = @"
""Şiir""

Sanma şâhım / herkesi sen / sâdıkâne / yâr olur
Herkesi sen / dost mu / sandın belki ol / ağyâr olur
Sâdıkâne belki / ol bu / âlemde / dildâr olur
Yâr olur / ağyâr olur / dildâr olur / serdâr olur
                        -Yavuz Sultan Selim";   //@ ile başlarken sadece " escape edilir. diğerleri olduğu gibi yazılır. örn: / ...
            Console.WriteLine(alinti);

            Console.WriteLine(cizgiCek);

            //String'lerin içine değişken enjekte etme..

            int adet = 3;

            Console.WriteLine("ben " + adet + " adet kuş gördüm"); //String Concatenation

            Console.WriteLine($"ben {adet} adet kuş gördüm"); //Templete literal

            Console.WriteLine(cizgiCek);

            string sehir = "afyon";

            Console.WriteLine(sehir[0]);




            Console.ReadKey();
        }
    }
}

/* 10LUK SAYI SİSTEMİ RAKAMLARI : 0123456789
 * 
 * 16LIK SAYI SİSTEMİ RAKAMLARI : 0123456789ABCDEF
 * 65 -> 16 lık sayı sisteminde = 41             66 -> 16lık sayı sisteminde => 42
 * 
 * 
 * */
