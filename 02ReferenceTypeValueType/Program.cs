using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ReferenceTypeValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#'taki tüm türler ya Reference type ya da Value Typde ailesine aittir.
            int a = 3;
            int b = a;
            b++;
            Console.WriteLine(a); //  (3)  (CD kopyalayınca , kopyada yapılan değişiklikler orjinali alakadar etmez.)

            int[] dizi = { 1, 2, 3, };
            int[] dizi2 = dizi;
            dizi2[0] += 10;
            Console.WriteLine(dizi[0]); //(11) Reference type olduğu için gösterdiği değeri değiştirmiş oldu. Bellekte tek değer tutulur. o değişince öteki de değişir

            string c = "at";
            string d = c;
            d = d.ToUpper();
            Console.WriteLine(c); //Inmutable olduğu için yeni değere atar. STRINGLER REF TYPE OLMASINA RAĞMEN DEĞİŞİM OLMAZ. C'ye yeni değer atamadık. atamadığımız sürece değişim olmaz






            Console.ReadLine();
        }
    }
}
