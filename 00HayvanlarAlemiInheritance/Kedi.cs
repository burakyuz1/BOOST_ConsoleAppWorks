using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00HayvanlarAlemiInheritance
{
    //Kedi Türemiş Class'tır. (DERIVED CLASS) -- Hayvan ise (BASE CLASS).
    public class Kedi : Hayvan
    {
        public Kedi()
        {
            Tur = "Kedi";
        }
        public override void HareketEt() // Beslen Metodunu içini değiştiriyor. 
        {
            Console.WriteLine($"{Tur} Patileriyle yürüyor.");
        }

        public override void Beslen()
        {
            //base.Beslen(); // Önce Base Class'taki kod çalışır. istemiyorsan sil
            Console.WriteLine($"{Tur} Mama yiyor..");

        }
        public override void SesCikar()
        {
            Console.WriteLine($"{Tur} miyvalıyor.");

        }

        public void Tirman()
        { 
            Console.WriteLine($"{Tur} ağaca tırmanıyor..");

        }
    }
}
