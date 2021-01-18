using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        internal void MusteriEkle(Musteri[] musteriler, Musteri musteri)
        {
            Musteri[] eklenecekListe;
            eklenecekListe = musteriler;

            //if (musteriler.Length == 0)
            //{
                Array.Resize(ref eklenecekListe, eklenecekListe.Length + 1);
                for (int j = musteriler.Length; j < eklenecekListe.Length; j++)
                {
                     
                    eklenecekListe[j] = musteri;

                   
                    foreach (var musteriList in eklenecekListe)
                    {
                        Console.WriteLine(musteriList.MusteriAdi);
                    }
                }
            //}
            //else
            //{
            //    for (int i = eklenecekListe.Length; i <= musteriler.Length; i++)
            //    {
            //        Array.Resize(ref eklenecekListe, eklenecekListe.Length + 1);
            //        for (int j = musteriler.Length; j < eklenecekListe.Length; j++)
            //        {
                        
            //            eklenecekListe[j] = musteri;


            //            foreach (var musteriList in eklenecekListe)
            //            {
            //                Console.WriteLine(musteriList.MusteriAdi);
            //            }
                        
            //        }
            //    }


            //}

            //return null;
        }

        internal void MusteriSil(Musteri[] musteriler, Musteri musteri)
        {
            Musteri[] silinecekListe;

            if (musteriler.Length != 0)
            {
                for (int i = 0; i < musteriler.Length; i++)
                {
                    if (musteriler[i].Tckn != musteri.Tckn)
                    {
                        silinecekListe = new Musteri[i];
                        silinecekListe[i] = musteriler[i];
                    }
                }
            }

            Console.WriteLine(musteri.Id + " Id'li; " + musteri.MusteriAdi + " adlı; " + musteri.MusteriSoyadi + " soyadlı; " + musteri.Tckn + " kimlik nolu ve müşterimiz sistemden başarıyla silinmiştir.");
        }
    }
}
