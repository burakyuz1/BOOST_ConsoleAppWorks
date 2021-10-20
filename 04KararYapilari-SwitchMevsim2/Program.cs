

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
            switch (ay / 3)
            {

                case 1:

                    sonuc = "İlkbahar";
                    break;
                case 2:
                    sonuc = "Yaz";
                    break;
                case 3:
                    sonuc = "Sonbahar";
                    break;

                default:
                    sonuc = "kış";
                    break;
            }

            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
