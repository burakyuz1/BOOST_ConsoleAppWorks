using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DelegelerDevamTeori
{
    public delegate double Process(double number1, double number2);
    public delegate double Process2(double number1);
    public delegate bool Process3(int number1);
    public delegate bool Kosul(int sayi);
    public delegate void Eylem();

    internal class Program
    {
        static void Main(string[] args)
        {
            //Anonim(isimsiz) metot tanımlama
            Process process = Sum;
            double result = process(3, 28);
            Console.WriteLine(result);

            Process carp = delegate (double num1, double num2) //Isimsiz(Anonim) metot tanımlama.. 
                {
                    return num1 * num2;
                };

            result = carp(3, 5);
            Console.WriteLine(result);

            //LAMDA EXPRESSION (GIRENLER) => (CIKANLAR)

            Process cikar = (num1, num2) => num1 - num2; //Anonim fonksiyon ama lamda ile yapıldı.

            Console.WriteLine(cikar(29, 3));

            //Process2 pow = num1 => num1 * num1; // Anonim metot tanımladım.
            Process2 pow = delegate (double num1)
            { return num1 * num1; };
            Console.WriteLine(pow(5));

            // Girilen sayının çift olup olmadığını döndüren metotu anonim olarak tanımla
            Process3 ciftler = delegate (int number1)
            {
                return number1 % 2 == 0;
            };

            for (int i = 0; i < 21; i++)
            {
                if (!ciftler(i))
                    Console.WriteLine(i);
            }

            //Bir isimli metot tanımlayınız.
            //Bir int dizisi & bir bool döndüren int alan metodu parametre olarak alsın.
            //Koşula uyan dizi elemanlarını ekrana yan yana yazdısın ve yeni satıra geçsin.
            // Örnek:
            int[] dizi = { 1, 3, 5, 6, 4, 13 };
            //Yazdir(dizi, ciftMi); Çıktı: 6 4
            Kosul ciftMi = (sayi) => sayi % 2 == 0;



            Yazdir(dizi, ciftMi = (sayi) => sayi % 3 == 0);

            Console.WriteLine("****");
            Yazdir(dizi, delegate (int sayi) { return sayi < 10; });



            KereYap(3, () => Console.WriteLine("Merhaba"));
            KereYap(4, () => Console.Write("H€ll0! ->"));

            List<string> adlar = new List<string>() { "ae", "ıi", "oö" };

            IEnumerable<string> iGecenler = adlar.Where(x => x.Contains("i"));  //string alan, bool döndüren bir delegate

            Array.ForEach(adlar.ToArray(), x => Console.WriteLine(x)); //verdiğim arrayi anonim metoda sokup  istediğimi yaptırdım.

            Console.WriteLine();



            Console.ReadLine();
        }

        //isimli metot
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static void Yazdir(int[] dizi, Kosul kosul) //Kosul yerine aynı param ve return u olan istediğim metodu verebilirim.
        {
            foreach (var item in dizi)
            {
                if (kosul(item))
                {
                    Console.WriteLine(item + " ");
                }
            }
        }

        public static void KereYap(int kere, Eylem eylem)
        {
            for (int i = 0; i < kere; i++)
            {
                eylem();
            }
        }
    }


}
