using AkademiConsoleApp;
using System;
using System.Collections.Generic;

namespace AkademiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Akademi nesneleri oluşturma
            Akademi akademi1 = new Akademi();
            akademi1.Adres = new Adres()
            {
                Sehir = "İstanbul",
                İlce = "Kadıköy",
                Semt = "Örnek Semt",
                Sokak = "Örnek Sokak",
                nu = 789
            };
            akademi1.GrupOlusturmaYetkisi = true;
            bool grupOlusturmaYetkisi = akademi1.GrupOlusturmaYetkisi;

          


            // Ogrenci nesneleri oluşturma
            Ogrenci ogrenci1 = new Ogrenci()
            {
                Ad = "Ahmet",
                DogumTarihi = "01.01.2000",
                TCNu = "342434329",
                Adres = new Adres()
                {
                    Sehir = "İstanbul",
                    İlce = "Kadıköy",
                    Semt = "Örnek Semt",
                    Sokak = "Örnek Sokak",
                    nu = 123
                },
                TelNu = "5555555555",
                OgrNu = 1
            };

            Ogrenci ogrenci2 = new Ogrenci()
            {
                Ad = "Ayşe",
                DogumTarihi = "02.02.2001",
                TCNu = "943243849",
                Adres = new Adres()
                {
                    Sehir = "Ankara",
                    İlce = "Çankaya",
                    Semt = "Örnek Semt",
                    Sokak = "Örnek Sokak",
                    nu = 456
                },
                TelNu = "5555555556",
                OgrNu = 2
            };

            // Grup nesnesi oluşturma
            Grup grup = new Grup()
            {
                Id = 1,
                OgrenciListesi = new List<Ogrenci> { ogrenci1, ogrenci2 },
                Ogretmen = new Ogretmen()
                {
                    Ad = "Mehmet",
                    DogumTarihi = "03.03.1980",
                    TCNu = "1357924680",
                    Adres = new Adres()
                    {
                        Sehir = "İstanbul",
                        İlce = "Kadıköy",
                        Semt = "Örnek Semt",
                        Sokak = "Örnek Sokak",
                        nu = 789
                    },
                    TelNu = "5555555557",
                    HesapNu = "1234567890"

                    //Sınav yapma yetkisi
                 

                }
            };
            //Sınav yapma yetkisi

            Ogretmen Ogretmen = new Ogretmen();
            Ogretmen.SinavYapmaYetkisi = true;
            bool SinavYapmaYetkisi = Ogretmen.SinavYapmaYetkisi;

           


            // Sinav nesnesi oluşturma
            Sinav sinav = new Sinav(grup.Ogretmen, grup.OgrenciListesi, new List<Soru>(), "CEVAP", 90,  DateTime.Today);

         

            // Yoklama nesnesi oluşturma
            YoklamaFisi yoklama = new YoklamaFisi(2, 1);
            yoklama.Ders = new Ders()
            {
                Id = 1,
                Ad = "Matematik",
                DersAciklamasi = "Matematik dersi açıklaması"
            };
            yoklama.Ogretmen = grup.Ogretmen;
            yoklama.YoklamaListesi = grup.OgrenciListesi;

            // Nesneleri ekrana yazdırma
            Console.WriteLine("Akademi 1 Bilgileri");
            Console.WriteLine("Ad: {0}", akademi1.Ad);
            Console.WriteLine("Vergi Nu: {0}", akademi1.VergiNu);
            Console.WriteLine("Adres: {0}", GetAdresString(akademi1.Adres));

            Console.WriteLine("\nÖğrenci Bilgileri");
            Console.WriteLine("Ad: {0}", ogrenci1.Ad);
            Console.WriteLine("Doğum Tarihi: {0}", ogrenci1.DogumTarihi);
            Console.WriteLine("TC Nu: {0}", ogrenci1.TCNu);
            Console.WriteLine("Adres: {0}", GetAdresString(ogrenci1.Adres));
            Console.WriteLine("Tel Nu: {0}", ogrenci1.TelNu);
            Console.WriteLine("Öğrenci No: {0}", ogrenci1.OgrNu);

            Console.WriteLine("\nÖğretmen Bilgileri");
            Console.WriteLine("Ad: {0}", grup.Ogretmen.Ad);
            Console.WriteLine("Doğum Tarihi: {0}", grup.Ogretmen.DogumTarihi);
            Console.WriteLine("TC Nu: {0}", grup.Ogretmen.TCNu);
            Console.WriteLine("Adres: {0}", GetAdresString(grup.Ogretmen.Adres));
            Console.WriteLine("Tel Nu: {0}", grup.Ogretmen.TelNu);
            Console.WriteLine("Hesap Nu: {0}", grup.Ogretmen.HesapNu);

            Console.WriteLine("\nSınav Bilgileri");
            Console.WriteLine("Öğretmen: {0}", GetKisiString(sinav.Ogretmen));
            Console.WriteLine("Öğrenci Listesi:");
            foreach (Ogrenci ogrenci in sinav.OgrenciListesi)
            {
                Console.WriteLine(" - {0}", GetKisiString(ogrenci));
            }
            
            Console.WriteLine("Yanıt: {0}", sinav.Yanit);
            Console.WriteLine("Not: {0}", sinav.Not);

            Console.WriteLine("\nYoklama Bilgileri");
            Console.WriteLine("Mevcut: {0}", yoklama.Mevcut);
            Console.WriteLine("Yoklama Kaçağı: {0}", yoklama.YoklamaKacagi);
            Console.WriteLine("Öğretmen: {0}", GetKisiString(yoklama.Ogretmen));
            Console.WriteLine("Yoklama Listesi:");
            foreach (Ogrenci ogrenci in yoklama.YoklamaListesi)
            {
                Console.WriteLine(" - {0}", GetKisiString(ogrenci));
            }

            Console.ReadLine();
        }

        static string GetAdresString(Adres adres)
        {
            return $"{adres.Sehir}, {adres.İlce}, {adres.Semt}, {adres.Sokak} {adres.nu}";
        }

        static string GetKisiString(Kisi kisi)
        {
            return $"{kisi.Ad}, TC: {kisi.TCNu}";
        }
    }
}
