using System;

namespace Mocking2HandsOn._01
{
    public interface IBillingTriggerer
    {
        event EventHandler BillingDue;
    }
}