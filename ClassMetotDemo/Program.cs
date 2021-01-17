using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "34234";
            musteri1.Ad = "İrem";
            musteri1.Soyad = "Ceylan";
            musteri1.Yas = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Id = "46756";
            musteri2.Ad = "Elif";
            musteri2.Soyad = "Atagül";
            musteri2.Yas = 19;

            Musteri musteri3 = new Musteri();
            musteri3.Id = "34674";
            musteri3.Ad = "Nuran";
            musteri3.Soyad = "Korkmaz";
            musteri3.Yas = 20;

            Musteri musteri4 = new Musteri();
            musteri4.Id = "563354";
            musteri4.Ad = "Ahmet";
            musteri4.Soyad = "Yaşar";
            musteri4.Yas = 25;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 ,musteri4};

            MusteriManager musteriMananger = new MusteriManager();

            musteriMananger.Ekle(musteri1);
            musteriMananger.Ekle(musteri2);
            musteriMananger.Ekle(musteri3);
            musteriMananger.Listele(musteriler);
            musteriMananger.Sil(musteri4);

           


        }
    }
}
