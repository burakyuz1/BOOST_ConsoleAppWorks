using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01IComperableSomething
{
    internal class Contact : IComparable<Contact>
    {
        private readonly string _first;
        private readonly string _last;

        public Contact(string first, string last)
        {
            _last = last;
            _first = first;
        }
        public string GetFirst()
        {
            return _first;
        }
        public string GetLast()
        {
            return _last;
        }

        public override string ToString()
        {
            return $"Adı: {_first} Soyadı:{_last}";
        }

        public virtual void Notify(string str)
        {
            Console.WriteLine(str + " Contact");
        }

        public int CompareTo(Contact other)
        {
            return _first.CompareTo(other._first);
        }
    }
}
