using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OOPCalismalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Hayvan().Tur);
            Console.WriteLine(new Hayvan("İnek").Tur);

            Console.WriteLine(new Maymun().Tur);

            Console.ReadLine();
        }
    }
}
