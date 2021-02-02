using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNo = "14";
            customer1.Name = "Vincent";
            customer1.Surname = "Aboubakar";
            customer1.IdCardNo = "1903";

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNo = "123";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "123456";

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);




            Console.Read();
        }
    }
}
