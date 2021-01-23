using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotlar

        public void Add(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Hesabı Eklendi");
        }
        public void Insert(Musteri musteri)
        {
            Console.WriteLine("İstenilen Listelendi");
        }

        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Silindi");
        }

        public void MusteriGoster(Musteri musteri)
        {
            Console.WriteLine();
        }
    }
}
