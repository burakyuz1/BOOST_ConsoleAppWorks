using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00PracticeMethods
{
    public static class ExtensionMethod
    {
        public static bool TcNoDogrula(this string tc)
        {
            if (tc[0] == '0')
                return false;

            int tekToplamlar = Convert.ToInt32(tc[0].ToString());
            int ciftToplamlar = 0;


            for (int i = 1; i < 9; i++)
            {
                if (i % 2 == 0) //tek haneler 
                    tekToplamlar += Convert.ToInt32(tc[i].ToString());

                else // çift haneler
                    ciftToplamlar += Convert.ToInt32(tc[i].ToString());
            }

            if ((tekToplamlar * 7 - ciftToplamlar) % 10 != Convert.ToInt32(tc[9].ToString()))  // 10. karakter kontrolü
                return false;

            int genelToplam = tekToplamlar + ciftToplamlar + Convert.ToInt32(tc[9].ToString());
            if (genelToplam % 10 != Convert.ToInt32(tc[10].ToString()))  //11. karakter kontrolü
                return false;

            return true;
        }
        #region YONTEM I

        ////static string TcNoUret() 
        ////{
        ////    Random rnd = new Random();
        ////    int[] tc = new int[11];

        ////    tc[0] = rnd.Next(1, 10); // ilk basamağı belirleme
        ////    int tekToplamlar = 0;
        ////    int ciftToplamlar = 0;

        ////    tekToplamlar = tc[0];
        ////    for (int i = 2; i <= 8; i += 2) // tek haneli rakamların toplamı - üretilmesi
        ////    {
        ////        tc[i] = rnd.Next(0, 10);
        ////        tekToplamlar += tc[i];
        ////    }
        ////    for (int i = 1; i <= 7; i += 2) // çift haneli rakamların toplamı - üretilmesi
        ////    {
        ////        tc[i] = rnd.Next(0, 10);
        ////        ciftToplamlar += tc[i];
        ////    }
        ////    tc[9] = (tekToplamlar * 7 - ciftToplamlar) % 10; // 10. hanenin üretilmesi
        ////    tc[10] = (tekToplamlar + ciftToplamlar + tc[9]) % 10; // son hanenin üretilmesi
        ////    return string.Join("", tc);
        ////} 
        #endregion
        public static string TcNoUret() //YÖNTEM II
        {
            Random rnd = new Random();
            string tc = "";
            tc += rnd.Next(1, 10);

            int tekToplamlar = Convert.ToInt32(tc[0].ToString());
            int ciftToplamlar = 0;

            for (int i = 1; i <= 8; i++) // tek ve çift haneli sayıların toplanması
            {
                int randomRakam = rnd.Next(0, 10);
                if (i % 2 == 0)
                {
                    tc += Convert.ToInt32(randomRakam);
                    tekToplamlar += randomRakam;
                }
                else
                {
                    tc += Convert.ToInt32(randomRakam);
                    ciftToplamlar += randomRakam;
                }
            }

            tc += (tekToplamlar * 7 - ciftToplamlar) % 10; // 10. hanenin üretilmesi
            int toplam = tekToplamlar + ciftToplamlar + Convert.ToInt32(tc[9].ToString());
            tc += toplam % 10; // son hanenin üretilmesi
            return tc;
        }


    }0
}
