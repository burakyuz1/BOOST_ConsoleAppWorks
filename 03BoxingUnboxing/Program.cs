using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = "Ali ata bak";

            Console.WriteLine(o.ToString());

            object o2 = 333;

            Console.WriteLine( o2); //Obj ile 1 toplanamaz.
            Console.WriteLine( (int)o2 + 1); //int obj in içinde olduğu için. kutusundan çıkarıp int olarak kullanabiliyoruz.

            object a = 1; //obj bir CLASS tır . Bu sebepten dolayı bir REFERANCE TYPE dır. TÜM TÜRLER BUNDAN MİRAS ALIR.
                         // içine bir value type atmak istiyorum.
                         // Obj kutusunun içine bir int oluşturulur. onun içinde 1 saklanır.
                         // Buna da BOXING denir. - Object sayesinde bir adrese sahip oldu.
                         // Yani obj in içine bir int atmak için ADRES TAYİN ederek içine int verilir.
            object b = "1"; //heap alanında ref typeı vardır. REF -> Heap a gösterir. 
                            //HEAP alanında bir string alan oluşturulur referans verilir ve orayı gösterir.
                            //IMPLİCİT oldu.
                            //BOXING Olmadı. -- Zaten bir adresi vardı. OBJ sayesinde adres aldı diyemem. bu yüzden BOXING DEĞİL.

            int c = (int)a; // UNBOXING

            Console.WriteLine(string.Concat("ali",3,true)); // 3 ve true bir boxing işlemidir. bool -> object , int -> object


            List<object> mixedList = new List<object>();
            mixedList.Add("first group");
            for (int i = 1; i < 5; i++)
            {
                mixedList.Add(i);
            }
            int sum = 0;
            //kareleri toplamı
            for (int i = 1; i < 5; i++)
            {
                sum += (int)mixedList[i] + (int)mixedList[i]; // object içinden integerları unboxing yaptık. böylece işleme izin verdi.
            }

            int sayi = 10;
            object sayiObj = sayi;

            sayi = 20;

            //sayiObj = 10   ,   sayi= 20
            //Çünkü object ref type dır. gösterdiği değer heap alanında int(sayi=10) dur. sayı değişince sayının value type olduğunu göze alarak stack alanında değişim olur. dolayısıyla sayiObj nin gösterdiği yer değişmediğinden değeri de 10 olarak kalır.

            int sayi3 = 30; // value type
            object o3 = sayi3; // boxing işlemi
            int sayi4 = (int)o3; // unboxing işlemi

            bool d = true; //value type
           //ref type 'e'
            object e = d;
            bool f = (bool)e; //UNBOXING 

            //NOT: KUtulama (boxing) implicit şekilde yapılırken --> KAPALI DÖNÜŞÜM
            // UNBOXING explicit şekilde yapılır. --> AÇIK DÖNÜŞÜM  CASTING 


            object[] birDizi = { "ali", new Random(), 3, true, 'c', 3.3, 2m };
            //Yukarıda kaç adet kutulama islemi yapılmıştır.
            //ali ve random ref type olduğu için adreslerinin atanması yeterli, diğerleri value type olduğu için mecbur boxing yapılmalıdır.

            int g = (int)birDizi[2]; //Object kutusundan çıkarmak lazım.
            


            Console.ReadKey();
        }
    }
}
