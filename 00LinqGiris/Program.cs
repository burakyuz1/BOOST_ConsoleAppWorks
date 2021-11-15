using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00LinqGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = StudentList();


            //Console.WriteLine(string.Format("|{0,-3}|{ 1,-18}|{ 2,-8}|{ 3,-3}|", "ID", "FirstName", "LastName", "Age"));
            Console.WriteLine("id -- firstname -- surname -- age");
            foreach (var item in students)
            {
                //Console.WriteLine(string.Format("|{ 0,-3}|{ 1,-18}|{ 2,-8}|{ 3,-3}| ", item.Id, item.FirstName, item.LastName, item.Age));
                Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName + " " + item.Age + " ");
            }

            //Öğrencilerin Yaşlarını bir List<int> türünde tutup ekrana yan yana yazdırınız
            Console.WriteLine("//Öğrencilerin Yaşlarını bir List<int> türünde tutup ekrana yan yana yazdırınız");
            List<int> studentAges = students.Select(x => x.Age).ToList();
            Console.WriteLine(string.Join(", ", studentAges));

            //Öğrencilerin soyadlarını bir listString türünde tutup ekrana yan yana yazdırınız
            Console.WriteLine("//Öğrencilerin soyadlarını bir listString türünde tutup ekrana yan yana yazdırınız");
            List<string> studentSurnames = students.Select(x => x.LastName).ToList();
            Console.WriteLine(string.Join(", ", studentSurnames));

            //Öğrencilerin FirstName uzunluğu 15'den büyük olanları getir.
            Console.WriteLine("//Öğrencilerin FirstName uzunluğu 5'den büyük olanları getir");
            List<Student> studentLength = students.Where(x => x.FirstName.Length > 5).ToList();
            studentLength.ForEach(x => Console.Write(x.FirstName + " " + x.LastName + ", "));

            //Öğrencilerin soyadlarında A harfi olan
            Console.WriteLine("Öğrencilerin soyadlarında A harfi olan:");
            List<Student> studentAHarfi = students.Where(x => x.LastName.ToLower().Contains("a")).ToList();
            studentAHarfi.ForEach(x => Console.Write(x.LastName + ", "));
            Console.WriteLine("A harfi geçen kişi sayısı: " + studentAHarfi.Count);

            //Öğrencilerin soyadlarında A harfi olan ve soyad uzunluğu 5'den büyük olanlar
            Console.WriteLine("soydaları a ile başlayan ve soyad uzunluğu 5'den büyük olanlar");
            List<Student> studentKosul = students.Where(x => x.LastName.ToLower().StartsWith("a") && x.LastName.Length > 5).ToList();
            studentKosul.ForEach(x => Console.Write(x.LastName + ", "));

            //Öğrencilerin soyadı R ile biten veya Id'sinin 2'ye bölümünden kalanı 0 olanları ekrana yazdırınız
            Console.WriteLine("Öğrencilerin soyadı R ile biten veya Id'sinin 2'ye bölümünden kalanı 0 olanları ekrana yazdırınız");
            List<string> studentKosul1 = students.Where(x => x.LastName.ToLower().EndsWith("r") || x.Id % 2 == 0).Select(x => x.Id + " " + x.LastName).ToList(); //Select kullanarak
            studentKosul1.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("***");

            List<Student> studentKosul2 = students.Where(x => x.LastName.ToLower().EndsWith("r") || x.Id % 2 == 0).OrderByDescending(x => x.Id).ToList();
            studentKosul2.ForEach(x => Console.WriteLine(x.Id + " " + x.LastName));


            //SKIP-TAKE
            Console.WriteLine("Skip/Take");
            List<Student> studentKosul3 = students.Skip(3).Take(2).ToList();
            studentKosul3.ForEach(x => Console.WriteLine(x.FirstName));


            //
            Console.WriteLine("*****");
            List<Student> studentKosul4 = students.Where(x => x.Age > 25).Skip(2).Take(2).ToList();
            studentKosul4.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));
            Console.WriteLine("+++");
            List<Student> studentKosul5 = students.SkipWhile(x => x.Id < 5).ToList(); //şartı sağladığı sürece dvam et.
            studentKosul5.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));


            //ALL-ANY

            bool studentKosul6 = students.All(x => x.Age < 25);
            Console.WriteLine("Herkesin yaşı 25'ten küçük mü :" + studentKosul6);// herkese bakar.

            bool studentKosul7 = students.Any(x => x.Age < 25);
            Console.WriteLine("Yaşı 25'ten küçük olan var mı?" + studentKosul7); // Bir tane olması yeterli


            //öğrenci listesindeki öğrencilerin soyadlarının uzunluğunun ortalamasını ekrana yazdırınız.

            var ortalama = students.Select(x => x.LastName.Length).ToList().Average();
            Console.WriteLine(ortalama);



            Console.ReadLine();
        }

        private static List<Student> StudentList()
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    FirstName="Burak",
                    LastName="Akyüz",
                    Age = 26
                },
                new Student()
                {
                    Id = 2,
                    FirstName="Ali",
                    LastName="Doğan",
                    Age = 30
                },
                new Student()
                {
                    Id = 3,
                    FirstName="Mustafa",
                    LastName="Kaplan",
                    Age = 25
                },
                new Student()
                {
                    Id = 4,
                    FirstName="Mehmet",
                    LastName="Aslancı",
                    Age = 18
                },
                new Student()
                {
                    Id = 5,
                    FirstName="Leyla",
                    LastName="Coşkun",
                    Age = 11
                },
                new Student()
                {
                    Id = 6,
                    FirstName="Zeliha",
                    LastName="Yıldız",
                    Age = 36
                },
                    new Student()
                {
                    Id = 7,
                    FirstName="Cengiz",
                    LastName="Eryılmaz",
                    Age = 27
                },
                 new Student()
                {
                    Id = 8,
                    FirstName="Selçuk",
                    LastName="Taşkıran",
                    Age = 41
                },
                new Student()
                {
                    Id = 9,
                    FirstName="Halil",
                    LastName="Yurdakul",
                    Age = 23
                },
                new Student()
                {
                    Id = 10,
                    FirstName="Tuncay",
                    LastName="Ak",
                    Age = 28
                },
                new Student()
                {
                    Id = 11,
                    FirstName="Erdal",
                    LastName="Göçer",
                    Age = 29
                },

            };
            return students;
        }
    }
}
