using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week1
{
    public class Motorbike : Vehicle
    {
        public void drive()
        {
            Console.WriteLine("The motorbike is moving");
        }
        public void stop()
        {
            Console.WriteLine("The motorbike just stopped");
        }
    }
}