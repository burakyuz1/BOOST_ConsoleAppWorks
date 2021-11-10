using _01EnumOrnek.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01EnumOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar pc1 = new Bilgisayar()
            {
                Anakart = Anakart.Asus_Prime_H410,
                Bellek = Bellek.GSkill_Ripjaws_V,
                EkranKarti = EkranKarti.ASUS_R7240,
                Harddisk = Harddisk.Toshiba_N300_4TB,
                Islemci = Islemci.Intel_Core_i9_10980XE,
                SesKarti = true
            };
            Bilgisayar pc2 = new Bilgisayar()
            {
                Anakart = Anakart.GIGABYTE_Z590,
                Bellek = Bellek.HyperX_Predator_DDR4,
                EkranKarti = EkranKarti.Gigabyte_GeForce_RTX_3080Ti,
                Harddisk = Harddisk.WD_Blue_2TB,
                Islemci = Islemci.AMD_Ryzen9_3900XT,
                SesKarti = false
            };
            Bilgisayar pc3 = new Bilgisayar()
            {
                Anakart = Anakart.MSI_Z490,
                Bellek = Bellek.HyperX_Predator_DDR4,
                EkranKarti = EkranKarti.MSI_GeForce_RTX_3090,
                Harddisk = Harddisk.WD_Blue_2TB,
                Islemci = Islemci.AMD_Ryzen9_3900XT,
                SesKarti = true
            };
            Bilgisayar pc4 = new Bilgisayar()
            {
                Anakart = Anakart.GIGABYTE_Z590,
                Bellek = Bellek.Corsair_Vengeance_LPX,
                EkranKarti = EkranKarti.ASUS_R7240,
                Harddisk = Harddisk.Seagate_BarraCuda_1TB,
                Islemci = Islemci.Intel_Core_i7_11700KF,
                SesKarti = false
            };
            List<Bilgisayar> pcList = new List<Bilgisayar>()
            {
                pc1,pc2,pc3,pc4
            };

            Console.WriteLine("SES KARTI OLANLAR");
            Console.WriteLine("-------------");
            foreach (var item in pcList)
            {
                if (item.SesKarti == true)
                {
                    Console.WriteLine($"ANAKART: {item.Anakart}\nISLEMCI: {item.Islemci}\nEKRANKARTI: {item.EkranKarti}\nBELLEK: {item.Bellek}\nHARDDISK: {item.Harddisk}");
                    Console.WriteLine("************");
                }
            }

            Console.ReadLine();


        }
    }
}
