using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        
        internal void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.Cinsiyet + " " + musteri.Uyruk + " " + musteri.Yas);
            }

            Console.WriteLine("-----------------------------------------------------");
        }

        //internal void MusteriEkle(Musteri musteri)
        //{
        //    Console.WriteLine(musteri.MusteriAdi + " adlı; " + musteri.MusteriSoyadi + " soyadlı; " + musteri.Tckn + " kimlik nolu müşterimiz sisteme başarıyla eklenmiştir.");

        //    Console.WriteLine("-----------------------------------------------------------------------");
        //}

        internal Musteri[] MusteriEkle(Musteri musteri,Musteri[] musteriler)
        {
            Musteri[] eklenecekListe;
            
            for (int i = 0; i < musteriler.Length; i++)
            {
                eklenecekListe = musteriler;
                
                Array.Resize(ref eklenecekListe,eklenecekListe.Length+1);
                for (int j = musteriler.Length; j < eklenecekListe.Length; j++)
                {
                    var list = eklenecekListe[j] = musteri;
                    
                    return eklenecekListe;

                }

                
            }
            
            Console.WriteLine(musteri.MusteriAdi + " adlı; " + musteri.MusteriSoyadi + " soyadlı; " + musteri.Tckn + " kimlik nolu müşterimiz sisteme başarıyla eklenmiştir.");
            

            Console.WriteLine("-----------------------------------------------------------------------");

            return null;
        }

        internal void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " Id'li; " + musteri.MusteriAdi + " adlı; " + musteri.MusteriSoyadi + " soyadlı; " + musteri.Tckn + " kimlik nolu ve müşterimiz sistemden başarıyla silinmiştir.");
        }
    }
}
