using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04IComparableOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 88, 2, 1, 3, 7, 100, 0 };
            string[] adlar = { "ali", "cem", "zeki", "can", "emre" };
            Array.Sort(sayilar);
            Array.Sort(adlar);

            Console.WriteLine(string.Join(", ", sayilar));
            Console.WriteLine(string.Join(", ", adlar));

            //"Hatay".CompareTo("Adana")   -> 1 döner
            //"Adana".CompareTo("Zonguldak")   -> 1 döner
            //"Samsun".CompareTo("Samsun")   -> 0 döner.

            //-> Bu integer için de , bool için de aynıdır

            Film[] filmler =
            {
                    new Film() {Ad = "Saw" , Imdb = 7.4m},
                    new Film() {Ad = "Jaws" , Imdb = 8.0m},
                    new Film() {Ad = "The Matrix" , Imdb = 8.7m},
                    new Film() {Ad = "Gora" , Imdb = 8.0m}
            };

            Array.Sort(filmler);
            foreach (var film in filmler)
            {
                Console.WriteLine(film.Ad +"  + " + film.Imdb );
            }
    

            Console.ReadKey();

        }
    }
}
