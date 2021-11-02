using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03RecursionCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir problemin çözümünde, problemi daha küçük benzer parçalarına bölüp sonrasında bu küçük parçaların çözümünden bütüne ulaşmak için rekursif(Recurvive) metotlardan yararlanılır. Bu metotlar kendi kendini çağırarak çözüme ulaşır.

            Console.WriteLine(FaktoriyelAl(4));
            int sayi = Toplam(5);
            Console.WriteLine(sayi);
            Console.WriteLine(TerseCevir("Ankara"));
            Fibo();
            Console.ReadLine();
        }

        static int FaktoriyelAl(int sayi)
        {
            int faktoriyel = 1;
            for (int i = 2; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            return faktoriyel;
        }

        static int FaktoriyelAl2(int sayi)
        {
            //base case
            if (sayi < 2) return 1;
            return FaktoriyelAl2(sayi - 1) * sayi;

        }

        //1 den n e kadar olan sayıların toplamı
        static int Toplam(int n)
        {
            if (n < 1) return 0;
            return Toplam(n - 1) + n;
        }

        //stringi tersine çevir (recursion ile)

        static string TerseCevir(string metin)
        {
            if (metin.Length <= 1) return metin;
            return TerseCevir(metin.Substring(1)) + metin[0];
        }

        //fibonacci sayi dizisi yazdır Recursion


        static void Fibo(int a = 0, int b = 1)
        {
            if (a + b > 1000)
            {
                return;
            }
            Console.WriteLine(a + " ");
            Fibo(b, a + b);
        }
    }
}
