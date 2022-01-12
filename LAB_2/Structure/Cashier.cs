using System;
using System.Collections.Generic;
using System.Text;
using patterns.Behavioral;
using patterns.Structure;

namespace patterns
{
    class Cashier
    {
        VehicleBuilder builder;
        Document doc;
        Shop shop = new Shop();
        VehicleDiscount vehicleDiscount;
        bool isBlackFriday = true;
        CheckContext context = new CheckContext();
        public void Checkout(string vehType, string strategy)
        {

            if (vehType == "scooter")
            {
                builder = new ScooterBuilder("scooter", 1300, new SimpleAnalysis());
                shop.Construct(builder);

                if (isBlackFriday)
                {
                    vehicleDiscount = new VehicleDiscount(builder.Vehicle, 0.5f);
                    vehicleDiscount.ShowDiscount();
                }

                builder.Vehicle.Show();
                doc = new PaymentCheck();
                doc.ListPages();
            }

            else if (vehType == "car")
            {
                builder = new CarBuilder("car", 5000, new FullAnalysis());
                shop.Construct(builder);

                if (isBlackFriday)
                {
                    vehicleDiscount = new VehicleDiscount(builder.Vehicle, 0.3f);
                    vehicleDiscount.ShowDiscount();
                }

                builder.Vehicle.Show();
                doc = new PaymentCheck();
                doc.ListPages();
            }

            if (vehType == "motorcycle")
            {
                builder = new MotorCycleBuilder("motorcycle", 2400, new FullAnalysis());
                shop.Construct(builder);

                if (isBlackFriday)
                {
                    vehicleDiscount = new VehicleDiscount(builder.Vehicle, 0.4f);
                    vehicleDiscount.ShowDiscount();
                }

                builder.Vehicle.Show();
                doc = new Credit();
                doc.ListPages();
            }

            if(strategy == "juridic")
            {
                context.Strategy = new JuridicCheck();

            }


            else if (strategy == "physical")
            {
                context.Strategy = new PhysicalCheck();

            }

            context.ExecuteStrategy();

        }
    }
}
