using System;
using System.Collections.Generic;
using System.Text;
using patterns.Structure;

namespace patterns
{
    class CarBuilder : VehicleBuilder
    {
          public CarBuilder(string type, float price, IDiagnostics diagnostics)
          {
               vehicle = new Vehicle(type, price, diagnostics);
          }
          public override void BuildFrame()
        {
            vehicle["frame"] = "Car Frame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
    }
}
