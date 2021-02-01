using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not repeat yourself
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 32000;
            double faizOrani = 1.59;
            bool girisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun == dolarBugun)
            {
                Console.WriteLine("Sabit çizgi");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else
            {
                Console.WriteLine("Artış oku");
            }

            if (girisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            String mesaj = girisYapmisMi ? "Giriş Yapıldı" : "Giriş yapılmadı";

            Console.Read();
        }
    }
}
