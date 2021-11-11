using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03StaticNonStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // new Kisi() dediğim zaman bunlar non-static yani durağan değil. bellekte boşlukta bi yerde durur.
            // bağlamadığım zaman da o boşlukta GC tarafından toplanır.
            // Bir sınıfın static prop değiştiğin zaman komple sınıfın tüm elemanları için değişir.
            // statik üyeler hiçbir örnek oluşturmasan dahi aktif olarak varlardır.

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Static üyedir. 
            // Sınıf instance'larından bağımsız ve durağan olduğu için örnek oluşturmadan erişim sağlanabilir.
            Console.WriteLine(Kisi.KisiAdet);
            Kisi k1 = new Kisi() { Ad = "Burak", Soyad = "Akyüz" };
            Kisi k2 = new Kisi() { Ad = "Murat", Soyad = "Karan" };
            Kisi k3 = new Kisi() { Ad = "Zeliha", Soyad = "Akkaşoğlu" };
            Kisi k4 = new Kisi() { Ad = "Kerimhan", Soyad = Kisi.SoyadOner() };

            //Bellekte 3er adet ad ve soyad içeren Kişi nesnesi oluşturuldu
            // Ancak hala sadece bir adet KisiAdet int  değeri bulunmaktadır.
            //static üyelerde sınıfların örneklerinden erişilemez.
            // k1.KisiAdet = 3 --> HATALI KULLANIM
            Kisi.KisiAdet = 3; //  DOĞRU  KULLANIM

            Console.WriteLine(k1.TamAd()); // Static değil bu şekilde kullanabilirim.

            //Soyad önerisi static bir metot

            Console.WriteLine(Kisi.SoyadOner()) ;

            //Matematik sınıfı static bir sınıf olduğu için new'yelemeyiz.
            // HATALI : Matematik mat = new Matematik(); :HATALI
            Console.WriteLine(Matematik.Karesi(31));
            Console.WriteLine(Matematik.Kucugu(3,4));
            Console.WriteLine(Matematik.Buyugu(9,6));

            Console.WriteLine(Matematik.ALTIN_ORAN); //Değiştirilemez. Sabit değerdir. Statictir. Newlenmeden Kullanılır
                                                     //Zaten Class bir static olduğu için içine non static üye tanımlayamam.

            //Static class'ın içinde extension metot yapabiliriz.
            Console.WriteLine(2.Karesi()); //Int sınıfının bir metoduymuşcasına...




            Console.ReadLine();
        }
    }
}
