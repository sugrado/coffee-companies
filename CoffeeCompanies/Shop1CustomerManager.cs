using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeCompanies
{
    class Shop1CustomerManager : BaseSaver, IVerification
    {
        Customer custv = new Customer { Id = 1, FirstName = "Gorkem", LastName = "Arik", BirthYear = 2002 };
        public bool Confirmative(Customer cust)
        {
            if(cust.FirstName == custv.FirstName
                && cust.LastName == custv.LastName
                && cust.BirthYear == custv.BirthYear
                && cust.Id == custv.Id)
            {
                Console.WriteLine("User verified.");
                return true;
            }
            else
            {
                Console.WriteLine("User not verified.");
                return false;
            }
                
        }
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }
    }
}
