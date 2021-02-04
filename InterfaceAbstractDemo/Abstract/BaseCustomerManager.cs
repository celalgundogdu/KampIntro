using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            // musteriyi kaydetme kodları yazılır
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
