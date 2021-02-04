using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1983, 2, 8),
                FirstName = "Atiba",
                LastName = "Hutchinson",
                NationalityId = "98765432100"
            });

            BaseCustomerManager customerManager2 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager2.Save(new Customer
            {
                DateOfBirth = new DateTime(1992, 1, 22),
                FirstName = "Vincent",
                LastName = "Aboubakar",
                NationalityId = "12345678900"
            });

            Console.ReadLine();
        }
    }
}
