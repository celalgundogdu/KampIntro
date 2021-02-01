using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> Customers = new List<Customer>();

        public void Add(Customer customer)
        {
            if (Search(customer.Id) == false)
            {
                Customers.Add(customer);
                return;
            }
            Console.WriteLine("It is already added before..");
        }

        public void Delete(Customer customer)
        {
            if (Customers.Contains(customer))
            {
                Customers.Remove(customer);
                return;
            }
            Console.WriteLine("It is not already in the list");
        }


        public bool Search(int id)
        {
            bool IsInTheList = false;
            foreach (Customer customer in Customers)
            {
                if (customer.Id == id)
                {
                    IsInTheList = true;
                    break;
                }
            }
            return IsInTheList;
        } 

        public void ListCustomers()
        {
            foreach (Customer customer in Customers)
            {
                Console.WriteLine(customer.Id + " - " + customer.name + " " + customer.surname + " (" + customer.phone + ")");
            }
        }

        public void GetCustomerInfos(int id)
        {
            Customer customer = Customers.FirstOrDefault(customer => customer.Id == id );
            Console.WriteLine(customer.name + " " + customer.surname + " (" + customer.phone + ")");
        }

    }
}
