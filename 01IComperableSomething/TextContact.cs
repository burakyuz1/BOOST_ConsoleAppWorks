using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01IComperableSomething
{
    internal class TextContact : PhoneContact
    {
        public TextContact(string first, string last, string phoneNumber) : base(first, last, phoneNumber)
        {
        }

        public override void Notify(string str)
        {
            Console.WriteLine(str + "Text Contact");
        }
    }
}
