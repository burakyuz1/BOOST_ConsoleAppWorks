using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Examples
{
    class Program
    {
        static void Main(string[] args)
        {
        //Console.Write("Yaş girin : ");
        //int yas = Convert.ToInt32(Console.ReadLine());
        //string durum = (yas < 18) ? "Ehliyet alamaz" : "Ehliyet alır";
        //Console.WriteLine(durum);


        //Kullanıcıdan alınan kelimenin ilk ve son harflerini değiştererek ekrana yazınız.
      
            Console.WriteLine("Bir kelime giriniz : ");

            Console.WriteLine(ChangePositions(Console.ReadLine()));            

            Console.ReadKey();

        }


        private static string ChangePositions(string text)
        {
            if (text.Length > 1)
            {
                string firstChar = text.Substring(0, 1);
                string lastChar = text.Substring(text.Length - 1);
                string middleChars = text.Substring(1, text.Length - 2);
                return lastChar + middleChars + firstChar ;
            }
            else
            {
                return text;
            }

        }
    }
}
