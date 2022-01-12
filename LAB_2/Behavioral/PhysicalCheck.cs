using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Behavioral
{
    internal class PhysicalCheck : ICheck
    {
        public void MakeCheck()
        {
            Console.WriteLine("Making check for a physical person");
        }
    }
}
