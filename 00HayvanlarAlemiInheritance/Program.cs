using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00HayvanlarAlemiInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.HareketEt();
            kedi.Beslen();
            kedi.SesCikar(); ;

            Hayvan hayvan = kedi;
            hayvan.HareketEt(); // Base class Child class a virtual ile yetki verdi.
                                // Chhild class da override kullandığı için ne zaman kedi newlesek kendi metotlarını kullanabilecek. Aksi halde kendi metotlarını kullanamaz.  Base Class'ın metoduna muhtaç kalır.
                                //Kedi aynı zamanda hayvandır.


            Kus kus = new Kus();
            hayvan = kus;
            hayvan.Beslen();
            hayvan.HareketEt();
            hayvan.SesCikar();
            Console.WriteLine("************");

            Hayvan[] hayvanListesi = new Hayvan[6];

            for (int i = 0; i < 3; i++)
            {
                hayvanListesi[i] = new Kus();
                hayvanListesi[i].HareketEt();
                Kedi cat = (Kedi)hayvanListesi[i]; // gelen hayvanın kedi olduğunu bildiğim için cast edebilirim. ve onu  cat adında kedi sınıfına alabilirim.
                cat.Tirman(); // kedinin metodunu kullanabilir. bu da polimorfizmdir.
            }

            for (int i = 3; i < 6; i++)
            {
                hayvanListesi[i] = new Kedi();
                hayvanListesi[i].HareketEt();
                Kus bird = (Kus)hayvanListesi[i];
                bird.YuvaYap();
            }





            Console.ReadLine();
        }
    }
}
