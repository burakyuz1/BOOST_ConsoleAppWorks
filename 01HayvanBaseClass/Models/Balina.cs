using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HayvanBaseClass.Models
{
    public class Balina : Hayvan , IYuzebilir
    {
        public Balina()
        {
            Tur = "Balina";
            Console.WriteLine($"{Tur} olarak oluştum.");
        }

        public void Yuz()
        {
            Console.WriteLine($"{Tur} yüzüyor.");
        }
    }
}
