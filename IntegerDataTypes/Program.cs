using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamSayisalVeriTurleri
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //8 bit unsigned..
            byte minByte = 0; //8 bittir, işaretsiz (unsigned) -> pozitiftir. 8 bit yani 0/1 lerden 8 ayrı sayı verebiliriz. 2^8 = 256 - 1 -> 0 ı çıkartırsak 255 .
                              //[0-255]  arası değer alır.  
            byte maxByte = 255;  //1 eklediğim zaman  0'a geri dönmüş olur..
            checked // Taşmaları engellemek için hata fırlatır..
            {
                minByte--;
                Console.WriteLine(minByte);
                Console.ReadKey();
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //8 bit signed..
            sbyte minSbyte = -128;  //Pozitif 127 (0 dahil) -- Negatif 128 adet sayı alır.                       [-128(-2^7) , 127(2^7-1) arası değer alır.]
            sbyte maxSbyte = 127;   //sbyte.MinValue; -> Property sini kullanarak da ulaşabiliriz.

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //16 bit signed.. Int16 olarak da bilinir:
            short minShort = -32768; //2^15 negatifler  2^15 pozitifler -> -32768   32767
            short maxShort = 32767;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //16 bit unsigned.. 
            ushort minshort = 0;
            ushort maxShot = 65535;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //32 bit signed.. -> Int32 olarak da bilinir:
            int minInt = -2147483648; //-2^31
            int maxInt = 2147483647; //2^31-1

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //32 bit unsigned..

            uint minUint = 0;
            uint maxUint = 4294967295; //2^32

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //64 bit signed.. -> Int64 olarak da bilinir:

            long minLong = -9223372036854775808; // -2^63
            long maxLong = 9223372036854775807; // 2^63-1

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //64 bit unsigned..

            ulong minUlong = 0;
            ulong maxUlong = 18446744073709551615;//2^64-1

        }
    }
}
