using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 16;
            musteri1.Adi = "Ecem";
            musteri1.Soyadi = "Yıldız";
            musteri1.HesapNo = 1;
            musteri1.TC = 1111111;
            musteri1.Bakiye = 2000;
            musteri1.HesapTuru = "Vadeli";
            musteri1.HesapAcilisTarihi=010121;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 17;
            musteri2.Adi = "Cemre";
            musteri2.Soyadi ="Pekoz";
            musteri2.HesapNo = 2;
            musteri2.TC = 2222222;
            musteri2.Bakiye = 3500;
            musteri2.HesapTuru = "Vadesiz";
            musteri2.HesapAcilisTarihi = 010916;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Insert(musteri1);
            musteriManager.Remove(musteri1);

            foreach (Musteri i in musteriler)
            {
                musteriManager.MusteriGoster(i);
            }

        }
    }
}
