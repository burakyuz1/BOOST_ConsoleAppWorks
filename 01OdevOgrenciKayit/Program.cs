using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OdevOgrenciKayit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi girin (1- Öğrenci Kayıt , 2- Öğrenci Listele , 3- Çıkış yap)");
            string[] ogrenciAdSoyad = new string[0];
            string[] ogrenciSinif = new string[0];
            string[] ogrenciTcNo = new string[0];
            string[] ogrenciCinsiyet = new string[0];
            string[] ogrenciDogumTarihi = new string[0];
            string[] ogrenciDogumYeri = new string[0];
        yukari:
            byte islem = 0;
            try
            {
                islem = Convert.ToByte(Console.ReadLine());
                if (islem > 3)
                {
                    throw new Exception();
                }
                while (islem == 1 || islem == 2 || islem == 3)
                {
                    switch (islem)
                    {
                        case 1:
                            Console.Write("Öğrencinin Ad Soyad Bilgisini Girin : ");
                            Array.Resize(ref ogrenciAdSoyad, ogrenciAdSoyad.Length + 1);
                            ogrenciAdSoyad[ogrenciAdSoyad.Length - 1] = Console.ReadLine();

                            Console.Write("Öğrencinin Sınıf Bilgisini Girin : ");
                            Array.Resize(ref ogrenciSinif, ogrenciSinif.Length + 1);
                            ogrenciSinif[ogrenciSinif.Length - 1] = Console.ReadLine();

                            Console.Write("Öğrencinin TCK No Bilgisini Girin : ");
                            Array.Resize(ref ogrenciTcNo, ogrenciTcNo.Length + 1);
                            ogrenciTcNo[ogrenciTcNo.Length - 1] = Console.ReadLine();

                            Console.Write("Öğrencinin Cinsiyet Bilgisini Girin : ");
                            Array.Resize(ref ogrenciCinsiyet, ogrenciCinsiyet.Length + 1);
                            ogrenciCinsiyet[ogrenciCinsiyet.Length - 1] = Console.ReadLine();

                            Console.Write("Öğrencinin Doğum Tarihi Bilgisini Girin : ");
                            Array.Resize(ref ogrenciDogumTarihi, ogrenciDogumTarihi.Length + 1);
                            ogrenciDogumTarihi[ogrenciDogumTarihi.Length - 1] = Console.ReadLine();

                            Console.Write("Öğrencinin Doğum Yeri Bilgisini Girin : ");
                            Array.Resize(ref ogrenciDogumYeri, ogrenciDogumYeri.Length + 1);
                            ogrenciDogumYeri[ogrenciDogumYeri.Length - 1] = Console.ReadLine();
                            Console.WriteLine("*****************************************************");
                            Console.WriteLine("Kayıt başarıyla eklendi. Tekrar seçim yapın.(1- Öğrenci Kayıt , 2- Öğrenci Listele , 3- Çıkış yap)");
                            islem = Convert.ToByte(Console.ReadLine());

                            break;

                        case 2:
                            if (ogrenciAdSoyad.Length != 0)
                            {
                                for (int i = 0; i < ogrenciAdSoyad.Length; i++)
                                {
                                    Console.WriteLine($"{i + 1}. Öğrencinin Adı Soyadı : {ogrenciAdSoyad[i]}");
                                    Console.WriteLine($"{i + 1}. Öğrencinin Sınıfı : {ogrenciSinif[i]}");
                                    Console.WriteLine($"{i + 1}. Öğrencinin TCK Numarası : {ogrenciTcNo[i]}");
                                    Console.WriteLine($"{i + 1}. Öğrencinin Cinsiyeti : {ogrenciCinsiyet[i]}");
                                    Console.WriteLine($"{i + 1}. Öğrencinin Doğum Tarihi : {ogrenciDogumTarihi[i]}");
                                    Console.WriteLine($"{i + 1}. Öğrencinin Doğum Yeri : {ogrenciDogumYeri[i]}");
                                    Console.WriteLine("*****************************************************");
                                }

                                Console.WriteLine(ogrenciAdSoyad.Length + " adet kayıt listelendi. Tekrar seçim yapın.(1- Öğrenci Kayıt , 2- Öğrenci Listele , 3- Çıkış yap)");
                                islem = Convert.ToByte(Console.ReadLine());

                            }
                            else
                            {
                                Console.WriteLine("Hiç bir öğrenci bulunamadı. Tekrar seçim yapın (1- Öğrenci Kayıt , 2- Öğrenci Listele , 3- Çıkış yap)");
                                islem = Convert.ToByte(Console.ReadLine());
                            }
                            break;

                        case 3:
                            Environment.Exit(0);
                            break;

                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("1,2,3 değerlerinden birini girebilirsiniz. Tekrar seçim yapın: ");
                goto yukari;
            }

        }
    }
}
