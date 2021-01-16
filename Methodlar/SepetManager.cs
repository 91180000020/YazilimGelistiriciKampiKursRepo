using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : "+urun.Adi);

        }
        public void Ekle2(string urunAdi, string aciklama, int fiyati, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);

        }
    }
}
