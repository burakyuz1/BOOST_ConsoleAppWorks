using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_OOPTekrarExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP bir programlama dili midir?
            //-> Değildir. Object Oriented Programming yani Nesne Yönelimli Programlama, her işlevin nesnel olarak soyutlandığı bir programlama tekniğidir.
            //Class ve object farkı nedir
            //> classlar sayesinde programı parçalara bölüp içerisine propertyler fieldlar constructorlar koyalarak bunları defalarca kullanılırız.
            //> obj ise bu classlardan üretilerek bunun özelliklerini kullanılır.

            //Classlar içerisinde neler bulunabilir.
            //>property - Constructor - fields - events - metotlar - desctructor

            //> 4 pillars of OOP -> Encapsulation, Polimorphizim, Inheritance, Abstraction
            //Polimorpihzm -> Metotların objeye göre farklı çıktılar üretmesi veya farklı işler yapmasıdır. Metodlara sabit görevler vermek yerine onlara çok biçimli davranacak şekilde bir esneklik verilebilir. ORN: hayvan sınıfından kalıtım kalmış kedinin miyav sesi çıkarması. Hangi nesneden türerse ona görev davranış gösterir.
            //Encapsulation -> propertylerin korumaya alınması. bunun için access modifierlar ve getter setterlar kullanılır.
                        //Private-> sadece aynı sınıf içerisinde erişilebilir.
                        //Public-> herkese açık
                        //Internal-> Aynı proje içinde erişilen.

                        //Protected ->  Base Class'a yazılır.

                        //Protected Internal ->Ya miras aldığı sınıftan - ya da aynı projeden erişim sağlanır.

            //Abstaction -> base classtan chilld classa aktarım yapmak istediğimizde child class bu metotlardan farklı faydalanıyor olabilir. böylece metodu soyutlarız, örnek olarak şekil sınıfını base class olarak düşündüğümüzde dikdörtgen çevresi farklı hesaplanır çemberin farklı..


            //Inheritance -> bir classın üst classlarına ait metotları, propertyleri kullanabilmesi.



        }
    }
}
