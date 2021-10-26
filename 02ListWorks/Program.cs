using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ListWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> adlar = new List<string>() { "Koray", "Ömer" };
            Console.WriteLine("Uzunluk: " + adlar.Count);
            adlar.Add("Burak");
            adlar.Add("Ayşegül");
            adlar.Add("Hande");
            adlar.Add("Sina");
            adlar.Add("Arzu");
            Console.WriteLine("Uzunluk: " + adlar.Count);
            Console.WriteLine("İlk elemanı: " + adlar[0]);
            Console.WriteLine("Son elemanı: " + adlar[adlar.Count - 1]);
            Console.WriteLine(string.Join(" ", adlar));


            foreach (var item in adlar)
            {
                Console.Write(item + " ");
            }

            //Adlar.Sort -> Sıralama işlemi
            //Adlar.RemoveAt -> verilen indexteki değeri silme
            //Adlar.Remove -> verilen değeri bulup silme

            //fibonacci sayı dizisinin ilk 20 elemanını bir listeye atayın.
            //Console.WriteLine("\nFibonacci Sayı Dizisi : ");
            //List<int> fibSayilar = new List<int>() { 0, 1 };

            //for (int i = 2; i <= 20; i++)
            //{
            //    fibSayilar.Add(fibSayilar[i - 1] + fibSayilar[i - 2]);
            //    Console.Write(fibSayilar[i] + " ");
            //}

            //Yontem II
            //while (fibSayilar.Count < 20)
            //{
            //    fibSayilar.Add(fibSayilar[fibSayilar.Count - 1] + fibSayilar[fibSayilar.Count - 2]);
            //}
            //Console.WriteLine(string.Join(", ",fibSayilar));

            //List<int> rastgeleSayilar = new List<int>();
            //int yeni;
            //Random rnd = new Random();
            //while (rastgeleSayilar.Count<6)
            //{
            //    if (!rastgeleSayilar.Contains(yeni = rnd.Next(1,49)))
            //    {
            //        rastgeleSayilar.Add(yeni);
            //    }
            //}

            string[] adlar1 = { "omer", "hande", "ayşegül", "uğurcan", "serkan", "kudret", "burak", "seda", "tuğba", "koray", "ali", "bilge", "ezgi", "arzu", "bilgehan", "sina" };

            List<string> tumu;
            List<string> tekler = new List<string>();
            List<string> ciftler = new List<string>();


            tumu = new List<string>(adlar1);

            for (int i = 0; i < tumu.Count; i++)
            {
                if (i % 2 == 0)
                {
                    tekler.Add(tumu[i]);
                }
                else
                {
                    ciftler.Add(tumu[i]);
                }
            }
            Console.WriteLine("\nTüm isimler");
            foreach (string isim in tumu)
                Console.Write(isim + " ");

            byte tek = 1;
            byte cift = 0;

            Console.WriteLine("\nTek sıra");
            foreach (string tekSira in tekler)
            {
                Console.Write($"{tek}. index : {tekSira} ");
                tek += 2;
            }

            Console.WriteLine("\nÇift sıra");
            foreach (string ciftSira in ciftler)
            {
                Console.Write($"{cift}. index : {ciftSira} ");
                cift += 2;
            }


            //Sayilar dizisinin elemanlarını tekrarsız olarak bir lisetede saklayınız.
            int[] sayilar = { 1, 3, 3, 5, 1, 11, 22, 33, 11, 7, 6, 5 }; //1,3,5,11,22,33,6,7
            List<int> sayilarList = new List<int>(sayilar);
            for (int i = 0; i < sayilarList.Count; i++)
            {
                for (int j = i + 1; j < sayilarList.Count; j++)
                {
                    if (sayilarList[i] == sayilarList[j])
                    {
                        sayilarList.RemoveAt(j);
                    }
                }
            }//Hocanın algoritma : Sayıları sırala, yazdırırken bir sonrakini içermediği sürece yazdır.
            Console.WriteLine();

            Console.WriteLine(string.Join(", ", sayilarList));
            Console.WriteLine();


            List<int> sayilar1 = new List<int>();

            for (int i = 10; i >= 1; i--) //7 haric ekler
            {
                if (i == 7)
                    continue;
                sayilar1.Add(i); //10 9 8 6 5 4 3 2 1 
            }

            sayilar1.RemoveAt(6);//10 9 8 6 5 4  2 1 
            sayilar1[3] ++;//10 9 8 7 5 4 2 1 
            int temp = sayilar1[0];
            sayilar1[0] = sayilar1[sayilar1.Count - 1];
            sayilar1[sayilar1.Count - 1] = temp; //1 9 8 7 5 4 2 10

            Console.WriteLine(string.Join(", ", sayilar1));



            Console.ReadKey();

        }
    }
}
