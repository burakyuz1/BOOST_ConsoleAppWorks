using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00DictionaryUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Key için TR, USA , UK şeklinde ve 
            // Value için tr-> ankara,istanbul....
            //usa   -> washington, new york
            //uk    -> London, Watfort

            Dictionary<string, List<string>> countries = new Dictionary<string, List<string>>();

            countries.Add("TR ", new List<string>() { "Ankara", "İzmir", "Konya", "S♥msun" });
            countries.Add("USA", new List<string>() { "Washington", "New York", "Chichago", "Los Angeles" });
            countries.Add("UK ", new List<string>() { "London", "Manchester", "Bristol", "Birmingham" });


            //DE Keyine sahip bir eleman ekleyiniz.
            countries.Add("DE ", new List<string>() { "Berlin", "Munich", "Frankfurt" });

            //UK Keyini siliniz
            countries.Remove("UK");

            //Tr nin Izmir şehrini siliniz.
            countries["TR "].Remove("İzmir");

            foreach (KeyValuePair<string,List<string>> item in countries)
            {
                Console.Write(item.Key + " -> ");
                Console.WriteLine(string.Join(", ", item.Value));
            }

          


            Console.ReadLine();
        }
    }
}
