using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HayvanBaseClass.Models
{
    public class Hayvan
    {
        public Hayvan()
        {
            Tur = "Hayvan";
        }
        public string Tur { get; protected internal set; } //Protected Internal -> tür değişimini sadece inherit olanlar ya da aynı projedekiler değiştirebilir

        public virtual void HareketEt()
        {
            Console.WriteLine($"{Tur} Hareket ediyor");
        }
        public virtual void SesCikar()
        {
            Console.WriteLine($"{Tur} Ses cikariyor");
        }

        public override string ToString()
        {
            return Tur;
        }


    }
}
