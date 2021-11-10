using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06IEnumerableOrnek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> list = new List<string>();
            IEnumerable<int> numberList = new int[] { 1, 2, 3 };
            List<string> aa = new List<string>();

            //IEnumerable -> bir çok extension metot'u vardır. Bunlar system.Linq kütüphanesinde bulunur.
            Console.WriteLine(numberList.Sum());
            Console.WriteLine(numberList.Min());
            Console.WriteLine(numberList.Max());
            Console.WriteLine(numberList.Average());
            IEnumerable<int> sirali = numberList.OrderBy(x => x); //Küçükten büyüğe sıralama

            string baba = "baba";
            sirali = baba.Select(x => (int)x); // .Selec() Extension metotuyla x'i int'e cast ederek ASCII lerini alabiliriz

            int[] babaDizi = sirali.ToArray(); // IEnumerable'ı babaDizinin içine ToArray() metodu ile koyabiliriz.

            Console.WriteLine(string.Join(", ", babaDizi));

            int[] benimliste = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(benimliste.Max()); //IEnumerable türünde olduğu için System.Linq Kullanabildim.

        }
    }
}
