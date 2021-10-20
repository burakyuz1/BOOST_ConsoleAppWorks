using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Enviroment_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(CultureInfo.CurrentCulture);
            Console.WriteLine("Ad-Soyad girin: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + isim + Environment.NewLine + "Çıkmak için bir tuşa basınız.");

            Console.WriteLine("Makina adı : " + Environment.MachineName);
            Console.WriteLine("Kullanıcı adı : " + Environment.UserName);
            Console.WriteLine("Network Kullanıcı adı : " + Environment.UserDomainName);

            Console.WriteLine($"sbyte -> max Value : {sbyte.MaxValue} / min Value : {sbyte.MinValue}");
            Console.WriteLine($"byte -> max Value : {byte.MaxValue} / min Value :  {byte.MinValue}");
            Console.WriteLine($"long -> max Value : {long.MaxValue} / min Value : {long.MinValue} ");
            Console.WriteLine($"int -> max Value : {int.MaxValue} / min Value : {int.MinValue} ");
            Console.WriteLine($"short -> max Value : {short.MaxValue} / min Value : {short.MinValue} ");
            Console.WriteLine($"float -> max Value : {float.MaxValue} / min Value : {float.MinValue} ");
            Console.WriteLine($"double -> max Value : {double.MaxValue} / min Value : {double.MinValue} ");
            Console.WriteLine($"decimal -> max Value : {decimal.MaxValue} / min Value : {decimal.MinValue} ");
            //Kullanıcıdan alınan 3 sayıyı  
            //formül 1 -> (x+y)*z
            //formül 2 -> x*y+ y*z 
            //formül 3 -> (x+y)^z  formüllerine göre hesaplayınız .

            Console.Write("1. sayıyı girin : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı girin : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. sayıyı girin : ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            int formul1 = (sayi1 + sayi2) * sayi3;
            int formul2 = (sayi1 * sayi2) + (sayi2 * sayi3);
            double formul3 = Math.Pow((sayi1 + sayi2), sayi3);


            //Console.WriteLine($"(x+y)*z formülüne göre sonuç = {formul1} {Environment.NewLine}x*y+ y*z formülüne göre sonuç = {formul2}{Environment.NewLine}(x+y)^z formülüne göre sonuç = {formul3}");

            Console.WriteLine("(x+y)*z formülüne göre sonuç ={0}{1}x*y + y*z formülüne göre sonuç ={2}{3}(x+y)^z formülüne göre sonuç ={4}   ", formul1, Environment.NewLine, formul2, Environment.NewLine, formul3);

            Console.Write("a sayısı girin : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b sayısı girin : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a^b = {Math.Pow(a, b)}");

            //Perfect Square:

            Console.Write("Perfect Square hesaplamak için bir sayı girin : ");

            int perfectNumber = Convert.ToInt32(Console.ReadLine());
            double kok = Math.Sqrt(perfectNumber);

            if (kok * kok == perfectNumber)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Değil");
            }


            //kullanıcıdan alınan celcius derecesini fahreneit ve kelvin cinsinden hesaplayınız.
            Console.WriteLine("Bir celsius derece girin : ");
            double degree = Convert.ToInt32(Console.ReadLine());
            //c* 18 / 10 +32 -> Celsius to Fahrenheit
            //c + 273.15 -> Celsius to Kelvin
            Console.WriteLine($"Kelvin : {degree + 273.15}");
            Console.WriteLine($"Fahrenheit : {degree * 1.8 + 32}");


            //Kullanıcıdan alınan 2 değeri yerlerini değiştirerek ekrana yazdırınız 

            Console.Write("Birşey gir: ");
            string data1 = Console.ReadLine();
            Console.Write("Birşey daha gir: ");
            string data2 = Console.ReadLine();
            string temp;
            temp = data1;
            data1 = data2;
            data2 = temp;

            Console.WriteLine($"{data1}{data2}");

            Console.ReadKey();

        }
    }
}