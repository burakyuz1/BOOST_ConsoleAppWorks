using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01StokEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();
            urun.Ad = "Ciklet";
            urun.Id = 1;
            urun.StokMiktari = 50;

            urun.StokAzaldi += Urun_StokAzaldi;
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(750);
                urun.StokMiktari -= 15;
                Console.WriteLine("StokMiktari " + urun.StokMiktari);
            }
        }

        private static void Urun_StokAzaldi(object sender, StokAzaldiEventArgs e)
        {
            Urun gelenUrun = (Urun)sender;

        }
    }
}
