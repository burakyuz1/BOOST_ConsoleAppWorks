using System;

namespace _03DelegelerZamanlayiciOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sizden bir projede kullanılmak üzere, bir küçük sınıf yazmanız isteniyor.
            // Bu sınıfın adı Zamanlayici olup, yazacağınız Yap metodu, belirtilen islemi belirtilen adet kadar,
            // ve belirtilen zaman aralıklarıyla yapması bekleniyor.
            // 0rnek kullanim :
            // 10 kere 100ms aralıklarla tarih/saati yaz.
            Console.Beep();
            Zamanlayici.Yap(Console.Beep, 10, 10);
            Zamanlayici.Yap(() => Console.Write(DateTime.Now), 10, 100);

            Console.WriteLine();
            int sayac = 1;
            Zamanlayici.Yap(() => Console.WriteLine(sayac++), 10, 100);


            Console.ReadLine();
        }


    }
}
