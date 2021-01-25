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
            // Mernis sisteminden doğrulama yaptığımızı varsayıyoruz. Buradan true dönerse müşteri kaydı gerçekleşiyor, false dönerse kayıt gerçekleşmiyor ve bir bilgilendirme mesajı alıyoruz.
            
            return true;

            //return false;
        }
    }
}
