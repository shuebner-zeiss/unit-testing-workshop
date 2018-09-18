using Domain;

namespace DependencyInjectionAndInversion
{
    public interface ICustomerProcessor
    {
        void UpdateCustomerSubscriptions(Subscription subscription);
    }
}