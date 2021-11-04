using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06JSONDeseriailizeSerialize.Models
{
    public class Araba
    {
        public Araba()
        {
            Id = Guid.NewGuid();
            UretimTarihi = DateTime.Now;
        }
        public Guid Id { get;}
        public string Marka { get; set; }
        public DateTime UretimTarihi { get;  }
        public ConsoleColor Renk { get; set; }
        public bool VergiBorcuVarMi { get; set; }

        public int AnlikHiz { get; set; }
        public void KapilariKilitle() { }
        public void MotorCalistir() { } //hiz + 10 -> MAX hız 220
        public void MotorDurdur() { } //hiz - 10  




    }
}
