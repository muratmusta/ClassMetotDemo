using System;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Eklendi, Tekrikler  :  "
                + musteriler.Id +
                " : "
                + musteriler.AdiSoyadi + " : " + musteriler.TcKimlik +
                " : "
                + musteriler.Iletisim + " : " + musteriler.KrediRiskDurumu);

        }


        public void Sil(Musteri musteriler)
        {

            Console.WriteLine("Müşteriler Silindi ! :  "
               + musteriler.Id +
                " : "
                + musteriler.AdiSoyadi + " : " + musteriler.TcKimlik +
                " : "
                + musteriler.Iletisim + " : " + musteriler.KrediRiskDurumu);

        }

        public void Liste(Musteri musteriler)

        {
            Console.WriteLine("Müşteriler Listelendi ! :  "
                 + musteriler.Id +
                  " : "
                  + musteriler.AdiSoyadi + " : " + musteriler.TcKimlik +
                  " : "
                  + musteriler.Iletisim + " : " + musteriler.KrediRiskDurumu);

        }


    }

}



