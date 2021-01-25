using System;
using OyunProject.Abstract.Entities;

namespace OyunProject.Entities
{
    public class Musteri:IEntity
    {
        public int Id { get; set; }
        //public int OyunId { get; set; }
        public string Tckn { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime KayitTarihi { get; set; }
        //public string KullaniciAdi { get; set; }
        //public string Parola { get; set; }

    }
}
