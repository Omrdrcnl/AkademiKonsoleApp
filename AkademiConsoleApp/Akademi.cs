using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiConsoleApp
{
    public class Akademi
    {
        public string Ad;
        public long VergiNu;
        public Adres Adres;
        private bool GrupOlusturma;
        public bool GrupOlusturmaYetkisi
        {
            get { return GrupOlusturma; }
            set { GrupOlusturma = value; }
        }
    }
    public class Adres
    {
        public string Sehir;
        public string İlce;
        public string Semt;
        public string Sokak;
        public int nu;
    }
    public class Kisi
    {
        public string Ad;
        public string DogumTarihi;
        public string TCNu;
        public Adres Adres;
        public string TelNu;
    }

    public class Grup
    {
        public int Id;
        public List<Ogrenci> OgrenciListesi;
        public Ogretmen Ogretmen;
    }



    public class Ogrenci : Kisi
    {
        
        public int OgrNu;
        public List<Ders> Ders;

    }
    public class Ogretmen : Kisi
    {
        public string HesapNu;
        public Ders Ders;
        private bool SinavYapma;

        public bool SinavYapmaYetkisi
        {
            get { return SinavYapma; }
            set { SinavYapma = value; }
        }
       
    }
    public class Ders
    {
        public int Id;
        public string Ad;
        public string DersAciklamasi;
        
    }
}
