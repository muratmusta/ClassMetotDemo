using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Eklendi, Tekrikler  :  " + musteriler.Id + " : " + musteriler.AdiSoyadi + " : " + musteriler.TcKimlik + " : " + musteriler.Iletisim + " : " + musteriler.Bakiye);

        }

        
        public void Sil(Musteri musteriler)
        {

            Console.WriteLine("Müşteriler Silindi ! :  " + musteriler.Id + " : " + musteriler.AdiSoyadi + " : " + musteriler.TcKimlik + " : " + musteriler.Iletisim + " : " + musteriler.Bakiye);

        }

        public void Liste(Musteri musteriler)

        {

            Console.WriteLine(musteriler.Id + " : " + musteriler.AdiSoyadi + " : " + musteriler.TcKimlik + " : " + musteriler.Iletisim + " : " + musteriler.Bakiye);
            
        }


    }

}

    

