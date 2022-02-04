using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesHWS
{
    internal class Fish: IAnimal
    {
        public string Name { get; set; }
        public Fish()
        {
                
        }
        public Fish(string name)
        {
            Name = name;
        }

        public void eat()
        {
            Console.WriteLine($"the fish is eating....");
        }
        public void sleep()
        {
            Console.WriteLine($"the fish  is sleep right now....");
        }
        public void move()
        {
            Console.WriteLine($"the fish  is moving....");
        }
    }
}
