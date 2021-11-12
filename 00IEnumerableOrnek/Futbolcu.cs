using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00IEnumerableOrnek
{
    public enum Mevkii
    {
        Kaleci, Defans, OrtaSaha, Forvet
    }
    internal class Futbolcu
    {
        public string AdSoyad { get; set; }
        public byte FormaNo { get; set; }
        public Mevkii Mevkii { get; set; }

        public override string ToString()
        {
            return $"Ad Soyad:{AdSoyad,-10}FormaNo: {FormaNo,-10}Mevkii: {Mevkii,-20}";
        }


    }
}
