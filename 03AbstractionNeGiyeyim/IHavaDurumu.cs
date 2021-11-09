using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AbstractionNeGiyeyim
{
    public interface IHavaDurumu
    {
        //Interfacelerde public private diye belirtilmez, bodysi olmaz!
        double SicaklikVer(string sehirAd);
    }
}
