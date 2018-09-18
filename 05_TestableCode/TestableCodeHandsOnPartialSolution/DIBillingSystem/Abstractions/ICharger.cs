namespace DIBillingSystem.Abstractions
{
    using DIBillingSystem.Models;

    public interface ICharger
    {
        void Charge(Customer debitor);
    }
}
