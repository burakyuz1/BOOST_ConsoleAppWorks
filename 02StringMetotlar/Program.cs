using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //ÖNEMLİ NOT : Hicbr string metodu uygulandığı string nesnesini değiştirmez.
            //Yeni bir string döndürür. Stringler IMMUTABLE'dır.
            string text = "Ali Yılmaz";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Length);
            Console.WriteLine(text.Substring(4,3)); //Tek parametre verirsek sonuna kadar alır.
            Console.WriteLine(text.IndexOf('m')); // "m" Karakteri hangi index'de olduğunu  gösterir -> Soldan başlar
            Console.WriteLine(text.LastIndexOf('A')); // "a" Karakteri sağdan başlayarak indexini verir

            Console.WriteLine(text.Remove(5, 3)); // Ali yılmazı Ali yaz'a çevirmek istiyorum

            Console.WriteLine(text.Contains("li")); //"li" içerir mi -> FALSE / TRUE

            Console.WriteLine(text.Replace('l','1')); //l karakterini 1 yapar.

            int[] sansliNolar = { 1, 3, 5, 6 };
            string beraber = string.Join(" - ", sansliNolar);
            Console.WriteLine(beraber);

            Console.WriteLine(text.Insert(7,"dır"));

            char[] charArr = text.ToCharArray(); // Tüm karakterleri char dizisine aktarır

            Console.WriteLine("araba".Equals("ARABA", StringComparison.CurrentCultureIgnoreCase));//Mevcut kültürü baz alarak büyük/küçük ayrımı yapmadan

            string str0 = null;
            string str1 = "";
            string str2 = string.Empty;//empty string Yukardakiyle aynı
            string str3 = "                                              "; //whitespacestring tatamen görünmeyen karakterler
            string str4 = "         \t\r\n            ";   //whitespacestring tatamen görünmeyen karakterler
            string str5 = "           \t,\r\n";

            Console.WriteLine(string.IsNullOrEmpty(str0)); //true
            Console.WriteLine(string.IsNullOrEmpty(str1));//true
            Console.WriteLine(string.IsNullOrEmpty(str2));//true
            Console.WriteLine(string.IsNullOrWhiteSpace(str3)); //true
            Console.WriteLine(string.IsNullOrWhiteSpace(str4)); //true
            Console.WriteLine(string.IsNullOrWhiteSpace(str5)); //false

            Console.WriteLine("Burak".PadLeft(10,'#')); //10 Karakter olacak şekilde soluna space veya karakter atar


            Console.ReadKey();
        }
    }
}
