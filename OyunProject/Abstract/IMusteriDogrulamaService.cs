using System;
using System.Collections.Generic;
using System.Text;
using OyunProject.Entities;

namespace OyunProject.Abstract
{
    public interface IMusteriDogrulamaService
    {
        bool MusteriDogrula(Musteri musteri);
    }
}
