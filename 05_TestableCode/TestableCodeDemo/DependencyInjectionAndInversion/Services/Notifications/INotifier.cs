using Domain;

namespace DependencyInjectionAndInversion
{
    public interface INotifier
    {
        void SendReceipt(Subscription subscription);
    }
}