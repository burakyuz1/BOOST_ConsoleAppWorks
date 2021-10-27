using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExtensionMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            Console.WriteLine("ütök".Tersi());
            Console.WriteLine(a.Karesi());



            Console.ReadKey();
            
        }
        
       
    }
}
//EXTENSION CLASS TANIMLAMA
// 1 - public static bir class tanımlanır
// 2-  public static bir metot tanımlanır.
// 3-  this keywordü kullanılarak, parametrede olan değişkene extend eder (ILK PARAMETRE OLMALI !)