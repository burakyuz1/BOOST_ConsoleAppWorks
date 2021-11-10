using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04IEnumerableOrnek1
{
    internal class Person :IEnumerable
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public IEnumerator GetEnumerator()
        {
            return new PersonEnumerator(this);//This: Person
        }
    }
}
