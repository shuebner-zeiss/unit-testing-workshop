using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo._01
{
    public abstract class AbstractSubscriptionStatusSource
    {
        public abstract SubscriptionStatus GetStatus();
    }
}
