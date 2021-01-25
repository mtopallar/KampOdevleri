using System;
using System.Collections.Generic;
using OyunProject.Concrete;
using OyunProject.Entities;

namespace OyunProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriDogrulamaManager musteriDogrulamaManager = new MusteriDogrulamaManager();

            Kampanya kampanya = new Kampanya();
            kampanya.Id = 1;
            kampanya.KampanyaAdi = "Hafta ortası indirimi";
            kampanya.IndirimOranı = 18;

            Kampanya kampanya2 = new Kampanya();
            kampanya2.Id = 2;
            kampanya2.KampanyaAdi = "Birden Fazla Oyun";
            kampanya2.IndirimOranı = 25;

            /////////////////////////////////////////////////////////////////////////////////////
            
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Adi = "Murat";
            musteri.Soyadi = "Topallar";
            musteri.Tckn = "123456789";
            musteri.DogumTarihi=new DateTime(1986,1,1);
            musteri.KayitTarihi = DateTime.Now;
            
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Engin";
            musteri2.Soyadi = "Demiroğ";
            musteri2.Tckn = "123456789";
            musteri2.DogumTarihi=new DateTime(1985,1,1);
            musteri2.KayitTarihi=DateTime.Now;

            ///////////////////////////////////////////////////////////////////////////////////////
            
            Oyun oyun = new Oyun();
            oyun.Id = 1;
            oyun.OyunAdi = "Gameloper";
            oyun.OyunFiyat = 85;
            
            Oyun oyun2 = new Oyun();
            oyun2.Id = 2;
            oyun2.OyunAdi = "Tsubasa :)";
            oyun2.OyunFiyat = 25;

            List<Oyun> oyunListBos = new List<Oyun> {}; 
            List<Oyun> oyunListTek = new List<Oyun> {oyun}; 
            List<Oyun> oyunList = new List<Oyun> {oyun,oyun2}; 
            
            

            KampanyaManager kampanyaManager = new KampanyaManager();
            //kampanyaManager.Add(kampanya2);

            MusteriManager musteriManager = new MusteriManager(musteriDogrulamaManager);
            //musteriManager.Add(musteri);

            SatisManager satisManager = new SatisManager();
            satisManager.SatisYap(musteri, kampanya2, oyunListBos);
        }
    }
}
