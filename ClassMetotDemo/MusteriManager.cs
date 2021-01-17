using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine( musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " +  musteri.Yas + " " + " İsimli Müşteri eklendi...");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("\n" + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " +musteri.Yas + " " + " İsimli Müşteri silindi... ");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine( " \nMüşteri Listesi : ");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas  );
            }
        }

    }
}
