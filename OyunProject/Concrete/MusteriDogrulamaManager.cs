using System;
using System.Collections.Generic;
using System.Text;
using OyunProject.Abstract;
using OyunProject.Entities;

namespace OyunProject.Concrete
{
    public class MusteriDogrulamaManager:IMusteriDogrulamaService
    {
        public bool MusteriDogrula(Musteri musteri)
        {
            return true;
            //return false;
        }
    }
}
