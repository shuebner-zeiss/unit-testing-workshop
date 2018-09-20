using System;

namespace Mocking2HandsOn._01
{
    public class BillingObserver
    {
        private readonly IBillingSystem billingSystem;
        private readonly IBillingTriggerer billingTriggerer;

        public BillingObserver(IBillingSystem billingSystem, IBillingTriggerer billingTriggerer)
        {
            this.billingSystem = billingSystem;
            this.billingTriggerer = billingTriggerer;
        }

        public void StartObserving()
        {
        }

        public void StopObserving()
        {
        }
    }
}
