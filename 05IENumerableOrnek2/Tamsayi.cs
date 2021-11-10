using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05IENumerableOrnek2
{
    internal class Tamsayi : IEnumerable
    {
        private readonly int sayi;
        int numberCopy = 0;

        public Tamsayi(int sayi)
        {
            this.sayi = sayi;
            numberCopy = sayi;
        }

        public int Deger => sayi;


        public IEnumerator GetEnumerator() => new RakamNumerator(this); //Tamsayi class'ı RakamNumerator'a yolladım

        #region Yontem Yield
        //public IEnumerator GetEnumerator()
        //{
        //    while (numberCopy > 0)
        //    {
        //        int basamak = numberCopy % 10;
        //        numberCopy /= 10;
        //        yield return basamak;
        //    }
        //} 
        #endregion

    }
}
