using System;
using System.Collections.Generic;
using System.Text;
using patterns.Structure;

namespace patterns
{
    class Vehicle
    {
          public float Price { get; set; }
          private string _vehicleType;
           private Dictionary<string, string> _parts =
          new Dictionary<string, string>();
          IDiagnostics diagnostics;

        public Vehicle(string vehicleType, float price, IDiagnostics diagnostics)
        {
            this._vehicleType = vehicleType;
            Price = price;
            this.diagnostics = diagnostics;
        }
      
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
               Console.WriteLine("Vehicle Type: {0}", _vehicleType);
               Console.WriteLine("Vehicle Price: {0}", Price);
               Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}
