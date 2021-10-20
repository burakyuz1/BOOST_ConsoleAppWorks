using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05TryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
        bas:
            try
            {
                Console.WriteLine("Sayı");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi * sayi);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Sadece sayı girebilirsin..");
                goto bas;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok büyük ya da çok küçük girdin");
                goto bas;
            }
            finally
            {
                //Hata olsun olmasın burası çalışır
                // Kaynaklar : veritabanında bağlantı kopartma
                //             Dosya oluşturunca kapatmak için kullanılır.
            }

            Console.ReadKey();
        }
    }
}
