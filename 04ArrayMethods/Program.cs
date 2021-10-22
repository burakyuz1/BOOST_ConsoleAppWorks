using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] adlar1 = { "serkan", "sina" };
            //string[] adlar2 = { "aysegul", "ugurcan", "burak", "ali" };

            //string[] adlar3 = new string[adlar1.Length + adlar2.Length];

            //for (int i = 0; i < adlar1.Length; i++)
            //{
            //    adlar3[i] = adlar1[i];
            //}
            //for (int i = 0; i < adlar2.Length; i++)
            //{
            //    adlar3[i + adlar1.Length] = adlar2[i];
            //}


            //nolar1 de olup nolar2 de olmayanl elemanları yazdırın

            int[] nolar1 = { 3, 7, 11, 1, 2, 7 };
            int[] nolar2 = { 2, 9, 7 };


            for (int i = 0; i < nolar1.Length; i++)
            {
                //int sayac = 0;
                bool yok = true;
                for (int j = 0; j < nolar2.Length; j++)
                {
                    if (nolar1[i] == nolar2[j])
                    {
                        yok = false;
                        break;
                    }
                }
                if (yok)
                {
                    Console.Write(nolar1[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
