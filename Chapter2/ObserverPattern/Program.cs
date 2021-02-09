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

            subject.OnQuantityUpdated += greenObserver.ObserverQuantity;
            subject.OnQuantityUpdated += redObserver.ObserverQuantity;
            subject.OnQuantityUpdated += yellowObserver.ObserverQuantity;

            subject.UpdateQuantity(12);
            subject.UpdateQuantity(5);

            Console.WriteLine("Enter a key to quit.");
            Console.Read();
        }
    }
}
