using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week1
{
    public class Mains
    {

        public static void Main(string[] args)
        {
            VehicleFactory vehicleFactory = new VehicleFactory();
            Vehicle car = vehicleFactory.CreateVehicle("car");
            Vehicle motorbike = vehicleFactory.CreateVehicle("motorbike");
            car.drive();
            car.stop();
            motorbike.drive();
            motorbike.stop();
         }
    }
}