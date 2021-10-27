using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExtensionMetot
{
    public static class AdditionalMethods
    {
        public static string Tersi(this string metin) //This keywordu sayesinde string sınıfını extend ettik.
                                                     // Yani "ifade".Tersi() kullanarak ulaşım sağlayabiliriz.
        {
            char[] dizi = metin.ToCharArray();
            Array.Reverse(dizi);
            return new string(dizi);
        }
        public static int Karesi(this int sayi)
        {
            return sayi * sayi;
        }
    }
}
