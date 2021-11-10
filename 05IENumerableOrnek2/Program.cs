using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05IENumerableOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tamsayi ts = new Tamsayi(12745);
            //BURADA DEĞİŞİKLİK YAPMA
            foreach (int rakam in ts)
            {
                Console.WriteLine(rakam);
            }



            Console.ReadLine();
        }
    }
}
