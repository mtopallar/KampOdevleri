using System;
using System.Collections.Generic;
using System.Text;
using OyunProject.Entities;

namespace OyunProject.Abstract
{
    interface ISatisService
    {
        void SatisYap(Musteri musteri, Kampanya kampanyalar, List<Oyun> oyunlar);
    }
}
