using Domain;

namespace DependencyInversion
{
    public interface ICustomerProcessor
    {
        void UpdateCustomerSubscriptions(Subscription subscription);
    }
}