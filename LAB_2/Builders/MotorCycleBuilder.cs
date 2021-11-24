using System;
using System.Collections.Generic;
using System.Text;
using patterns.Structure;

namespace patterns
{
    class MotorCycleBuilder : VehicleBuilder
    {
          public MotorCycleBuilder(string type, float price, IDiagnostics diagnostics)
          {
               vehicle = new Vehicle(type, price, diagnostics);
          }
          public override void BuildFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "500 cc";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }
}
