using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.musteriAdi = "Berrin";
            musteri1.musteriSoyadi = "Cengiz";
            musteri1.TcNo = "12345678910";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.musteriAdi = "Ali";
            musteri2.musteriSoyadi = "Cengiz";
            musteri2.TcNo = "12345678910";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Ekle(musteri1);
            musteriManager1.Ekle(musteri2);

            musteriManager1.Listele(musteriler);

            musteriManager1.Sil(musteri2);
           
        }
    }
}
