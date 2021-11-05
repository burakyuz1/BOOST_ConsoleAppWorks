using _06JSONDeseriailizeSerialize.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _06JSONDeseriailizeSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Araba> arabalar; //Boş liste oluşturdum aşağıda doldurdum.
            try
            {
                arabalar = VerileriOku(); //okunabilir bir json varsa okur
            }
            catch (Exception)
            {
                arabalar = new List<Araba>(); //okunabilir bir json yoksa yeni bir araba listesi oluşturur. (Zaten çıkarkan json'u oluşturacaktır.)
            }
            Console.WriteLine("Veri tabanındaki araçları görmek için 1, Araba üretmek için 2 basın.");
            int ilkSecim = Convert.ToInt32(Console.ReadLine());
            if (ilkSecim == 2) //Üretim esnasında çalışır.
            {
                Console.Clear();
                Console.Write("Kaç adet araba üretmek istiyorsun?: ");
                int arabaAdet = Convert.ToInt32(Console.ReadLine());

                ArabaEkle(arabalar, arabaAdet);
            }
        listeSecim:
            ArabaListele(arabalar);//Tüm liste gelir
            Console.WriteLine("******************");
            Console.Write("İşlem yapmak istediğiniz arabanın sıra numarasını yazın: ");
            int arabaIndis = Convert.ToInt32(Console.ReadLine());
            ArabaListele(arabaIndis, arabalar); //Kullanıcının seçtiği gelir
        tekrarSecim:
            Console.WriteLine("******************");
            Console.WriteLine("Seçtiğiniz araçla ilgili ne işlem yapmak istersin? (1: Arabayı veritabanından sil - 2: Arabayı çalıştır ve Arabayı durdur - 3: Kapıları kilitle 4: Vergi Borcunu öde - 5: Arabanın veritabanını güncelle - 6: Araba Listesine geri dön - 7: Çıkış yap)");
            int islemTercih = Convert.ToInt32(Console.ReadLine());

            switch (islemTercih) //Yukarıda verilen 7 case'i kontrol eder.
            {
                case 1:
                    ArabayiSil(arabaIndis, arabalar);
                    goto listeSecim;
                case 2:
                    arabalar[arabaIndis - 1].ArabaHizlandir();
                    Thread.Sleep(1000);
                    arabalar[arabaIndis - 1].ArabaDurdur();
                    goto tekrarSecim;
                case 3:
                    arabalar[arabaIndis - 1].KapilariKilitle();
                    goto tekrarSecim;
                case 4:
                    arabalar[arabaIndis - 1].VergiBorcuOde();
                    goto tekrarSecim;
                case 5:
                    ArabaGuncelle(arabalar[arabaIndis - 1]);
                    goto listeSecim;
                case 6:
                    ArabaListele(arabalar);
                    goto listeSecim;
                default:
                    VerileriKaydet(arabalar);
                    Environment.Exit(0);
                    break;
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Parametre olarak yollanan arabayı günceller
        /// </summary>
        /// <param name="araba"></param>
        private static void ArabaGuncelle(Araba araba)
        {
            Console.Clear();
            Console.WriteLine($"Marka : {araba.Marka}");
            Console.Write("Yeni marka değeri gir: ");
            araba.Marka = Console.ReadLine();
            Console.WriteLine($"Renk : {araba.Renk}");
            Console.Write("Yeni renk değeri girin:(Sarı için 1, Kırmızı için 2, Mavi için 3):  ");
            int renkSecim = Convert.ToInt32(Console.ReadLine());
            ConsoleColor renk;
            if (renkSecim == 1) renk = ConsoleColor.Yellow;
            else if (renkSecim == 2) renk = ConsoleColor.Red;
            else renk = ConsoleColor.Blue;
            araba.Renk = renk;
            string borcDurum = araba.VergiBorcuVarMi ? "Vergi borcu var." : "Vergi borcu yok";
            Console.WriteLine($"Borç : {borcDurum}");
            Console.Write("Yeni Borc Durumu girin : (var-yok): ");
            string borc = Console.ReadLine();
            bool vergiBorcuVarMi = (borc == "var") ? true : false;
            araba.VergiBorcuVarMi = vergiBorcuVarMi;
        }

        /// <summary>
        /// Verilen listedeki verilen index'i silen metot
        /// </summary>
        /// <param name="arabaIndis"></param>
        /// <param name="arabalar"></param>
        private static void ArabayiSil(int arabaIndis, List<Araba> arabalar)
        {
            arabalar.RemoveAt(arabaIndis - 1);
            Console.WriteLine("Araba veritabanından silindi. Araba listesine geri dönülüyor.");
            Thread.Sleep(2000);
            Console.Clear();
        }

        /// <summary>
        /// Parametre olarak verdiğim araba listesini Console'a yazdıran metot
        /// </summary>
        /// <param name="arabalar"></param>
        private static void ArabaListele(List<Araba> arabalar)
        {
            Console.Clear();
            Console.WriteLine("Eklediğiniz tüm arabalar listeleniyor.\n********************");
            int arabaSiraNo = 1;
            foreach (Araba araba in arabalar)
            {
                Console.WriteLine(arabaSiraNo + ". Araba");
                Console.WriteLine(araba.ArabaListele());
                Console.WriteLine("********************");
                arabaSiraNo++;
            }
        }

        /// <summary>
        /// verdiğim indexe göre arabalar listesinden 1 tane araba listeleyen metot
        /// </summary>
        /// <param name="arabaIndis"></param>
        /// <param name="arabalar"></param>
        private static void ArabaListele(int arabaIndis, List<Araba> arabalar)
        {
            Console.Clear();
            Console.WriteLine(arabalar[arabaIndis - 1].ArabaListele());
        }

        /// <summary>
        /// Parametre olarak aldığı listeye, aldığı parametre kadar araba ekleyen metot
        /// </summary>
        /// <param name="arabalar"></param>
        /// <param name="arabaAdet"></param>
        private static void ArabaEkle(List<Araba> arabalar, int arabaAdet)
        {
            for (int i = 1; i <= arabaAdet; i++)
            {
                Console.WriteLine($"{i}. araba bilgilerini girin");
                Console.Write("Marka girin: ");
                string marka = (Console.ReadLine());
                Console.Write("Renk girin(Sarı için 1, Kırmızı için 2, Mavi için 3): ");
                int renkSecim = Convert.ToInt32(Console.ReadLine());
                ConsoleColor renk;
                if (renkSecim == 1) renk = ConsoleColor.Yellow;
                else if (renkSecim == 2) renk = ConsoleColor.Red;
                else renk = ConsoleColor.Blue;

                Console.Write("Vergi borcu var mı? (var - yok): ");
                string borc = Console.ReadLine();
                bool vergiBorcuVarMi = (borc == "var") ? true : false;

                arabalar.Add(new Araba { Marka = marka, Renk = renk, VergiBorcuVarMi = vergiBorcuVarMi });
                Console.Clear();
            }
        }

        /// <summary>
        /// Json olarak verileri /Data klasörüne kaydeden metot.
        /// </summary>
        /// <param name="list"></param>
        private static void VerileriKaydet(List<Araba> list)
        {
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(@"C:\Users\BURAKDEV\source\repos\BOOST_ConsoleAppWorks\06JSONDeseriailizeSerialize\Data\veri.json", json);
        }

        /// <summary>
        /// Json olarak kaydedilen verileri /Data klasöründen okuyan metot.
        /// </summary>
        /// <returns></returns>
        private static List<Araba> VerileriOku()
        {
            string jsonOkunan = File.ReadAllText(@"C:\Users\BURAKDEV\source\repos\BOOST_ConsoleAppWorks\06JSONDeseriailizeSerialize\Data\veri.json");
            return JsonConvert.DeserializeObject<List<Araba>>(jsonOkunan);
        }

    }
}
