using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var subject = new Subject();
            var greenObserver = new Observer(ConsoleColor.Green);
            var redObserver = new Observer(ConsoleColor.Red);
            var yellowObserver = new Observer(ConsoleColor.Yellow);

            subject.QuantityUpdated += greenObserver.OnUpdateQuantity;
            subject.QuantityUpdated += redObserver.OnUpdateQuantity;
            subject.QuantityUpdated += yellowObserver.OnUpdateQuantity;

            subject.AddToQuantity(12);
            subject.AddToQuantity(5);

            Console.WriteLine("Enter a key to quit.");
            Console.Read();
        }
    }
}
