using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AbstractionNeGiyeyim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nerede yaşıyorsun?");
            string yer = Console.ReadLine();

            /*  NeGiysem tavsiye = new NeGiysem(new Meteorolji());*/ //burası meteoroloji sıınıfına bağlı, bunu bağımlılıklarından kurtarmam lazım
                                                                     // çünkü yarın başka sağlayıcıyla çalıştığım zaman neGiysem Classı da patlar..!


            IHavaDurumu havaServis = new Meteorolji();
            //Mesela artık Meteoroljiyle değil Wheather.Com ile çalışacağım. Onun classını yazdıktan sonra sadece onu newliyorum.
            IHavaDurumu havaServis2 = new WheatherCom();

            NeGiysem tavsiye = new NeGiysem(havaServis2);


            Console.WriteLine(tavsiye.TavsiyeVer(yer)); 


            Console.ReadLine();
        }
    }
}
