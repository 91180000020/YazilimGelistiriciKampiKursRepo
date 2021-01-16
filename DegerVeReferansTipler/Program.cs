using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,double,bool = değer tip
            //array,class,interface = referans tip
            //string bir arraydir yani refereans tiptir.

            //stack -- değer tip olanlar stackte gerçekleşir.
            //heap -- referans tip olanlar heapte gerçekleşir.

            int sayi1 = 10;//sayi1 in değeri = 10
            int sayi2 = 30;
            sayi1 = sayi2;//sayi1 in değeri = sayi2 in değeri
            sayi2 = 65;
            //sayi1 ?? 30 //değer tip

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; // sayilar1 in referans numarası, sayilar2 nin referans numarasıdır.
            sayilar2[0] = 999;//sayilar1 de artık sayilar2 nin referansını tuttuğu için sayilar2[0] değiştiğinde sayilar1[0] da yeni değeri gösterir.
            //sayilar1[0] ?? 999 //referans tip

            //stack             heap
            //sayilar1          [10,20,30]
            //sayilar2          [100,200,300]
            //new - heapte yeni bir yer oluştur demektir.

           
        }
    }
}
