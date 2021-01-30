using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCompanies
{
    public abstract class BaseSaver : ISaver
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Saved: " + customer.FirstName);
        }
    }
}
