
using System;
using static Polymorphism.Animal;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal lion = new Lion("Simba");
            Animal dolphin = new Dolphin("Luna");

            Animal[] animals = new Animal[2];
            animals[0] = lion;
            animals[1] = dolphin;

            foreach (var animal in animals)
            {
               animal.MakeSound();
            }

            Console.WriteLine("-----------------------------");

            if (dolphin is ISwim s)
            {
                Console.WriteLine(s.Swim);
            }

        }
    }
}