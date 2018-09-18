namespace BillingSystemDemo
{
    using System;
    using Autofac;
    using DIBillingSystem;
    using DIBillingSystem.Abstractions;
    using DIBillingSystem.Models;
    using DIBillingSystem.Repositories;

    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#########################################");
            Console.WriteLine("# Welcome to workshop 5 | Testable Code #");
            Console.WriteLine("#########################################");
            Console.WriteLine();

            var db = new PostgresqlDatabase();
            db.Customers.Add(new Customer { Id = Guid.NewGuid(), Name = "John Doe" });
            db.Customers.Add(new Customer { Id = Guid.NewGuid(), Name = "Maggie Musterman" });
            db.Customers.Add(new Customer { Id = Guid.NewGuid(), Name = "Some Dude" });

            // Replace this by AUTOFAC
            var database = new PostgresqlDatabase();
            var billingSystem =
                new BillingSystem(
                    new CustomerRepository(database),
                    new SubscriptionRepository(database),
                    new CreditCardCharger());

            /*
             * USE AUTOFAC HERE!!
             *
             * var billingSystem = container.Resolve<BillingSystem>();
             */
            var containerConfig = new ContainerBuilder();

            containerConfig.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            containerConfig.RegisterType<SubscriptionRepository>().As<ISubscriptionRepository>();
            containerConfig.RegisterType<CreditCardCharger>().As<ICharger>();

            // this tells Autofac to only create a single instance of PostgresqlDatabase and
            // use that one instance everytime a ICustomerDatabase or ISubscriptionDatabase
            // is needed
            containerConfig
                .RegisterType<PostgresqlDatabase>()
                .As<ICustomerDatabase>()
                .InstancePerLifetimeScope();
            containerConfig
                .RegisterType<PostgresqlDatabase>()
                .As<ISubscriptionDatabase>()
                .InstancePerLifetimeScope();

            billingSystem.Process();

            Console.WriteLine();
            Console.WriteLine("Good bye! See you next time!");
            Console.ReadLine();
        }
    }
}
