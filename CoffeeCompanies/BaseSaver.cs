using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCompanies
{
    public abstract class BaseSaver : ISaver
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved: " + customer.FirstName);
        }
    }
}
