using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04IComparableOrnek
{
    public class Film : IComparable
    {
        public string Ad { get; set; }
        public decimal Imdb { get; set; }

        public int CompareTo(object obj)
        {
            Film diger = (Film)obj;
            //int puanKiyas = Imdb.CompareTo(diger.Imdb);
            int adKiyas = Ad.CompareTo(diger.Ad);
            return adKiyas;
            //return puanKiyas;    -> HANGISINE GORE SIRALAMAK İSTERSEK ONU RETURN EDERSEK ÖYLE SIRALAR
        }
    }
}

//Once puana sonra ada göre sıralama işlemi
//int puanKiyas = Imdb.CompareTo(diger.Imdb);
//int adKiyas = Ad.CompareTo(diger.Ad);
//return puanKiyas == 0 ? adKiyas : puanKiyas;