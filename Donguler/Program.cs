using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java ile İleri Seviye Programlama Kursu";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya başlangıç için temel kurs",
            "Java ile İleri Seviye Programlama Kursu"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadLine();
        }
    }
}
