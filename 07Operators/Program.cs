using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aritmetik  / * - 
            //Mantıksal || &&
            //Kıyaslama < > <= >=
            //Eşitlik operatörü == 
            //Nokta operatörü Dizi.Length();
            //new operatörü -> Random rnd = new Random();
            //is operatörü -> 1 is int => True
            //Atama operatörü -> int i= 0;

            int a = 5;
            Console.WriteLine(a++); //5 -> önce değeri yazar, sonra bellekte arttırır
            Console.WriteLine(a); //6 -> bellekte arttırılmış değeri işler

            int b = 5;
            Console.WriteLine(++b); // 6 -> hem arttırır hem yazar
            Console.WriteLine(b); //6 -> zaten bellekte 6 idi direk yazdırır.

            int c = 5;
            Console.WriteLine(c++ * ++c); //5 * 7 = 35..
            Console.WriteLine(c); // 4 

            int d = 3;
            Console.WriteLine(d + d++ * --d + d);
            Console.WriteLine(d);

            int f = 2;
            Console.WriteLine(f++ + f * f--);

            int g = 10;
            g = g++;
            Console.WriteLine(g);//10

            int i = 5;
            bool sonuc = i++ == 6 && ++i == 8; //sağa bakmaz bu yüzden sonuc = false , i = 6
            Console.WriteLine(i);
            Console.WriteLine(sonuc);

            int j = 5;
            sonuc = j++ == 6 & ++j == 8; //bitWise bu operatör sağa da bakar. bu yüzden false , 7 sonucu alır
            Console.WriteLine(j);
            Console.WriteLine(sonuc);

            //BIT WISE OPERATORS

            int x = 4; //ikilik sistemde 100
            int y = 5; //ikilik sistemde 101 

            int z = x | y;
            Console.WriteLine(z); //5

            x = 11;// 1011
            y = 7; // 0111
            z = x | y; //0011
            Console.WriteLine(z);//3 cevap verir...





            Console.ReadKey();


        }
    }
}
