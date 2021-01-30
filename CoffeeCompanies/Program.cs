using System;

namespace CoffeeCompanies
{
    class Program
    {
        static void Main(string[] args)
        {
            int shop;
            bool res;
            Customer customer1 = new Customer();
            Console.WriteLine("Enter your Id: "); customer1.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your FirstName: "); customer1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your LastName: "); customer1.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Birth Year: "); customer1.BirthYear = Convert.ToInt32(Console.ReadLine());

        here: Console.WriteLine("Which shop would you like to shop from?\n Shop1 = 1\n Shop2 = 2\nEnter your choose: ");
            shop = Convert.ToInt32(Console.ReadLine());
            // First shop requests verification.
            if (shop == 1)
            {
                Shop1CustomerManager shop1CustomerManager = new Shop1CustomerManager();
                res = shop1CustomerManager.Confirmative(customer1);
                if (res == true)
                {
                    shop1CustomerManager.Save(customer1);
                }
                else if (res == false)
                {}
            } // Second store does not require verification.
            else if (shop == 2)
            {
                Shop2CustomerManager shop2CustomerManager = new Shop2CustomerManager();
                shop2CustomerManager.Save(customer1);
            }
            else
            {
                Console.WriteLine("Incorrect entry. Try again.");
                goto here;
            }
        }
    }
}
