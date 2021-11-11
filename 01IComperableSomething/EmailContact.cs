using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01IComperableSomething
{
    internal class EmailContact : Contact
    {
        private readonly string _email;

        public EmailContact(string first, string last,string email) : base(first, last)
        {
            _email = email;
        }


        public string GetEmail()
        {
            return _email;
        }

        public override void Notify(string str)
        {
          
            Console.WriteLine(str + "Email Contact");
        }
        public override string ToString()
        {
            return $"Email: {_email} İsim: {GetFirst()} Soyad: {GetLast()}";
        }
    }
}
