using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04IEnumerableOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Ad = "Burak", Soyad = "Akyüz", Yas = 26 };

            foreach (var item in p)
            {
                Console.WriteLine(item + " ");
            }

            IEnumerator enumerator = p.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.WriteLine(item);
            }
            enumerator.Reset();

            Console.ReadLine();
        }
    }
}
