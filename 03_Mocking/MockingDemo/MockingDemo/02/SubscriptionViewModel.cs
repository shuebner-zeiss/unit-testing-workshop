using System;

namespace MockingDemo._02
{
    public class SubscriptionViewModel
    {
        private readonly ISubscriptionStatusSource statusSource;

        public SubscriptionViewModel(ISubscriptionStatusSource statusSource)
        {
            this.statusSource = statusSource;
        }

        public bool IsSubscribed()
        {
            return false;
        }
    }
}
