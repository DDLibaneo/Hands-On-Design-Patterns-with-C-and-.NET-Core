using System;
using System.Collections.Generic;

namespace LiskovPrinciple
{

    // On the Liskov Principle:
    // "Being able to substitute objects at runtime is the basis of the Liskov substitution principle.
    // In OOP, if a class inherits from a base class or implements an interface, then it can be 
    // referenced as an object of the base class or interface."

    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>() 
            { 
                new Cat(), 
                new Dog() 
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.MakeNoise());
            }

            Console.Read();
        }
    }
}
