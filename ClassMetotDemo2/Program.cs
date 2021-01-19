using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Hoş geldiniz-----");

            Musteri musteri1 = new Musteri
            {
                Id = 25,
                Adi = "Zeynep",
                SoyAdi = "Yılmaz",
                Adres = "Adana",
                TelefonNo = 123456789
            };

            Musteri musteri2 = new Musteri
            {
                Id = 96,
                Adi = "Ela",
                SoyAdi = "Yaman",
                Adres = "Bursa",
                TelefonNo = 987654321
            };

            Musteri musteri3 = new Musteri
            {
                Id = 269,
                Adi = "Çınar",
                SoyAdi = "Can",
                Adres = "Ankara",
                TelefonNo = 147258369
            };

            Musteri musteri4 = new Musteri
            {
                Id = 123,
                Adi = "Efe",
                SoyAdi = "Yılmaz",
                Adres = "Muğla",
                TelefonNo = 963852741
            };


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id : " + musteri.Id);
                Console.WriteLine("Müşterinin Adı : " + musteri.Adi);
                Console.WriteLine("Müşterinin Soyadı : " + musteri.SoyAdi);
                Console.WriteLine("Müşterinin Adresi : " + musteri.Adres);
                Console.WriteLine("Müşterinin Telefon Numarası : " + musteri.TelefonNo);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("-----İşlem bitti-----");
        }
    }
}

