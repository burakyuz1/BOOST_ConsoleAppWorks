using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DictionaryGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary benzersiz anahtarlarla değer tutmaya yarayan bir veri yapısıdır.

            Dictionary<int, string> sehirler = new Dictionary<int, string>() 
            {
                { 32, "Isparta"},
                { 55,  "Samsun"}
            }; //Initilizer

            sehirler.Add(1, "Adana");
            sehirler.Add(6, "Ankara"); //6 Anahtarıyla 2 adet değer eklenmez, (Key,Value) Tek bir key olabilir.
            sehirler.Add(34, "Istanbul");
            sehirler.Add(35, "Izmir");
            sehirler.Add(46, "Maraş");
            sehirler.Add(82, "NewYork");


            sehirler[46] = "Kahramanmaraş"; // Index yerine Key kullanılır. Index'ten ulaşılmaz.

            //spesifik olarak bir şehri yazdırma
            Console.WriteLine(sehirler[35]);

            //Index olarak bakmak için ElementAt kullanılır
            Console.WriteLine(sehirler.ElementAt(1).Value);

            //Belli bir itemi kaldırmak için 
            sehirler.Remove(82);

            foreach (KeyValuePair<int, string> cift in sehirler)
            {
                Console.WriteLine(cift.Key + " " + cift.Value);
            }

            Console.ReadKey();
        }
    }
}
