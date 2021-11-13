using System;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder;
            Document doc;
            Shop shop = new Shop();
            RandomNonBuyers dontBuy = RandomNonBuyers.GetRandomNonBuyers();

            for (int i = 0; i < 15; i++)
            {
                string nbuy = dontBuy.NonBuyer;
                Console.WriteLine(nbuy);
            }

            Console.WriteLine("\n\n");

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            doc = new PaymentCheck();
            doc.ListPages();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            doc = new PaymentCheck();
            doc.ListPages();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            doc = new Credit();
            doc.ListPages();

        }
    }
}
