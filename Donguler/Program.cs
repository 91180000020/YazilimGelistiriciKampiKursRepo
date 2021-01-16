using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı"
                , "Programlamaya başlangıç için temel kurs"
                ,"Java"
                ,"Python"
                ,"C#"};
            for (int j = 0; j < kurslar.Length; j++)
            {
                Console.WriteLine(kurslar[j]);
            }
            Console.WriteLine("Sayfa sonu - footer");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu - footer");

        }
    }
}
