using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06OpsiyonelArgumanlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Yazdir("Merhaba", true, true, true);
            Yazdir("***************************",ortali:true,yeniSatir:true);
            Yazdir(yeniSatir: true);





            Console.ReadKey();
        }
        static void Yazdir(string metin="", bool buyuk = false, bool ortali = false, bool yeniSatir= false) // eşit koyarsak, opsiyonel olur, kullanıcının keyfine bakar
        {
            if (buyuk) metin = metin.ToUpper();
            if (ortali) metin = new string(' ', (Console.BufferWidth - metin.Length) / 2) + metin;
            if (yeniSatir) metin = metin + Environment.NewLine;

            Console.Write(metin);
        }
    }
}
