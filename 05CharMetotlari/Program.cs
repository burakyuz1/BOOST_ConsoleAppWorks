using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CharMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(char.IsWhiteSpace(' ')); //true
            Console.WriteLine(char.IsWhiteSpace('\t')); //true
            Console.WriteLine(char.IsLetter('ğ')); //true
            Console.WriteLine(char.IsLetter(',')); //false
            Console.WriteLine(char.IsNumber('2'));//true
            Console.WriteLine(char.IsNumber('-'));//false
            Console.WriteLine(char.IsNumber('¾'));//true
            Console.WriteLine(char.IsDigit('¾'));//false
            Console.WriteLine(char.IsDigit('4'));//true

            Console.WriteLine(char.IsPunctuation('!')); //imla karakteri mi 


            for (int i = 0; i < char.MaxValue; i++)
            {
                char a = (char)i;
                if (char.IsPunctuation(a))
                {
                    Console.Write(a + " ");
                }
            }





            Console.ReadKey();
        }
    }
}
