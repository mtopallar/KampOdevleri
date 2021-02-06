using System;
using System.Collections.Generic;
using System.Text;
using OyunProject.Abstract;
using OyunProject.Entities;

namespace OyunProject.Concrete
{
    class MusteriManager:IMusteriService
    {
        private IMusteriDogrulamaService _musteriDogrulamaService; //mikro service

        public MusteriManager(IMusteriDogrulamaService musteriDogrulamaService)
        {
            _musteriDogrulamaService = musteriDogrulamaService;
        }

        public void Add(Musteri musteri)
        {
            if (_musteriDogrulamaService.MusteriDogrula(musteri))
            {
                Console.WriteLine(musteri.Adi+" "+musteri.Soyadi+" sisteme kaydedildi");
            }
            else
            {
                Console.WriteLine("Kimlik bilgilerinizde hata var. Lüften kontrol ediniz.");
            }
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+"' id li müşteri başarıyla güncellenmiştir.");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+"' id li müşteri başarıyla silinmiştir.");

        }
    }
}
