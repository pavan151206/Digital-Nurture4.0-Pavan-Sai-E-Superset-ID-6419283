using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week1
{
    public class Car : Vehicle
    {
        public void drive() {
        Console.WriteLine("The car is moving");
    }
    public void stop() {
        Console.WriteLine("The car just stopped");
        }
    }
}