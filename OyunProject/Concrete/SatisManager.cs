using System;
using System.Collections.Generic;
using System.Text;
using OyunProject.Abstract;
using OyunProject.Entities;

namespace OyunProject.Concrete
{
    public class SatisManager : ISatisService
    {

        public void SatisYap(Musteri musteri, Kampanya kampanya, List<Oyun> oyunlar)
        {
            if (oyunlar.Count == 0)
            {
                Console.WriteLine("Satış işlemini gerçekleştirmek için en az bir oyun seçiniz.");
            }
            else if (oyunlar.Count == 1 && kampanya.KampanyaAdi == "Birden Fazla Oyun")
            {
                Console.WriteLine("Birden fazla oyun kampanyasından faydalanabilmek için birden fazla oyun almalısınız.");
            }
            else
            {
                foreach (var oyun in oyunlar)
                {

                    {
                        Console.WriteLine(oyun.OyunAdi);

                    }

                }
                Console.WriteLine("\n" + musteri.Adi + " " + musteri.Soyadi + " isimli oyuncuya " + kampanya.KampanyaAdi + " kampanyası avantajı ile satılmıştır.");
            }

        }
    }
}
