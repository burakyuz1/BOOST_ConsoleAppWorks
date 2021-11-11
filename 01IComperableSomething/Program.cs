using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01IComperableSomething
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new TextContact("Burak", "Akyüz", "5068442874");

            Console.WriteLine(contact.ToString());
            contact.Notify("Kullanıcı: ");

            Contact contact2 = new PhoneContact("Ali", "Yıldız", "5051451423");
            Console.WriteLine(contact2.ToString());
            contact.Notify("Kullanıcı2: ");

            Contact contact3 = new EmailContact("Veli", "Yılmaz", "veli@gmail.com");
            Console.WriteLine(contact3.ToString());
            contact.Notify("Kullanıcı3: ");

            Contact contact4 = new Contact("Mustafa", "Çakır");
            Console.WriteLine(contact4.ToString());
            contact.Notify("Kullanıcı4: ");

            Console.WriteLine("****************************");

            List<Contact> contacts = new List<Contact>()
            {
                new Contact("burak","akyüz"),
                new Contact("Zeliha", "çakır"),
                new Contact("Meliha", "çakır")
            };
            contacts.Sort();

            foreach (var item in contacts)
            {
                Console.WriteLine(item.ToString());
            }





            Console.ReadLine();
        }
    }
}
