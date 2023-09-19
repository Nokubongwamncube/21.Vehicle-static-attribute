using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Vehicle_static_attribute
{
    class Vehicles
    {
        public string Model;
        public string color;
        public int wheels;

        public static int vehicleCount; // declared a static attribute

        public Vehicles(string aModel, string aColor, int aWheels)
        {
            Model = aModel;
            color = aColor;
            wheels = aWheels;

            vehicleCount++;


        }
    }
}
