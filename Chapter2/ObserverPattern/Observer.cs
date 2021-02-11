using System;

namespace ObserverPattern
{
    internal class Observer
    {
        readonly ConsoleColor _color;

        public Observer(ConsoleColor color)
        {
            _color = color;
        }

        internal void OnUpdateQuantity(int quantity)
        {
            Console.ForegroundColor = _color;
            Console.WriteLine($"I observe the new quantity value of {quantity}.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
