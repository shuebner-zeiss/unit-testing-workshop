﻿namespace BillingSystemDemo
{
    using System;
    using DIBillingSystem;
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

            // ----------------------------------------------------------------
            // Optimize the code below ...
            var billingSystem = new BillingSystem(db, new CreditCardCharger());
            billingSystem.Init(); // bad!
            billingSystem.Process();
            // ----------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Good bye! See you next time!");
            Console.ReadLine();
        }
    }
}
