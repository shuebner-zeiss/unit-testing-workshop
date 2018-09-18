using Autofac;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        private static readonly string Usage =
            "0: Exit" + Environment.NewLine +
            "1: Starting Point" + Environment.NewLine +
            "2: With dependency injection" + Environment.NewLine +
            "3: With dependency inversion" + Environment.NewLine +
            "4: With dependency injection and dependency inversion" + Environment.NewLine +
            "5: With dependency injection and dependency inversion using dependency injection framework Autofac";

        static void Main(string[] args)
        {
            Console.WriteLine("#########################################");
            Console.WriteLine("# Welcome to workshop 5 | Testable Code #");
            Console.WriteLine("#########################################");

            var subscription = new Subscription
            {
                CustomerName = "Some dude",
                Email = "somedude@crazycompany.org",
                Product = "Blue Cheese",
                InitialFee = 1200,
                CreditCardNumber = "123456789",
            };

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please select an example...");
                Console.WriteLine(Usage);
                Console.WriteLine();

                var input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Exit();
                        break;

                    case "1": // starting point without dependency injection and without dependency inversion
                        StartingPointProgram.Execute(subscription);
                        break;

                    case "2": // with Dependency Injection
                        DependencyInjectionProgram.Execute(subscription);
                        break;

                    case "3": // with Dependency Inversion
                        DependencyInversionProgram.Execute(subscription);
                        break;

                    case "4": // with dependency injection and dependency inversion
                        DependencyInjectionAndInversionProgram.Execute(subscription);
                        break;

                    case "5": // with dependency injection and inversion using the Dependency Injection Framework Autofac
                        DependencyInjectionAndInversionWithAutofacProgram.Execute(subscription);
                        break;
                }
            }
        }

        private static void Exit()
        {
            Console.WriteLine("Good bye! See you next time!");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
