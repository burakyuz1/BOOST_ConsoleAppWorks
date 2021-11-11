using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01IComperableSomething
{
    internal class PhoneContact : Contact
    {
        private readonly string _phoneNumber;

        public PhoneContact(string first, string last, string phoneNumber) : base(first, last)
        {
            _phoneNumber = phoneNumber;
        }

        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public override void Notify(string str)
        {
            Console.WriteLine(str + " Phone Contact");
        }

        public override string ToString()
        {
            return $"Telefon No: {_phoneNumber}";
        }

    }
}
