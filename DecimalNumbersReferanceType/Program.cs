using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndalikliSayisalVeriTurleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float num1 = 3.3f;
            double num2 = 3.3d;
            decimal num3 = 3.3m;

            //Aralarındaki farklar
            //Float-Double daha çok matematiksel işlemlerde tercih edilir. Ondalıklı kısım tam gerçekliği ifade etmeyebilir. (Deviri bi yerden sonra kesilir.) Ama bu sayede büyük ondalıklı sayıları yaklaşık olarak ifade etme şansını yakalar. Hassasiyet beklenmez, yaklaşıklık beklenir.
            double buyurBirSayi = 88888888888888888888888888888888888888888888888888888888888888888888888888888.9; //bi kısımdran sonrakini x10^2 gibi yazıyor.
                                                                                                                   // Console.WriteLine(buyurBirSayi);
                                                                                                                   //Console.ReadKey();

            //Decimal -> gerçeklik tamdır.-1 ~ 1 arasında bir aralıktaki sayıyı belirler
            decimal deciNumMax = 79228162514264337593543950335M;
            decimal deciNumMin = -79228162514264337593543950335M;

            //Ondalık hassasiyetleri.
            Console.WriteLine(1 / 3);  //0 
            Console.WriteLine(1 / 3f); //-> float
            Console.WriteLine(1 / 3d);//-> double
            Console.WriteLine(1 / 3m);//-> decimal



            decimal deciSifir = 0m;
            double doubleSifir = 0d;


            //Console.WriteLine(3 / deciSifir); //SYstem exception -> DivideByZero
            Console.WriteLine(3 / doubleSifir); //sonsuz
            Console.WriteLine(-3 / doubleSifir); // negatife sonsuz
            Console.WriteLine(doubleSifir / doubleSifir); // NaN Verir...
            Console.WriteLine(doubleSifir / doubleSifir == double.NaN); // belirsizlikler kıyaslanamaz.. methodla kıyaslanabilir
            Console.WriteLine(double.IsNaN(doubleSifir)); // true verir. Bu şekilde NaN mı diye kontrol eder...



            Console.ReadKey();
        }
    }
}
