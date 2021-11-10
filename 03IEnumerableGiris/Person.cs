using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03IEnumerableGiris
{
    public class Person : IEnumerable
    {
        //NOT Person sınıfı aslında foreach için çok uygun bir sınıf değildir.
        //Oğrenme amacıyla IEnumerable'i implemet ettik.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public IEnumerator GetEnumerator() //Yukarıdan implement edildi.
        {
            yield return Ad; //Tekrar tekrar döndürmek için yield kullanılır.
            yield return Soyad;
            yield return Yas;

        }
    }
}
