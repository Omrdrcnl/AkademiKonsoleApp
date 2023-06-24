using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiConsoleApp
{
    public class YoklamaFisi
    {
        public Ders Ders;
        public int Mevcut;
        public int YoklamaKacagi;
        public Ogretmen Ogretmen;
        public List<Ogrenci> YoklamaListesi;

        public YoklamaFisi(int mevcut, int yoklamaKacagi)
        {
            Mevcut = mevcut;
            YoklamaKacagi = yoklamaKacagi;
            YoklamaListesi = new List<Ogrenci>();
        }
    }
}
