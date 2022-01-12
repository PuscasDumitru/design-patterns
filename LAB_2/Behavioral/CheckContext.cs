using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Behavioral
{
    internal class CheckContext
    {
        public ICheck Strategy { get; set; }

        public void ExecuteStrategy()
        {
            Strategy.MakeCheck();
        }
    }
}
