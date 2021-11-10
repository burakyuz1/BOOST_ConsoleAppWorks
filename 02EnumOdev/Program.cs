using _02EnumOdev.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ODEV:
//AlanHesapla.cs adında bir static class oluşturunuz.
//Tip adında bir enum oluşturunuz. (Kare, dikdörtgen, Üçgen, Daire)
//AlanHesapla Classı içerisinde hesapla adında static metot tanımlayınız ve aldığı uzunluk ölçülerine göre alanları hesaplatıp console'a yazdırınız.
//EKSTRA : Metodu extension yapınız.
namespace _02EnumOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hangi Tipin alanını hesaplamak istersin: (dikdörtgen, üçgen, kare, daire)");
            string tip = Console.ReadLine();
            double sonuc = 0;
            switch (tip)
            {
                case "dikdörtgen":
                    Console.Write("Uzun Kenar Girin: ");
                    int kenarDikdortgen1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kısa Kenar Girin: ");
                    int kenarDikdortgen2 = Convert.ToInt32(Console.ReadLine());
                    sonuc = Tip.Dikdortgen.Hesapla(dikdortgenKenar1: kenarDikdortgen1, diktortgenKenar2: kenarDikdortgen2);

                    //sonuc = AlanHesapla.Hesapla(Tip.Dikdortgen, dikdortgenKenar1: kenarDikdortgen1, diktortgenKenar2: kenarDikdortgen2);
                    break;

                case "kare":
                    Console.Write("Kenar Girin: ");
                    int kenarKare = Convert.ToInt32(Console.ReadLine());
                    sonuc = Tip.Kare.Hesapla(kareKenar: kenarKare);
                    break;

                case "üçgen":
                    Console.Write("Taban Kenarı Girin: ");
                    int taban = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Üçgenin yüksekliğini Girin: ");
                    int yukseklik = Convert.ToInt32(Console.ReadLine());
                    sonuc = Tip.Ucgen.Hesapla(yukseklik: yukseklik, taban: taban);
                    break;

                case "daire":
                    Console.Write("Yarıçapı Girin: ");
                    int yariCap = Convert.ToInt32(Console.ReadLine());
                    sonuc = Tip.Daire.Hesapla(yariCap: yariCap);
                    break;
            }

            Console.WriteLine($"{tip}'in alanı: {sonuc}");
            Console.ReadKey();

        }
    }
}
