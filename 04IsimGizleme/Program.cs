using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04IsimGizleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime girin baş harfleri hariç gizlenecek");
            string text = Console.ReadLine();

            string[] kelimeler = text.Split(' ');

            foreach (var kelime in kelimeler)
            {
                string yeni = kelime[0] + new string('*', kelime.Length - 1);
                Console.Write(yeni + " ");
            }
            

            Console.ReadKey();

        }
    }
}
