using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double tutar;
        tekrar:
            Console.Write("Indirim hesaplamak  için tutar giriniz : ");

            try
            {
                tutar = Convert.ToDouble(Console.ReadLine());
                if (tutar < 0)
                    throw new Exception("0'dan küçük");
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
                goto tekrar;
            }

            if (tutar < 100)
            {
                Console.WriteLine("Indirim yok.");
            }
            else if (tutar < 200)
            {
                tutar -= ((tutar * 10) / 100);
            }
            else if (tutar < 300)
            {
                tutar -= ((tutar * 15) / 100);
            }
            else
            {
                tutar -= tutar * 30 / 100;
            }

            Console.WriteLine(tutar);


            Console.ReadKey();
        }
    }
}
