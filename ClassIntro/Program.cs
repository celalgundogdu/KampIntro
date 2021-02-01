using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C# ile Programlamaya Giriş";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 74;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python ile Temel Programlama";
            kurs2.Egitmen = "BTK Akademi";
            kurs2.IzlenmeOrani = 22;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java ile İleri Seviye Programlama";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.IzlenmeOrani = 93;

            Console.WriteLine(kurs1.KursAdi + " - " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

            // Kamp 2 Odev 

            Product product1 = new Product();
            product1.brand = "HP";
            product1.name = "Laptop";
            product1.Oldprice = 8900;
            product1.Newprice = 7700;

            Product product2 = new Product();
            product2.brand = "MSI";
            product2.name = "Laptop";
            product2.Oldprice = 9900;
            product2.Newprice = 8500;

            Product product3 = new Product();
            product3.brand = "ASUS";
            product3.name = "Laptop";
            product3.Oldprice = 8300;
            product3.Newprice = 7600;

            Product[] products = new Product[] { product1, product2, product3};

            Console.WriteLine("for ile döngü");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].brand + "-" + products[i].name);
                Console.WriteLine("Fiyat: " + products[i].Newprice);
            }

            Console.WriteLine("foreach ile döngü");
            foreach (Product item in products)
            {
                Console.WriteLine(item.brand + "-" + item.name);
                Console.WriteLine("Fiyat: " + item.Newprice);
            }

            Console.WriteLine("while ile döngü");
            int temp = 0;
            while (temp < products.Length)
            {
                Console.WriteLine(products[temp].brand + "-" + products[temp].name);
                Console.WriteLine("Fiyat: " + products[temp].Newprice);
                temp++;
            }



            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    class Product
    {
        public string brand { get; set; }
        public string name { get; set; }
        public double Oldprice { get; set; }
        public double Newprice { get; set; }

    }
}
