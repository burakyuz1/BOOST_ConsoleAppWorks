using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03KararYapilari_SwitchOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mevsim bilgisi           
            int ay;


            do
            {
                Console.WriteLine("Bir ay numarası giriniz (1-12) : ");
                ay = Convert.ToInt32(Console.ReadLine());

            } while (ay < 1 || ay > 12); ;

            string sonuc;
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    sonuc = "Kış";
                    break;
                case 3:
                case 4:
                case 5:
                    sonuc = "İlkbahar";
                    break;
                case 6:
                case 7:
                case 8:
                    sonuc = "Yaz";
                    break;
                default:
                    sonuc = "Sonbahar";
                    break;
            }


            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
