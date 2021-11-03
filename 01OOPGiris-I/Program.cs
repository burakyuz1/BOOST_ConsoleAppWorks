using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OOPGiris_I
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci1 = new Ogrenci();
            Ogrenci ogrenci2 = new Ogrenci();
            Ogrenci ogrenci3 = new Ogrenci();

            Console.WriteLine();

            ogrenci1.Id = Guid.NewGuid();
            ogrenci1.FirstName = "Burak";
            ogrenci1.MiddleName = null;
            ogrenci1.Surname = "Akyüz";
            //Console.WriteLine($"ID : {ogrenci1.Id,-4} Name : {ogrenci1.FirstName,-14} Middle Name : {ogrenci1.MiddleName,-6} Surname : {ogrenci1.Surname,-4} ");

            ogrenci2.Id = Guid.NewGuid();
            ogrenci2.FirstName = "Koray";
            ogrenci2.MiddleName = "Ali";
            ogrenci2.Surname = "Doğan";
            //Console.WriteLine($"ID : {ogrenci2.Id,-4} Name : {ogrenci2.FirstName,-14} Middle Name : {ogrenci2.MiddleName,-6} Surname : {ogrenci2.Surname,-4} ");

            ogrenci3.Id = Guid.NewGuid();
            ogrenci3.FirstName = "Muhammed Ali";
            ogrenci3.MiddleName = "Ragıp";
            ogrenci3.Surname = "Çakır";
            //Console.WriteLine($"ID : {ogrenci3.Id,-4} Name : {ogrenci3.FirstName,-14} Middle Name : {ogrenci3.MiddleName,-6} Surname : {ogrenci3.Surname,-4} ");

            Ogrenci ogrenci4 = new Ogrenci();
            //ogrenci4.Id = Guid.NewGuid();   -> Zaten constructor'da verildiği için atama yapmaya gerek yok 
            ogrenci4.FirstName = "Haydar";
            ogrenci4.Surname = "Dümen";
            ogrenci4.MiddleName = "YOK";

            //Console.WriteLine($"ID : {ogrenci4.Id,-4} Name : {ogrenci4.FirstName,-14} Middle Name : {ogrenci4.MiddleName,-6} Surname : {ogrenci4.Surname,-4} ");

            List<Ogrenci> ogrenciler = new List<Ogrenci>() { ogrenci3, ogrenci4 };

            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item.OgrencileriGetir());
            }




            Console.ReadKey();
        }
    }
    public class Ogrenci
    {
        public Ogrenci()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }

        public string OgrencileriGetir()
        {
            return $" ID: {Id} -- FirstName:{FirstName} -- MiddleName: {MiddleName} -- Surname{Surname}";
        }

    }
}
