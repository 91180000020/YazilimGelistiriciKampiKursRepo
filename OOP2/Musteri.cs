using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Bir nesnede bir alanı kullanmak zorunda görmüyorsak o nesnede hata yapıyoruz demektir.
    //Gerçek Müşteri - Tüzel Müşteri //Bunlar birbirine benziyor diye birbirinin yerine kullanılamazlar. --> SOLID - L(Liskov's Substitution)
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}
