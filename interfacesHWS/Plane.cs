using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesHWS
{
    internal class Plane : IFlayable
    {
        public double num;
        public Plane()
        {

        }

        public Plane(double num)
        {
            this.num = num;
        }
        public void Fly()
        {
            Console.WriteLine("this plane is flying...");
        }

        public double GetAltitude(double num)
        {
            Console.WriteLine($"this plane is now in this {num} altitude");
            return num;
        }
    }
}
