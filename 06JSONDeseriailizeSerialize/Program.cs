using _06JSONDeseriailizeSerialize.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Console kmapanırken veri.json kaydedsin. Data klasörü açalım onun içine kaydetsin. açılınken veri.json okusun. data klasörü içinden okunsun.
namespace _06JSONDeseriailizeSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Araba> arabalar;
            try
            {
                arabalar = VerileriOku();
            }
            catch (Exception)
            {

                arabalar = new List<Araba>();
            }

            Console.WriteLine("Kaç adet araba üretmek istiyorsun?");
            int arabaAdet = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arabaAdet; i++)
            {
                Console.WriteLine("Marka girin");
                string marka = (Console.ReadLine());
                Console.WriteLine("Renk girin(Sarı için 1, Kırmızı için 2, mavi için 3)");
                int renkSecim = Convert.ToInt32(Console.ReadLine());
                ConsoleColor renk;
                if (renkSecim == 1)
                    renk = ConsoleColor.Yellow;
                else if(renkSecim == 2)
                    renk = ConsoleColor.Red;
                else 
                    renk = ConsoleColor.Blue;

                Console.WriteLine("Vergi borcu var mı? (var - yok)");
                string borc = Console.ReadLine();
                bool vergiBorcuVarMi;
                if (borc == "var")
                    vergiBorcuVarMi = true;
                else
                    vergiBorcuVarMi = false;

                arabalar.Add(new Araba { Marka = marka, Renk = renk, VergiBorcuVarMi = vergiBorcuVarMi });
            }


            VerileriKaydet(arabalar);

        }

        private static void VerileriKaydet(List<Araba> list)
        {
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(@"C:\Users\user.user\Source\Repos\BOOST_ConsoleAppWorks\06JSONDeseriailizeSerialize\Data\veri.json", json);
        }

        private static List<Araba> VerileriOku()
        {
            string jsonOkunan = File.ReadAllText(@"C:\Users\user.user\Source\Repos\BOOST_ConsoleAppWorks\06JSONDeseriailizeSerialize\Data\veri.json");
            return JsonConvert.DeserializeObject<List<Araba>>(jsonOkunan);
        }

    }
}
