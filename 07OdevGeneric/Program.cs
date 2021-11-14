using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07OdevGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Öyle bir metot yazın ki list olsun dizi olsun int listesi olsun char listesi olsun 
            //Her türlü foreach 'e girebilen yapıların öğelerini ekrana satır satır yazdırabilsin.

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 15 };
            sayilar.Yazdir();

            string[] kelimelerDizisi = { "bilge", "adam", "boost", "5" };
            kelimelerDizisi.Yazdir();

            List<object> karisikList = new List<object>() { "burak", true, '5', -2, 10.4 };
            karisikList.Yazdir();

            List<char> charList = new List<char>() { 'b', '.', 'a', 'k', 'y', 'ü', 'z' };
            charList.Yazdir();


            Console.ReadLine();



        }
    }
}
