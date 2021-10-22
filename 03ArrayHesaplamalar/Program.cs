using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ArrayHesaplamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] yaslar = { 34, 25, 26, 25, 25, 24, 26, 28, 32, 27, 27, 24, 28, 26, 27, 18, 25 };

            //yaşların en küçüğünü, en büyüğünü, ortalamasını bulunuz
            int min = yaslar[0], max = 0;
            double toplam = 0;
            for (int i = 0; i < yaslar.Length; i++)
            {
                if (yaslar[i] > max)
                {
                    max = yaslar[i];
                }
            }

            for (int i = 0; i < yaslar.Length; i++)
            {
                if (yaslar[i] < min)
                {
                    min = yaslar[i];
                }
            }

            for (int i = 0; i < yaslar.Length; i++)
            {
                toplam += yaslar[i];
            }

            double ortalama = toplam / yaslar.Length;


            Console.WriteLine($"EN büyük yaş {max} Yaşların ortalaması : {ortalama} En küçük yaş {min}");
            Console.ReadKey();

        }
    }
}
