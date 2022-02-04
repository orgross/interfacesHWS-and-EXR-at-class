using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesHWS
{
    internal class Dog: IAnimal, IMakeSoundable
    {
        public string Name { get; set; }
        public Dog()
        {

        }
        public Dog(string name)
        {
            Name = name;
        }
        public void eat()
        {
            Console.WriteLine($"the dog is eating....");
        }
        public void sleep()
        {
            Console.WriteLine($"the dog is sleep right now....");
        }
        public void move()
        {
            Console.WriteLine($"the dog is moving....");
        }
        public void MakeSoundBeforeEAting()
        {
            Console.WriteLine("Ring ring the food is ready...");
        }

    }
}
