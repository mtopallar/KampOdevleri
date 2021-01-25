using System;
using System.Collections.Generic;
using System.Text;
using OyunProject.Abstract;
using OyunProject.Entities;

namespace OyunProject.Concrete
{
    class KampanyaManager:IKampanyaService
    {
        public void Add(Kampanya entity)
        {
            Console.WriteLine(entity.KampanyaAdi+" isimli kampanya sisteme başarıyla eklendi");
        }

        public void Update(Kampanya entity)
        {
            Console.WriteLine(entity.KampanyaAdi+" isimli kampanya başarıyla güncellendi");
        }

        public void Delete(Kampanya entity)
        {
            Console.WriteLine(entity.Id+" Id'li kampanya sistemden başarıyla silindi");
        }
    }
}
