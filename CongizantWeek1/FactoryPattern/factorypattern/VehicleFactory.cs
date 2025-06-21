using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week1
{
    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string vehicleType)
        {
            if (vehicleType == "car")
            {
                return new Car();
            }
            else if (vehicleType == "motorbike")
            {
                return new Motorbike();
            }
            else
            {
                throw new ArgumentException("Unknown vehicle type");
            }
        }
    }
}