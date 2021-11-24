using System;
using System.Collections.Generic;
using System.Text;

namespace patterns
{
    class PaymentCheck : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new PurchasedProductInfoPage());
            Pages.Add(new PaymentInfoPage());
            Pages.Add(new ClientInfoPage());
        }
    }
}
