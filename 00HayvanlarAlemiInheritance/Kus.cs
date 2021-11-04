using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00HayvanlarAlemiInheritance
{
    public class Kus : Hayvan
    {
        public Kus()
        {
            Tur = "Kuş";
        }

        public override void Beslen()
        {
            Console.WriteLine($"{Tur} yem yiyor.");
        }

        public override void SesCikar()
        {
            Console.WriteLine($"{Tur} cikliyo.");
        }
        public override void HareketEt()
        {
            Console.WriteLine($"{Tur} kanat çırpıyor.");
            //ToString metodunu override et 

        }

        public void YuvaYap()
        {
            Console.WriteLine($"{Tur} yuva yapıyor..");
        }

    }
}
