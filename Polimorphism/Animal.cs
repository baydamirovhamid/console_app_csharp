using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Animal
    {
        public string Name { get; set; }
        public Animal(string Name)
        {
            this.Name = Name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Generic sounds of animal");
        }


        public class Lion : Animal
        {
            public Lion(string Name) : base(Name)
            {
                     
            }
            public override void MakeSound()
            {
                Console.WriteLine("This is sound of the lion");
            }                      
        }

        public class Dolphin : Animal, ISwim
        {
            public Dolphin(string Name) : base(Name)
            {

            }
            public override void MakeSound()
            {
                Console.WriteLine("This is sound of the dolphin");
            }
            public void Swim()
            {
                Console.WriteLine("Dolphins swim perfect");
            }
        }

        public interface ISwim
        {
            public void Swim();
        }

    }
}
        

       
    


