using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03DelegelerZamanlayiciOrnegi
{
    public delegate void Eylem();
    internal static class Zamanlayici
    {
        /// <summary>
        /// Verdiğiniz  eylemi (Anonim Metot), verdiğiniz adet kadar ve zaman aralığında yapar.
        /// </summary>
        /// <param name="eylem">Eylem delegesine uygun bir metot</param>
        /// <param name="adet">kaç kere çalışacağı</param>
        /// <param name="zaman">iki eylem arası zaman aralığı (ms türü)</param>
        public static void Yap(Eylem eylem, int adet, int zaman)
        {
            for (int i = 0; i < adet; i++)
            {
                Thread.Sleep(zaman);
                eylem();
            }
        }
      
    }
}
