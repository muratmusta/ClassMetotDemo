using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdiSoyadi = "Mustafa Bülbül";
            musteri1.Id = 1;
            musteri1.TcKimlik = "12345678910";
            musteri1.Iletisim = "5321234567";
            musteri1.Bakiye = 4500;

            Musteri musteri2 = new Musteri();
            musteri2.AdiSoyadi = "Onur Keleş";
            musteri2.Id = 2;
            musteri2.TcKimlik = "12345678919";
            musteri2.Iletisim = "5321234560";
            musteri2.Bakiye = 3500;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

          

            MusteriManager musteriManager = new MusteriManager();
                musteriManager.Ekle(musteri1);
                musteriManager.Ekle(musteri2);
                musteriManager.Sil(musteri1);
                musteriManager.Sil(musteri2);
                musteriManager.Liste(musteri1);
                musteriManager.Liste(musteri2);



        }


        }
    }

