using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not repeat yourself !
            // Clean code principles

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + " - " + product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("--------------");
            }


            Console.WriteLine("----------Metotlar----------");
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
            


            Console.Read();

        }
    }
}
