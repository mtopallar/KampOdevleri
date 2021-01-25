using System;
using System.Collections.Generic;
using System.Text;
using OyunProject.Abstract;
using OyunProject.Entities;

namespace OyunProject.Concrete
{
    class OyunManager:IOyunService
    {
        public void Add(Oyun entity)
        {
            Console.WriteLine(entity.OyunAdi+" isimli oyun sisteme eklenmiştir.");
        }

        public void Update(Oyun entity)
        {
            Console.WriteLine(entity.OyunAdi+" isimli oyun başarıyla güncellenmiştir.");
        }

        public void Delete(Oyun entity)
        {
            Console.WriteLine(entity.Id+" Id'li oyun sistemden başarıyla silinmiştir.");
        }
    }
}
