using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            double b = a;
            //İmplicit conversion : int değeri double değerine dönüştülüp öyle değişkene aktarıldı.

            int c = (int)b; //-> bu şekilde yaparsak explicit conversion
            //aktarılmaz, çünkü belki oraya ondalıklı sayı verilmiş olabilir.

            decimal d = 3.3m;
            byte e = (byte)d;
            //ondalıklı kısmını feda etmeyi göze alarak explicit conversion yaptık 
            //NOT:: Bir değerin soluna parantez içinde hedef tür girilerek yapılan dönüştürme işlemine type casting denir.

            int f = 256;
            byte g = (byte)f;
            //veri kaybı pahasına dönüşüm yaptı.. cevap olarak 0 alır çünkü -> devir eder.
            Console.WriteLine(g);
            //explicit conversion'da veri kaybı mümkündür, zaten ondan dolayı veri kaybı oluşabilecek durumlarda implicit conversion'a izin verilmez.

            double h = 1;
            decimal i = (decimal)h;

            decimal j = 3.3m;
            double k = j;

            Console.WriteLine((char)65.99);
            //explicit conversion-veri kaybı

            int o = 1;
            byte p = (byte)o;

            Convert.ToByte(false); // ile çevirebiliriz.
       

            Console.ReadKey();

        }
    }
}
