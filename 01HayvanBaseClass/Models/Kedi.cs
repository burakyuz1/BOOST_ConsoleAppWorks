using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HayvanBaseClass.Models
{
    public class Kedi : Hayvan
    {
        public Kedi()
        {
            Tur = "Kedi";
            Console.WriteLine($"{Tur} olarak oluştum.");
        }

        public override void HareketEt()
        {
            Console.WriteLine($"{Tur} patileriyle koşuyor.");
        }

        public void Mirilda()
        {
            Console.WriteLine($"{Tur} mirildiyor.");
        }

    }
}
