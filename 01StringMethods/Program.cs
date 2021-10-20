using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Lorem ipsum dolor sit amet.";
            string metin1 = "Lorem ipsum dolor sit amet,";
            string metinCopy;

            //Yöntem 1 : Data Conversion
            metinCopy = Convert.ToString(metin.Clone());

            //Yöntem 2 : Extension Method
            metinCopy = metin.Clone().ToString();

            //Yöntem 3 : Casting 
            metinCopy = (string)metin.Clone();



            //CompareTo -> iki ifadeyi karşılaştırır eşitse 0 , değilse 1 veya -1 döndürür.
            int result = metin.CompareTo(metin1);
            Console.WriteLine(result);


            //Contains -> herhangi bir metin içerisinde parametre var ya da yok ona bakar.
            bool value = metin.Contains("dolor");

            //EndsWith -> herhangi bir metnin verilen ifadeye göre bitip bitmediğini kontrol eder.
            //StartsWith -> herhangi bir metnin verilen ifadeye göre başlayıp başlamadığını kontrol eder.

            value = metin.EndsWith("amet.");
            value = metin.StartsWith("Lorem");

            //Equals -> herhangi bir metnin diğer metin ile eşitliğini kontrol eder.
            value = metin.Equals(metin1.ToString());

            //GetHashCode -> verilen bir string ifadenin HashCode'unu verir.
            int hash = "bilgeAdam".GetHashCode();

            //GetType -> verilen ifadenin namespace.Class şeklinde tipini döner.
            Console.WriteLine("metnin Tipi : " + metin.GetType());

            //GetTypeCode -> verilen ifadenin sadece classını geri döndürür.
            Console.WriteLine("metnin class'ı" + metin.GetTypeCode());

            //IndexOf -> verilen ifadenin içerisindeki kelimeyi bulur ilk gördüğü yerdeki index numarasını geri döndürürü.

            Console.WriteLine(metin.IndexOf("su"));
            Console.WriteLine(metin.LastIndexOf("su"));

            //ToLower -> verilen metnin tüm karakterlerini küçük harf yapar.
            Console.WriteLine(metin.ToLower());

            //ToUpper -> verilen metnin tüm karakterlerini büyük harf yapara.
            Console.WriteLine(metin.ToUpper());

            //Insert -> verilen bir ifadeyi belirlenen indexten itibaren ekler.
            Console.WriteLine(metin.Insert(5, " bilge adam"));

            //Length -> verilen karakterin uzunluğunu int olarak söyler (Property)

            //Remove -> verilen bir index numarasına göre verdiğimiz integer kadar siler.

            Console.WriteLine("Burak".Remove(1,1));

            //Replace -> string içerisindeki bir değeri verdiğimiz başka bir değerle değiştirir..

            Console.WriteLine("BilgeAdam".Replace("Ad", "ad"));

            //Split -> verilen bir ifadeye göre metni parçalara ayırır.
          
            string[] dizi = new string[10];
            dizi = "burak,akyuz,bilge,adam".Split(',');
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            //ToCharArray() Metnin tüm karakterlerini bir diziye atar.

            char[] dizi2 = "burakakyuz".ToCharArray();
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }

            //trim() Metindeki boşlukları sağdan ve soldan siler.
            Console.WriteLine("          burak          ".Trim());


            //Join() Verilen ayraca göre verilen ifadeleri ayırır.
            string[] dizi3 = { "ankara","izmir","istanbul"};
            Console.WriteLine(String.Join("*",dizi3));



            Console.ReadKey();
        }
    }
}
