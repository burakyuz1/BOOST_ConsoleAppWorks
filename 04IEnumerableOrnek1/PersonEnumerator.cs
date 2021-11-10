using System;
using System.Collections;

namespace _04IEnumerableOrnek1
{
    internal class PersonEnumerator : IEnumerator
    {
        private readonly Person p;
        object nextObj;
        int counter = -1;

        public PersonEnumerator(Person p)
        {
            this.p = p;
        }

        public object Current { get { return nextObj; } }

        public bool MoveNext()
        {
            counter++;
            if (counter >= 3)
                return false;
            switch (counter)
            {
                case 0:
                    nextObj = p.Ad;
                    break;
                case 1:
                    nextObj = p.Soyad;
                    break;
                case 2:
                    nextObj = p.Yas;
                    break;
            }
            return true;
        }

        public void Reset()
        {
            counter = -1;
            nextObj = null;
        }
    }
}
