using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            List<SehirPlakalari> plakalar = new List<SehirPlakalari>();
            //plakalar.Add(SehirPlakalari.Ankara);
            //plakalar.Add(SehirPlakalari.Istanbul);
            //plakalar.Add(SehirPlakalari.Izmir);
            //plakalar.Add(SehirPlakalari.Samsun);

            //foreach (var item in plakalar)
            //{
            //    Console.WriteLine(item + " " + (int)item);
            //}


            //II. BIR BASKA YONTEM
            var list = Enum.GetValues(typeof(SehirPlakalari)).Cast<SehirPlakalari>().ToList();
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item + " " + (int)item);

            }


            Console.ReadKey();
        }
    }
}
