using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00ArrayWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[5] { "a", "b", "c", "d","e" };

            //students[2] = "k"; //-> 2. indexi değiştir

            //Array.Resize(ref students, students.Length + 1);
            //students[students.Length - 1] = "F";
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine();

            ////Çift boyutlu  dizi
            //string[,] regions = new string[5, 3] { //satır, sutun
            //    {"Ankara","İstanbul","İzmir" },
            //    {"Varşova","Krakow","Poznan" },
            //    {"Berlin","Münih","Köln" },
            //    {"Paris","Nice","Marsilya" },
            //    {"Roma","Lazio","Napoli" }
            //};

            //for (int i = 0; i <= regions.GetUpperBound(0); i++) // satır
            //{
            //    for (int j = 0; j <= regions.GetUpperBound(1); j++) //Sutun
            //    {
            //        Console.WriteLine(regions[i,j]);
            //    }
            //}


            //string[] mevsimler = new string[] { "Ilkbahar", "Yaz", "Sonbahar", "Kış" };

            //foreach (string mevsim in mevsimler)
            //{
            //    Console.Write(mevsim + " ");
            //}
            //Console.WriteLine();
            ////Mevsimleri 1. mevsim ilkbahar , 2. mevsim yaz, 3. mevsim sonbahar, 4. mevsim kış. formatında yaz

            //for (int i = 1; i <= mevsimler.Length; i++)
            //{
            //    Console.WriteLine($"{i}. Mevsim: {mevsimler[i - 1]}");
            //}
            //Console.WriteLine();
            ////Haftanın günlerini bir string dizisinnde tutunuz.
            ////Günleri yan yana ve tersten şekilde ekrana yazdırınız
            ////Eğer gün Cumartesi ya da Pazarsa (Cumartesi Tatil) şeklinde ekrana yazdırınız.

            //string[] gunler = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            //Array.Reverse(gunler);

            //foreach (string gun in gunler)
            //{
            //    if (gun.ToLower() == "cumartesi".ToLower() || gun.ToLower() == "pazar".ToLower())
            //    {
            //        Console.Write(gun + " tatil, ");
            //        continue;
            //    }

            //    Console.Write(gun + ", ");
            //}

            //Soru: elinizde string değerler tutan bir dizi oslun,
            //İçerisinde GS,GB,BJK,TS değerleri olsun
            ////Daha sonra bu değerleri GS_TS- FB_BJK _ BJK-FB_ TS-GS şeklinde ekrana yazdıralım
            //Console.WriteLine();
            //string[] takimlar = { "GS", "FB", "BJK", "TS" };

            //for (int i = 0; i < takimlar.Length; i++)
            //{
            //    Console.WriteLine(takimlar[i] + "-" + takimlar[takimlar.Length - 1 - i]);
            //}

            ////YONTEM II

            //for (int i = 0, j = takimlar.Length - 1; i < takimlar.Length; i++, j--)
            //{
            //    Console.WriteLine(takimlar[i] + "-" + takimlar[j]);
            //}

            //Soru: elemanları rastgele (1,1000 dahil) tam sayılardan oluşan, 30 elemanla bir array'in 
            //2'ye tam bölünebilen elemanlarını küçüktün büyüğe
            //hem 2'ye hem de 3'e tam bölünebilenlerin ise sayısını ekrana yazdırınız
            Random rnd = new Random();
            int[] sayilar = new int[30];
            int sayac = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 1001);

            }
            Array.Sort(sayilar);
            Console.WriteLine("2 ye bölünenleri küçükten büyüğe");
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    //Yöntem II
                    //Array.Resize() Kullanarak yeni bir aray oluşturup boyutunu her defasında kendisinin 1 fazlası kadar arttırarak(Length + 1) içine ekleyebiliriz.
                    Console.Write(sayi + " ");
                }
            }
            Console.WriteLine("\n**********************");
            Console.WriteLine("hem 2 hem 3 e tam bölünenler");
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0 && sayi % 3 == 0)
                {
                    Console.Write(sayi + " ");
                    sayac++;
                }
            }
            Console.WriteLine("\n2 ve 3 e bölünenlerin sayısı: " + sayac);


            //Soru : eleman sayısını kullanıcı belirlediği 
            //Elemanlarının 1 ile 50 arasında random oluşturulan dizinin her elemanının kaçar tane olduğunu
            //3 ve 5 e tam bölünenlerin ayrı bir dizide tutulduğu ve eğer 3'e ve 5'e tam bölünen varsa bunların da ekrana yazırıldığı
            //Programı yaz

            Console.Write("\nKaç tane sayı? :");
            int sayiAdedi = (int)Convert.ToInt32(Console.ReadLine());

            int[] randomSayilar = new int[sayiAdedi];
            int[] ucVeBesTamBolunenler = { };
            for (int i = 0; i < sayiAdedi; i++)//sayı üretme ve 3-5'e tam bölünenleri yeni diziye aktarma
            {
                randomSayilar[i] = rnd.Next(1, 51);
               
                if (randomSayilar[i] % 3 == 0 && randomSayilar[i] % 5 == 0)
                {
                    Array.Resize(ref ucVeBesTamBolunenler, ucVeBesTamBolunenler.Length + 1);
                    ucVeBesTamBolunenler[ucVeBesTamBolunenler.Length - 1] = randomSayilar[i];
                }
            }

            for (int i = randomSayilar.Min(); i <= randomSayilar.Max(); i++) //Sayı adedi hesaplama
            {
                int sayac1 = 0;
                for (int j = 0; j < randomSayilar.Length; j++)
                {
                    if (i == randomSayilar[j])
                    {
                        sayac1++;
                    }
                }
                if (sayac1!=0)
                {
                    Console.WriteLine(i + " sayısından "+ sayac1 +" tane var");
                }
            }

            Console.WriteLine("3 ve 5 e bölünenler");
            int count = ucVeBesTamBolunenler.Length;
            if (count != 0)//ilan kısmı
            {
                foreach (var item in ucVeBesTamBolunenler)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("3 ve 5 e bölünen sayı üretilemedi...");
            }

            //Öğrenci kayıt otomasyonu:
            //Program çalıştığında 
            //Lütfen yapmak istediğiniz işlemi seçiniz: 
            // 1- Öğrenci kayıt
            // 2- Öğrencileri listele
            // 3- Çıkış yap.(Console.Kapanır)
            //Seçime göre (switch Case) işlemlerini gerçekleştiren öğrenci kayıt programını kodlayınız.
            //NOT: Programda kaç adet öğrenci bilgisi tutulacağı belli değildir. Kullanıcı giriş yapmaya devam ettiği sürece öğrenci kaydı yapılır.
            //Öğrenciye ait tutulması gereken bilgiler: AD SOYAD ,SINIF, TCNO, CİNSİYET, DOĞUMTARİHİ, DOĞUMYERİ -> Bunlar dizide tutulur (6 Adet dizi)
            //NOT 2 : Kayıt işlemi gerçekletirildiğinde ekrana "Kayıt işlemi başarıyla gerçekleştirildi" yazsın.
            //NOT 3 : 1,2,3 seçim ekranı tekrar  dönmelidir.


            Console.ReadLine();
        }
    }
}
