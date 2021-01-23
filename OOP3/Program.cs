using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // interface onu implemente eden classın REFERANSINI tutabilir.
            IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            //ihtiyacKrediManager2.Hesapla();

            IKrediManager tasitKrediManager2 = new TasitKrediManager();
            //tasitKrediManager2.Hesapla();

            IKrediManager konutKrediManager2 = new KonutKrediManager();
            //konutKrediManager2.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager2, databaseLoggerService);

            Console.WriteLine("--------------------------------------------");

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager2,tasitKrediManager2};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
