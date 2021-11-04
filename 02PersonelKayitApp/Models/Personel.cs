using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PersonelKayitApp.Models
{
    public class Personel
    {
        public string AdSoyad { get; set; }
        public string TcNO { get; set; }
        public bool Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Yas { get { return DateTime.Now.Year - DogumTarihi.Year; } }
        public string Birim { get; set; }
        public string PersonelBilgileriniGetir()
        {
            string cinsiyet = Cinsiyet == true ? "Erkek" : "Kadın";
            return $"Kullanıcı Adı: {AdSoyad}\r\nTC: {TcNO}\r\nCinsiyet:{cinsiyet} \r\nDoğum Tarihi: {DogumTarihi}\r\nYas: {Yas}\r\nBirim: {Birim}";
        }
    }
}