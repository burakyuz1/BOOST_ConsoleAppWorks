using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Islem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 0;
        tekrar:
            Console.WriteLine("İşlem seçiniz. (1=>karesi,2=>küpü,3=>karakök)");
            int islem = Convert.ToInt32(Console.ReadLine());


            switch (islem)
            {
                case 1:
                    sonuc = (int)Math.Pow(sayi, 2);
                    break;

                case 2:
                    sonuc = (int)Math.Pow(sayi, 3);
                    break;

                case 3:
                    sonuc = (int)Math.Sqrt(sayi);
                    break;
                default:
                    Console.WriteLine("Hata, 1 2 3 rakamlarından birini seçin");
                    goto tekrar;
            }

    

            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
