using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComperableTakim
{
    internal class Takim : IComparable
    {
        public string TakimAdi { get; set; }
        public byte Puani { get; set; }
        public sbyte Average { get; set; }
        public int CompareTo(object obj)
        {
            Takim t = (Takim)obj;
            int sonuc = t.Puani.CompareTo(Puani);
            return sonuc;


        }
    }
    internal class PuanaGoreKucuktenBuyuge : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            return x.Puani.CompareTo(y.Puani);
        }
    }

    internal class AdaGoreSirala : IComparer<Takim>
    {

        public int Compare(Takim x, Takim y)
        {
            return (x.TakimAdi).CompareTo(y.TakimAdi);
        }
    }

    internal class AdaGoreSiralaKucuktenBuyuge : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            return y.TakimAdi.CompareTo(x.TakimAdi);
        }
    }

    internal class AverajaGoreKucuktenBuyuge : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            return x.Average.CompareTo(y.Average);
        }
    }
    internal class AverajaGoreBuyuktenKucuge : IComparer<Takim>
    {
        public int Compare(Takim x, Takim y)
        {
            return y.Average.CompareTo(x.Average);
        }
    }
}
