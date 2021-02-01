using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.name = "Atiba";
            customer1.surname = "Hutchinson";
            customer1.phone = "1903 13 13";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.name = "Vincent";
            customer2.surname = "Aboubakar";
            customer2.phone = "1903 14 14";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.name = "Josef";
            customer3.surname = "De Souza";
            customer3.phone = "1903 05 05";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            customerManager.ListCustomers();

            customerManager.Delete(customer3);
            Console.WriteLine();
            customerManager.ListCustomers();
            Console.WriteLine();
            customerManager.GetCustomerInfos(1);

            Console.Read();
        }
    }
}
