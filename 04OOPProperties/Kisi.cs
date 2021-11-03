using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04OOPProperties
{
    public class Kisi
    {
        #region Property olmadan Encapsulation
        private string ad;
        public string GetAd()
        {
            return ad;
        }

        public void SetAd(string deger)
        {
            ad = deger; //Encapsulation delinmedi. Çünkü benim verdiğim metot sayesinde ad değişkeni değişebilir veya okunabilir.. eğer yukarıdaki ad değişkeni public olmuş olsaydı encapsulation ilkesini delmiş olurdum.
        }
        #endregion

        #region Full Property
        private string soyad;// field alanı, doğrudan erişim var. aşağı satırlarda.
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        #endregion

        #region AutoProperty

        public DateTime DogumTarihi { get; set; } // buranın fieldı içinde gizli yani o field'a doğrudan erişim sağlayamayız

        #endregion

        #region Read-only Property
        public int Yas
        {
            get
            {
                return DateTime.Now.Year - DogumTarihi.Year;
            }
        }
        #endregion

        #region Read-only Propert - II
        //public string TamAd { get { return $"{ad} {Soyad }" } }
        public string TamAd => $"{ad} {Soyad}"; //Arrow gösterdiği yer return olur.
                                            // Kısacası read-only prop tanımlamak için kullanılır
                                            //Expression bodied member
        #endregion
        public string Kunye()
        {
            return $"{GetAd()} {Soyad} ({Yas})";
        }

    }
}
