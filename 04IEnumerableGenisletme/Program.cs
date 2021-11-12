using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04IEnumerableGenisletme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> adlar = new List<string>() { "ömer faruk", "hande", "sina", "ayşegül", "uğurcan", "serkan", "kudret", "burak", "seda", "tuğba", "koray", "ali", "bilge", "ezgi", "arzu", "bilgehan" };

            adlar.VirgulleYazdir();

            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6,35,42,53 };
            sayilar.VirgulleYazdir<int>(); //program generic'i biliyor zaten. o yüzden yazmasak da olur BKNZ: bir alt satır
            sayilar.VirgulleYazdir();


            sayilar.KosulluYazdir(x => x % 2 == 0); //ciftleri yan yana yazdır
            Console.WriteLine("***");
            sayilar.KosulluYazdir(x => x > 10); //10'dan büyükleri yan yana yazdır.

           ;
            Console.ReadLine();
        }
    }
}
