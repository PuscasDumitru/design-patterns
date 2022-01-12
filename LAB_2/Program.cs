using patterns.Behavioral;
using System;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            RandomNonBuyers dontBuy = RandomNonBuyers.GetRandomNonBuyers();

            for (int i = 0; i < 15; i++)
            {
                string nbuy = dontBuy.NonBuyer;
                Console.WriteLine(nbuy);
            }

            Console.WriteLine("\n\n");

            Cashier cashier = new Cashier();
           
            cashier.Checkout("scooter", "juridic");
            cashier.Checkout("car", "physical");
            cashier.Checkout("motorcycle", "physical");

        }
    }
}
