using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Bir tahıl ambarı app. yapmanız bekleniyor.
//Ambar Class ı oluştur.
//Kullanıcıdan aldığın veri kadar ambarı doldur. -> delegates
//Taşması durumunda kullanıcıya bilgi mesajı ver. -> events
namespace _06TahilAmbariApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tonluk bir ambarınız var ?");
            Ambar ambar = new Ambar(Convert.ToInt32(Console.ReadLine()));
            ambar.DepoDoldu += Ambar_DepoDoldu;





            Console.ReadLine();

        }

        private static void Ambar_DepoDoldu(int tasanMiktar)
        {
            Console.WriteLine("Kaç ton tahıl eklemek istersin");
            int miktar = Convert.ToInt32(Console.ReadLine());



        }
    }
}
