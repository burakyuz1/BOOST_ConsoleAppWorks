using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"E sayisi = {Math.E} Pi sayisi = {Math.PI}");

            //Math.Pow -> Üslü sayı alma
            Console.WriteLine(Math.Pow(2,3));

            //Math.Sqrt -> Karekok alma
            Console.WriteLine(Math.Sqrt(16));

            //Math.Max() -- Math.Min()
            Console.WriteLine(Math.Max(3,3));

            //23,11,48,69,100 -> En Küçüğü yazdır.

            Console.WriteLine(Math.Max(100,(Math.Max(11,Math.Max(48,Math.Max(69,23))))));
            Console.WriteLine(Math.Min(100,(Math.Min(11,Math.Min(48,Math.Min(69,23))))));

            //Math.Ceiling() -> verilen bir ondalıklı sayıyı en yakın bir üst sayıya yuvarlar.
            //Math.Floor() -> verilen bir ondalıklı sayıyı en yakın bir alt sayıya yuvarlar.
           //Math.Round() -> En yakına yuvarlar.
            Console.WriteLine(Math.Ceiling(3.2));
            Console.WriteLine(Math.Floor(3.9));
            Console.WriteLine(Math.Round(3.6));

            //Math.Sign -> Sayının işaretini verir (Negatif : -1 // Pozitif : 1 )

            Console.WriteLine(Math.Sign(-4));
            Console.WriteLine(Math.Sign(5));

            //Verilen 2 uzunluğa göre hipo, alan, çevre

            Console.Write("Kenar 1 : ");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kenar 2 : ");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            double hipotenus = Math.Sqrt((Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2)));
            Console.WriteLine($"Hipotenüs = {hipotenus}");
            Console.WriteLine($"Çevre = {kenar1+kenar2+hipotenus}");
            Console.WriteLine($"Alan = {(kenar1 * kenar2 ) / 2}");



            Console.ReadKey();

        }
    }
}
