using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00HayvanlarAlemiInheritance
{
    public class Hayvan
    {
        public string Tur { get; protected set; } = "Hayvan";//Default olarak bir set yaptık.istersem CTOR ile de yapabilirm. 
                                                             //Classın çocuğu da değiştirebilsin diye protected yaptık.
        public virtual void SesCikar()  // VIRTUAL Kelimesiyle Çocukları bu class'ı değiştirebilsin diyoruz.
                                        //
        {
            Console.WriteLine($"{Tur} Ses çıkarıyor..");
        }

        public virtual void HareketEt()
        {
            Console.WriteLine($"{Tur} Hareket ediyor..");
        }
        public virtual void Beslen()
        {
            Console.WriteLine($"{Tur} Besleniyor...");
        }
    }
}
