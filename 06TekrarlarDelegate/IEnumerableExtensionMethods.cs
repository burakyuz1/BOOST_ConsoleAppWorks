using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06TekrarlarDelegate
{
    internal static class IEnumerableExtensionMethods
    {
        public delegate bool Kosul<T>(T sayi);
        public static void VirgulleYazdir<T>(this List<T> source)
        {
            Console.WriteLine(string.Join(", ", source));
        }

        public static void KosulluYazdir<T>(this IEnumerable<T> source, Kosul<T> kosul)
        {
            List<T> uyanlar = new List<T>();
            foreach (T item in source)
            {
                if (kosul(item))
                {
                    uyanlar.Add(item);
                }

            }
            VirgulleYazdir(uyanlar);
        }
    }


}
