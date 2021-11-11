using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03StaticNonStatic
{
    //Static sınıflar sadece static üyeler(Members) içerir ve
    //kendilerinden yeni bir örnek üretilemez! waw
    internal static class Matematik
    {
        public const double ALTIN_ORAN = 31;

        public static int Kucugu(int a, int b) => a < b ? a : b; //Expression bodied Type metot tanımlama
        public static int Buyugu(int a, int b) => a > b ? a : b;
        public static int Karesi(this int a) => a * a;

    }
}
