using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DelegeExcersize
{
    //Görev : Parametre almayan string döndüren bir delege danımlayın
    //Bu delegeden oluşan değişkene Console.Readline metodunu aktarın
    // Bu delegeyi çağırarak konsoldan değer okuyun ve sonra bu değeri ekrana yazdırın.
    internal class Program
    {
        public delegate string Oku();
        static void Main(string[] args)
        {
            Oku oku = new Oku(Console.ReadLine);

            Console.Write("Delege ile okunmasını istediğin bir değer gir :");
            string deger = oku();


            Console.WriteLine(deger);




            Console.ReadLine();


        }
    }
}
