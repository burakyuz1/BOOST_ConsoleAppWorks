using _01HayvanBaseClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HayvanBaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region YONTEM I
            //Hayvan hayvan = new Hayvan();
            //hayvan.SesCikar();
            //hayvan.HareketEt();
            //Console.WriteLine(hayvan.ToString());

            //Console.WriteLine("*******");

            //Hayvan kedi1 = new Kedi();
            //kedi1.HareketEt();
            //((Kedi)kedi1).Mirilda();

            //Console.WriteLine("*******");

            //Hayvan serce = new Serce();
            //serce.HareketEt();
            //serce.SesCikar();
            //Console.WriteLine(serce.ToString());

            //Console.WriteLine("*******");

            //Hayvan balina = new Balina();
            //((Balina)balina).Yuz();

            //Console.WriteLine("*******");
            //Ahtapot ahtapot = new Ahtapot();
            //ahtapot.Yuz(); 
            #endregion

            Hayvan hayvan = new Hayvan();
            hayvan.SesCikar();
            hayvan.HareketEt();
            Console.WriteLine(hayvan.ToString());

            Console.WriteLine("*****");
            List<Hayvan> hayvanListesi = new List<Hayvan>();
            hayvanListesi.Add(new Ahtapot());
            hayvanListesi.Add(new Balina());
            hayvanListesi.Add(new Kedi());
            hayvanListesi.Add(new Serce());

            foreach (Hayvan hayvan1 in hayvanListesi)
            {
                if (hayvan1 is Kedi)
                {
                    Console.WriteLine("*****");
                    Kedi cat = (Kedi)hayvan1;
                    cat.HareketEt();
                    cat.Mirilda();
                }
                if (hayvan1 is Ahtapot)
                {
                    Console.WriteLine("*****");
                    Ahtapot ahtapot = (Ahtapot)hayvan1;
                    ahtapot.Yuz();
                }
                if (hayvan1 is Balina)
                {
                    Console.WriteLine("*****");
                    Balina balina = (Balina)hayvan1;
                    balina.Yuz();
                }
                if (hayvan1 is Serce)
                {
                    Console.WriteLine("*****");
                    Serce serce = (Serce)hayvan1;
                    serce.HareketEt();
                    serce.SesCikar();
                    Console.WriteLine(serce.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
