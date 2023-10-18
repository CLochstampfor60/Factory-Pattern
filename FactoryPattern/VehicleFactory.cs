using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(string tireNumber)
        {
            switch (tireNumber.ToLower())
            {
                case "four":
                    return new Car();
                case "4":
                    return new Car();
                case "two":
                    return new Motorcycle();
                case "2":
                    return new Motorcycle();
                case "eighteen":
                    return new BigRig();
                case "18":
                    return new BigRig();
                default:
                    return new Car();
            }
        }
    }
}
