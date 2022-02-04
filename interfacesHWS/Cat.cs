using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesHWS
{
    internal class Cat: IAnimal, IMakeSoundable
    {
        public string Name { get; set; }
        public Cat()
        {

        }
        public Cat(string name)
        {
            Name = name;
        }
        public void eat()
        {
            Console.WriteLine($"the cat is eating....");
        }
        public void sleep()
        {
            Console.WriteLine($"the cat is sleep right now....");
        }
        public void move()
        {
            Console.WriteLine($"the cat is moving....");
        }
        public void MakeSoundBeforeEAting()
        {
            Console.WriteLine("Ring ring the food is ready...");
        }
    }
}
