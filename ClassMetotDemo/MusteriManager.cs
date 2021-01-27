using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteriler listelendi : " + musteri.musteriAdi);
            }
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("müşteri eklendi : " + musteri.musteriAdi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("müşteri silindi : " + musteri.musteriAdi);
        }
    }
}
