using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AbstractionNeGiyeyim
{
    public class NeGiysem
    {
        //private readonly Meteorolji _havaServis; //burayı oluşturmamım sebebi aşağıda ctor un içinde bu fieldin içine program.cs'den bir değer yolladım.
        //yolladığım değer bir metaoroloji sınıfından instance. 
        //public NeGiysem(Meteorolji havaServis)
        //{
        //    _havaServis = havaServis;
        //}

        private readonly IHavaDurumu _havaServis;
        public NeGiysem(IHavaDurumu havaServis) //Bağımlılıklardan kurtulduğumuz yer. IHavaDurumu adında Interface'e sahip bütün classları burda                                                    kullanabilirim. Simdi yukarıdaki gibi olsaydı eğer. Ben sadece 1 tane hava durumu servisi                                                       kullanabilecektim. O da meteoroloji classı. Ama Ben burada IHavaDurumu verdiğim için onu kullanan her                                           servis sağlayıcı parametre olarak program cs tarafında yollar. burada yakalar. istediğimi yapabilirim.
        {
            _havaServis = havaServis;
        }


        
        public string TavsiyeVer(string sehirAd)
        {
            double sicaklik = _havaServis.SicaklikVer(sehirAd);
            if (sicaklik < 0)
                return "kalın Bot ve kaban giy.";
            else if (sicaklik < 10)
                return "ince bot ve kaban giy.";
            else if (sicaklik < 25)
                return "ceket ya da mont giy.";
            else if (sicaklik < 35)
                return "ince giy, güneş şapkası al.";
            else
                return "aşırı sıcak evde kal";

        }
    }
}
