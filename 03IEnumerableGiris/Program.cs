using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03IEnumerableGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hangi tür nesneler foreach yapısı ile kullanılabilir.
            //Diziler, Listeler, koleksiyonlar, Dictionary 
            //Hepsi IENumerable interface'ini implemete etmiştir.

            Console.WriteLine(new int[0] is IEnumerable);
            Console.WriteLine(new List<string>() is IEnumerable);

            //Erzurumun harflerini ekrana yazdırma (Foreachsiz)

            IEnumerator enumarator = "erzurum".GetEnumerator();
            while (enumarator.MoveNext()) //Sıradakine geçebildiğin sürece bana sıradakini ver.
            {
                char item = (char)enumarator.Current;
                Console.Write(item + " - ");
            }

            object[] nesneler = { "ali", 3, true, 4.4, 'c', DateTime.Now };

            IEnumerator enumerator2 = nesneler.GetEnumerator(); //IEnumerator interfaceinin .GetEnumerator metodunu kullanarak, obj i aktardım.

            while (enumerator2.MoveNext()) //Yukarda aktarımını yaptığım IEnumerator'de dolaştım. MoveNext() Bool döndürür, var mı yok mu diye kontorl                                                                                                                                      eder
            {
                object item = enumerator2.Current;  //Current, şu ankini item obj içine aktar
                Console.WriteLine(item + ": " + item.GetType()); //kendini ve tipini yazdır...
            }

            Person person = new Person() { Ad = "Mustafa", Soyad = "Kamil", Yas = 41 };
            foreach (var p in person) //person'u IEnumerable yaptığım için iterate edebildim.0
            {
                Console.WriteLine(p + " ");
            }

           // enumarator = person.GetEnumerator(); -> Diyerek while ile de dönebilirdik.


            Console.ReadLine();
        }
    }
}
