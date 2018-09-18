namespace MockingDemo._01
{
    public interface ISubscriptionStatusSource
    {
        SubscriptionStatus GetStatus();
    }

    public enum SubscriptionStatus
    {
        None,
        Subscribed,
        Unsubscribed
    }
}