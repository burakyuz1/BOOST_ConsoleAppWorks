using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrayler sıralı bir şekilde aynı türde verileri bir arada tutan bir veri yapısıdır.
            string[] names = { "ömer", "hande", "sina ", "ayşegül", "uğurcan", "serkan", "kudret", "burak", "seda", "tuğba", "koray", "ali", "bilge", "ezgi", "arzu", "bilgehan" };

            Console.WriteLine("Dizinin uzunlugu " + names.Length);
            Console.WriteLine("Dizinin ilk elemanı" + names[0]);
            Console.WriteLine("Dizinin son elemanı" + names[names.Length - 1]);
            //Bilgenin indexi kaç?
            int bilgeIndex = Array.IndexOf(names, "bilge");
            Console.WriteLine(bilgeIndex);
            names[bilgeIndex] = "Bilge Tuna";

            foreach (var name in names)
            {
                Console.Write($"{name} ");
            }

            Array.Sort(names);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine(names.Length);
            Console.ReadKey();

        }
    }
}
