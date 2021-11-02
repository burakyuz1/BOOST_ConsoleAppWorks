using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07OOPGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> adlar = new List<string>() { "Ezgi", "Arzu", "Serkan", "Yiğit" };
            List<int> yaslar = new List<int>() { 25, 26, 25, 34 };

            for (int i = 0; i < adlar.Count; i++)
            {
                Console.Write(adlar[i] + " "+yaslar[i]); //Nesneler bütün değil, kopukluk var. 2 Ayrı liste birbiriyle bir ilişkisi yok.
                                                        // Listeyi sort ettiğim zaman, kopukluk açık bir şekilde görünüyor.
            }

            Console.ReadLine();
        }
    }
}
