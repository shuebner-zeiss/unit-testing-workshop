using Domain;
using DependencyInjectionAndInversion;
using System;
using Autofac;

namespace App
{
    public static class DependencyInjectionAndInversionWithAutofacProgram
    {
        public static void Execute(Subscription subscription)
        {
            Console.WriteLine("With Dependency Injection and inversion using Dependency Injection Framework Autofac");

            var builder = new ContainerBuilder();
            builder.RegisterType<SubscriptionProcessor>();
            builder.RegisterType<CreditCardPaymentProcessor>().As<IPaymentProcessor>();
            builder.RegisterType<CustomerProcessor>().As<ICustomerProcessor>();
            builder.RegisterType<DeutscheBankConnection>().As<IPaymentConnection>();
            builder.RegisterType<Notifier>().As<INotifier>();
            var diContainer = builder.Build();

            var subscriptionProcessor = diContainer.Resolve<SubscriptionProcessor>();
            subscriptionProcessor.ProcessSubscription(subscription);
        }
    }
}
