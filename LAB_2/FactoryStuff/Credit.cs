using System;
using System.Collections.Generic;
using System.Text;

namespace patterns
{
    class Credit : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new ClientInfoPage());
            Pages.Add(new CreditConditionsPage());
            Pages.Add(new CreditRequirementsPage());
        }
    }
}
