using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HayvanBaseClass.Models
{
    public class Serce:Hayvan
    {
        public Serce()
        {
            Tur = "Serçe";
            Console.WriteLine($"{Tur} olarak oluştum.");
        }
        public override void HareketEt()
        {
            Console.WriteLine($"{Tur} uçuyor");
        }
        public override void SesCikar()
        {
            Console.WriteLine($"{Tur} cik cik ötüyor.");
        }
        public override string ToString()
        {
            return "Serçe Kuşu";
        }
    }
}
