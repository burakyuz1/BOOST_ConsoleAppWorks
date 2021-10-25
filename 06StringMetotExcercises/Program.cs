using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringMetotExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Earth is the third planet from the Sun and the only astronomical object known to harbour and support life. About 29.2% of Earth's surface is land consisting of continents and islands. The remaining 70.8% is covered with water, mostly by oceans, seas, gulfs, and other salt-water bodies, but also by lakes, rivers, and other freshwater, which together constitute the hydrosphere. Much of Earth's polar regions are covered in ice. Earth's outer layer is divided into several rigid tectonic plates that migrate across the surface over many millions of years, while its interior remains active with a solid iron inner core, a liquid outer core that generates Earth's magnetic field, and a convective mantle that drives plate tectonics.";

            Console.WriteLine("Together kelimesi " + s.IndexOf("together") + ". indextedir.");

            Console.WriteLine("Uzunluk : " + s.Length);

            //% karakterlerinden önceki sayıları ekrana yazdır.
            Console.WriteLine("*****************************");
            Console.WriteLine("% işaretlerinden öncekiki 4 eleman.");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '%')
                {
                    for (int j = 4; j > 0; j--)                    
                        Console.Write(s[i - j]);                    
                    Console.WriteLine();
                }
            }


            //6. ve  7. virgüller arası ne var hesapla
            Console.WriteLine("*****************************");
            Console.WriteLine("6 ve 7. virgül arasındaki karakterler");
            int sayac = 0, a = 0, b = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                {
                    sayac++;
                    if (sayac == 6)
                    {
                        a = i;
                    }
                    if (sayac == 7)
                    {
                        b = i;
                    }
                }
            }
            Console.WriteLine(s.Substring(a + 1, b - a - 1));

            Console.WriteLine("*****************************");
            string[] allWords = s.Split(' ');
            Console.WriteLine("Toplam kelime sayısı {0}", allWords.Length);



            Console.WriteLine("*****************************");
            int oHarfiSayaci = 0;
            foreach (string word in allWords)
            {
                if (word.Contains('o'))
                {
                    oHarfiSayaci++;
                }
            }
            Console.WriteLine("İçinde 'o' harfi geçen kelime sayısı: {0}", oHarfiSayaci);



            Console.WriteLine("*****************************");
            Console.WriteLine("Her harfin ayrı ayrı hesaplaması");
            string sLowerCase = s.ToLower();

            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine($"{i} harfinden {sLowerCase.Length - sLowerCase.Replace(i.ToString(),"").Length}");
            }

            Console.ReadKey();
        }
    }
}
