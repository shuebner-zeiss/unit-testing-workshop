namespace BillingSystemDemo
{
    using System;
    using DIBillingSystem.Abstractions;
    using DIBillingSystem.Models;

    public class CreditCardCharger : ICharger
    {
        public void Charge(Customer debitor)
        {
            Console.WriteLine($"Charged \"{debitor.Name}\".");
        }
    }
}
