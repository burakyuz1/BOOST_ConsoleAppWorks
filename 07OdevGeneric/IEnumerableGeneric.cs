using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07OdevGeneric
{
    internal static class IEnumerableGeneric
    {
        public static void Yazdir<T>(this IEnumerable<T> source)
        {

            Console.WriteLine(string.Join(", ", source));
        }

    }
}
