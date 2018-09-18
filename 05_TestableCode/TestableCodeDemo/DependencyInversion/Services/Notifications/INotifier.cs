using Domain;

namespace DependencyInversion
{
    public interface INotifier
    {
        void SendReceipt(Subscription subscription);
    }
}