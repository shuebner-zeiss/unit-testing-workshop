using System;

namespace Mocking2Demo._02
{
    public interface IBillingTriggerer
    {
        event EventHandler BillingDue;
    }
}