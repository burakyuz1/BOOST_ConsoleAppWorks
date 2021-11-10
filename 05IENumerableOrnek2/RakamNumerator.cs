using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05IENumerableOrnek2
{
    internal class RakamNumerator : IEnumerator
    {
        private readonly Tamsayi t;
        object nextObj;
        int counter = -1, numberCopy;

        public RakamNumerator(Tamsayi t)
        {
            this.t = t;
            numberCopy = t.Deger; //constructor'da sayının kopyası alınıyor
        }

        public object Current { get { return nextObj; } }

        public bool MoveNext()
        {
            counter++;
            if (counter >= 5)
                return false;
            else
            {
                int basamak;
                basamak = numberCopy % 10; //10 a bölümünden kalan
                nextObj = basamak; // current olarak foreach'e yollanan yer
                numberCopy /= 10;
                return true;
            }
        }

        public void Reset()
        {
            counter = -1;
            nextObj = null;
        }
    }
}
