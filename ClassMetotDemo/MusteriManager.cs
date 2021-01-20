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
            if (musteriler.Length == 0)
            {
                Console.WriteLine("Müşteri listenizde kayıtlı müşteri bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("Mevcut müşteri listeniz şu şekildedir: \n");
                foreach (Musteri musteri in musteriler)
                {
                    Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.Cinsiyet + " " + musteri.Uyruk + " " + musteri.Yas);
                }
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

            if (Array.Exists(musteriler, m => m.Tckn == musteri.Tckn))
            {
                Console.WriteLine("Eklemek istediğiniz müşteri zaten listenizde kayıtlıdır.");
            }
            else
            {
                Array.Resize(ref eklenecekListe, eklenecekListe.Length + 1);
                for (int j = musteriler.Length; j < eklenecekListe.Length; j++)
                {
                    eklenecekListe[j] = musteri;

                    Console.WriteLine(musteri.MusteriAdi + " adlı; " + musteri.MusteriSoyadi + " soyadlı;" +
                                      musteri.Tckn + " kimlik numaralı müşteri sisteme başarıyla eklenmiştir.\n");
                    Console.WriteLine("Güncel liste: \n");
                    foreach (var musteriList in eklenecekListe)
                    {
                        Console.WriteLine(musteriList.MusteriAdi + " " + musteriList.MusteriSoyadi + " " +
                                          musteriList.Tckn + " " + musteriList.Cinsiyet + " " + musteriList.Yas + " " +
                                          musteriList.Uyruk);
                    }
                }

                Console.WriteLine("-----------------------------------------------------------");
                
            }
        }

        internal void MusteriSil(Musteri[] musteriler, Musteri musteri)
        {
            Musteri[] listedeOlmayan = new Musteri[0];
            Musteri[] kontrolListesi = new Musteri[musteriler.Length];
            int indexer = 0;

            if (musteriler.Length != 0)
            {
                Array.Copy(musteriler, kontrolListesi, musteriler.Length);
                var index = Array.FindIndex(musteriler, m => m.MusteriAdi == musteri.MusteriAdi);

                if (index == -1)
                {
                    Console.WriteLine("Müşteri listenizde " + musteri.MusteriAdi + " adlı; " + musteri.MusteriSoyadi + " soyadlı, " + musteri.Tckn + " soyadlı müşteri bulunmamaktadır. Listeniz şu şekildedir: \n");
                    foreach (var musteri1 in kontrolListesi)
                    {
                        Console.WriteLine(musteri1.MusteriAdi + " " + musteri1.MusteriSoyadi + " " + musteri1.Tckn + " " + musteri1.Cinsiyet + " " + musteri1.Yas + " " + musteri1.Uyruk);
                    }
                }
                else
                {
                    kontrolListesi[index] = null;

                    Console.WriteLine("Müşteri silmeden önce sistemdeki müşteri listeniz şu şekildedir : \n");

                    foreach (var musteriListesi in musteriler)
                    {
                        Console.WriteLine(musteriListesi.MusteriAdi + " " + musteriListesi.MusteriSoyadi + " " + musteriListesi.Tckn + " " + musteriListesi.Cinsiyet + " " + musteriListesi.Yas + " " + musteriListesi.Uyruk);
                    }

                    Console.WriteLine("\n" + musteri.MusteriAdi + " adlı; " + musteri.MusteriSoyadi + " soyadlı; " + musteri.Tckn + " Tckn numaralı; müşterimiz sistemden başarı ile silinmiştir.\n\nGüncel müşteri listemiz şu şekildedir:\n");

                    foreach (var musteri1 in kontrolListesi)
                    {

                        if (musteri1 != null)
                        {
                            Array.Resize(ref listedeOlmayan, listedeOlmayan.Length + 1);
                            listedeOlmayan[indexer] = musteri1;
                            indexer++;
                        }
                    }

                    if (listedeOlmayan.Length == 0)
                    {
                        Console.WriteLine("Listede tek kayıtlı olan " + musteri.MusteriAdi + " isimli; " + musteri.MusteriSoyadi + " soyisimli müşteriyi sildikten sonra listenizde kayıtlı müşteri kalmamıştır.");
                    }
                    else
                    {
                        foreach (var musteri2 in listedeOlmayan)
                        {
                            Console.WriteLine(musteri2.MusteriAdi + " " + musteri2.MusteriSoyadi + " " + musteri2.Tckn + " " + musteri2.Cinsiyet + " " + musteri2.Yas + " " + musteri2.Uyruk);
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("Müşteri listesinde müşteri kaydına rastlanmamıştır. Lüften listeyi kontrol ediniz.\n");
            }

            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
