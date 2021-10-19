using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05KararYapilari_GununSozu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomSayi;
            string devamMi = "";
            Console.WriteLine("Günün sözünü yazdıran program ENTER bastıkça yeni söz verir. Çıkış için E basın.");

            while (devamMi=="")
            {
                randomSayi = rnd.Next(6);
                devamMi = Console.ReadLine();
                if (devamMi == "E" || devamMi == "e")                
                    Environment.Exit(0);

                Console.ForegroundColor = ConsoleColor.Red;
                switch (randomSayi)
                {

                    case 0:
                        Console.WriteLine($"\"The journey of a thousand miles begins with one step. -Lao Tzu\"");
                        break;
                    case 1:
                        Console.WriteLine("\"That which does not kill us makes us stronger. -Friedrich Nietzsche\"");
                        break;
                    case 2:
                        Console.WriteLine("\"You must be the change you wish to see in the world. -Mahatma Gandhi\"");
                        break;

                    case 3:
                        Console.WriteLine("\"Whether you think you can or you think you can’t, you’re right. -Henry Ford\"");
                        break;
                    case 4:
                        Console.WriteLine("\"Great minds discuss ideas; average minds discuss events; small minds discuss people. -Eleanor Roosevelt\"");
                        break;
                    default:
                        Console.WriteLine("\"Dream big and dare to fail. -Norman Vaughan\"");
                        break;
                }
                
            }


      
            Console.ReadKey();
        }
    }
}
