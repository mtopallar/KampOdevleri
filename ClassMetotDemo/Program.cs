using System;

namespace ClassMetotDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.MusteriAdi = "Murat";
            musteri.MusteriSoyadi = "Öğrenci";
            musteri.Yas = 35;
            musteri.Cinsiyet = "Erkek";
            musteri.Uyruk = "T.C.";
            musteri.Tckn = "123456789";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Engin";
            musteri2.MusteriSoyadi = "Eğitmen";
            musteri2.Yas = 35;
            musteri2.Cinsiyet = "Erkek";
            musteri2.Uyruk = "T.C.";
            musteri2.Tckn = "987654321";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Cansu";
            musteri3.MusteriSoyadi = "Öğrenci";
            musteri3.Yas = 27;
            musteri3.Cinsiyet = "Kadın";
            musteri3.Uyruk = "T.C.";
            musteri3.Tckn = "123321456";

            Musteri[] musteriler = new Musteri[] { musteri, musteri2, musteri3 };
            Musteri[] musteriler2 = new Musteri[] { musteri, musteri2 };
            Musteri[] musteriler1 = new Musteri[] { musteri };
            Musteri[] musteriler3 = new Musteri[] { };

            MusteriManager musteriManager = new MusteriManager();

            //musteriManager.MusteriListele(musteriler);

            //musteriManager.MusteriEkle(musteriler3,musteri3);

            musteriManager.MusteriSil(musteriler3,musteri3);
        }
    }
}
