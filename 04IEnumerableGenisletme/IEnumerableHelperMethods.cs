using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04IEnumerableGenisletme
{
    internal static class IEnumerableHelperMethods
    {
        public delegate bool Kosul<T>(T value);
        public static void VirgulleYazdir<T>(this IEnumerable<T> source)
        {
            Console.WriteLine(string.Join(", ", source));
            Console.WriteLine();
        }

        public static void KosulluYazdir<T>(this IEnumerable<T> source, Kosul<T> kosul)
        {
            List<T> uyanlar = new List<T>();
            foreach (var item in source)
            {
                if (kosul(item))
                    uyanlar.Add(item);
            }
            uyanlar.VirgulleYazdir();
        }
    }
}
