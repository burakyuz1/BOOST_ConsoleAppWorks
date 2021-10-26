using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00DateTimeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(); // Tarih ve saat işlemleri için kullanılır
            dt = dt.AddYears(2002);
            dt = dt.AddMonths(1); //fazla girersek devreder
            dt = dt.AddDays(2);

            Console.WriteLine(dt);
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.DayOfYear);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Today.ToShortDateString());

            DateTime dt2 = new DateTime(2002,2,2);
            Console.WriteLine(dt2.ToString("yyyy-MMMM-dd"));

            DateTime birinciZaman = new DateTime(2021,10,25,10,7,10);
            TimeSpan ts = DateTime.Now - birinciZaman;

            Console.WriteLine((int)ts.TotalHours);






            Console.ReadKey();
        }
    }
}
