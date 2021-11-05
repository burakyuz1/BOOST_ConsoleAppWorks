using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06JSONDeseriailizeSerialize.Models
{
    public class Araba
    {
        public Araba()
        {
            Id = Guid.NewGuid();
            UretimTarihi = DateTime.Now;
            AnlikHiz = 0;
        }
        public Guid Id { get; }
        public string Marka { get; set; }
        public DateTime UretimTarihi { get; }
        public ConsoleColor Renk { get; set; }
        public bool VergiBorcuVarMi { get; set; }

        public int AnlikHiz { get; private set; }
        public void KapilariKilitle()
        {
            Console.WriteLine("Kapılar kilitlendi :D");
        }
        public void ArabaHizlandir()
        {
            while (AnlikHiz < 220)
            {
                AnlikHiz += 10;
                Console.Write("{0:000}", AnlikHiz);
                Thread.Sleep(50);
                Console.Write("\b\b\b");
            }
            Console.Write("\nAraba max. hıza ulaştı...\n");
        }
        public void ArabaDurdur()
        {
            while (AnlikHiz > 0)
            {
                AnlikHiz -= 10;
                Console.Write("{0:000}", AnlikHiz);
                Thread.Sleep(50);
                Console.Write("\b\b\b");
            }
            Console.Write("\nAraba durdu...\n");
        }
        public void VergiBorcuOde()
        {
            if (!VergiBorcuVarMi)
            {
                Console.WriteLine("Borcunuz yoktur");
            }
            else
            {
                VergiBorcuVarMi = false;
                Console.WriteLine("Borcunuz ödenmiştir");
            }
        }
        public string ArabaListele()
        {
            string vergiBorcDurumu = (VergiBorcuVarMi == true) ? "Var." : "Yok.";
            return $"ID: {Id}\nMarka: {Marka}\nUretim Tarihi: {UretimTarihi}\nRenk: {Renk}\nVergi Borç Durumu: Borcu {vergiBorcDurumu}";
        }



    }
}
