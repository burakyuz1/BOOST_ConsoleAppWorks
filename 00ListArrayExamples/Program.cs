using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00ListArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            //bir sayi listesi tanımlayınız. ve bu sayı listesine 6 adet sayı ekleyiniz ve ekrana yan yana yazdırınız.

            List<int> sayilar = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
                sayilar.Add(rnd.Next(0, 10));
            Console.WriteLine(string.Join(", ", sayilar));

            //Listenin elemanlarını küçükten büyüğe sıralayın. Ekrana yazdırnıız.
            Console.WriteLine("\nKüçükten büyüğe sıralanmış hali: \n***********");
            sayilar.Sort();
            Console.WriteLine(string.Join(", ", sayilar));
            Console.WriteLine("Eleman sayısı: {0}", sayilar.Count);

            //Listenin elemanlarını büyükten küçüğe sıralayıp ekrana yazdırın
            Console.WriteLine("\nBüyükten küçüğe sıralanmış hali\n***********");
            sayilar.Reverse();
            //sayilar.ForEach(x => Console.Write(x + " "));
            Console.WriteLine(string.Join(", ", sayilar));

            // İçerisinde Ankara İstanbul İzmir Bursa Malatya Niğde Kocaeli şehirlerini barındıran bir liste tanımlayınız ve kullanıcıdan bir aranacak şehir isteyiniz eğer listede bu şehir varsa aradığınız şehir listede bulunmaktadır. ylistede yoksa aradığınız şehir listede yoktur. Contains Metot ile


            List<string> sehirler = new List<string>() { "ankara", "istanbul", "izmir", "bursa", "malatya", "niğde", "kocaeli" };
            sehirler.Add("izmir");
            Console.WriteLine("Aranacak şehir giriniz : (örn. Ankara)");
            string aranacakSehir = Console.ReadLine().ToLower();
            string sonuc = sehirler.Contains(aranacakSehir) ? "Aradığın şehir listede var." : "Aradığın şehir listede yok ";
            Console.WriteLine(sonuc);

            //Sort metodu string/charları da sıralayabilir.

            sehirler.Sort();
            //Alfabetik sıralı şehirler listesinde İzmir hangi indexte yer alır 
            Console.WriteLine(sehirler.IndexOf("izmir"));
            //LastIndexOf metoduyla sondan indexi alır.

            //5 elemanlı bir sayı listesinin 4 elemanının min ve max toplamını hesaplayınız

            List<int> sayiListesi = new List<int>() { 555, 100, 200, 333, 444 };
            int maxToplam = 0, minToplam = 0;
            int max = sayiListesi.Max();
            int min = sayiListesi.Min();
            for (int i = 0; i < sayiListesi.Count; i++)
            {
                if (sayiListesi[i] != max)
                    minToplam += sayiListesi[i];
                else
                    max = int.MaxValue;

                if (sayiListesi[i] != min)
                    maxToplam += sayiListesi[i];
                else
                    min = 0;
            }
            Console.WriteLine("Minimum toplam {0} , Maximum toplam {1}", minToplam, maxToplam);
            Console.ReadKey();

        }
    }
}
