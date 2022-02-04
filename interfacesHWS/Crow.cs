using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesHWS
{
    internal class Crow : IFlayable
    {
        public double num;
        public Crow()
        {

        }

        public Crow(double num)
        {
            this.num = num;
        }

        public void Fly()
        {
            Console.WriteLine("this crow is fliying...");
        }

        public double GetAltitude(double num)
        {
            Console.WriteLine($"this crow is now in this {num} altitude");
            return num; 
        }
    }
}
