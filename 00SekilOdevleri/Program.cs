using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00SekilOdevleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir n sayısı girin.");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------\nŞEKİL 1\n-------");
            for (int i = 0; i < n; i++)
            {
                Yazdir("*", n);  //Şekil 1 Kare
            }


            Console.WriteLine("-------\nŞEKİL 2\n-------");


            for (int i = 1; i <= n; i++)
            {
                Yazdir("*", i); //Şekil 2 Dik üçgen sola bakan
            }
            Console.WriteLine("-------\nŞEKİL 3\n-------");



            for (int i = 1; i <= n; i++)
            {
                Yazdir("* ", i);//Şekil 3 Dik üçgen sola bakan boşluklu
            }
            Console.WriteLine("-------\nŞEKİL 4\n-------");


            for (int i = 1; i <= n; i++)
            {
                string newString = new string(' ', n - i);
                string yildiz = new string('*', i);
                newString += yildiz;
                Yazdir(newString, 1);//Şekil 4 Dik üçgen sağa bakan
            }
            Console.WriteLine("-------\nŞEKİL 5\n-------");




            int j = 1;
            for (int i = 1; i <= n; i++)
            {
                string newString = new string(' ', n - i);

                string yildiz = new string('*', j);
                j += 2;
                newString += yildiz;
                Yazdir(newString, 1); //şekil 5 normal üçgen
            }

            Console.WriteLine("-------\nŞEKİL 6\n-------");
            for (int i = 0; i < n; i++)
            {
                Yazdir("*".PadLeft(i + 1), 1); //şekil 6 sola çapraz
            }


            Console.WriteLine("-------\nŞEKİL 7\n-------");

            for (int i = n; i > 0; i--)
            {
                Yazdir("*".PadLeft(i), 1); // Şekil 7 sağa çapraz
            }
            Console.WriteLine("-------\nŞEKİL 8\n-------");

            int yildiz2 = n - 1;
            for (int i = 1; i <= n / 2; i++)
            {
                Yazdir("*", i, yildiz2);
                if (yildiz2 < 0)
                    break;
                yildiz2 -= 2;
            }

            if (n % 2 == 1)
            {
                Yazdir(n / 2 + 1);
                yildiz2 = 2;
            }

            else
            {
                yildiz2 = 1;

            }
            for (int i = n / 2; i >= 1; i--)
            {
                Yazdir("*", i, yildiz2);
                yildiz2 += 2;
            }




            Console.WriteLine("-------\nŞEKİL 9\n-------");
            Yazdir("*", n);  //ŞEKİL 9 İÇİ BOŞ KARE
            for (int i = 1; i <= n - 2; i++)
            {
                YanKenarCiz("*", n - 1);

            }
            Yazdir("*", n);

            Console.WriteLine("-------\nŞEKİL 10\n-------");

            int ustVeAltTaraf = (n - 1) / 2;          //ŞEKİL 10 BAKLAVA DİLİMİ
            int yildizAdet = 1;
            int yanBosluk = ustVeAltTaraf;
            for (int i = 1; i <= ustVeAltTaraf; i++)
            {
                BaklavaCiz(yanBosluk--, yildizAdet);
                yildizAdet += 2;
            }
            if (n % 2 == 0)
            {

                BaklavaCiz(0, yildizAdet);
            }
            for (int i = ustVeAltTaraf; i >= 0; i--)
            {
                BaklavaCiz(yanBosluk++, yildizAdet);
                yildizAdet -= 2;

            }


            Console.ReadLine();


        }


        static void Yazdir(string ifade, int adet)
        {
            for (int i = 1; i <= adet; i++)
            {
                Console.Write(ifade);
            }
            Console.WriteLine();
        }

        static void Yazdir(string yildiz, int bosluk1, int bosluk2)
        {
            Console.Write(yildiz.PadLeft(bosluk1));
            Console.Write(yildiz.PadLeft(bosluk2));
            Console.WriteLine();
        }
        static void Yazdir(int bosluk1)
        {
            Console.Write("*".PadLeft(bosluk1));
            Console.WriteLine();
        }

        static void YanKenarCiz(string yildiz, int bosluk)
        {
            Console.Write(yildiz);
            Console.Write(yildiz.PadLeft(bosluk));
            Console.WriteLine();
        }

        static string AdetUret(int adet)
        {
            string tam = "";
            for (int i = 0; i < adet; i++)
            {
                tam += "*";

            }
            return tam;

        }
        static void BaklavaCiz(int yanBosluk, int yildizAdet)
        {

            Console.WriteLine(AdetUret(yildizAdet).PadLeft(yanBosluk + yildizAdet));

        }

    }
}
