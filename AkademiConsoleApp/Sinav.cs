using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiConsoleApp
{
    public class Sinav : Ders
    {
        public Ogretmen Ogretmen;
        public DateTime Tarihi;
        public List<Ogrenci> OgrenciListesi;
        private List<Soru> Sorular;
        public string Yanit;
        public int Not;

        public Sinav(Ogretmen ogretmen,  List<Ogrenci> ogrenciListesi, List<Soru> sorular, string yanit, int not, DateTime tarihi)
        {
            Ogretmen = ogretmen;
            OgrenciListesi = ogrenciListesi;
            
            if(Tarihi ==DateTime.Today)
            {

                Sorular = sorular;

            }
            {
               Sorular = new List<Soru>();
            }
            Yanit = yanit;
            Not = not;
            
        }
    }

    public class Soru
    {
        public int SoruNu;
        public string SorulanSoru;
        public Siklar Siklar;
        public string Cevap;
    }
    public enum Siklar
    {
        None = 0,
        A = 1,
        B = 2,
        C = 3,
        D = 4,
    }

    
}
