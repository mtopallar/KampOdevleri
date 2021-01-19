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

            Array.Resize(ref eklenecekListe, eklenecekListe.Length + 1);
            for (int j = musteriler.Length; j < eklenecekListe.Length; j++)
            {

                eklenecekListe[j] = musteri;

                Console.WriteLine(musteri.MusteriAdi + " adlı; " + musteri.MusteriSoyadi + " soyadlı;" + musteri.Tckn + " kimlik numaralı müşteri sisteme başarıyla eklenmiştir.\n");
                Console.WriteLine("Güncel liste: \n");
                foreach (var musteriList in eklenecekListe)
                {
                    Console.WriteLine(musteriList.MusteriAdi + " " + musteriList.MusteriSoyadi + " " + musteriList.Tckn + " " + musteriList.Cinsiyet + " " + musteriList.Yas + " " + musteriList.Uyruk);
                }
            }

            Console.WriteLine("-----------------------------------------------------------");

        }

        internal void MusteriSil(Musteri[] musteriler, Musteri musteri)
        {
            Musteri[] silinecekListe = new Musteri[0];
            int sayac = 0;

            if (musteriler.Length != 0)
            {
                //liste doluysa fakan gönderilen müşteri listedekilerden biri değilse listede yok yazacak.

                Console.WriteLine("Müşteri silmeden önce sistemdeki müşteri listemiz şu şekildedir : \n");
                foreach (var mevcutList in musteriler)
                {
                    Console.WriteLine(mevcutList.MusteriAdi + " " + mevcutList.MusteriSoyadi + " " + mevcutList.Tckn + " " + mevcutList.Cinsiyet + " " + mevcutList.Yas + " " + mevcutList.Uyruk);
                }

                foreach (var musteri1 in musteriler)
                {
                    var isim = musteri1.MusteriAdi;

                    if (isim != musteri.MusteriAdi)
                    {
                        Array.Resize(ref silinecekListe, silinecekListe.Length + 1);
                        silinecekListe[sayac] = musteri1;
                        sayac++;

                        if (silinecekListe.Length == musteriler.Length - 1)
                        {
                            Console.WriteLine("\n" + musteri.MusteriAdi + " adlı; " + musteri.MusteriSoyadi + " soyadlı; " + musteri.Tckn + " Tckn numaralı; müşterimiz sistemden başarı ile silinmiştir.\n");
                            Console.WriteLine("Güncel müşteri listemiz şu şekildedir: \n");

                            foreach (var musteriGuncelListe in silinecekListe)
                            {
                                Console.WriteLine(musteriGuncelListe.MusteriAdi + " " + musteriGuncelListe.MusteriSoyadi + " " + musteriGuncelListe.Tckn + " " + musteriGuncelListe.Cinsiyet + " " + musteriGuncelListe.Yas + " " + musteriGuncelListe.Uyruk);
                            }
                        }
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Müşteri zaten müşteriler listemizde mevcut değil.\n");
            }

            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
