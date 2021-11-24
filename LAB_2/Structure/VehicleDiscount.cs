using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Structure
{
     class VehicleDiscount
     {
          protected Vehicle discountedVehicle;
          float discount;

          public VehicleDiscount(Vehicle discountedVehicle, float discount)
          {
               this.discountedVehicle = discountedVehicle;
               this.discount = discount;
          }

          public void ShowDiscount()
          {
               discountedVehicle.Price *= discount;
               Console.WriteLine($"This vehicle has been discounted by {discount * 100}%, the final price is {discountedVehicle.Price}$");
          }
     }
}
