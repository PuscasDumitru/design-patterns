using System;
using System.Collections.Generic;
using System.Text;
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
          public void Checkout(string vehType)
          {

               if(vehType == "scooter")
               {
                    builder = new ScooterBuilder("scooter", 1300, new SimpleAnalysis());
                    shop.Construct(builder);

                    if(isBlackFriday)
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

              
          }
     }
}
