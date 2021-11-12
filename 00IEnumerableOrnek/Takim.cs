using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00IEnumerableOrnek
{
    internal class Takim : IEnumerable
    {
        private readonly Futbolcu[] _futbolcular;
        double  toplam;

        public Takim(params Futbolcu[] futbolcular)  //Ctor içi futbolcular ile doldu.
        {
            _futbolcular = futbolcular; // field'a atama yapıldı.
        }
        public int FutbolcuSayisi { get { return _futbolcular.Length; } } // Futbolcu sayısı readonly set edilemez. 
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _futbolcular.Length; i++)
            {
                toplam += _futbolcular[i].FormaNo;
                yield return _futbolcular[i]; //her döndüğünde yukarda atama yaptığım fieldın elemanını döndüm. bunların her biri futbolcu
            }
        }
        public double OrtalamaHesapla()
        {
            double ortalama = toplam / FutbolcuSayisi;
            return ortalama;
        }
    }
}
