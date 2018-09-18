using System;
using System.Collections.Generic;
using System.Text;

namespace MockingDemo._01
{
    public class VirtualSubscriptionStatusSource
    {
        public virtual SubscriptionStatus GetStatus()
        {
            return SubscriptionStatus.None;
        }
    }
}
