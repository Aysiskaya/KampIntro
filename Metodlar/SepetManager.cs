using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class SepetManager
    {
        // naming convention 

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: "+ urun.UrunAdi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi :" + urunAdi);
        }
    }
}
