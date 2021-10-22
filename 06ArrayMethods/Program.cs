using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clear : dizinin belirlenen aralıktaki elemanlarının türünün default değerine eşitler.

            int[] dizi1 = { 1, 3, 5, 7, 8, 9, 3, 3 };
            Array.Clear(dizi1, 2, 3);
            Console.WriteLine("Dizinin uzunluğu: " + dizi1.Length);

            foreach (var item in dizi1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            //IndexOf : dizide belirli bir elemanın baştan başlayarak ilk geçtiği indexi döndürür
            //          bulamaz ise -1 
            int dokuzunIndexi = Array.IndexOf(dizi1, 9);
            Console.WriteLine("Dokkuzun indexi: " + dokuzunIndexi);
            int dortunIndexi = Array.IndexOf(dizi1, 4);
            Console.WriteLine("Dört'ün indexi: " + dortunIndexi);


            //LastIndexOf: IndexOf gibidir, ancak sondan aramaya başlar
            int ucunSonGorulduguIndex = Array.LastIndexOf(dizi1, 3);
            Console.WriteLine("Üç'ün son görüldüğü index: " + ucunSonGorulduguIndex);

            //Reverse : Diziyi tersine çeviren metot 
            Console.WriteLine("dizi Tersine çevrildikten sonra :");
            Array.Reverse(dizi1);
            foreach (int eleman in dizi1)
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine();


            //Sort : Diziyi sıralayan metot 
            Console.Write("dizi Tersine çevrildikten sonra: ");
            Array.Sort(dizi1);
            foreach (int eleman in dizi1)
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine();

            //Diziye 99 ve 100 sayılarını eklemek istiyoruz 
            //Diziler oluşturulktan sonra boyutu değiştirilemez
            //ama yardımcı metot ile aynı değişkene eski dizinin elemanlarını da içeren
            //yeni boyutlu bir dizi atamak mümkündür.
            int[] yedek = dizi1;
            Array.Resize(ref dizi1, dizi1.Length + 2);
            dizi1[dizi1.Length - 2] = 99;
            dizi1[dizi1.Length - 1] = 100;
            Console.Write("Dizinin boyutu +2 ve 99-100 sayıları eklendi: ");
            foreach (int eleman in dizi1)
            {
                Console.Write(eleman + " ");
            }

            Console.WriteLine();
            //Yedek -> dizi bir referans türüdür.
            //Array resize mevcut diziyi değiştiremez. Sadece referans gösterilerek kopyası başka diziye aktarılır. IMMUTABLE olarak geçer.
            //Stringler ve DateTime'lar da buna örnektir. 

            foreach (int eleman in yedek)
            {
                Console.Write(eleman + " ");
            }


            //Basketbol takımı 

            string[] takim = { "bilgehan", "ayşegül", "tuğba", "burak", "serkan" };

            //yedekler
            string[] yedekler = { "hande", "seda" };

            //ayşegül ve tuğbannın düğünü olduğu için onların yerine yedekleri yerleştirin.
            Array.Copy(yedekler, 0, takim, 1,2);

            Console.WriteLine("değişimden sonraki takım");
            for (int i = 0; i < takim.Length; i++)
            {
                Console.Write(takim[i] + " ");
            }
            Console.WriteLine();



            //2,1 yerine ikinci dizinin 77,88 i ekle
            int[] sayilar1 = { 3, 4, 2, 1, 1, 7 };
            int[] sayilar2 = { 66, 77, 88 };

            //Kaynak, baslangic, hedef, baslangic,uzunluk (Overload'ı)
            Array.Copy(sayilar2, 1, sayilar1, 2, 2);


            foreach (int sayi in sayilar1)
            {
                Console.Write(sayi + " ");
            }

            Console.ReadLine();

            //"İki diziyi birleştirme" ile "1. arrayda olup 2. arrayda olmayan" örnekleri bu methodlardan uygun olananı kullanarak kendin yap.
        }
    }
}
